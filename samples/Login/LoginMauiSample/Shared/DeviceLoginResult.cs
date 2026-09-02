
namespace LoginMauiSample;

/// <inheritdoc />
public sealed class DeviceLoginResult : IDeviceLoginResult
{
    /// <inheritdoc />
    public IAccessToken? AccessToken { get; }

    /// <inheritdoc />
    public bool IsCancelled { get; }

    internal DeviceLoginResult(IAccessToken accessToken, bool isCancelled)
    {
        AccessToken = accessToken;
        IsCancelled = isCancelled;
    }

    /// <inheritdoc />
    public string DebugDescription() => $"AccessToken={AccessToken?.DebugDescription()}, IsCancelled={IsCancelled}";
}