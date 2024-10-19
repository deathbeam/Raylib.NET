namespace RaylibNET;

public enum BlendMode
{
    /// <summary>
    /// Blend textures considering alpha (default)
    /// </summary>
    BLEND_ALPHA = 0,
    /// <summary>
    /// Blend textures adding colors
    /// </summary>
    BLEND_ADDITIVE,
    /// <summary>
    /// Blend textures multiplying colors
    /// </summary>
    BLEND_MULTIPLIED,
    /// <summary>
    /// Blend textures adding colors (alternative)
    /// </summary>
    BLEND_ADD_COLORS,
    /// <summary>
    /// Blend textures subtracting colors (alternative)
    /// </summary>
    BLEND_SUBTRACT_COLORS,
    /// <summary>
    /// Blend premultiplied textures considering alpha
    /// </summary>
    BLEND_ALPHA_PREMULTIPLY,
    /// <summary>
    /// Blend textures using custom src/dst factors (use rlSetBlendFactors())
    /// </summary>
    BLEND_CUSTOM,
    /// <summary>
    /// Blend textures using custom rgb/alpha separate src/dst factors (use rlSetBlendFactorsSeparate())
    /// </summary>
    BLEND_CUSTOM_SEPARATE,
}