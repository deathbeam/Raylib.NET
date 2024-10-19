using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct FilePathList
{
    /// <summary>
    /// Filepaths max entries
    /// </summary>
    public uint Capacity;
    /// <summary>
    /// Filepaths entries count
    /// </summary>
    public uint Count;
    /// <summary>
    /// Filepaths entries
    /// </summary>
    public unsafe sbyte** Paths;

    public unsafe FilePathList(uint Capacity, uint Count, sbyte** Paths)
    {
        this.Capacity = Capacity;
        this.Count = Count;
        this.Paths = Paths;
    }
}