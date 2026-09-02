
namespace LoginMauiSample;

/// <summary>
/// Provides data for a completed Facebook login operation.
/// </summary>
public sealed class LoggedInEventArgs : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FacebookLoggedInEventArgs"/> class.
    /// </summary>
    /// <param name="result">
    /// The result of the login operation.
    /// </param>
    /// <param name="exception">
    /// The exception that occurred during login, if the operation failed; otherwise, <see langword="null"/>.
    /// </param>
    public LoggedInEventArgs(ILoginResult? result, LoginException? exception)
    {
        Result = result;
        Exception = exception;
    }

    /// <summary>
    /// Gets the result of the login operation.
    /// </summary>
    public ILoginResult? Result { get; }

    /// <summary>
    /// Gets the exception that occurred during the login operation, if any.
    /// </summary>
    public LoginException? Exception { get; }
}

/// <summary>
/// Provides data for a completed Facebook logout operation.
/// </summary>
public sealed class LoggedOutEventArgs : EventArgs
{
}
