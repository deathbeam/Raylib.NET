using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct BoneInfo
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