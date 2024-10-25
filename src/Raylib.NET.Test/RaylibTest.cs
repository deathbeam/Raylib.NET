using Xunit;
using Bindgen.Test;

namespace RaylibNET.Test;

public class RaylibTest
{
    private unsafe void CheckType<T>() where T : unmanaged
    {
        Assert.True(BlittableHelper.IsBlittable<T>());
    }

    [Fact]
    public void CheckTypes()
    {
        CheckType<ConfigFlags>();
        CheckType<TraceLogLevel>();
        CheckType<KeyboardKey>();
        CheckType<MouseButton>();
        CheckType<MouseCursor>();
        CheckType<GamepadButton>();
        CheckType<GamepadAxis>();
        CheckType<MaterialMapIndex>();
        CheckType<ShaderLocationIndex>();
        CheckType<ShaderUniformDataType>();
        CheckType<ShaderAttributeDataType>();
        CheckType<PixelFormat>();
        CheckType<TextureFilter>();
        CheckType<TextureWrap>();
        CheckType<CubemapLayout>();
        CheckType<FontType>();
        CheckType<BlendMode>();
        CheckType<Gesture>();
        CheckType<CameraMode>();
        CheckType<CameraProjection>();
        CheckType<NPatchLayout>();
        CheckType<Color>();
        CheckType<Image>();
        CheckType<Texture>();
        CheckType<RenderTexture>();
        CheckType<NPatchInfo>();
        CheckType<GlyphInfo>();
        CheckType<Font>();
        CheckType<Camera3D>();
        CheckType<Camera2D>();
        CheckType<Mesh>();
        CheckType<Shader>();
        CheckType<MaterialMap>();
        CheckType<Material>();
        CheckType<Transform>();
        CheckType<BoneInfo>();
        CheckType<Model>();
        CheckType<ModelAnimation>();
        CheckType<Ray>();
        CheckType<RayCollision>();
        CheckType<BoundingBox>();
        CheckType<Wave>();
        CheckType<rAudioBuffer>();
        CheckType<rAudioProcessor>();
        CheckType<AudioStream>();
        CheckType<Sound>();
        CheckType<Music>();
        CheckType<VrDeviceInfo>();
        CheckType<VrStereoConfig>();
        CheckType<FilePathList>();
        CheckType<AutomationEvent>();
        CheckType<AutomationEventList>();
    }
}