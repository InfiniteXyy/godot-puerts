import { defineComponent, Godot } from './utils.js'
import { effect, signal } from '@preact/signals-core'

export const count$ = signal(0)

export default defineComponent<CS.Godot.Label>(() => {
  return {
    onReady() {
      effect(() => {
        this.Text = `Click Count: ${count$.value}`
      })
    },
  }
})
