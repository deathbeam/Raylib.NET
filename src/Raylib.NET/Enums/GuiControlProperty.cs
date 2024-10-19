namespace RaylibNET;

public enum GuiControlProperty
{
    /// <summary>
    /// Control border color in STATE_NORMAL
    /// </summary>
    BORDER_COLOR_NORMAL = 0,
    /// <summary>
    /// Control base color in STATE_NORMAL
    /// </summary>
    BASE_COLOR_NORMAL,
    /// <summary>
    /// Control text color in STATE_NORMAL
    /// </summary>
    TEXT_COLOR_NORMAL,
    /// <summary>
    /// Control border color in STATE_FOCUSED
    /// </summary>
    BORDER_COLOR_FOCUSED,
    /// <summary>
    /// Control base color in STATE_FOCUSED
    /// </summary>
    BASE_COLOR_FOCUSED,
    /// <summary>
    /// Control text color in STATE_FOCUSED
    /// </summary>
    TEXT_COLOR_FOCUSED,
    /// <summary>
    /// Control border color in STATE_PRESSED
    /// </summary>
    BORDER_COLOR_PRESSED,
    /// <summary>
    /// Control base color in STATE_PRESSED
    /// </summary>
    BASE_COLOR_PRESSED,
    /// <summary>
    /// Control text color in STATE_PRESSED
    /// </summary>
    TEXT_COLOR_PRESSED,
    /// <summary>
    /// Control border color in STATE_DISABLED
    /// </summary>
    BORDER_COLOR_DISABLED,
    /// <summary>
    /// Control base color in STATE_DISABLED
    /// </summary>
    BASE_COLOR_DISABLED,
    /// <summary>
    /// Control text color in STATE_DISABLED
    /// </summary>
    TEXT_COLOR_DISABLED,
    /// <summary>
    /// Control border size, 0 for no border
    /// </summary>
    BORDER_WIDTH,
    /// <summary>
    /// Control text padding, not considering border
    /// </summary>
    TEXT_PADDING,
    /// <summary>
    /// Control text horizontal alignment inside control text bound (after border and padding)
    /// </summary>
    TEXT_ALIGNMENT,
}