namespace LoginMauiSample;

/// <summary>
/// Use this class to perform a device login flow.
/// The device login flow starts by requesting a code from the device login API.
/// This class informs the delegate when this code is received. You should then present the
/// code to the user to enter. In the meantime, this class polls the device login API
/// periodically and informs the delegate of the results.
/// See <a href="https://developers.facebook.com/docs/facebook-login/for-devices">Facebook Device Login</a>.
/// </summary>
public interface IDeviceLoginManager
{
    /// <summary>
    /// Gets the permissions requested by this device login flow.
    /// </summary>
    IReadOnlyList<string> Permissions { get; }

    /// <summary>
    /// The optional URL to redirect the user to after they complete the login.
    /// The URL must be configured in your App Settings -> Advanced -> OAuth Redirect URIs
    /// </summary>
    Uri? RedirectUrl { get; set; }

    /// <summary>
    /// Starts the device login flow
    /// This instance will retain self until the flow is finished or cancelled.
    /// </summary>
    void Start();

    /// <summary>
    /// Attempts to cancel the device login flow.
    /// </summary>
    void Cancel();

    /// <summary>
    /// Raised when the device code is received and should be presented to the user.
    /// </summary>
    event EventHandler<DeviceLoginStartedEventArgs>? Started;

    /// <summary>
    /// Raised when login completes successfully.
    /// </summary>
    event EventHandler<DeviceLoginCompletedEventArgs>? Completed;
}