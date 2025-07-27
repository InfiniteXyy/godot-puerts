1. Download PuerTS dll from https://github.com/Tencent/puerts, and put `libpuerts.dylib` or `libpuerts.dll` in the root folder, based on your OS
2. `cd scripts`, then run `bun i` to install deps, after that run `bun dev` to build

### TODO LIST

- [x] Use ts to define component
- [x] Share jsMachine between nodes
- [x] Hot Reload
- [x] Generate tres files for js script
- [ ] Improve DX by automatically generate cs file and connect to js file when creating a js component
- [ ] Hot Reload on demand
- [ ] Create addon
- [ ] use JSX to define a scene?
