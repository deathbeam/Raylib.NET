Initializes submodules:

```sh
git submodule update --init --recursive
```

Updates raylib submodules:

```sh
git submodule update --recursive --remote lib/raylib lib/raygui
```

Generates bindings, builds natives for whatever os you are on etc:

```sh
dotnet build
```

Can somewhat cross-compile with RID:

```sh
cd src/Raylib.NET.Native
dotnet build -r win-x64
dotnet build -r win-x86
dotnet build -r linux-x64
dotnet build -r osx-x64
dotnet build -r browser-wasm
```

`browser-wasm` requires `EMSDK`:

```sh
git clone https://github.com/emscripten-core/emsdk
cd emsdk
./emsdk install latest
./emsdk activate latest
export EMSDK=$PWD
```

### Use as dependency

```sh
dotnet add package Raylib.NET --version '*-dev-*'
dotnet add package Raylib.NET.Native --version '*-dev-*'
```

### Stuff being done here

Everything is 100% generated, Im not touching the generated stuff, only generator.

### TODO/Maybe

- [ ] Normalize ints/uints
- [ ] Get rid of remaining fake ints/bools (in Raygui especially i think)
- [ ] Any way to map enums to input params automatically?
- [ ] Detect arrays automatically, use Span?
- [ ] String/NativeBool in delegates?
- [ ] Bindgen order
- [ ] Detect actual refs vs arrays and use ref for refs (C types are fake so unreliable)
