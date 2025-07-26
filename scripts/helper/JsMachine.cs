using System;
using System.IO;
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
  private bool generateCode = true;

  [Export]
  private bool watchCodeChanges = true;

  private bool isCodeDirty = false;

  public static event Action<string> CodeChanged;

  private static JsEnv scriptEnv;

  private FileSystemWatcher watcher;

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

    if (watchCodeChanges)
    {
      // 将 Godot 路径转换为系统路径
      var absPath = ProjectSettings.GlobalizePath("res://scripts/dist");

      watcher = new FileSystemWatcher
      {
        Path = absPath,
        NotifyFilter = NotifyFilters.Size,
        Filter = "*.mjs",
        IncludeSubdirectories = true,
        EnableRaisingEvents = true
      };

      watcher.Changed += OnScriptFileChanged;
      watcher.Created += OnScriptFileChanged;
      watcher.Deleted += OnScriptFileChanged;

      GD.Print($"[JsMachine] Watching JS files in: {absPath}");
    }

    GetScriptEnv();
  }

  private void OnScriptFileChanged(object sender, FileSystemEventArgs e)
  {
    GD.Print($"[JsMachine] JS file changed: {e.Name} ({e.ChangeType})");
    isCodeDirty = true;
  }


  public override void _Process(double delta)
  {
    if (isCodeDirty || Input.IsActionJustPressed("ui_accept"))
    {
      isCodeDirty = false;
      scriptEnv?.ClearModuleCache();
      CodeChanged?.Invoke("");
      GD.Print("File changed, force reload");
    }
    scriptEnv?.Tick();
  }

  public override void _ExitTree()
  {
    scriptEnv?.Dispose();
    scriptEnv = null;

    if (watcher != null)
    {
      watcher.EnableRaisingEvents = false;
      watcher.Dispose();
      watcher = null;
    }
  }
}
