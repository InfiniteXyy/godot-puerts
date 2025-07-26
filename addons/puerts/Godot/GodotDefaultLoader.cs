using System;
using System.Diagnostics;
using System.IO;
using Godot;
using Puerts;
using FileAccess = Godot.FileAccess;

public class GodotDefaultLoader : ILoader
{
    public bool FileExists(string filepath)
    {
        return FileAccess.FileExists("res://addons/PuerTS/Runtime/Resources/" + filepath)
            || FileAccess.FileExists("res://addons/PuerTS/Editor/Resources/" + filepath)
            || FileAccess.FileExists(filepath);
    }

    public string ReadFile(string filePath, out string debugPath)
    {
        var appPath = ProjectSettings.GlobalizePath("res://" + filePath);
        var runtimePath = ProjectSettings.GlobalizePath("res://addons/PuerTS/Runtime/Resources/" + filePath);
        var editorPath = ProjectSettings.GlobalizePath("res://addons/PuerTS/Editor/Resources/" + filePath);

        if (FileAccess.FileExists(appPath))
            debugPath = appPath;
        else if (FileAccess.FileExists(runtimePath))
            debugPath = runtimePath;
        else if (FileAccess.FileExists(editorPath))
            debugPath = editorPath;
        else
            throw new Exception("file not found: " + filePath);

        return File.ReadAllText(debugPath);
    }
}
