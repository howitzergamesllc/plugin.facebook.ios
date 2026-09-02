
namespace LoginMauiSample;

/// <summary>
/// Configuration options used to modify the behavior of a login attempt.
/// </summary>
public sealed class LoginConfiguration
{
    /// <summary>
    /// Creates a new login configuration.
    /// </summary>
    /// <param name="permissions">
    /// Permissions requested during login.
    /// </param>
    /// <param name="tracking">
    /// The tracking  preference. Defaults to <see cref="LoginTracking.Enabled"/>.
    /// </param>
    /// <param name="appSwitch">
    /// The app switch behavior. Defaults to <see cref="AppSwitch.Enabled"/>.
    /// </param>
    public LoginConfiguration(IReadOnlySet<string>? permissions = null, LoginTracking tracking = LoginTracking.Enabled, AppSwitch appSwitch = AppSwitch.Enabled)
    {
        Permissions = permissions ?? new HashSet<string>();
        Tracking = tracking;
        AppSwitch = appSwitch;
    }

    /// <summary>
    /// Attempts to initialize a new configuration with the expected parameters.
    /// A valid nonce must be a non-empty string without whitespace.
    /// Creation of the configuration will fail if the nonce is invalid.
    /// </summary>
    /// <param name="permissions">The requested permissions for the login attempt. Defaults to an empty set.</param>
    /// <param name="tracking">
    /// The tracking  preference. Defaults to <see cref="LoginTracking.Enabled"/>.
    /// </param>
    /// <param name="nonce">The nonce that the configuration was created with.
    /// A unique nonce will be used if none is provided to the initializer.
    /// </param>
    /// <param name="messengerPageId">The Messenger Page Id associated with this login request.</param>
    /// <param name="authType">The auth type associated with this login request.</param>
    /// <param name="appSwitch">
    /// The app switch behavior. Defaults to <see cref="AppSwitch.Enabled"/>.
    /// </param>
    /// <param name="codeVerifier">The code verifier used in the PKCE process.</param>
    public LoginConfiguration(string nonce, IReadOnlySet<string>? permissions = null,  string? messengerPageId = null, LoginAuthType authType = LoginAuthType.Rerequest, 
        AppSwitch appSwitch = AppSwitch.Enabled, LoginTracking tracking = LoginTracking.Enabled,  CodeVerifier? codeVerifier = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nonce);

        Nonce = nonce;
        Permissions = permissions ?? new HashSet<string>();
        MessengerPageId = messengerPageId;
        AuthType = authType;
        AppSwitch = appSwitch;
        Tracking = tracking;
        CodeVerifier = codeVerifier;
    }

    /// <summary>
    /// Permissions requested during the login attempt.
    /// </summary>
    public IReadOnlySet<string> Permissions { get; } = new HashSet<string>();

    /// <summary>
    /// The tracking  preference. Defaults to <see cref="LoginTracking.Enabled"/>.
    /// </summary>
    public LoginTracking Tracking { get; }

    /// <summary>
    /// Nonce used for the login request.
    /// </summary>
    public string Nonce { get; } = "";

    /// <summary>
    /// Messenger page identifier associated with this request.
    /// </summary>
    public string? MessengerPageId { get; }
    
    /// <summary>
    /// Gets the PKCE code verifier used for the login request.
    /// </summary>
    /// <remarks>
    /// If specified, the code verifier is used to support Proof Key for Code Exchange (PKCE)
    /// during the authentication flow. If <see langword="null"/>, a code verifier may be
    /// generated automatically by the underlying platform implementation, if supported.
    /// </remarks>
    public CodeVerifier? CodeVerifier { get; }

    /// <summary>
    /// Gets the authorization type to use for the login request.
    /// </summary>
    /// <remarks>
    /// Specify an authorization type to request additional permissions or
    /// reauthorize access when appropriate. If <see langword="null"/>,
    /// the default authorization behavior is used.
    /// </remarks>
    public LoginAuthType? AuthType { get; }

    /// <summary>
    /// The app switch behavior. Defaults to <see cref="AppSwitch.Enabled"/>.
    /// </summary>
    public AppSwitch AppSwitch { get; }
}