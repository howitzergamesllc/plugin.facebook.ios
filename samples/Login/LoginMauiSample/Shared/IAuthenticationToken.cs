
namespace LoginMauiSample;

/// <summary>
/// Represents an authentication token returned from a login attempt.
/// </summary>
/// <remarks>
/// Authentication tokens are created and managed by the authentication service.
/// Consumers should treat implementations as immutable and use the exposed
/// properties to inspect authentication state.
/// </remarks>
public interface IAuthenticationToken
{
    /// <summary>
    /// Gets the raw token string returned from the authentication response.
    /// </summary>
    string TokenString { get; }

    /// <summary>
    /// Gets the nonce value associated with the authentication response.
    /// </summary>
    /// <remarks>
    /// The nonce is used to validate that the authentication response
    /// corresponds to the original authentication request.
    /// </remarks>
    string Nonce { get; }

    /// <summary>
    /// Gets the graph domain where the user was authenticated.
    /// </summary>
    string GraphDomain { get; }

    /// <summary>
    /// Provides string description of all available properties for debugging purposes.
    /// </summary>
    /// <returns>String conataining all property information.</returns>
    string DebugDescription();
}