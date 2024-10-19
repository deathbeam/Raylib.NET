using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct ModelAnimation
{
    /// <summary>
    /// Number of bones
    /// </summary>
    public int BoneCount;
    /// <summary>
    /// Number of animation frames
    /// </summary>
    public int FrameCount;
    /// <summary>
    /// Bones information (skeleton)
    /// </summary>
    public unsafe BoneInfo* Bones;
    /// <summary>
    /// Poses array by frame
    /// </summary>
    public unsafe Transform** FramePoses;
    /// <summary>
    /// Animation name
    /// </summary>
    public unsafe fixed sbyte Name[32];
}