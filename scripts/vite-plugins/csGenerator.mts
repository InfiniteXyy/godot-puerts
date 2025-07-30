import { Plugin } from 'vite'
import fse from 'fs-extra'

export function csGenerator(entrypoints: string[]): Plugin {
  return {
    name: 'auto-create-cs',
    async buildEnd() {
      const createCsSource = (jsPath: string, className: string, baseClassName: string) => `using Godot;

public partial class ${className} : ${baseClassName}
{
  private string jsPath = "${jsPath}";

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

      for (const filePath of entrypoints) {
        const sourceCode = fse.readFileSync(filePath, 'utf-8')
        const relativePath = filePath.replace(/src[\/\\]/, '').replace('.ts', '')

        const className = filePath.match(/[\/\\](.*)\.ts/)?.[1]
        const baseClassName = sourceCode.match(/defineComponent<CS\.Godot\.(.*?)>/)?.[1]

        const csPath = `src/${relativePath}.cs`

        if (className && baseClassName && !fse.existsSync(csPath)) {
          const csSource = createCsSource(`scripts/dist/${relativePath}.mjs`, className, baseClassName)
          fse.writeFileSync(csPath, csSource)
        }
      }
    },
  }
}
