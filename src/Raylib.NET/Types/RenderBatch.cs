using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct RenderBatch
{
    /// <summary>
    /// Number of vertex buffers (multi-buffering support)
    /// </summary>
    public int BufferCount;
    /// <summary>
    /// Current buffer tracking in case of multi-buffering
    /// </summary>
    public int CurrentBuffer;
    /// <summary>
    /// Dynamic buffer(s) for vertex data
    /// </summary>
    public unsafe VertexBuffer* VertexBuffer;
    /// <summary>
    /// Draw calls array, depends on textureId
    /// </summary>
    public unsafe DrawCall* Draws;
    /// <summary>
    /// Draw calls counter
    /// </summary>
    public int DrawCounter;
    /// <summary>
    /// Current depth value for next draw
    /// </summary>
    public float CurrentDepth;

    public unsafe RenderBatch(int bufferCount, int currentBuffer, VertexBuffer* vertexBuffer, DrawCall* draws, int drawCounter, float currentDepth)
    {
        this.BufferCount = bufferCount;
        this.CurrentBuffer = currentBuffer;
        this.VertexBuffer = vertexBuffer;
        this.Draws = draws;
        this.DrawCounter = drawCounter;
        this.CurrentDepth = currentDepth;
    }
}