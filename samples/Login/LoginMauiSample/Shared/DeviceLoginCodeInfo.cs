
namespace LoginMauiSample;

/// <inheritdoc />
public sealed class DeviceLoginCodeInfo : IDeviceLoginCodeInfo
{
    /// <inheritdoc />
    public string Identifier { get; } = "";

    /// <inheritdoc />
    public string LoginCode { get; } = "";

    /// <inheritdoc />
    public Uri? VerificationUrl { get; }

    /// <inheritdoc />
    public DateTimeOffset ExpirationDate { get; }

    /// <inheritdoc />
    public TimeSpan PollingInterval { get; }

    internal DeviceLoginCodeInfo(string identifier, string loginCode, Uri verificationUrl, DateTimeOffset expirationDate, TimeSpan pollingInterval)
    {
        Identifier = identifier;
        LoginCode = loginCode;
        VerificationUrl = verificationUrl;
        ExpirationDate = expirationDate;
        PollingInterval = pollingInterval;
    }

    /// <inheritdoc />
    public string DebugDescription() => $"Identifier={Identifier}, LoginCode={LoginCode}, VerificationUrl={VerificationUrl?.AbsolutePath} " +
        $"ExpirationDate={ExpirationDate}, PollingInterval={PollingInterval}";
}