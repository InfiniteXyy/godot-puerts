import { defineConfig } from 'tsdown'

export default defineConfig({
  entry: ['src/**/*.ts'],
  outDir: 'dist',
  clean: true,
  format: ['esm'],
  target: 'esnext',
  outExtensions: () => ({ js: '.js' }),
})
