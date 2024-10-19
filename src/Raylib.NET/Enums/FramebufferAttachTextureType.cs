namespace Raylib.NET;

public enum FramebufferAttachTextureType
{
    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +X side
    /// </summary>
    RL_ATTACHMENT_CUBEMAP_POSITIVE_X = 0,
    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -X side
    /// </summary>
    RL_ATTACHMENT_CUBEMAP_NEGATIVE_X = 1,
    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +Y side
    /// </summary>
    RL_ATTACHMENT_CUBEMAP_POSITIVE_Y = 2,
    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -Y side
    /// </summary>
    RL_ATTACHMENT_CUBEMAP_NEGATIVE_Y = 3,
    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +Z side
    /// </summary>
    RL_ATTACHMENT_CUBEMAP_POSITIVE_Z = 4,
    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -Z side
    /// </summary>
    RL_ATTACHMENT_CUBEMAP_NEGATIVE_Z = 5,
    /// <summary>
    /// Framebuffer texture attachment type: texture2d
    /// </summary>
    RL_ATTACHMENT_TEXTURE2D = 100,
    /// <summary>
    /// Framebuffer texture attachment type: renderbuffer
    /// </summary>
    RL_ATTACHMENT_RENDERBUFFER = 200,
}