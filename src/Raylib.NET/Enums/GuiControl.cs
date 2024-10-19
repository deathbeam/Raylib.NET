namespace Raylib.NET;

public enum GuiControl
{
    /// <summary>
    /// Default -> populates to all controls when set
    /// </summary>
    DEFAULT = 0,
    /// <summary>
    /// Used also for: LABELBUTTON
    /// </summary>
    LABEL,
    BUTTON,
    /// <summary>
    /// Used also for: TOGGLEGROUP
    /// </summary>
    TOGGLE,
    /// <summary>
    /// Used also for: SLIDERBAR, TOGGLESLIDER
    /// </summary>
    SLIDER,
    PROGRESSBAR,
    CHECKBOX,
    COMBOBOX,
    DROPDOWNBOX,
    /// <summary>
    /// Used also for: TEXTBOXMULTI
    /// </summary>
    TEXTBOX,
    VALUEBOX,
    /// <summary>
    /// Uses: BUTTON, VALUEBOX
    /// </summary>
    SPINNER,
    LISTVIEW,
    COLORPICKER,
    SCROLLBAR,
    STATUSBAR,
}