using System;
using System.Collections.Generic;
using Godot;


public class JsComponentHook<T>(T owner, string jsPath) where T : Node
{
  public Action JsOnReady { get; set; }
  public Action<double> JsOnProcess { get; set; }
  public Action<double> JsOnPhysicsProcess { get; set; }
  public Action<InputEvent> JsOnInput { get; set; }
  public Action JsOnExitTree { get; set; }


  private void HandleJSReload(string moduleName)
  {
    if (moduleName == null || jsPath.Contains(moduleName) || moduleName.Contains("utils.mjs"))
    {
      JsOnExitTree?.Invoke();
      JsMachine.GetScriptEnv().ExecuteModule<Action<JsComponentHook<T>, T>>(jsPath, "default")(this, owner);
      JsOnReady?.Invoke();
    }
  }

  public void _Ready()
  {
    JsMachine.CodeChanged += HandleJSReload;
    HandleJSReload(null);
  }
  public void _Process(double delta) => JsOnProcess?.Invoke(delta);
  public void _PhysicsProcess(double delta) => JsOnPhysicsProcess?.Invoke(delta);
  public void _Input(InputEvent @event) => JsOnInput?.Invoke(@event);
  public void _ExitTree()
  {
    JsMachine.CodeChanged -= HandleJSReload;
    JsOnExitTree?.Invoke();
  }
}