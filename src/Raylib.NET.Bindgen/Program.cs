using System.Text.RegularExpressions;
using Bindgen;

var libPath = "../../lib";
var includePath = args[0];

var options = new GeneratorOptions
{
    DetectArray = (string parent, string name) =>
        parent switch
        {
            "rlGenTextureMipmaps" => true,
            "rlMultMatrixf" => true,
            "rlSetShader" => true,
            _ => parent.StartsWith("Unload"),
        },
    TransformType = (string parent, string name, string type) =>
        type switch
        {
            "Matrix" => "Matrix4x4",
            "Rectangle" => "Vector4",
            "va_list" => "IntPtr",
            _ => Regex.Replace(type, @"\b(rl|r)", ""),
        },
    TransformName = (string name) => Regex.Replace(name, @"\b(rl)", ""),
    ExistingTypes = new()
    {
        { "Vector2", "System.Numerics" },
        { "Vector3", "System.Numerics" },
        { "Vector4", "System.Numerics" },
        { "Quaternion", "System.Numerics" },
        { "Matrix4x4", "System.Numerics" },
    },
    OutputPath = "../../src/Raylib.NET",
    TestPath = "../../src/Raylib.NET.Test",
    GeneratedNamespace = "RaylibNET",
    LibraryName = "raylib",
    SystemIncludeFolders = new[]
    {
        $"{includePath}/libc/include/generic-musl",
        $"{includePath}/libc/include/x86-linux-musl",
    },
    IncludeFolders = new[] {
        $"{libPath}/raylib/src",
        $"{libPath}/raygui/src"
    },
};

options.GeneratedClass = "Rlgl";
options.FilePath = $"{libPath}/raylib/src/rlgl.h";
new Generator(options).Generate();

options.GeneratedClass = "Raymath";
options.FilePath = $"{libPath}/raylib/src/raymath.h";
new Generator(options).Generate();

options.GeneratedClass = "Raygui";
options.FilePath = $"{libPath}/raygui/src/raygui.h";
new Generator(options).Generate();

options.GeneratedClass = "Raylib";
options.FilePath = $"{libPath}/raylib/src/raylib.h";
new Generator(options).Generate();
