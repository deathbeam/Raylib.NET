using System.Text.RegularExpressions;
using Bindgen;

var transformIdentifier = (string identifier) =>
    identifier switch
    {
        "Matrix" => "Matrix4x4",
        "Rectangle" => "Vector4",
        "va_list" => "IntPtr",
        _ => Regex.Replace(identifier, @"\brl", ""),
    };

var existingIdentifiers = new Dictionary<string, string>
{
    { "Vector2", "System.Numerics" },
    { "Vector3", "System.Numerics" },
    { "Vector4", "System.Numerics" },
    { "Quaternion", "System.Numerics" },
    { "Matrix4x4", "System.Numerics" },
};

string[] defines = { };

var generatedNamespace = "RaylibNET";
var ouputPath = "../../src/Raylib.NET";
var libPath = "../../lib";

string[] systemIncludeFolders =
{
    $"{libPath}/zig/lib/libc/include/generic-musl",
    $"{libPath}/zig/lib/libc/include/x86-linux-musl",
};

string[] includeFolders = { $"{libPath}/raylib/src" };

new Generator(
    generatedClass: "Raygui",
    libraryName: "raylib",
    filePath: $"{libPath}/raygui/src/raygui.h",
    generatedNamespace: generatedNamespace,
    outputPath: ouputPath,
    systemIncludeFolders: systemIncludeFolders,
    includeFolders: includeFolders,
    defines: defines,
    transformIdentifier: transformIdentifier,
    existingIdentifiers: existingIdentifiers
).Generate();

new Generator(
    generatedClass: "Rlgl",
    libraryName: "raylib",
    filePath: $"{libPath}/raylib/src/rlgl.h",
    generatedNamespace: generatedNamespace,
    outputPath: ouputPath,
    systemIncludeFolders: systemIncludeFolders,
    includeFolders: includeFolders,
    defines: defines,
    transformIdentifier: transformIdentifier,
    existingIdentifiers: existingIdentifiers
).Generate();

new Generator(
    generatedClass: "Raymath",
    libraryName: "raylib",
    filePath: $"{libPath}/raylib/src/raymath.h",
    generatedNamespace: generatedNamespace,
    outputPath: ouputPath,
    systemIncludeFolders: systemIncludeFolders,
    includeFolders: includeFolders,
    defines: defines,
    transformIdentifier: transformIdentifier,
    existingIdentifiers: existingIdentifiers
).Generate();

new Generator(
    generatedClass: "Raylib",
    libraryName: "raylib",
    filePath: $"{libPath}/raylib/src/raylib.h",
    generatedNamespace: generatedNamespace,
    outputPath: ouputPath,
    systemIncludeFolders: systemIncludeFolders,
    includeFolders: includeFolders,
    defines: defines,
    transformIdentifier: transformIdentifier,
    existingIdentifiers: existingIdentifiers
).Generate();
