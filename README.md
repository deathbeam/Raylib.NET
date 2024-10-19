Initializes submodules:

```sh
git submodule update --init --recursive
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
```

Still limited by missing native libs and missing OSX SDK, so basically only thing that works
well is cross-compiling to win from linux.

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
