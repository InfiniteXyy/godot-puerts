import { count$ } from './CountLabel'
import { defineComponent, Godot } from './utils'

export default defineComponent<CS.Godot.Sprite2D>(() => {
  let isMovingRight = true
  let isDragging = false
  let isHovered = false

  const textLabel = new Godot.Label()
  textLabel.Text = 'Hello, Godot with JS!'

  return {
    onProcess(delta) {
      if (!isHovered) {
        this.Position = new Godot.Vector2(this.Position.X + (isMovingRight ? 100 : -100) * delta, this.Position.Y)
      }
      if (isDragging) {
        this.Position = this.GetViewport().GetMousePosition()
      }
    },
    onInput(event) {
      if (event instanceof Godot.InputEventMouseButton) {
        if (isHovered && event.IsPressed()) {
          isDragging = true
          textLabel.Text = `Ready to drag from ${event.Position}`
          count$.value += 1
        }
        if (isDragging && event.IsReleased()) {
          isDragging = false
          this.QueueFree()
        }
      }
    },
    onReady() {
      const interval = setInterval(() => (isMovingRight = !isMovingRight), 1000)

      const area = this.GetNode(new Godot.NodePath('Area2D')) as CS.Godot.CollisionObject2D
      const onHovered = () => {
        this.Modulate = new Godot.Color(1, 0, 0, 1) // Change color to red
        isHovered = true
      }
      const onUnHovered = () => {
        this.Modulate = new Godot.Color(1, 1, 1, 1) // Change color back to white
        isHovered = false
      }

      this.AddChild(textLabel)
      area.add_MouseEntered(onHovered)
      area.add_MouseExited(onUnHovered)
      return () => {
        area.remove_MouseEntered(onHovered)
        area.remove_MouseExited(onUnHovered)
        this.RemoveChild(textLabel)

        clearInterval(interval)
      }
    },
  }
})
