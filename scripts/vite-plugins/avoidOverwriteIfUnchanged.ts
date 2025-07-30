import fse from 'fs-extra'
import path from 'path'
import { Plugin } from 'vite'

export function avoidOverwriteIfUnchanged(): Plugin {
  return {
    name: 'avoid-overwrite-if-unchanged',
    async generateBundle(options, bundle) {
      const outDir = 'dist'

      console.log('\n')
      for (const [fileName, asset] of Object.entries(bundle)) {
        const filePath = path.join(outDir, fileName)

        try {
          const existing = fse.readFileSync(filePath)
          const newContent = asset.type === 'asset' ? Buffer.from(asset.source) : Buffer.from(asset.code)

          if (Buffer.compare(existing, newContent) === 0) {
            // Content is the same, skip writing
            delete bundle[fileName]
            console.log('[skip] Content is the same for', fileName)
          }
        } catch (err) {
          // File does not exist, or other error, just proceed
        }
      }
    },
  }
}
