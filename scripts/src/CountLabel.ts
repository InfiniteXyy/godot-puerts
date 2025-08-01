import { defineComponent, Godot } from './utils.js'
import { effect, signal } from '@preact/signals-core'

export const count$ = signal(0)

export default defineComponent<CS.Godot.Label>(() => {
  return {
    onReady() {
      const dispose = effect(() => {
        this.Text = `Click Count: ${count$.value}`
      })
      return () => dispose()
    },
  }
})
