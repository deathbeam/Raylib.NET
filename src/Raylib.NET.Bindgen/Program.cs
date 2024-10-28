using System.Text.RegularExpressions;
using Bindgen;

var libPath = "../../lib";
var includePath = args[0];

var transformEnum = (string parent, string name) => parent switch
{
    "IsKeyPressed" or "IsKeyPressedRepeat" or "IsKeyDown" or "IsKeyReleased" or "IsKeyUp" or "GetKeyPressed" => name switch
    {
        "key" or "return" => "KeyboardKey",
        _ => null
    },
    "IsMouseButtonPressed" or "IsMouseButtonDown" or "IsMouseButtonReleased" or "IsMouseButtonUp" => name switch
    {
        "button" => "MouseButton",
        _ => null
    },
    "IsGampadButtonPressed" or "IsGamepadButtonDown" or "IsGamepadButtonReleased" or "IsGamepadButtonUp" or "GetGamepadButtonPressed" => name switch
    {
        "button" or "return" => "GamepadButton",
        _ => null
    },
    "GuiGetStyle" or "GuiSetStyle" => name switch
    {
        "control" => "GuiControl",
        _ => null
    },
    _ => null
};

var options = new GeneratorOptions
{
    DetectArray = (string parent, string name) => {
        if (parent == "rlGenTextureMipmaps") {
            return true;
        }

        if (parent == "rlMultMatrixf") {
            return true;
        }

        if (parent == "rlSetShader") {
            return true;
        }

        if (parent.StartsWith("Unload")) {
            return true;
        }

        return false;
    },
    TransformType = (string parent, string name, string type) =>
        type switch
        {
            "Matrix" => "Matrix4x4",
            "Rectangle" => "Vector4",
            "va_list" => "IntPtr",
            "int" => transformEnum(parent, name),
            _ => Regex.Replace(type, @"\b(rres|rl|r)", ""),
        },
    TransformName = (string name) => Regex.Replace(name, @"\b(rres|rl)", ""),
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
    IncludeFolders = new[] { $"{libPath}/raylib/src" },
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

options.GeneratedClass = "Rres";
options.FilePath = $"{libPath}/rres/src/rres.h";
new Generator(options).Generate();

options.GeneratedClass = "Raylib";
options.FilePath = $"{libPath}/raylib/src/raylib.h";
new Generator(options).Generate();
