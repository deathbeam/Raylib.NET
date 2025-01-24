// This file was generated by Bindgen, do not edit it manually.
namespace RaylibNET;

public enum ShaderLocationIndex
{
    /// <summary>
    /// Shader location: vertex attribute: position
    /// </summary>
    SHADER_LOC_VERTEX_POSITION = 0,
    /// <summary>
    /// Shader location: vertex attribute: texcoord01
    /// </summary>
    SHADER_LOC_VERTEX_TEXCOORD01,
    /// <summary>
    /// Shader location: vertex attribute: texcoord02
    /// </summary>
    SHADER_LOC_VERTEX_TEXCOORD02,
    /// <summary>
    /// Shader location: vertex attribute: normal
    /// </summary>
    SHADER_LOC_VERTEX_NORMAL,
    /// <summary>
    /// Shader location: vertex attribute: tangent
    /// </summary>
    SHADER_LOC_VERTEX_TANGENT,
    /// <summary>
    /// Shader location: vertex attribute: color
    /// </summary>
    SHADER_LOC_VERTEX_COLOR,
    /// <summary>
    /// Shader location: matrix uniform: model-view-projection
    /// </summary>
    SHADER_LOC_MATRIX_MVP,
    /// <summary>
    /// Shader location: matrix uniform: view (camera transform)
    /// </summary>
    SHADER_LOC_MATRIX_VIEW,
    /// <summary>
    /// Shader location: matrix uniform: projection
    /// </summary>
    SHADER_LOC_MATRIX_PROJECTION,
    /// <summary>
    /// Shader location: matrix uniform: model (transform)
    /// </summary>
    SHADER_LOC_MATRIX_MODEL,
    /// <summary>
    /// Shader location: matrix uniform: normal
    /// </summary>
    SHADER_LOC_MATRIX_NORMAL,
    /// <summary>
    /// Shader location: vector uniform: view
    /// </summary>
    SHADER_LOC_VECTOR_VIEW,
    /// <summary>
    /// Shader location: vector uniform: diffuse color
    /// </summary>
    SHADER_LOC_COLOR_DIFFUSE,
    /// <summary>
    /// Shader location: vector uniform: specular color
    /// </summary>
    SHADER_LOC_COLOR_SPECULAR,
    /// <summary>
    /// Shader location: vector uniform: ambient color
    /// </summary>
    SHADER_LOC_COLOR_AMBIENT,
    /// <summary>
    /// Shader location: sampler2d texture: albedo (same as: SHADER_LOC_MAP_DIFFUSE)
    /// </summary>
    SHADER_LOC_MAP_ALBEDO,
    /// <summary>
    /// Shader location: sampler2d texture: metalness (same as: SHADER_LOC_MAP_SPECULAR)
    /// </summary>
    SHADER_LOC_MAP_METALNESS,
    /// <summary>
    /// Shader location: sampler2d texture: normal
    /// </summary>
    SHADER_LOC_MAP_NORMAL,
    /// <summary>
    /// Shader location: sampler2d texture: roughness
    /// </summary>
    SHADER_LOC_MAP_ROUGHNESS,
    /// <summary>
    /// Shader location: sampler2d texture: occlusion
    /// </summary>
    SHADER_LOC_MAP_OCCLUSION,
    /// <summary>
    /// Shader location: sampler2d texture: emission
    /// </summary>
    SHADER_LOC_MAP_EMISSION,
    /// <summary>
    /// Shader location: sampler2d texture: height
    /// </summary>
    SHADER_LOC_MAP_HEIGHT,
    /// <summary>
    /// Shader location: samplerCube texture: cubemap
    /// </summary>
    SHADER_LOC_MAP_CUBEMAP,
    /// <summary>
    /// Shader location: samplerCube texture: irradiance
    /// </summary>
    SHADER_LOC_MAP_IRRADIANCE,
    /// <summary>
    /// Shader location: samplerCube texture: prefilter
    /// </summary>
    SHADER_LOC_MAP_PREFILTER,
    /// <summary>
    /// Shader location: sampler2d texture: brdf
    /// </summary>
    SHADER_LOC_MAP_BRDF,
    /// <summary>
    /// Shader location: vertex attribute: boneIds
    /// </summary>
    SHADER_LOC_VERTEX_BONEIDS,
    /// <summary>
    /// Shader location: vertex attribute: boneWeights
    /// </summary>
    SHADER_LOC_VERTEX_BONEWEIGHTS,
    /// <summary>
    /// Shader location: array of matrices uniform: boneMatrices
    /// </summary>
    SHADER_LOC_BONE_MATRICES,
    /// <summary>
    /// Shader location: vertex attribute: instanceTransform
    /// </summary>
    SHADER_LOC_VERTEX_INSTANCE_TX,
}