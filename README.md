### Stuff being done here

- Everything is 100% generated, no manual wrappers, minimal amount of manual mappings (mostly just slight correction for array detection, C "arrays" are worst thing ever made)
- Natives are built for all platforms, using raylib zig build scripts

### Stuff not being done here

- Enum to argument mappings - this is raylib design decision, if raylib maintainers decide to provide type info in headers I can parse it, but i dont want to hardcode it
- Array->Span mappings - there is no info if something is array or not in raylib C headers so detecting arrays is very volatile. I do some basic array detection at the moment so this might be possible eventually, but im undecided yet
- Manual wrappers - Everything manual is error prone and harder to maintain, the bindings are perfectly usable without them (partially thanks to LibraryImport being so nice to work with)

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
- Browser WASM (using better WASM not the awful default .NET one, e.g [NativeAOT-LLVM](https://github.com/dotnet/runtimelab/tree/feature/NativeAOT-LLVM))

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
git submodule update --recursive --remote
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
