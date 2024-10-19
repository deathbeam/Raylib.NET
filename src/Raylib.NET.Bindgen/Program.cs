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

string[] defines =
{
    "BUILD_LIBTYPE_SHARED",
    // "RAYGUI_IMPLEMENTATION",
    // "RLGL_IMPLEMENTATION"
};

var generatedNamespace = "Raylib.NET";
var ouputPath = "../../src/Raylib.NET";
var libPath = "../../lib";

List<string> systemIncludeList = new();

foreach (var include in Directory.GetDirectories("/usr/lib/clang", "*", SearchOption.AllDirectories))
{
    string includePath = Path.Combine(include, "include");
    if (Directory.Exists(includePath))
    {
        Console.WriteLine(includePath);
        systemIncludeList.Add(includePath);
    }
}

// foreach (var include in Directory.GetDirectories("/usr/lib/", "llvm-*", SearchOption.AllDirectories))
// {
//     string includePath = Path.Combine(include, "include/c++/v1");
//     if (Directory.Exists(includePath))
//     {
//         Console.WriteLine(includePath);
//         systemIncludeList.Add(includePath);
//     }
// }

systemIncludeList.Add("/usr/include");
string[] systemIncludeFolders = systemIncludeList.ToArray();
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
