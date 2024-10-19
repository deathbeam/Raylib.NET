using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

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

    public unsafe Mesh(int VertexCount, int TriangleCount, float* Vertices, float* Texcoords, float* Texcoords2, float* Normals, float* Tangents, byte* Colors, ushort* Indices, float* AnimVertices, float* AnimNormals, byte* BoneIds, float* BoneWeights, Matrix4x4* BoneMatrices, int BoneCount, uint VaoId, uint* VboId)
    {
        this.VertexCount = VertexCount;
        this.TriangleCount = TriangleCount;
        this.Vertices = Vertices;
        this.Texcoords = Texcoords;
        this.Texcoords2 = Texcoords2;
        this.Normals = Normals;
        this.Tangents = Tangents;
        this.Colors = Colors;
        this.Indices = Indices;
        this.AnimVertices = AnimVertices;
        this.AnimNormals = AnimNormals;
        this.BoneIds = BoneIds;
        this.BoneWeights = BoneWeights;
        this.BoneMatrices = BoneMatrices;
        this.BoneCount = BoneCount;
        this.VaoId = VaoId;
        this.VboId = VboId;
    }
}