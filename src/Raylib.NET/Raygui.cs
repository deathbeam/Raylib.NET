using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

public static unsafe partial class Raygui
{
    public const string LIBRARY = "raylib";

    public const int RAYGUI_VERSION_MAJOR = 4;

    public const int RAYGUI_VERSION_MINOR = 5;

    public const int RAYGUI_VERSION_PATCH = 0;

    public const string RAYGUI_VERSION = "4.5-dev";

    public const int SCROLLBAR_LEFT_SIDE = 0;

    public const int SCROLLBAR_RIGHT_SIDE = 1;

    /// <summary>
    /// Enable gui controls (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiEnable();

    /// <summary>
    /// Disable gui controls (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDisable();

    /// <summary>
    /// Lock gui controls (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLock();

    /// <summary>
    /// Unlock gui controls (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiUnlock();

    /// <summary>
    /// Check if gui is locked (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool GuiIsLocked();

    /// <summary>
    /// Set gui controls alpha (global state), alpha goes from 0.0f to 1.0f
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetAlpha(float alpha);

    /// <summary>
    /// Set gui state (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetState(int state);

    /// <summary>
    /// Get gui state (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGetState();

    /// <summary>
    /// Set gui custom font (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetFont(Font font);

    /// <summary>
    /// Get gui custom font (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font GuiGetFont();

    /// <summary>
    /// Set one style property
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetStyle(int control, int @property, int value);

    /// <summary>
    /// Get one style property
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGetStyle(int control, int @property);

    /// <summary>
    /// Load style file over global style variable (.rgs)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLoadStyle(string fileName);

    /// <summary>
    /// Load style default over global style
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLoadStyleDefault();

    /// <summary>
    /// Enable gui tooltips (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiEnableTooltip();

    /// <summary>
    /// Disable gui tooltips (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDisableTooltip();

    /// <summary>
    /// Set tooltip string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetTooltip(string tooltip);

    /// <summary>
    /// Get text with icon id prepended (if supported)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GuiIconText(int iconId, string text);

    /// <summary>
    /// Set default icon drawing size
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetIconScale(int scale);

    /// <summary>
    /// Get raygui icons data pointer
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint* GuiGetIcons();

    /// <summary>
    /// Load raygui icons file (.rgi) into internal icons data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** GuiLoadIcons(string fileName, NativeBool loadIconsName);

    /// <summary>
    /// Draw icon using pixel size at specified position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDrawIcon(int iconId, int posX, int posY, int pixelSize, Color color);

    /// <summary>
    /// Window Box control, shows a window that can be closed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiWindowBox(Vector4 bounds, string title);

    /// <summary>
    /// Group Box control with text name
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGroupBox(Vector4 bounds, string text);

    /// <summary>
    /// Line separator control, could contain text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLine(Vector4 bounds, string text);

    /// <summary>
    /// Panel control, useful to group controls
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiPanel(Vector4 bounds, string text);

    /// <summary>
    /// Tab Bar control, returns TAB to be closed or -1
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiTabBar(Vector4 bounds, sbyte** text, int count, int* active);

    /// <summary>
    /// Scroll Panel control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiScrollPanel(Vector4 bounds, string text, Vector4 content, Vector2* scroll, Vector4* view);

    /// <summary>
    /// Label control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLabel(Vector4 bounds, string text);

    /// <summary>
    /// Button control, returns true when clicked
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiButton(Vector4 bounds, string text);

    /// <summary>
    /// Label button control, returns true when clicked
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLabelButton(Vector4 bounds, string text);

    /// <summary>
    /// Toggle Button control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggle(Vector4 bounds, string text, NativeBool* active);

    /// <summary>
    /// Toggle Group control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggleGroup(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Toggle Slider control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggleSlider(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Check Box control, returns true when active
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiCheckBox(Vector4 bounds, string text, NativeBool* @checked);

    /// <summary>
    /// Combo Box control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiComboBox(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Dropdown Box control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiDropdownBox(Vector4 bounds, string text, int* active, NativeBool editMode);

    /// <summary>
    /// Spinner control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSpinner(Vector4 bounds, string text, int* value, int minValue, int maxValue, NativeBool editMode);

    /// <summary>
    /// Value Box control, updates input text with numbers
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiValueBox(Vector4 bounds, string text, int* value, int minValue, int maxValue, NativeBool editMode);

    /// <summary>
    /// Value box control for float values
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiValueBoxFloat(Vector4 bounds, string text, string textValue, float* value, NativeBool editMode);

    /// <summary>
    /// Text Box control, updates input text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiTextBox(Vector4 bounds, string text, int textSize, NativeBool editMode);

    /// <summary>
    /// Slider control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSlider(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Slider Bar control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSliderBar(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Progress Bar control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiProgressBar(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Status Bar control, shows info text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiStatusBar(Vector4 bounds, string text);

    /// <summary>
    /// Dummy control for placeholders
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiDummyRec(Vector4 bounds, string text);

    /// <summary>
    /// Grid control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiGrid(Vector4 bounds, string text, float spacing, int subdivs, Vector2* mouseCell);

    /// <summary>
    /// List View control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiListView(Vector4 bounds, string text, int* scrollIndex, int* active);

    /// <summary>
    /// List View with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiListViewEx(Vector4 bounds, sbyte** text, int count, int* scrollIndex, int* active, int* focus);

    /// <summary>
    /// Message Box control, displays a message
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiMessageBox(Vector4 bounds, string title, string message, string buttons);

    /// <summary>
    /// Text Input Box control, ask for text, supports secret
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiTextInputBox(Vector4 bounds, string title, string message, string buttons, string text, int textMaxSize, NativeBool* secretViewActive);

    /// <summary>
    /// Color Picker control (multiple color controls)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPicker(Vector4 bounds, string text, Color* color);

    /// <summary>
    /// Color Panel control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPanel(Vector4 bounds, string text, Color* color);

    /// <summary>
    /// Color Bar Alpha control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorBarAlpha(Vector4 bounds, string text, float* alpha);

    /// <summary>
    /// Color Bar Hue control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorBarHue(Vector4 bounds, string text, float* value);

    /// <summary>
    /// Color Picker control that avoids conversion to RGB on each call (multiple color controls)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPickerHSV(Vector4 bounds, string text, Vector3* colorHsv);

    /// <summary>
    /// Color Panel control that updates Hue-Saturation-Value color value, used by GuiColorPickerHSV()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPanelHSV(Vector4 bounds, string text, Vector3* colorHsv);
}
