using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct BoneInfo
{
    /// <summary>
    /// Bone name
    /// </summary>
    public unsafe fixed sbyte Name[32];
    /// <summary>
    /// Bone parent
    /// </summary>
    public int Parent;
}