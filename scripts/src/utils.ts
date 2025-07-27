export const { Godot } = CS
export const { GD, Input, StringName, Vector2 } = Godot

console.log = GD.Print

type TNodeExtended<T extends CS.Godot.Node> = Omit<T, 'GetNode'> & {
  getNode: <N extends CS.Godot.Node>(path: string) => N
}

export function defineComponent<T extends CS.Godot.Node>(
  getConfig: (this: TNodeExtended<T>) => {
    onReady?: (this: TNodeExtended<T>) => void | (() => void)
    onProcess?: (this: TNodeExtended<T>, delta: number) => void
    onPhysicsProcess?: (this: TNodeExtended<T>, delta: number) => void
    onExitTree?: (this: TNodeExtended<T>) => void
    onInput?: (this: TNodeExtended<T>, event: CS.Godot.InputEvent) => void
  }
) {
  return (hook: CS.JsComponentHook$1<T>, self: T) => {
    // Mixin js helpers
    const component = self as unknown as TNodeExtended<T>
    component.getNode = (path) => {
      return self.GetNode(new CS.Godot.NodePath(path)) as any
    }

    const config = getConfig.call(component)

    let cleanup: (() => void) | void

    hook.JsOnReady = () => {
      cleanup = config.onReady?.call(component)
    }

    hook.JsOnExitTree = () => {
      cleanup?.()
      config.onExitTree?.call(component)
    }

    if (config.onProcess) {
      hook.JsOnProcess = config.onProcess.bind(component)
    }

    if (config.onPhysicsProcess) {
      hook.JsOnPhysicsProcess = config.onPhysicsProcess.bind(component)
    }

    if (config.onInput) {
      hook.JsOnInput = config.onInput.bind(component)
    }
  }
}
