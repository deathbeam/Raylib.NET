using System.Numerics;
namespace RaylibNET;

/// <summary>
/// Extension methods for converting between Raylib Color and Vector4 color formats.
/// </summary>
public static class ColorExtensions
{
    /// <summary>
    /// Convert a Raylib Color to Vector4 format (normalized 0.0-1.0 floats).
    /// </summary>
    /// <param name="color">The Raylib color to convert</param>
    /// <returns>A Vector4 with RGBA components normalized to 0.0-1.0 range</returns>
    public static Vector4 ToVector(this Color color)
    {
        return new Vector4(
            color.R / 255f,
            color.G / 255f,
            color.B / 255f,
            color.A / 255f
        );
    }

    /// <summary>
    /// Convert an Vector4 color to Raylib Color format (0-255 byte values).
    /// </summary>
    /// <param name="color">The ImGui color to convert</param>
    /// <returns>A Raylib Color with RGBA components in 0-255 range</returns>
    public static Color ToColor(this Vector4 color)
    {
        return new Color(
            (byte)(color.X * 255f),
            (byte)(color.Y * 255f),
            (byte)(color.Z * 255f),
            (byte)(color.W * 255f)
        );
    }
}
