export const { Godot } = CS
export const { GD } = Godot

console.log = GD.Print

export function defineComponent<T extends CS.Godot.Node>(
  getConfig: (this: T) => {
    onReady?: (this: T) => void | (() => void)
    onProcess?: (this: T, delta: number) => void
    onPhysicsProcess?: (this: T, delta: number) => void
    onExitTree?: (this: T) => void
    onInput?: (this: T, event: CS.Godot.InputEvent) => void
  }
) {
  return (self: CS.IJsComponent) => {
    const component = self as unknown as T
    const config = getConfig.call(component)

    let cleanup: (() => void) | void

    self.JsOnReady = () => {
      cleanup = config.onReady?.call(component)
    }

    self.JsOnExitTree = () => {
      cleanup?.()
      config.onExitTree?.call(component)
    }

    if (config.onProcess) {
      self.JsOnProcess = config.onProcess.bind(component)
    }

    if (config.onPhysicsProcess) {
      self.JsOnPhysicsProcess = config.onPhysicsProcess.bind(component)
    }

    if (config.onInput) {
      self.JsOnInput = config.onInput.bind(component)
    }
  }
}
