namespace Raylib.NET;

public enum GlVersion
{
    /// <summary>
    /// OpenGL 1.1
    /// </summary>
    RL_OPENGL_11 = 1,
    /// <summary>
    /// OpenGL 2.1 (GLSL 120)
    /// </summary>
    RL_OPENGL_21,
    /// <summary>
    /// OpenGL 3.3 (GLSL 330)
    /// </summary>
    RL_OPENGL_33,
    /// <summary>
    /// OpenGL 4.3 (using GLSL 330)
    /// </summary>
    RL_OPENGL_43,
    /// <summary>
    /// OpenGL ES 2.0 (GLSL 100)
    /// </summary>
    RL_OPENGL_ES_20,
    /// <summary>
    /// OpenGL ES 3.0 (GLSL 300 es)
    /// </summary>
    RL_OPENGL_ES_30,
}