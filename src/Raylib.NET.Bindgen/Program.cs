using System.Text.RegularExpressions;
using Bindgen;

var libPath = "../../lib";

var transformEnum = (string parent, string name, string type) => {
    if (parent == "GuiGetStyle" || parent == "GuiSetStyle")
    {
        if (name == "control")
        {
            return "GuiControl";
        }

        if (name == "property")
        {
            return "GuiDefaultProperty";
        }
    }

    if (parent == "IsKeyPressed"
            || parent == "IsKeyPressedRepeat"
            || parent == "IsKeyDown"
            || parent == "IsKeyReleased"
            || parent == "IsKeyUp"
            || parent == "GetKeyPressed")
    {
        if (name == "key" || name == "return")
        {
            return "KeyboardKey";
        }
    }

    if (parent == "IsMouseButtonPressed"
            || parent == "IsMouseButtonDown"
            || parent == "IsMouseButtonReleased"
            || parent == "IsMouseButtonUp")
    {
        if (name == "button")
        {
            return "MouseButton";
        }
    }

    if (parent == "IsGampadButtonPressed"
            || parent == "IsGamepadButtonDown"
            || parent == "IsGamepadButtonReleased"
            || parent == "IsGamepadButtonUp"
            || parent == "GetGamepadButtonPressed")
    {
        if (name == "button" || name == "return")
        {
            return "GamepadButton";
        }
    }

    return type;
};

var options = new GeneratorOptions
{
    TransformType = (string parent, string name, string type) =>
        type switch
        {
            "Matrix" => "Matrix4x4",
            "Rectangle" => "Vector4",
            "va_list" => "IntPtr",
            "int" => transformEnum(parent, name, type),
            _ => Regex.Replace(type, @"\brl", ""),
        },
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
        $"{libPath}/zig/lib/libc/include/generic-musl",
        $"{libPath}/zig/lib/libc/include/x86-linux-musl",
    },
    IncludeFolders = new[] { $"{libPath}/raylib/src" },
};

options.GeneratedClass = "Rlgl";
options.FilePath = $"{libPath}/raylib/src/rlgl.h";
new Generator(options).Generate();

options.GeneratedClass = "Raymath";
options.FilePath = $"{libPath}/raylib/src/raymath.h";
new Generator(options).Generate();

options.GeneratedClass = "Raylib";
options.FilePath = $"{libPath}/raylib/src/raylib.h";
new Generator(options).Generate();

options.GeneratedClass = "Raygui";
options.FilePath = $"{libPath}/raygui/src/raygui.h";
new Generator(options).Generate();
