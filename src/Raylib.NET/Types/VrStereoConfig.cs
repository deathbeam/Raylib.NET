using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct VrStereoConfig
{
    /// <summary>
    /// VR projection matrices (per eye)
    /// </summary>
    public Matrix4x4 Projection0;
    public Matrix4x4 Projection1;
    /// <summary>
    /// VR view offset matrices (per eye)
    /// </summary>
    public Matrix4x4 ViewOffset0;
    public Matrix4x4 ViewOffset1;
    /// <summary>
    /// VR left lens center
    /// </summary>
    public unsafe fixed float LeftLensCenter[2];
    /// <summary>
    /// VR right lens center
    /// </summary>
    public unsafe fixed float RightLensCenter[2];
    /// <summary>
    /// VR left screen center
    /// </summary>
    public unsafe fixed float LeftScreenCenter[2];
    /// <summary>
    /// VR right screen center
    /// </summary>
    public unsafe fixed float RightScreenCenter[2];
    /// <summary>
    /// VR distortion scale
    /// </summary>
    public unsafe fixed float Scale[2];
    /// <summary>
    /// VR distortion scale in
    /// </summary>
    public unsafe fixed float ScaleIn[2];
}