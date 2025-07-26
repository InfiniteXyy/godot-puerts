const { Godot } = CS;
const { GD, Input } = Godot;

console.log = GD.Print;

function defineComponent<T extends CS.Godot.Node>(
  getConfig: () => {
    onReady?: (this: T) => void;
    onProcess?: (this: T, delta: number) => void;
  }
) {
  const config = getConfig();
  return (self: CS.JsComponent) => {
    self.jsOnReady = () => config.onReady?.call(self as unknown as T);
    self.jsOnProcess = (delta) =>
      config.onProcess?.call(self as unknown as T, delta);
  };
}

export default defineComponent<CS.Godot.Sprite2D>(() => {
  let isMovingRight = true;
  return {
    onProcess(delta) {
      this.Position = new Godot.Vector2(
        this.Position.X + (isMovingRight ? 100 : -100) * delta,
        this.Position.Y
      );

      if (Input.IsActionJustPressed(new Godot.StringName("ui_accept"))) {
        console.log("Button pressed!");
      }
    },
    onReady() {
      setInterval(() => (isMovingRight = !isMovingRight), 1000);
      console.log("JS Environment is ready!");
      const area = this.GetNode(
        new Godot.NodePath("Area2D")
      ) as CS.Godot.CollisionObject2D;

      area.add_MouseEntered(() => {
        this.Modulate = new Godot.Color(1, 0, 0, 1); // Change color to red
        console.log("Mouse entered the area!");
      });
      area.add_MouseExited(() => {
        this.Modulate = new Godot.Color(1, 1, 1, 1); // Change color back to white
        console.log("Mouse exited the area!");
      });
    },
  };
});
