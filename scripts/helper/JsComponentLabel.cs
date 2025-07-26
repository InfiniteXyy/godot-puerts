using System;
using Godot;
using Puerts;

public partial class JsComponentLabel : Label, IJsComponent
{
  [Export]
  private string jsPath = "scripts/dist/";

  public Action JsOnReady { get; set; }
  public Action<double> JsOnProcess { get; set; }
  public Action<double> JsOnPhysicsProcess { get; set; }
  public Action<InputEvent> JsOnInput { get; set; }
  public Action JsOnExitTree { get; set; }

  public override void _Ready()
  {
    JsMachine.GetScriptEnv().ExecuteModule<Action<JsComponentLabel>>(jsPath, "default")(this);
    JsOnReady?.Invoke();
  }

  public override void _Process(double delta) => JsOnProcess?.Invoke(delta);
  public override void _PhysicsProcess(double delta) => JsOnPhysicsProcess?.Invoke(delta);
  public override void _Input(InputEvent @event) => JsOnInput?.Invoke(@event);
  public override void _ExitTree() => JsOnExitTree?.Invoke();

}