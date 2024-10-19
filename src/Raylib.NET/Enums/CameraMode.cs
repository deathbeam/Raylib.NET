namespace RaylibNET;

public enum CameraMode
{
    /// <summary>
    /// Camera custom, controlled by user (UpdateCamera() does nothing)
    /// </summary>
    CAMERA_CUSTOM = 0,
    /// <summary>
    /// Camera free mode
    /// </summary>
    CAMERA_FREE,
    /// <summary>
    /// Camera orbital, around target, zoom supported
    /// </summary>
    CAMERA_ORBITAL,
    /// <summary>
    /// Camera first person
    /// </summary>
    CAMERA_FIRST_PERSON,
    /// <summary>
    /// Camera third person
    /// </summary>
    CAMERA_THIRD_PERSON,
}