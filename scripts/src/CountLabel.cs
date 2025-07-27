using Godot;

public partial class CountLabel : Label
{
  private string jsPath = "scripts/dist/CountLabel.mjs";

  private JsComponentHook<Label> jsComponentHook;

  public override void _Ready()
  {
    jsComponentHook = new JsComponentHook<Label>(this, jsPath);
    jsComponentHook._Ready();
  }

  public override void _Process(double delta) => jsComponentHook._Process(delta);
  public override void _PhysicsProcess(double delta) => jsComponentHook._PhysicsProcess(delta);
  public override void _Input(InputEvent @event) => jsComponentHook._Input(@event);
  public override void _ExitTree() => jsComponentHook._ExitTree();
}