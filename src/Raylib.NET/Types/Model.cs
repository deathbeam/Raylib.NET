using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Model
{
    /// <summary>
    /// Local transform matrix
    /// </summary>
    public Matrix4x4 Transform;
    /// <summary>
    /// Number of meshes
    /// </summary>
    public int MeshCount;
    /// <summary>
    /// Number of materials
    /// </summary>
    public int MaterialCount;
    /// <summary>
    /// Meshes array
    /// </summary>
    public unsafe Mesh* Meshes;
    /// <summary>
    /// Materials array
    /// </summary>
    public unsafe Material* Materials;
    /// <summary>
    /// Mesh material number
    /// </summary>
    public unsafe int* MeshMaterial;
    /// <summary>
    /// Number of bones
    /// </summary>
    public int BoneCount;
    /// <summary>
    /// Bones information (skeleton)
    /// </summary>
    public unsafe BoneInfo* Bones;
    /// <summary>
    /// Bones base transformation (pose)
    /// </summary>
    public unsafe Transform* BindPose;

    public unsafe Model(Matrix4x4 Transform, int MeshCount, int MaterialCount, Mesh* Meshes, Material* Materials, int* MeshMaterial, int BoneCount, BoneInfo* Bones, Transform* BindPose)
    {
        this.Transform = Transform;
        this.MeshCount = MeshCount;
        this.MaterialCount = MaterialCount;
        this.Meshes = Meshes;
        this.Materials = Materials;
        this.MeshMaterial = MeshMaterial;
        this.BoneCount = BoneCount;
        this.Bones = Bones;
        this.BindPose = BindPose;
    }
}