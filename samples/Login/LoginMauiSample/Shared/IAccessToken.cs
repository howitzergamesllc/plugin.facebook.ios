
namespace LoginMauiSample;

/// <summary>
/// Represents an immutable access token used to authenticate requests
/// against Facebook services.
/// </summary>
public interface IAccessToken
{
    /// <summary>
    /// Gets the opaque token string used for authentication.
    /// </summary>
    string TokenString { get; }

    /// <summary>
    /// Gets the Facebook application identifier associated with this token.
    /// </summary>
    string AppId { get; }

    /// <summary>
    /// Gets the Facebook user identifier associated with this token.
    /// </summary>
    string UserId { get; }

    /// <summary>
    /// Gets the date and time when the token expires.
    /// </summary>
    DateTimeOffset? ExpirationDate { get; }

    /// <summary>
    /// Gets the date and time when user data access expires.
    /// </summary>
    DateTimeOffset? DataAccessExpirationDate { get; }

    /// <summary>
    /// Gets the date and time when the token was last refreshed.
    /// </summary>
    DateTimeOffset? RefreshDate { get; }

    /// <summary>
    /// Gets the set of permissions granted to the application.
    /// </summary>
    IReadOnlySet<string> GrantedPermissions { get; }

    /// <summary>
    /// Gets the set of permissions declined by the user.
    /// </summary>
    IReadOnlySet<string> DeclinedPermissions { get; }

    /// <summary>
    /// Gets the set of permissions that have expired.
    /// </summary>
    IReadOnlySet<string> ExpiredPermissions { get; }

    /// <summary>
    /// Gets a value indicating whether this token has expired.
    /// </summary>
    bool IsExpired { get; }

    /// <summary>
    /// Gets a value indicating whether user data access has expired.
    /// </summary>
    bool IsDataAccessExpired { get; }

    /// <summary>
    /// Returns <c>true</c> if <see cref="CrossFacebookLogin.CurrentToken"/> is not null or expired.
    /// </summary>
    bool IsActive{ get; }

    /// <summary>
    /// Determines whether the specified permission has been granted.
    /// </summary>
    /// <param name="permission">The permission to check.</param>
    /// <returns>
    /// <see langword="true"/> if the permission has been granted;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    bool HasGranted(string permission);

    /// <summary>
    /// Provides string description of all available properties for debugging purposes.
    /// </summary>
    /// <returns>String conataining all property information.</returns>
    string DebugDescription();
}