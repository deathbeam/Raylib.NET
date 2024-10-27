### Stuff being done here

Everything is 100% generated, Im not touching the generated stuff, only generator.
The goal is to eventually PR some of this stuff to [Raylib-cs](https://github.com/chrisdill/raylib-cs). Natives PR requires 5.5 update there first and generator is a lot of effort
due to Raylib-cs project structure being quite difficult to work with. If I decide that its not worth it, I will just keep this as a separate project.

### Included bindings

- Raylib
- Raymath
- Rlgl
- Raygui
- Rres

### Supported platforms

- Windows x64/x86/arm64
- OSX x64/arm64
- Linux x64/arm64 (arm64 currently not prebuilt)
- Browser WASM

### Use as dependency

#### Add source

Needs GitHub credentials.

```sh
dotnet nuget add source --name "raylib.net" --username "YOUR_GITHUB_USERNAME" --password "YOUR_GITHUB_TOKEN" --store-password-in-clear-text "https://nuget.pkg.github.com/deathbeam/index.json"
```

#### Use package

```sh
dotnet add package Raylib.NET --version '*-build.*'
dotnet add package Raylib.NET.Native --version '*-build.*'
```

### Try the example

```sh
cd src/Raylib.NET.Example

# linux
dotnet publish -r linux-x64 -c Release
./bin/Release/net8.0/linux-x64/publish/Raylib.NET.Example

# windows
dotnet publish -r win-x64 -c Release
bin/Release/net8.0/win-x64/publish/Raylib.NET.Example.exe

# wasm (EMSDK required + wasm-tools, see below for EMSDK setup)
dotnet workload install wasm-tools
dotnet publish -r browser-wasm -c Release
emrun --port 8080 bin/Release/net8.0/browser-wasm/native/Raylib.NET.Example.html
```

### Local development

Initializes submodules:

```sh
git submodule update --init --recursive
```

Updates raylib submodules (if needed):

```sh
git submodule update --recursive --remote lib/raylib lib/raygui
```

Generate bindings, build natives for whatever os you are on etc:

```sh
dotnet build
```

Cross-compile with RID:

```sh
cd src/Raylib.NET.Native
dotnet build -r win-x64
dotnet build -r win-x86
dotnet build -r win-arm64
dotnet build -r linux-x64
dotnet build -r osx-x64
dotnet build -r osx-arm64
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

### TODO/Maybe

- [ ] Normalize ints/uints
- [ ] Get rid of remaining fake ints/bools (in Raygui especially i think)
- [ ] Any way to map enums to input params automatically?
- [ ] Detect arrays automatically, use Span?
- [ ] String/NativeBool in delegates?
- [ ] Bindgen order
- [ ] Detect actual refs vs arrays and use ref for refs (C types are fake so unreliable)
