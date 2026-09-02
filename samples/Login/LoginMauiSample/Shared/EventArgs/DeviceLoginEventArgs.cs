
namespace LoginMauiSample;

/// <summary>
/// Indicates the device login flow has started. You should parse <code>codeInfo</code> to present the code to the user to enter.
/// </summary>
public sealed class DeviceLoginStartedEventArgs : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeviceLoginStartedEventArgs"/> class.
    /// </summary>
    /// <param name="manager">
    /// The login manager instance.
    /// </param>
    /// <param name="codeInfo">
    /// The code info data.
    /// </param>
    public DeviceLoginStartedEventArgs(IDeviceLoginCodeInfo codeInfo)
    {
        CodeInfo = codeInfo;
    }

    /// <summary>
    /// The code info data.
    /// </summary>
    public IDeviceLoginCodeInfo CodeInfo { get; }
}


/// <summary>
/// Indicates the device login flow has finished.
/// </summary>
public sealed class DeviceLoginCompletedEventArgs : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeviceLoginCompletedEventArgs"/> class.
    /// </summary>
    /// <param name="result">
    /// The login manager instance.
    /// </param>
    /// <param name="deviceLoginResult">
    /// The results of the login flow.
    /// </param>
    /// <param name="exception">
    /// The exception that occurred during login, if the operation failed; otherwise, <see langword="null"/>.
    /// </param>
    public DeviceLoginCompletedEventArgs(IDeviceLoginResult? deviceLoginResult, DeviceLoginException? exception)
    {
        DeviceLoginResult = deviceLoginResult;
        Exception = exception;
    }
    
    /// <summary>
    /// The device login results.
    /// </summary>
    public IDeviceLoginResult? DeviceLoginResult { get; }

    /// <summary>
    /// The error, if available.
    /// </summary>
    public DeviceLoginException? Exception { get; }
}
