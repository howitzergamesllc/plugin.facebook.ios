
namespace ShareMauiSample;

/// <summary>
/// Provides data for a completed sharing operation from a <see cref="ISharing"/> sharer.
/// </summary>
public sealed class FacebookSharingCompletedEventArgs : EventArgs
{
    /// <summary>
    /// Sent to the delegate when sharing completes without error or cancellation.
    /// </summary>
    /// <param name="results">
    /// The results from the <see cref="ISharing"/> sharer. This may be null or empty.
    /// </param>
    public FacebookSharingCompletedEventArgs(IReadOnlyDictionary<string, object?>? results = null)
    {
        Results = results;
    }

    /// <summary>
    /// The results from the <see cref="ISharing"/> sharer. This may be null or empty.
    /// </summary>
    public IReadOnlyDictionary<string, object?>? Results { get; }
}

/// <summary>
/// Provides data for a failed sharing operation from a <see cref="ISharing"/> sharer.
/// </summary>
public sealed class FacebookSharingFailedEventArgs : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SharingFailedEventArgs"/> class.
    /// </summary>
    /// <param name="error">
    /// The error that caused the sharing operation to fail.
    /// </param>
    public FacebookSharingFailedEventArgs(Exception error)
    {
        Error = error;
    }

    /// <summary>
    /// Gets the error that caused the sharing operation from a <see cref="ISharing"/> sharer.
    /// </summary>
    public Exception Error { get; }
}