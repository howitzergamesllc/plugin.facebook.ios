
namespace LoginMauiSample;

/// <summary>
/// Represents the result of a device login flow.
/// </summary>
/// <remarks>
/// This result is returned by device-based login flows and indicates
/// whether authentication succeeded, was cancelled by the user,
/// or expired before completion.
/// </remarks>
public interface IDeviceLoginResult
{
    /// <summary>
    /// Gets the access token returned from the device login flow.
    /// </summary>
    public IAccessToken? AccessToken { get; }

    /// <summary>
    /// Gets a value indicating whether the login was cancelled by the user
    /// or the device login code expired.
    /// </summary>
    public bool IsCancelled { get; }
    
    /// <summary>
    /// Provides string description of all available properties for debugging purposes.
    /// </summary>
    /// <returns>String conataining all property information.</returns>
    string DebugDescription();
}