namespace RaylibNET;

public enum TextureFilter
{
    /// <summary>
    /// No filter, just pixel approximation
    /// </summary>
    TEXTURE_FILTER_POINT = 0,
    /// <summary>
    /// Linear filtering
    /// </summary>
    TEXTURE_FILTER_BILINEAR,
    /// <summary>
    /// Trilinear filtering (linear with mipmaps)
    /// </summary>
    TEXTURE_FILTER_TRILINEAR,
    /// <summary>
    /// Anisotropic filtering 4x
    /// </summary>
    TEXTURE_FILTER_ANISOTROPIC_4X,
    /// <summary>
    /// Anisotropic filtering 8x
    /// </summary>
    TEXTURE_FILTER_ANISOTROPIC_8X,
    /// <summary>
    /// Anisotropic filtering 16x
    /// </summary>
    TEXTURE_FILTER_ANISOTROPIC_16X,
}