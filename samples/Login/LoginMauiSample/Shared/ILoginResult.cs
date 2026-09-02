
namespace LoginMauiSample;

/// <summary>
/// Represents the result of a login attempt using <see cref="ILoginService"/>.
/// </summary>
public interface ILoginResult
{
    /// <summary>
    /// Gets the access token returned from the login attempt.
    /// </summary>
    IAccessToken? Token { get; }

    /// <summary>
    /// Gets the authentication token returned from the login attempt.
    /// </summary>
    IAuthenticationToken? AuthenticationToken { get; }

    /// <summary>
    /// Gets a value indicating whether the login was cancelled by the user.
    /// </summary>
    bool IsCancelled { get; }

    /// <summary>
    /// Gets the permissions granted by the user.
    /// </summary>
    IReadOnlySet<string> GrantedPermissions { get; }

    /// <summary>
    /// Gets the permissions declined by the user.
    /// </summary>
    IReadOnlySet<string> DeclinedPermissions { get; }

    /// <summary>
    /// Provides string description of all available properties for debugging purposes.
    /// </summary>
    /// <returns>String conataining all property information.</returns>
    string DebugDescription();
}