using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Mesh
{
    /// <summary>
    /// Number of vertices stored in arrays
    /// </summary>
    public int VertexCount;
    /// <summary>
    /// Number of triangles stored (indexed or not)
    /// </summary>
    public int TriangleCount;
    /// <summary>
    /// Vertex position (XYZ - 3 components per vertex) (shader-location = 0)
    /// </summary>
    public unsafe float* Vertices;
    /// <summary>
    /// Vertex texture coordinates (UV - 2 components per vertex) (shader-location = 1)
    /// </summary>
    public unsafe float* Texcoords;
    /// <summary>
    /// Vertex texture second coordinates (UV - 2 components per vertex) (shader-location = 5)
    /// </summary>
    public unsafe float* Texcoords2;
    /// <summary>
    /// Vertex normals (XYZ - 3 components per vertex) (shader-location = 2)
    /// </summary>
    public unsafe float* Normals;
    /// <summary>
    /// Vertex tangents (XYZW - 4 components per vertex) (shader-location = 4)
    /// </summary>
    public unsafe float* Tangents;
    /// <summary>
    /// Vertex colors (RGBA - 4 components per vertex) (shader-location = 3)
    /// </summary>
    public unsafe byte* Colors;
    /// <summary>
    /// Vertex indices (in case vertex data comes indexed)
    /// </summary>
    public unsafe ushort* Indices;
    /// <summary>
    /// Animated vertex positions (after bones transformations)
    /// </summary>
    public unsafe float* AnimVertices;
    /// <summary>
    /// Animated normals (after bones transformations)
    /// </summary>
    public unsafe float* AnimNormals;
    /// <summary>
    /// Vertex bone ids, max 255 bone ids, up to 4 bones influence by vertex (skinning) (shader-location = 6)
    /// </summary>
    public unsafe byte* BoneIds;
    /// <summary>
    /// Vertex bone weight, up to 4 bones influence by vertex (skinning) (shader-location = 7)
    /// </summary>
    public unsafe float* BoneWeights;
    /// <summary>
    /// Bones animated transformation matrices
    /// </summary>
    public unsafe Matrix4x4* BoneMatrices;
    /// <summary>
    /// Number of bones
    /// </summary>
    public int BoneCount;
    /// <summary>
    /// OpenGL Vertex Array Object id
    /// </summary>
    public uint VaoId;
    /// <summary>
    /// OpenGL Vertex Buffer Objects id (default vertex data)
    /// </summary>
    public unsafe uint* VboId;

    public unsafe Mesh(int vertexCount, int triangleCount, float* vertices, float* texcoords, float* texcoords2, float* normals, float* tangents, byte* colors, ushort* indices, float* animVertices, float* animNormals, byte* boneIds, float* boneWeights, Matrix4x4* boneMatrices, int boneCount, uint vaoId, uint* vboId)
    {
        this.VertexCount = vertexCount;
        this.TriangleCount = triangleCount;
        this.Vertices = vertices;
        this.Texcoords = texcoords;
        this.Texcoords2 = texcoords2;
        this.Normals = normals;
        this.Tangents = tangents;
        this.Colors = colors;
        this.Indices = indices;
        this.AnimVertices = animVertices;
        this.AnimNormals = animNormals;
        this.BoneIds = boneIds;
        this.BoneWeights = boneWeights;
        this.BoneMatrices = boneMatrices;
        this.BoneCount = boneCount;
        this.VaoId = vaoId;
        this.VboId = vboId;
    }
}