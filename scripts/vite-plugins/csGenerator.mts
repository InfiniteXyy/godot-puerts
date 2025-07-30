import { Plugin } from 'vite'
import fse from 'fs-extra'

type TExport = { kind: string; name: string; type: string; value: string }
const getExports = (code: string): TExport[] => {
  const exportVarRegex = /export\s+(const|let|var)\s+(\w+)\s*(?::\s*([^=]+))?\s*=\s*([^\n]+)/gs
  const results: TExport[] = []
  let match
  while ((match = exportVarRegex.exec(code)) !== null) {
    results.push({
      kind: match[1], // const/let/var
      name: match[2], // variable name
      type: match[3]?.trim(), // type (may be undefined)
      value: match[4].trim().replace(/^'/, '').replace(/'$/, ''), // default value
    })
  }
  return results
}
const createCsSource = ({
  jsPath,
  className,
  baseClassName,
  exports,
}: {
  jsPath: string
  className: string
  baseClassName: string
  exports: TExport[]
}) => `using Godot;

public partial class ${className} : ${baseClassName}
{
  private string jsPath = "${jsPath}";
${exports.map((item) => `\n  [Export]\n  private ${item.type} ${item.name} = "${item.value}";\n`).join()}
  private JsComponentHook<${baseClassName}> jsComponentHook;

  public override void _Ready()
  {
    jsComponentHook = new JsComponentHook<${baseClassName}>(this, jsPath);
    jsComponentHook._Ready();
  }

  public override void _Process(double delta) => jsComponentHook._Process(delta);
  public override void _PhysicsProcess(double delta) => jsComponentHook._PhysicsProcess(delta);
  public override void _Input(InputEvent @event) => jsComponentHook._Input(@event);
  public override void _ExitTree() => jsComponentHook._ExitTree();
}`

export function csGenerator(entrypoints: string[]): Plugin {
  return {
    name: 'auto-create-cs',
    async buildEnd() {
      for (const filePath of entrypoints) {
        const sourceCode = fse.readFileSync(filePath, 'utf-8')
        const relativePath = filePath
          .replace(/src[\/\\]/, '')
          .replace('.ts', '')
          .replaceAll(/[\/\\]/g, '/')

        const className = filePath.match(/[\/\\](.*)\.ts/)?.[1].replaceAll(/[\/\\]/g, '_')
        const baseClassName = sourceCode.match(/defineComponent<CS\.Godot\.(.*?)>/)?.[1]

        const csPath = `src/${relativePath}.cs`

        if (className && baseClassName) {
          const csSource = createCsSource({
            jsPath: `scripts/dist/${relativePath}.mjs`,
            className,
            baseClassName,
            exports: getExports(sourceCode),
          })
          fse.writeFileSync(csPath, csSource)
        }
      }
    },
  }
}
