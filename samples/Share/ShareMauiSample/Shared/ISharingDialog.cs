
namespace ShareMauiSample;

/// <summary>
/// Represents a dialog capable of <see cref="ISharing"/> content.
/// </summary>
public interface ISharingDialog : ISharing
{
    /// <summary>
    /// Gets a value indicating whether the dialog can be displayed.
    /// </summary>
    bool CanShow { get; }

    /// <summary>
    /// Displays the share dialog.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the dialog was displayed successfully; otherwise, <see langword="false"/>.
    /// </returns>
    bool Show();
}