namespace Bindgen;

public struct GeneratorOptions
{
    public string GeneratedNamespace = "";
    public string GeneratedClass = "";
    public string OutputPath = "";
    public string TestPath = "";
    public string LibraryName = "";
    public string FilePath = "";
    public string[] SystemIncludeFolders = { };
    public string[] IncludeFolders = { };
    public string[] Defines = { };
    public Func<string, string, string, string?> TransformType = (parent, name, type) => null;
    public Func<string, string, bool> DetectArray = (parent, name) => false;
    public Dictionary<string, string> ExistingTypes = new();

    public GeneratorOptions()
    {
    }
}
