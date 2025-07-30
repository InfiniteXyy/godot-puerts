using Godot;

public partial class Icon : Sprite2D
{
  private string jsPath = "scripts/dist/Icon.mjs";

  [Export]
  private string text = "Hello, Godot with JS!";

  private JsComponentHook<Sprite2D> jsComponentHook;

  public override void _Ready()
  {
    jsComponentHook = new JsComponentHook<Sprite2D>(this, jsPath);
    jsComponentHook._Ready();
  }

  public override void _Process(double delta) => jsComponentHook._Process(delta);
  public override void _PhysicsProcess(double delta) => jsComponentHook._PhysicsProcess(delta);
  public override void _Input(InputEvent @event) => jsComponentHook._Input(@event);
  public override void _ExitTree() => jsComponentHook._ExitTree();
}