using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

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

    public unsafe Model(Matrix4x4 transform, int meshCount, int materialCount, Mesh* meshes, Material* materials, int* meshMaterial, int boneCount, BoneInfo* bones, Transform* bindPose)
    {
        this.Transform = transform;
        this.MeshCount = meshCount;
        this.MaterialCount = materialCount;
        this.Meshes = meshes;
        this.Materials = materials;
        this.MeshMaterial = meshMaterial;
        this.BoneCount = boneCount;
        this.Bones = bones;
        this.BindPose = bindPose;
    }
}