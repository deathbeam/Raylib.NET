using System.Text;
using System.Text.RegularExpressions;
using CppAst;
using Microsoft.CodeAnalysis.CSharp;

namespace Bindgen;

public class Generator
{
    private readonly string GeneratedNamespace;
    private readonly string GeneratedClass;
    private readonly string OutputPath;
    private readonly string LibraryName;
    private readonly string FilePath;
    private readonly Func<string, string> TransformIdentifier;
    private readonly Dictionary<string, string> ExistingIdentifiers;

    private readonly string FileContent;
    private readonly CppParserOptions Options;
    private readonly HashSet<string> ReservedKeywords = new HashSet<string>();
    private readonly Dictionary<string, Dictionary<string, string>> LiteralValues = new();

    public Generator(
        string generatedNamespace,
        string generatedClass,
        string outputPath,
        string libraryName,
        string filePath,
        string[] systemIncludeFolders,
        string[] includeFolders,
        string[] defines,
        Func<string, string> transformIdentifier,
        Dictionary<string, string> existingIdentifiers
    )
    {
        GeneratedNamespace = generatedNamespace;
        GeneratedClass = generatedClass;
        OutputPath = outputPath;
        LibraryName = libraryName;
        FilePath = filePath;
        TransformIdentifier = transformIdentifier;
        ExistingIdentifiers = existingIdentifiers;
        FileContent = File.ReadAllText(FilePath);

        Options = new CppParserOptions
        {
            AdditionalArguments = { "-xc", "-std=gnu99" },
            ParseAsCpp = false,
            ParseComments = true,
            ParseMacros = true,
        };

        Options.SystemIncludeFolders.AddRange(systemIncludeFolders);
        Options.IncludeFolders.AddRange(includeFolders);
        Options.Defines.AddRange(defines);

        foreach (var keyword in SyntaxFacts.GetKeywordKinds())
        {
            ReservedKeywords.Add(SyntaxFacts.GetText(keyword));
        }
    }

    public void Generate()
    {
        Console.WriteLine();
        Console.WriteLine($">>>>>>>> Parsing: {FilePath}");
        var ast = CppParser.Parse(FileContent, Options);

        Console.WriteLine();
        Console.WriteLine($"> Diagnostics: {ast.Diagnostics.Messages.Count}");
        foreach (var message in ast.Diagnostics.Messages)
        {
            Console.WriteLine(message);
        }

        var builder = new StringBuilder();

        builder.AppendLine("using System.Runtime.CompilerServices;");
        builder.AppendLine("using System.Runtime.InteropServices;");
        builder.AppendLine("using Bindgen.Interop;");

        foreach (var import in ExistingIdentifiers.Values.Distinct())
        {
            builder.AppendLine($"using {import};");
        }

        builder.AppendLine();
        builder.AppendLine($"namespace {GeneratedNamespace};");
        builder.AppendLine();
        builder.AppendLine($"public static unsafe partial class {GeneratedClass}");
        builder.AppendLine("{");
        builder.AppendLine($"    public const string LIBRARY = \"{LibraryName}\";");

        Console.WriteLine();
        Console.WriteLine($"> Macros: {ast.Macros.Count}");
        foreach (var macro in ast.Macros)
        {
            var name = GenerateConstant(macro, out var generated);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(generated))
            {
                continue;
            }

            Console.WriteLine($"- {name}");
            builder.AppendLine();
            builder.AppendLine(generated);
        }

        Console.WriteLine();
        Console.WriteLine($"> Functions: {ast.Functions.Count}");
        foreach (var function in ast.Functions)
        {
            var name = GenerateFunction(function, out var generated);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(generated))
            {
                continue;
            }

            Console.WriteLine($"- {name}");
            builder.AppendLine();
            builder.AppendLine(generated);
        }

        builder.AppendLine("}");

        Console.WriteLine();
        Console.WriteLine($"> Enums: {ast.Enums.Count}");
        foreach (var cppEnum in ast.Enums)
        {
            var name = GenerateEnum(cppEnum, out var generated);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(generated))
            {
                continue;
            }

            generated = "namespace " + GeneratedNamespace + ";\n\n" + generated;
            var path = $"{OutputPath}/Enums/{name}.cs";
            Console.WriteLine($"- Generated: {name} - {path}");
            WriteFile(path, generated);
        }

        Console.WriteLine();
        Console.WriteLine($"> Structs: {ast.Classes.Count}");
        foreach (var cppStruct in ast.Classes)
        {
            var name = GenerateStruct(cppStruct, out var generated);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(generated))
            {
                continue;
            }

            var generate = "";
            generate += "using System.Runtime.InteropServices;\n";
            generate += "using Bindgen.Interop;\n";

            foreach (var import in ExistingIdentifiers.Values.Distinct())
            {
                generate += "using " + import + ";\n";
            }

            generate += "\nnamespace " + GeneratedNamespace + ";\n\n";
            generate += generated;
            var path = $"{OutputPath}/Types/{name}.cs";
            Console.WriteLine($"- Generated: {name} - {path}");
            WriteFile(path, generate);
        }

        var outPath = $"{OutputPath}/{GeneratedClass}.cs";
        Console.WriteLine($"> Generated: {GeneratedClass} - {outPath}");
        WriteFile(outPath, builder.ToString());

        outPath = $"{OutputPath}/Interop.cs";
        Console.WriteLine($"> Generated: Interop - {outPath}");
        WriteFile(outPath, Interop.Generate());
    }

    private String GenerateConstant(CppMacro macro, out String output)
    {
        if (macro.Span.Start.File != "cppast.input")
        {
            output = "";
            return "";
        }

        string name = macro.Name.Trim();
        string value = macro.Value.Trim();

        output = "";

        if (string.IsNullOrEmpty(value))
        {
            return name;
        }

        if (value.StartsWith("0x"))
        {
            output += $"    public const int {name} = {Convert.ToInt32(value, 16)};";
        }
        else if (int.TryParse(value, out _))
        {
            output += $"    public const int {name} = {value};";
        }
        else if (float.TryParse(value.TrimEnd('f'), out _))
        {
            output += $"    public const float {name} = {value.TrimEnd('f')}f;";
        }
        else if (value.StartsWith("\""))
        {
            output += $"    public const string {name} = \"{value.Replace("\"", "")}\";";
        }
        else if (value.Contains("/"))
        {
            output += $"    public static readonly float {name} = {value};";
        }
        else if (value.StartsWith("CLITERAL("))
        {
            string re = "CLITERAL\\((.*)\\)";
            var match = Regex.Match(value, re);
            var type = match.Groups[1].Value;
            var typeValue = value.Substring(match.Length + 1, value.Length - match.Length - 2);

            if (!LiteralValues.ContainsKey(type))
            {
                LiteralValues.Add(type, new());
            }

            LiteralValues[type][name] = typeValue;
        }
        else
        {
            Console.WriteLine($"- Unsupported macro: {name} = {value}");
        }

        return name;
    }

    private String GenerateEnum(CppEnum cppEnum, out String output)
    {
        string enumName = MapIdentifier(cppEnum.Name);

        output = "";
        output += $"public enum {enumName}\n";
        output += "{\n";

        foreach (var enumItem in cppEnum.Items)
        {
            GenerateComments(enumItem, ref output);

            string itemName = enumItem.Name;
            string itemValue = enumItem.ValueExpression?.ToString() ?? "";

            if (string.IsNullOrEmpty(itemValue))
            {
                output += $"    {itemName},\n";
            }
            else
            {
                output += $"    {itemName} = {itemValue},\n";
            }
        }

        output += "}";
        return enumName;
    }

    private String GenerateStruct(CppClass cppStruct, out String output)
    {
        string structName = MapIdentifier(cppStruct.Name);

        output = "";

        if (ExistingIdentifiers.ContainsKey(structName))
        {
            return "";
        }

        output += "[StructLayout(LayoutKind.Sequential)]\n";
        output += $"public partial struct {structName}\n";
        output += "{\n";

        // Generate constants
        if (LiteralValues.TryGetValue(structName, out var values))
        {
            foreach (var value in values)
            {
                var name = value.Key;
                var type = value.Value;
                output += $"    public static readonly {structName} {name} = new {structName}({type});\n";
            }

            output += "\n";
        }

        var generateConstructor = cppStruct.Fields.Count > 0;

        // Generate fields
        foreach (var field in cppStruct.Fields)
        {
            GenerateComments(field, ref output);

            var pointerCount = 0;
            string fieldType = ConvertCppTypeToCSharp(field.Type, ref pointerCount, out var arraySize);
            string fieldName = MapIdentifier(field.Name, true);

            if (arraySize > 0)
            {
                generateConstructor = false;

                if (IsNotPrimitive(fieldType))
                {
                    for (int i = 0; i < arraySize; i++)
                    {
                        output += $"    public {fieldType} {fieldName}{i};\n";
                    }
                }
                else
                {
                    output += $"    public unsafe fixed {fieldType} {fieldName}[{arraySize}];\n";
                }
            }
            else
            {
                if (pointerCount > 0)
                {
                    output += $"    public unsafe {fieldType}{new string('*', pointerCount)} {fieldName};\n";
                }
                else
                {
                    output += $"    public {fieldType} {fieldName};\n";
                }
            }
        }

        // Generate constructor
        if (generateConstructor)
        {
            var constructorOutput = "";
            bool first = true;
            bool unsafeDecl = false;
            foreach (var field in cppStruct.Fields)
            {
                var pointerCount = 0;
                string fieldType = ConvertCppTypeToCSharp(field.Type, ref pointerCount, out var arraySize);
                string fieldName = ToCamelCase(MapIdentifier(field.Name, true));

                if (!first)
                {
                    constructorOutput += ", ";
                }
                first = false;

                constructorOutput += $"{fieldType}{new string('*', pointerCount)} {fieldName}";

                if (pointerCount > 0)
                {
                    unsafeDecl = true;
                }
            }

            constructorOutput =
                "\n    public " + (unsafeDecl ? "unsafe " : "") + structName + "(" + constructorOutput + ")\n    {\n";
            output += constructorOutput;

            foreach (var field in cppStruct.Fields)
            {
                string fieldName = MapIdentifier(field.Name, true);
                output += $"        this.{fieldName} = {ToCamelCase(fieldName)};\n";
            }
            output += "    }\n";
        }

        output += "}";
        return structName;
    }

    private String GenerateFunction(CppFunction function, out String output)
    {
        if (function.Span.Start.File != "cppast.input")
        {
            output = "";
            return "";
        }

        var pointerCount = 0;
        string returnType = ConvertCppTypeToCSharp(function.ReturnType, ref pointerCount, out _);
        returnType = AppendPointer(returnType, pointerCount);

        string functionName = MapIdentifier(function.Name);
        List<string> parameters = new List<string>();
        bool isUnsafe = pointerCount > 0;

        foreach (var parameter in function.Parameters)
        {
            var paramPointerCount = 0;
            string paramType = ConvertCppTypeToCSharp(parameter.Type, ref paramPointerCount, out _);
            paramType = AppendPointer(paramType, paramPointerCount);
            string paramName = MapIdentifier(parameter.Name);

            if (paramPointerCount > 0)
            {
                isUnsafe = true;
            }

            parameters.Add($"{paramType} {paramName}");
        }

        string parametersString = string.Join(", ", parameters);

        output = "";
        GenerateComments(function, ref output);

        if (functionName != function.Name)
        {
            output +=
                $"    [LibraryImport(LIBRARY, EntryPoint = \"{function.Name}\", StringMarshalling = StringMarshalling.Utf8)]\n";
        }
        else
        {
            output += $"    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]\n";
        }

        output += "    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]\n";
        output +=
            $"    public static {(isUnsafe ? "unsafe " : "")}partial {returnType} {functionName}({parametersString});";

        return functionName;
    }

    private bool GenerateComments(CppDeclaration dec, ref String output)
    {
        var lines = FileContent.Split('\n');
        var comments = new List<string>();

        for (int i = dec.Span.Start.Line - 1; i < dec.Span.End.Line; i++)
        {
            var line = lines[i].Trim();
            if (line.Contains("//"))
            {
                comments.Add(line.Substring(line.IndexOf("//") + 2).Trim());
            }
        }

        var commentsString = string.Join("\n", comments);

        if (string.IsNullOrEmpty(commentsString))
        {
            var commentList = dec.Comment?.ToString().Split('\n').Select(c => c.Trim().Replace("/", ""));
            if (commentList != null)
            {
                commentsString = string.Join("\n    /// ", commentList);
            }
        }

        if (!string.IsNullOrEmpty(commentsString))
        {
            output += $"    /// <summary>\n";
            output += $"    /// {commentsString}\n";
            output += $"    /// </summary>\n";
            return true;
        }

        return false;
    }

    private string ConvertCppTypeToCSharp(
        CppType cppType,
        ref int pointerCount,
        out int arraySize,
        bool skipHighOrder = false
    )
    {
        arraySize = 0;
        switch (cppType)
        {
            case CppPrimitiveType primitiveType:
                return primitiveType.Kind switch
                {
                    CppPrimitiveKind.Void => "void",
                    CppPrimitiveKind.Bool => skipHighOrder ? "sbyte" : "NativeBool",
                    CppPrimitiveKind.Char => "sbyte",
                    CppPrimitiveKind.Short => "short",
                    CppPrimitiveKind.Int => "int",
                    CppPrimitiveKind.Long => "long",
                    CppPrimitiveKind.Float => "float",
                    CppPrimitiveKind.Double => "double",
                    CppPrimitiveKind.UnsignedChar => "byte",
                    CppPrimitiveKind.UnsignedShort => "ushort",
                    CppPrimitiveKind.UnsignedInt => "uint",
                    CppPrimitiveKind.UnsignedLong => "ulong",
                    _ => throw new NotSupportedException($"Unsupported primitive type: {primitiveType.Kind}"),
                };
            case CppPointerType pointerType:
                if (pointerCount == 0 && !skipHighOrder)
                {
                    if (pointerType.ElementType is CppPrimitiveType pt)
                    {
                        if (pt.Kind == CppPrimitiveKind.Char)
                        {
                            return "string";
                        }
                    }
                    else if (pointerType.ElementType is CppQualifiedType qt)
                    {
                        if (qt.ElementType is CppPrimitiveType ptt)
                        {
                            if (ptt.Kind == CppPrimitiveKind.Char)
                            {
                                return "string";
                            }
                        }
                    }
                }

                pointerCount++;
                return ConvertCppTypeToCSharp(pointerType.ElementType, ref pointerCount, out _, skipHighOrder);
            case CppReferenceType referenceType:
                pointerCount++;
                return ConvertCppTypeToCSharp(referenceType.ElementType, ref pointerCount, out _, skipHighOrder);
            case CppArrayType arrayType:
                arraySize = arrayType.Size;
                return ConvertCppTypeToCSharp(arrayType.ElementType, ref pointerCount, out _, skipHighOrder);
            case CppQualifiedType qualifiedType:
                return ConvertCppTypeToCSharp(qualifiedType.ElementType, ref pointerCount, out _, skipHighOrder);
            case CppTypedef typedefType:
                return ConvertCppTypeToCSharp(typedefType.ElementType, ref pointerCount, out _, skipHighOrder);
            case CppClass cppClass:
                return MapIdentifier(cppClass.Name);
            case CppEnum cppEnum:
                return cppEnum.Name;
            case CppFunctionType cppFunctionType:
                var returnPointerCount = 0;
                string returnType = ConvertCppTypeToCSharp(
                    cppFunctionType.ReturnType,
                    ref returnPointerCount,
                    out _,
                    true
                );
                returnType = AppendPointer(returnType, returnPointerCount);

                List<string> parameters = new List<string>();
                foreach (var parameter in cppFunctionType.Parameters)
                {
                    var paramPointerCount = 0;
                    string paramType = ConvertCppTypeToCSharp(parameter.Type, ref paramPointerCount, out _, true);
                    paramType = AppendPointer(paramType, paramPointerCount);
                    parameters.Add(paramType);
                }

                string parametersString = string.Join(", ", parameters);
                return $"delegate unmanaged[Cdecl]<{parametersString}, {returnType}>";
            default:
                throw new NotSupportedException($"Unsupported type: {cppType.GetType().Name}");
        }
    }

    private string MapIdentifier(string identifier, bool toPascalCase = false)
    {
        var o = toPascalCase ? ToPascalCase(identifier) : identifier;

        if (ReservedKeywords.Contains(o))
        {
            return "@" + o;
        }

        return o switch
        {
            "int32_t" => "int",
            "uint32_t" => "uint",
            "int16_t" => "short",
            "uint16_t" => "ushort",
            "int8_t" => "sbyte",
            "uint8_t" => "byte",
            "int64_t" => "long",
            "uint64_t" => "ulong",
            _ => TransformIdentifier(o),
        };
    }

    private static string AppendPointer(string type, int pointerCount)
    {
        if (type.Contains("delegate"))
        {
            return type.Replace("delegate", "delegate" + new string('*', pointerCount));
        }

        return type + new string('*', pointerCount);
    }

    private static bool IsNotPrimitive(string identifier)
    {
        return identifier[0].ToString().ToLower() != identifier[0].ToString();
    }

    private static string ToPascalCase(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return value;
        }

        return char.ToUpper(value[0]) + value.Substring(1);
    }

    private static string ToCamelCase(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return value;
        }

        return char.ToLower(value[0]) + value.Substring(1);
    }

    private static void WriteFile(string path, string content)
    {
        var directoryPath = Path.GetDirectoryName(path);
        if (!string.IsNullOrEmpty(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        File.WriteAllText(path, content);
    }
}
