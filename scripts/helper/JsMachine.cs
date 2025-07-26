using System;
using Godot;
using Puerts;

public interface IJsComponent
{
  Action JsOnReady { get; set; }
  Action<double> JsOnProcess { get; set; }
  Action<double> JsOnPhysicsProcess { get; set; }
  Action<InputEvent> JsOnInput { get; set; }
  Action JsOnExitTree { get; set; }
}

public partial class JsMachine : Node
{
  [Export]
  private bool generateCode = false;

  private static JsEnv scriptEnv;

  public static JsEnv GetScriptEnv()
  {
    scriptEnv ??= new JsEnv(new GodotDefaultLoader());
    return scriptEnv;
  }

  public override void _Ready()
  {
    if (generateCode)
    {
      // Generate code for the project
      new PuerTSCodeGenerator().GenV1();
    }

    GetScriptEnv();
  }

  public override void _Process(double delta)
  {
    scriptEnv?.Tick();
  }

  public override void _ExitTree()
  {
    scriptEnv?.Dispose();
    scriptEnv = null;
  }
}

