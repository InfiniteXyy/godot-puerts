using System;
using Godot;
using Puerts;

public partial class JsComponentSprite2D : Sprite2D, IJsComponent
{
  [Export]
  private JsSource jsSource;

  public Action JsOnReady { get; set; }
  public Action<double> JsOnProcess { get; set; }
  public Action<double> JsOnPhysicsProcess { get; set; }
  public Action<InputEvent> JsOnInput { get; set; }
  public Action JsOnExitTree { get; set; }

  private void HandleJSReload(string moduleName)
  {
    // FIX: Should filter out unrelated code change events;
    JsOnExitTree?.Invoke();
    JsMachine.GetScriptEnv().ExecuteModule<Action<JsComponentSprite2D>>(jsSource.jsPath, "default")(this);
    JsOnReady?.Invoke();
  }

  public override void _Ready()
  {
    JsMachine.CodeChanged += HandleJSReload;
    HandleJSReload(null);
  }

  public override void _Process(double delta) => JsOnProcess?.Invoke(delta);
  public override void _PhysicsProcess(double delta) => JsOnPhysicsProcess?.Invoke(delta);
  public override void _Input(InputEvent @event) => JsOnInput?.Invoke(@event);
  public override void _ExitTree()
  {
    JsMachine.CodeChanged -= HandleJSReload;
    JsOnExitTree?.Invoke();
  }
}