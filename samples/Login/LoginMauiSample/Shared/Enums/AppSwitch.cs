namespace LoginMauiSample;

/// <summary>
/// The app switch behavior preference to use for a login attempt.
/// App switch allows users to switch to the Facebook app for authentication if installed.
/// </summary>
public enum AppSwitch
{
    /// <summary>
    /// Do not use app switch. Use browser-based login.
    /// </summary>
    Disabled = 0,

    /// <summary>
    /// Use app switch if the Facebook app is installed.
    /// This is the default behavior.
    /// </summary>
    Enabled = 1,

    /// <summary>
    /// The type was unknown. This could be an update to the facebook-ios-sdk.
    /// </summary>
    Unknown = -1,
}