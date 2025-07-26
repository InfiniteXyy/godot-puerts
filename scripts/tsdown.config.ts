import { defineConfig } from 'tsdown'
import { readFileSync, writeFileSync, statSync } from 'node:fs'
import { globSync } from 'glob'

const createResYaml = (jsPath: string) => `[gd_resource type="Resource" script_class="JsSource" load_steps=2 format=3]

[ext_resource type="Script" path="res://scripts/helper/JsSource.cs" id="script"]

[resource]
script = ExtResource("script")
jsPath = "${jsPath}"
`

const allEntries = globSync('src/**/*.ts')

export default defineConfig({
  entry: [...allEntries],
  outDir: 'dist',
  clean: true,
  format: ['esm'],
  target: 'esnext',
  onSuccess() {
    allEntries.forEach((filePath) => {
      const relativePath = filePath.replace('src/', '').replace('.ts', '')
      const tresYaml = createResYaml(`scripts/dist/${relativePath}.mjs`)
      const tresPath = `dist/${relativePath}.tres`

      writeFileSync(tresPath, tresYaml)
    })
  },
})
