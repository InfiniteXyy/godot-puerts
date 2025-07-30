import { count$ } from './CountLabel'
import { defineComponent, Vector2 } from './utils'

export default defineComponent<CS.Godot.Button>(function () {
  const newIconScene = CS.Godot.ResourceLoader.Load('res://scenes/icon.tscn') as CS.Godot.PackedScene

  const handleClick = () => {
    console.log('Clicked')
    count$.value += 1
    for (let i = 0; i < 5; i++) {
      const icon = newIconScene.Instantiate() as CS.Icon
      icon.Position = new Vector2(
        Math.random() * this.GetViewportRect().Size.X,
        Math.random() * this.GetViewportRect().Size.Y
      )
      this.GetTree().GetRoot().AddChild(icon)
    }
  }

  return {
    onReady() {
      this.Text = 'Click to add number'
      this.add_Pressed(handleClick)
      return () => this.remove_Pressed(handleClick)
    },
  }
})
