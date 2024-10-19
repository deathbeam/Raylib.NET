namespace RaylibNET;

public enum ShaderUniformDataType
{
    /// <summary>
    /// Shader uniform type: float
    /// </summary>
    SHADER_UNIFORM_FLOAT = 0,
    /// <summary>
    /// Shader uniform type: vec2 (2 float)
    /// </summary>
    SHADER_UNIFORM_VEC2,
    /// <summary>
    /// Shader uniform type: vec3 (3 float)
    /// </summary>
    SHADER_UNIFORM_VEC3,
    /// <summary>
    /// Shader uniform type: vec4 (4 float)
    /// </summary>
    SHADER_UNIFORM_VEC4,
    /// <summary>
    /// Shader uniform type: int
    /// </summary>
    SHADER_UNIFORM_INT,
    /// <summary>
    /// Shader uniform type: ivec2 (2 int)
    /// </summary>
    SHADER_UNIFORM_IVEC2,
    /// <summary>
    /// Shader uniform type: ivec3 (3 int)
    /// </summary>
    SHADER_UNIFORM_IVEC3,
    /// <summary>
    /// Shader uniform type: ivec4 (4 int)
    /// </summary>
    SHADER_UNIFORM_IVEC4,
    /// <summary>
    /// Shader uniform type: sampler2d
    /// </summary>
    SHADER_UNIFORM_SAMPLER2D,
}