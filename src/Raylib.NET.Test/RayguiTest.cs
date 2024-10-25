using Xunit;
using Bindgen.Test;

namespace RaylibNET.Test;

public class RayguiTest
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
        CheckType<GuiState>();
        CheckType<GuiTextAlignment>();
        CheckType<GuiTextAlignmentVertical>();
        CheckType<GuiTextWrapMode>();
        CheckType<GuiControl>();
        CheckType<GuiControlProperty>();
        CheckType<GuiDefaultProperty>();
        CheckType<GuiToggleProperty>();
        CheckType<GuiSliderProperty>();
        CheckType<GuiProgressBarProperty>();
        CheckType<GuiScrollBarProperty>();
        CheckType<GuiCheckBoxProperty>();
        CheckType<GuiComboBoxProperty>();
        CheckType<GuiDropdownBoxProperty>();
        CheckType<GuiTextBoxProperty>();
        CheckType<GuiSpinnerProperty>();
        CheckType<GuiListViewProperty>();
        CheckType<GuiColorPickerProperty>();
        CheckType<GuiIconName>();
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
        CheckType<GuiStyleProp>();
    }
}
