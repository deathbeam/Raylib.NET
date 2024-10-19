using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

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

    public unsafe FilePathList(uint capacity, uint count, sbyte** paths)
    {
        this.Capacity = capacity;
        this.Count = count;
        this.Paths = paths;
    }
}