namespace Raylib.NET;

public enum MaterialMapIndex
{
    /// <summary>
    /// Albedo material (same as: MATERIAL_MAP_DIFFUSE)
    /// </summary>
    MATERIAL_MAP_ALBEDO = 0,
    /// <summary>
    /// Metalness material (same as: MATERIAL_MAP_SPECULAR)
    /// </summary>
    MATERIAL_MAP_METALNESS,
    /// <summary>
    /// Normal material
    /// </summary>
    MATERIAL_MAP_NORMAL,
    /// <summary>
    /// Roughness material
    /// </summary>
    MATERIAL_MAP_ROUGHNESS,
    /// <summary>
    /// Ambient occlusion material
    /// </summary>
    MATERIAL_MAP_OCCLUSION,
    /// <summary>
    /// Emission material
    /// </summary>
    MATERIAL_MAP_EMISSION,
    /// <summary>
    /// Heightmap material
    /// </summary>
    MATERIAL_MAP_HEIGHT,
    /// <summary>
    /// Cubemap material (NOTE: Uses GL_TEXTURE_CUBE_MAP)
    /// </summary>
    MATERIAL_MAP_CUBEMAP,
    /// <summary>
    /// Irradiance material (NOTE: Uses GL_TEXTURE_CUBE_MAP)
    /// </summary>
    MATERIAL_MAP_IRRADIANCE,
    /// <summary>
    /// Prefilter material (NOTE: Uses GL_TEXTURE_CUBE_MAP)
    /// </summary>
    MATERIAL_MAP_PREFILTER,
    /// <summary>
    /// Brdf material
    /// </summary>
    MATERIAL_MAP_BRDF,
}