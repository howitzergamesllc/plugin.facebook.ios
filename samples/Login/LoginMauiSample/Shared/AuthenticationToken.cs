
namespace LoginMauiSample;

/// <inheritdoc />
public sealed class AuthenticationToken : IAuthenticationToken
{
    /// <inheritdoc />
    public string TokenString { get; } = "";

    /// <inheritdoc />
    public string Nonce { get; } = "";

    /// <inheritdoc />
    public string GraphDomain { get; } = "";

    internal AuthenticationToken(string tokenString, string nonce, string graphDomain)
    {
        TokenString = tokenString;
        Nonce = nonce;
        GraphDomain = graphDomain;
    }
    
    /// <inheritdoc />
    public string DebugDescription() => $"TokenString={TokenString}, Nonce={Nonce}, GraphDomain={GraphDomain}";
}