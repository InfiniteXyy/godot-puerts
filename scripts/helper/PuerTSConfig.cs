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
                typeof(Godot.NodePath),
                typeof(Godot.CanvasItem),
                typeof(JsComponent)
            };
    }
  }
}