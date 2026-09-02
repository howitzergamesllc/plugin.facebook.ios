
namespace ShareMauiSample.FacebookControls;

/// <summary>
/// A shared virtual instance of the native platform facebook send button.
/// </summary>
public class SendButton : ContentView, ISharingButton
{
    /// <summary>
    /// Raised when the button is pressed.
    /// </summary>
    public event EventHandler? Pressed;
    /// <summary>
    /// Raised when the button is released.
    /// </summary>
    public event EventHandler? Released;
    /// <summary>
    /// Raised when the button is clicked.
    /// </summary>
    public event EventHandler? Clicked;

    /// <summary>
    /// The message dialog managing the <see cref="ISharingDelegate"/> for <see cref="ISharingContent"/> when the button is clicked/>.
    /// </summary>
    public static readonly BindableProperty MessageDialogProperty =
        BindableProperty.Create(nameof(MessageDialog), typeof(IMessageDialog), typeof(SendButton), null, BindingMode.OneWay, null);

    /// <summary>
    /// The dialog to share when the button is clicked.
    /// </summary>
    public IMessageDialog MessageDialog
    {
        get { return (IMessageDialog)GetValue(MessageDialogProperty); }
        set { SetValue(MessageDialogProperty, value); }
    }

    /// <summary>
    /// The content (URL) to share when the button is clicked.
    /// </summary>
    public static readonly BindableProperty LinkContentProperty = 
        BindableProperty.Create(nameof(LinkContent), typeof(ShareLinkContent), typeof(SendButton), null, BindingMode.OneWay, null);

    /// <summary>
    /// The content (URL) to share when the button is clicked.
    /// </summary>
    public ShareLinkContent? LinkContent
    {
        get => (ShareLinkContent?)GetValue(LinkContentProperty);
        set => SetValue(LinkContentProperty, value);
    }

    /// <summary>
    /// The content (Photo, URL, Media, Video) to share when the button is clicked.
    /// </summary>
    public static readonly BindableProperty ShareContentProperty =
        BindableProperty.Create(nameof(ShareContent), typeof(ISharingContent), typeof(SendButton), null, BindingMode.OneWay, null);

    /// <summary>
    /// The content (Photo, URL, Media, Video) to share when the button is clicked.
    /// </summary>
    [Obsolete("FacebookSendButton only supports ShareLinkContent. Use LinkContent instead.", false)]
    public ISharingContent? ShareContent
    {
        get => (ISharingContent?)GetValue(ShareContentProperty);
        set => SetValue(ShareContentProperty, value);
    }

    internal void RaisePressedEvent(object? sender, EventArgs e) => Pressed?.Invoke(sender, e);
    internal void RaiseReleasedEvent(object? sender, EventArgs e) => Released?.Invoke(sender, e);
    internal void RaiseClickedEvent(object? sender, EventArgs e) => Clicked?.Invoke(sender, e);
}
