import { count$ } from './CountLabel'
import { defineComponent } from './utils'

export default defineComponent<CS.Godot.Button>(function () {
  const handleClick = () => {
    console.log('Clicked')
    count$.value += 1
  }

  return {
    onReady() {
      this.Text = 'Click to add number'
      this.add_Pressed(handleClick)
      return () => this.remove_Pressed(handleClick)
    },
  }
})
