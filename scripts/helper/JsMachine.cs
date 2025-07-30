using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Godot;
using Puerts;

public partial class JsMachine : Node
{
  [Export]
  private bool generateCode = true;

  [Export]
  private bool watchCodeChanges = true;

  private static JsEnv scriptEnv;

  private List<string> dirtyCodeList = [];
  private FileSystemWatcher watcher;
  public static event Action<string> CodeChanged;
  private double codeChangeThrottleTime = 0;

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
    if (codeChangeThrottleTime <= 0)
    {
      dirtyCodeList.Add(e.Name);
      codeChangeThrottleTime = 0.1;
    }
  }


  public override void _Process(double delta)
  {
    if (codeChangeThrottleTime > 0) codeChangeThrottleTime -= delta;
    if (dirtyCodeList.Count > 0)
    {
      // have to handle scriptEnv in the process
      var dirtyCodeName = dirtyCodeList[0];
      dirtyCodeList.RemoveAt(0);
      scriptEnv?.ClearModuleCache();
      CodeChanged?.Invoke(dirtyCodeName);
      GD.Print($"[JsMachine] JS file changed: {dirtyCodeName}");
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
