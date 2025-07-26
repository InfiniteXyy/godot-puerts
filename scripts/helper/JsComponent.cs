using System;
using Godot;
using Puerts;

public partial class JsComponent : Sprite2D
{
  [Export]
  private bool generatePuerTSCode = false;

  private string jsPath = "scripts/dist/main.js";

  public Action jsOnReady;
  public Action<double> jsOnProcess;

  private JsEnv scriptEnv;

  public override void _Ready()
  {
    if (generatePuerTSCode)
    {
      // used for debugging
      new PuerTSCodeGenerator().GenV1();
    }

    scriptEnv = new JsEnv(new GodotDefaultLoader());
    var init = scriptEnv.ExecuteModule<Action<JsComponent>>(jsPath, "default");

    init(this);

    jsOnReady?.Invoke();
  }

  public override void _Process(double delta)
  {
    jsOnProcess?.Invoke(delta);
    scriptEnv.Tick();
  }
}