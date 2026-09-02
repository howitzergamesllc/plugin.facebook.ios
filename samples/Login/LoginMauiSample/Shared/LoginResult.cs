
namespace LoginMauiSample;

/// <inheritdoc />
public sealed class LoginResult : ILoginResult
{
    /// <inheritdoc />
    public IAccessToken? Token { get; }

    /// <inheritdoc />
    public IAuthenticationToken? AuthenticationToken { get; }

    /// <inheritdoc />
    public bool IsCancelled { get; }

    /// <inheritdoc />
    public IReadOnlySet<string> GrantedPermissions { get; } = new HashSet<string>();

    /// <inheritdoc />
    public IReadOnlySet<string> DeclinedPermissions { get; } = new HashSet<string>();

    internal LoginResult(IAccessToken? token, IAuthenticationToken? authenticationToken, bool isCancelled, IReadOnlySet<string> grantedPermissions, IReadOnlySet<string> declinedPermissions)
    {
        Token = token;
        AuthenticationToken = authenticationToken;
        IsCancelled = isCancelled;
        GrantedPermissions = grantedPermissions;
        DeclinedPermissions = declinedPermissions;
    }
    
    /// <inheritdoc />
    public string DebugDescription() => $"Token={Token?.DebugDescription()}, AuthenticationToken={AuthenticationToken?.DebugDescription()}, " +
        $"IsCancelled={IsCancelled}, GrantedPermissions={string.Join(", ", GrantedPermissions)}, DeclinedPermissions={string.Join(", ", DeclinedPermissions)}";
}