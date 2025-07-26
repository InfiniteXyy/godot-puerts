using System;
using System.Collections.Generic;
using Godot;
using Puerts;

[Configure]
public class PuerTSConfig
{
  [Binding]
  static IEnumerable<Type> Bindings
  {
    get
    {
      return new List<Type>()
            {
                typeof(Godot.GD),
                typeof(Godot.StringName),
                typeof(Godot.Viewport),
                typeof(Godot.NodePath),
                typeof(Godot.Input),
                typeof(Godot.InputEvent),
                typeof(Godot.InputEventMouse),
                typeof(Godot.InputEventMouseButton),
                typeof(Godot.Node),
                typeof(Godot.Node2D),
                typeof(Godot.Vector2),
                typeof(Godot.Vector2),
                typeof(Godot.Area2D),
                typeof(Godot.Sprite2D),
                typeof(Godot.CollisionObject2D),
                typeof(Godot.Texture),
                typeof(Godot.Texture2D),
                typeof(Godot.Color),
                typeof(Godot.CanvasItem),
                typeof(JsComponent)
            };
    }
  }
}