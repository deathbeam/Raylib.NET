using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

public static unsafe partial class Rlgl
{
    public const string LIBRARY = "raylib";

    public const string RLGL_VERSION = "5.0";

    public const int RL_DEFAULT_BATCH_BUFFER_ELEMENTS = 8192;

    public const int RL_DEFAULT_BATCH_BUFFERS = 1;

    public const int RL_DEFAULT_BATCH_DRAWCALLS = 256;

    public const int RL_DEFAULT_BATCH_MAX_TEXTURE_UNITS = 4;

    public const int RL_MAX_MATRIX_STACK_SIZE = 32;

    public const int RL_MAX_SHADER_LOCATIONS = 32;

    public const float RL_CULL_DISTANCE_NEAR = 0.01f;

    public const float RL_CULL_DISTANCE_FAR = 1000.0f;

    public const int RL_TEXTURE_WRAP_S = 10242;

    public const int RL_TEXTURE_WRAP_T = 10243;

    public const int RL_TEXTURE_MAG_FILTER = 10240;

    public const int RL_TEXTURE_MIN_FILTER = 10241;

    public const int RL_TEXTURE_FILTER_NEAREST = 9728;

    public const int RL_TEXTURE_FILTER_LINEAR = 9729;

    public const int RL_TEXTURE_FILTER_MIP_NEAREST = 9984;

    public const int RL_TEXTURE_FILTER_NEAREST_MIP_LINEAR = 9986;

    public const int RL_TEXTURE_FILTER_LINEAR_MIP_NEAREST = 9985;

    public const int RL_TEXTURE_FILTER_MIP_LINEAR = 9987;

    public const int RL_TEXTURE_FILTER_ANISOTROPIC = 12288;

    public const int RL_TEXTURE_MIPMAP_BIAS_RATIO = 16384;

    public const int RL_TEXTURE_WRAP_REPEAT = 10497;

    public const int RL_TEXTURE_WRAP_CLAMP = 33071;

    public const int RL_TEXTURE_WRAP_MIRROR_REPEAT = 33648;

    public const int RL_TEXTURE_WRAP_MIRROR_CLAMP = 34626;

    public const int RL_MODELVIEW = 5888;

    public const int RL_PROJECTION = 5889;

    public const int RL_TEXTURE = 5890;

    public const int RL_LINES = 1;

    public const int RL_TRIANGLES = 4;

    public const int RL_QUADS = 7;

    public const int RL_UNSIGNED_BYTE = 5121;

    public const int RL_FLOAT = 5126;

    public const int RL_STREAM_DRAW = 35040;

    public const int RL_STREAM_READ = 35041;

    public const int RL_STREAM_COPY = 35042;

    public const int RL_STATIC_DRAW = 35044;

    public const int RL_STATIC_READ = 35045;

    public const int RL_STATIC_COPY = 35046;

    public const int RL_DYNAMIC_DRAW = 35048;

    public const int RL_DYNAMIC_READ = 35049;

    public const int RL_DYNAMIC_COPY = 35050;

    public const int RL_FRAGMENT_SHADER = 35632;

    public const int RL_VERTEX_SHADER = 35633;

    public const int RL_COMPUTE_SHADER = 37305;

    public const int RL_ZERO = 0;

    public const int RL_ONE = 1;

    public const int RL_SRC_COLOR = 768;

    public const int RL_ONE_MINUS_SRC_COLOR = 769;

    public const int RL_SRC_ALPHA = 770;

    public const int RL_ONE_MINUS_SRC_ALPHA = 771;

    public const int RL_DST_ALPHA = 772;

    public const int RL_ONE_MINUS_DST_ALPHA = 773;

    public const int RL_DST_COLOR = 774;

    public const int RL_ONE_MINUS_DST_COLOR = 775;

    public const int RL_SRC_ALPHA_SATURATE = 776;

    public const int RL_CONSTANT_COLOR = 32769;

    public const int RL_ONE_MINUS_CONSTANT_COLOR = 32770;

    public const int RL_CONSTANT_ALPHA = 32771;

    public const int RL_ONE_MINUS_CONSTANT_ALPHA = 32772;

    public const int RL_FUNC_ADD = 32774;

    public const int RL_MIN = 32775;

    public const int RL_MAX = 32776;

    public const int RL_FUNC_SUBTRACT = 32778;

    public const int RL_FUNC_REVERSE_SUBTRACT = 32779;

    public const int RL_BLEND_EQUATION = 32777;

    public const int RL_BLEND_EQUATION_RGB = 32777;

    public const int RL_BLEND_EQUATION_ALPHA = 34877;

    public const int RL_BLEND_DST_RGB = 32968;

    public const int RL_BLEND_SRC_RGB = 32969;

    public const int RL_BLEND_DST_ALPHA = 32970;

    public const int RL_BLEND_SRC_ALPHA = 32971;

    public const int RL_BLEND_COLOR = 32773;

    public const int RL_READ_FRAMEBUFFER = 36008;

    public const int RL_DRAW_FRAMEBUFFER = 36009;

    public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_POSITION = 0;

    public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_TEXCOORD = 1;

    public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_NORMAL = 2;

    public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_COLOR = 3;

    public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_TANGENT = 4;

    public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_TEXCOORD2 = 5;

    public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_INDICES = 6;

    /// <summary>
    /// Choose the current matrix to be transformed
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlMatrixMode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void MatrixMode(int mode);

    /// <summary>
    /// Push the current matrix to stack
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlPushMatrix", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PushMatrix();

    /// <summary>
    /// Pop latest inserted matrix from stack
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlPopMatrix", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PopMatrix();

    /// <summary>
    /// Reset current matrix to identity matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadIdentity", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void LoadIdentity();

    /// <summary>
    /// Multiply the current matrix by a translation matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlTranslatef", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Translatef(float x, float y, float z);

    /// <summary>
    /// Multiply the current matrix by a rotation matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlRotatef", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Rotatef(float angle, float x, float y, float z);

    /// <summary>
    /// Multiply the current matrix by a scaling matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlScalef", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Scalef(float x, float y, float z);

    /// <summary>
    /// Multiply the current matrix by another matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlMultMatrixf", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void MultMatrixf(float* matf);

    [LibraryImport(LIBRARY, EntryPoint = "rlFrustum", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Frustum(double left, double right, double bottom, double top, double znear, double zfar);

    [LibraryImport(LIBRARY, EntryPoint = "rlOrtho", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Ortho(double left, double right, double bottom, double top, double znear, double zfar);

    /// <summary>
    /// Set the viewport area
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlViewport", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Viewport(int x, int y, int width, int height);

    /// <summary>
    /// Set clip planes distances
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetClipPlanes", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetClipPlanes(double nearPlane, double farPlane);

    /// <summary>
    /// Get cull plane distance near
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetCullDistanceNear", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial double GetCullDistanceNear();

    /// <summary>
    /// Get cull plane distance far
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetCullDistanceFar", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial double GetCullDistanceFar();

    /// <summary>
    /// Initialize drawing mode (how to organize vertex)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlBegin", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Begin(int mode);

    /// <summary>
    /// Finish vertex providing
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnd", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void End();

    /// <summary>
    /// Define one vertex (position) - 2 int
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlVertex2i", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Vertex2i(int x, int y);

    /// <summary>
    /// Define one vertex (position) - 2 float
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlVertex2f", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Vertex2f(float x, float y);

    /// <summary>
    /// Define one vertex (position) - 3 float
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlVertex3f", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Vertex3f(float x, float y, float z);

    /// <summary>
    /// Define one vertex (texture coordinate) - 2 float
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlTexCoord2f", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TexCoord2f(float x, float y);

    /// <summary>
    /// Define one vertex (normal) - 3 float
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlNormal3f", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Normal3f(float x, float y, float z);

    /// <summary>
    /// Define one vertex (color) - 4 byte
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlColor4ub", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Color4ub(byte r, byte g, byte b, byte a);

    /// <summary>
    /// Define one vertex (color) - 3 float
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlColor3f", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Color3f(float x, float y, float z);

    /// <summary>
    /// Define one vertex (color) - 4 float
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlColor4f", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Color4f(float x, float y, float z, float w);

    /// <summary>
    /// Enable vertex array (VAO, if supported)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableVertexArray", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool EnableVertexArray(uint vaoId);

    /// <summary>
    /// Disable vertex array (VAO, if supported)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableVertexArray", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableVertexArray();

    /// <summary>
    /// Enable vertex buffer (VBO)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableVertexBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableVertexBuffer(uint id);

    /// <summary>
    /// Disable vertex buffer (VBO)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableVertexBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableVertexBuffer();

    /// <summary>
    /// Enable vertex buffer element (VBO element)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableVertexBufferElement", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableVertexBufferElement(uint id);

    /// <summary>
    /// Disable vertex buffer element (VBO element)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableVertexBufferElement", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableVertexBufferElement();

    /// <summary>
    /// Enable vertex attribute index
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableVertexAttribute", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableVertexAttribute(uint index);

    /// <summary>
    /// Disable vertex attribute index
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableVertexAttribute", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableVertexAttribute(uint index);

    /// <summary>
    /// Select and active a texture slot
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlActiveTextureSlot", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ActiveTextureSlot(int slot);

    /// <summary>
    /// Enable texture
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableTexture", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableTexture(uint id);

    /// <summary>
    /// Disable texture
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableTexture", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableTexture();

    /// <summary>
    /// Enable texture cubemap
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableTextureCubemap", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableTextureCubemap(uint id);

    /// <summary>
    /// Disable texture cubemap
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableTextureCubemap", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableTextureCubemap();

    /// <summary>
    /// Set texture parameters (filter, wrap)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlTextureParameters", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TextureParameters(uint id, int @param, int value);

    /// <summary>
    /// Set cubemap parameters (filter, wrap)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlCubemapParameters", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CubemapParameters(uint id, int @param, int value);

    /// <summary>
    /// Enable shader program
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableShader", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableShader(uint id);

    /// <summary>
    /// Disable shader program
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableShader", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableShader();

    /// <summary>
    /// Enable render texture (fbo)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableFramebuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableFramebuffer(uint id);

    /// <summary>
    /// Disable render texture (fbo), return to default framebuffer
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableFramebuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableFramebuffer();

    /// <summary>
    /// Get the currently active render texture (fbo), 0 for default framebuffer
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetActiveFramebuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint GetActiveFramebuffer();

    /// <summary>
    /// Activate multiple draw color buffers
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlActiveDrawBuffers", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ActiveDrawBuffers(int count);

    /// <summary>
    /// Blit active framebuffer to main framebuffer
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlBlitFramebuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BlitFramebuffer(int srcX, int srcY, int srcWidth, int srcHeight, int dstX, int dstY, int dstWidth, int dstHeight, int bufferMask);

    /// <summary>
    /// Bind framebuffer (FBO)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlBindFramebuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BindFramebuffer(uint target, uint framebuffer);

    /// <summary>
    /// Enable color blending
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableColorBlend", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableColorBlend();

    /// <summary>
    /// Disable color blending
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableColorBlend", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableColorBlend();

    /// <summary>
    /// Enable depth test
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableDepthTest", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableDepthTest();

    /// <summary>
    /// Disable depth test
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableDepthTest", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableDepthTest();

    /// <summary>
    /// Enable depth write
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableDepthMask", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableDepthMask();

    /// <summary>
    /// Disable depth write
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableDepthMask", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableDepthMask();

    /// <summary>
    /// Enable backface culling
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableBackfaceCulling", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableBackfaceCulling();

    /// <summary>
    /// Disable backface culling
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableBackfaceCulling", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableBackfaceCulling();

    /// <summary>
    /// Color mask control
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlColorMask", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ColorMask(NativeBool r, NativeBool g, NativeBool b, NativeBool a);

    /// <summary>
    /// Set face culling mode
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetCullFace", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetCullFace(int mode);

    /// <summary>
    /// Enable scissor test
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableScissorTest", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableScissorTest();

    /// <summary>
    /// Disable scissor test
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableScissorTest", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableScissorTest();

    /// <summary>
    /// Scissor test
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlScissor", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Scissor(int x, int y, int width, int height);

    /// <summary>
    /// Enable wire mode
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableWireMode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableWireMode();

    /// <summary>
    /// Enable point mode
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnablePointMode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnablePointMode();

    /// <summary>
    /// Disable wire (and point) mode
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableWireMode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableWireMode();

    /// <summary>
    /// Set the line drawing width
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetLineWidth", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetLineWidth(float width);

    /// <summary>
    /// Get the line drawing width
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetLineWidth", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetLineWidth();

    /// <summary>
    /// Enable line aliasing
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableSmoothLines", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableSmoothLines();

    /// <summary>
    /// Disable line aliasing
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableSmoothLines", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableSmoothLines();

    /// <summary>
    /// Enable stereo rendering
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlEnableStereoRender", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableStereoRender();

    /// <summary>
    /// Disable stereo rendering
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDisableStereoRender", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableStereoRender();

    /// <summary>
    /// Check if stereo render is enabled
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlIsStereoRenderEnabled", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsStereoRenderEnabled();

    /// <summary>
    /// Clear color buffer with color
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlClearColor", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearColor(byte r, byte g, byte b, byte a);

    /// <summary>
    /// Clear used screen buffers (color and depth)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlClearScreenBuffers", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearScreenBuffers();

    /// <summary>
    /// Check and log OpenGL error codes
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlCheckErrors", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CheckErrors();

    /// <summary>
    /// Set blending mode
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetBlendMode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetBlendMode(int mode);

    /// <summary>
    /// Set blending mode factor and equation (using OpenGL factors)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetBlendFactors", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetBlendFactors(int glSrcFactor, int glDstFactor, int glEquation);

    /// <summary>
    /// Set blending mode factors and equations separately (using OpenGL factors)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetBlendFactorsSeparate", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetBlendFactorsSeparate(int glSrcRGB, int glDstRGB, int glSrcAlpha, int glDstAlpha, int glEqRGB, int glEqAlpha);

    /// <summary>
    /// Initialize rlgl (buffers, shaders, textures, states)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlglInit", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void glInit(int width, int height);

    /// <summary>
    /// De-initialize rlgl (buffers, shaders, textures)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlglClose", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void glClose();

    /// <summary>
    /// Load OpenGL extensions (loader function required)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadExtensions", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void LoadExtensions(void* loader);

    /// <summary>
    /// Get current OpenGL version
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetVersion", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetVersion();

    /// <summary>
    /// Set current framebuffer width
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetFramebufferWidth", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetFramebufferWidth(int width);

    /// <summary>
    /// Get default framebuffer width
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetFramebufferWidth", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFramebufferWidth();

    /// <summary>
    /// Set current framebuffer height
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetFramebufferHeight", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetFramebufferHeight(int height);

    /// <summary>
    /// Get default framebuffer height
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetFramebufferHeight", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFramebufferHeight();

    /// <summary>
    /// Get default texture id
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetTextureIdDefault", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint GetTextureIdDefault();

    /// <summary>
    /// Get default shader id
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetShaderIdDefault", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint GetShaderIdDefault();

    /// <summary>
    /// Get default shader locations
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetShaderLocsDefault", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int* GetShaderLocsDefault();

    /// <summary>
    /// Load a render batch system
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadRenderBatch", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RenderBatch LoadRenderBatch(int numBuffers, int bufferElements);

    /// <summary>
    /// Unload render batch system
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUnloadRenderBatch", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadRenderBatch(RenderBatch batch);

    /// <summary>
    /// Draw render batch data (Update->Draw->Reset)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDrawRenderBatch", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawRenderBatch(RenderBatch* batch);

    /// <summary>
    /// Set the active render batch for rlgl (NULL for default internal)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetRenderBatchActive", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetRenderBatchActive(RenderBatch* batch);

    /// <summary>
    /// Update and draw internal render batch
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDrawRenderBatchActive", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRenderBatchActive();

    /// <summary>
    /// Check internal buffer overflow for a given number of vertex
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlCheckRenderBatchLimit", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckRenderBatchLimit(int vCount);

    /// <summary>
    /// Set current texture for render batch and check buffers limits
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetTexture", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTexture(uint id);

    /// <summary>
    /// Load vertex array (vao) if supported
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadVertexArray", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadVertexArray();

    /// <summary>
    /// Load a vertex buffer object
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadVertexBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint LoadVertexBuffer(void* buffer, int size, NativeBool dynamic);

    /// <summary>
    /// Load vertex buffer elements object
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadVertexBufferElement", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint LoadVertexBufferElement(void* buffer, int size, NativeBool dynamic);

    /// <summary>
    /// Update vertex buffer object data on GPU buffer
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUpdateVertexBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateVertexBuffer(uint bufferId, void* data, int dataSize, int offset);

    /// <summary>
    /// Update vertex buffer elements data on GPU buffer
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUpdateVertexBufferElements", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateVertexBufferElements(uint id, void* data, int dataSize, int offset);

    /// <summary>
    /// Unload vertex array (vao)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUnloadVertexArray", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadVertexArray(uint vaoId);

    /// <summary>
    /// Unload vertex buffer object
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUnloadVertexBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadVertexBuffer(uint vboId);

    /// <summary>
    /// Set vertex attribute data configuration
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetVertexAttribute", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetVertexAttribute(uint index, int compSize, int @type, NativeBool normalized, int stride, int offset);

    /// <summary>
    /// Set vertex attribute data divisor
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetVertexAttributeDivisor", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetVertexAttributeDivisor(uint index, int divisor);

    /// <summary>
    /// Set vertex attribute default value, when attribute to provided
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetVertexAttributeDefault", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetVertexAttributeDefault(int locIndex, void* value, int attribType, int count);

    /// <summary>
    /// Draw vertex array (currently active vao)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDrawVertexArray", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawVertexArray(int offset, int count);

    /// <summary>
    /// Draw vertex array elements
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDrawVertexArrayElements", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawVertexArrayElements(int offset, int count, void* buffer);

    /// <summary>
    /// Draw vertex array (currently active vao) with instancing
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDrawVertexArrayInstanced", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawVertexArrayInstanced(int offset, int count, int instances);

    /// <summary>
    /// Draw vertex array elements with instancing
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlDrawVertexArrayElementsInstanced", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawVertexArrayElementsInstanced(int offset, int count, void* buffer, int instances);

    /// <summary>
    /// Load texture data
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadTexture", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint LoadTexture(void* data, int width, int height, int format, int mipmapCount);

    /// <summary>
    /// Load depth texture/renderbuffer (to be attached to fbo)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadTextureDepth", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadTextureDepth(int width, int height, NativeBool useRenderBuffer);

    /// <summary>
    /// Load texture cubemap data
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadTextureCubemap", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint LoadTextureCubemap(void* data, int size, int format);

    /// <summary>
    /// Update texture with new data on GPU
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUpdateTexture", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateTexture(uint id, int offsetX, int offsetY, int width, int height, int format, void* data);

    /// <summary>
    /// Get OpenGL internal formats
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetGlTextureFormats", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GetGlTextureFormats(int format, uint* glInternalFormat, uint* glFormat, uint* glType);

    /// <summary>
    /// Get name string for pixel format
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetPixelFormatName", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetPixelFormatName(uint format);

    /// <summary>
    /// Unload texture from GPU memory
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUnloadTexture", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadTexture(uint id);

    /// <summary>
    /// Generate mipmap data for selected texture
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGenTextureMipmaps", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GenTextureMipmaps(uint id, int width, int height, int format, int* mipmaps);

    /// <summary>
    /// Read texture pixel data
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlReadTexturePixels", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void* ReadTexturePixels(uint id, int width, int height, int format);

    /// <summary>
    /// Read screen pixel data (color buffer)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlReadScreenPixels", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* ReadScreenPixels(int width, int height);

    /// <summary>
    /// Load an empty framebuffer
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadFramebuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadFramebuffer();

    /// <summary>
    /// Attach texture/renderbuffer to a framebuffer
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlFramebufferAttach", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void FramebufferAttach(uint fboId, uint texId, int attachType, int texType, int mipLevel);

    /// <summary>
    /// Verify framebuffer is complete
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlFramebufferComplete", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool FramebufferComplete(uint id);

    /// <summary>
    /// Delete framebuffer from GPU
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUnloadFramebuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadFramebuffer(uint id);

    /// <summary>
    /// Load shader from code strings
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadShaderCode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadShaderCode(string vsCode, string fsCode);

    /// <summary>
    /// Compile custom shader and return shader id (type: RL_VERTEX_SHADER, RL_FRAGMENT_SHADER, RL_COMPUTE_SHADER)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlCompileShader", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint CompileShader(string shaderCode, int @type);

    /// <summary>
    /// Load custom shader program
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadShaderProgram", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadShaderProgram(uint vShaderId, uint fShaderId);

    /// <summary>
    /// Unload shader program
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUnloadShaderProgram", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadShaderProgram(uint id);

    /// <summary>
    /// Get shader location uniform
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetLocationUniform", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetLocationUniform(uint shaderId, string uniformName);

    /// <summary>
    /// Get shader location attribute
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetLocationAttrib", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetLocationAttrib(uint shaderId, string attribName);

    /// <summary>
    /// Set shader value uniform
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetUniform", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetUniform(int locIndex, void* value, int uniformType, int count);

    /// <summary>
    /// Set shader value matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetUniformMatrix", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetUniformMatrix(int locIndex, Matrix4x4 mat);

    /// <summary>
    /// Set shader value matrices
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetUniformMatrices", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetUniformMatrices(int locIndex, Matrix4x4* mat, int count);

    /// <summary>
    /// Set shader value sampler
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetUniformSampler", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetUniformSampler(int locIndex, uint textureId);

    /// <summary>
    /// Set shader currently active (id and locations)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetShader", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetShader(uint id, int* locs);

    /// <summary>
    /// Load compute shader program
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadComputeShaderProgram", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadComputeShaderProgram(uint shaderId);

    /// <summary>
    /// Dispatch compute shader (equivalent to *draw* for graphics pipeline)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlComputeShaderDispatch", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ComputeShaderDispatch(uint groupX, uint groupY, uint groupZ);

    /// <summary>
    /// Load shader storage buffer object (SSBO)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadShaderBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint LoadShaderBuffer(uint size, void* data, int usageHint);

    /// <summary>
    /// Unload shader storage buffer object (SSBO)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUnloadShaderBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadShaderBuffer(uint ssboId);

    /// <summary>
    /// Update SSBO buffer data
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlUpdateShaderBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateShaderBuffer(uint id, void* data, uint dataSize, uint offset);

    /// <summary>
    /// Bind SSBO buffer
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlBindShaderBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BindShaderBuffer(uint id, uint index);

    /// <summary>
    /// Read SSBO buffer data (GPU->CPU)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlReadShaderBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ReadShaderBuffer(uint id, void* dest, uint count, uint offset);

    /// <summary>
    /// Copy SSBO data between buffers
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlCopyShaderBuffer", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CopyShaderBuffer(uint destId, uint srcId, uint destOffset, uint srcOffset, uint count);

    /// <summary>
    /// Get SSBO buffer size
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetShaderBufferSize", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint GetShaderBufferSize(uint id);

    /// <summary>
    /// Bind image texture
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlBindImageTexture", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BindImageTexture(uint id, uint index, int format, NativeBool @readonly);

    /// <summary>
    /// Get internal modelview matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetMatrixModelview", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixModelview();

    /// <summary>
    /// Get internal projection matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetMatrixProjection", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixProjection();

    /// <summary>
    /// Get internal accumulated transform matrix
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetMatrixTransform", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixTransform();

    /// <summary>
    /// Get internal projection matrix for stereo render (selected eye)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetMatrixProjectionStereo", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixProjectionStereo(int eye);

    /// <summary>
    /// Get internal view offset matrix for stereo render (selected eye)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlGetMatrixViewOffsetStereo", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixViewOffsetStereo(int eye);

    /// <summary>
    /// Set a custom projection matrix (replaces internal projection matrix)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetMatrixProjection", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMatrixProjection(Matrix4x4 proj);

    /// <summary>
    /// Set a custom modelview matrix (replaces internal modelview matrix)
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetMatrixModelview", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMatrixModelview(Matrix4x4 view);

    /// <summary>
    /// Set eyes projection matrices for stereo rendering
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetMatrixProjectionStereo", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMatrixProjectionStereo(Matrix4x4 right, Matrix4x4 left);

    /// <summary>
    /// Set eyes view offsets matrices for stereo rendering
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlSetMatrixViewOffsetStereo", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMatrixViewOffsetStereo(Matrix4x4 right, Matrix4x4 left);

    /// <summary>
    /// Load and draw a cube
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadDrawCube", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void LoadDrawCube();

    /// <summary>
    /// Load and draw a quad
    /// </summary>
    [LibraryImport(LIBRARY, EntryPoint = "rlLoadDrawQuad", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void LoadDrawQuad();
}
