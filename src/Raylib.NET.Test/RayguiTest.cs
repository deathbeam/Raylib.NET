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
        CheckType<GuiStyleProp>();
    }
}
