namespace LoginMauiSample;

/// <summary>
/// Specifies how a Facebook profile picture should be displayed.
/// </summary>
/// <remarks>
/// These values correspond to the native Facebook SDK's profile picture modes.
/// </remarks>
public enum ProfilePictureMode
{
    /// <summary>
    /// Displays a square-cropped version of the profile picture.
    /// </summary>
    Square = 0,

    /// <summary>
    /// Displays the profile picture using its original aspect ratio.
    /// </summary>
    Normal = 1,

    /// <summary>
    /// Displays an album-sized version of the profile picture using its original aspect ratio.
    /// </summary>
    Album = 2,

    /// <summary>
    /// Displays a small version of the profile picture using its original aspect ratio.
    /// </summary>
    Small = 3,

    /// <summary>
    /// Displays a large version of the profile picture using its original aspect ratio.
    /// </summary>
    Large = 4,
}