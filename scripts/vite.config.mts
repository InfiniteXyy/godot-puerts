import { defineConfig } from 'vite'
import fse from 'fs-extra'
import { csGenerator } from './vite-plugins/csGenerator.mts'
import { avoidOverwriteIfUnchanged } from './vite-plugins/avoidOverwriteIfUnchanged'

const entrypoints = fse.globSync('src/**/*.ts')
export default defineConfig({
  plugins: [csGenerator(entrypoints), avoidOverwriteIfUnchanged()],
  build: {
    emptyOutDir: false,
    lib: { entry: entrypoints, formats: ['es'] },
    target: false,
    minify: false,
  },
})
