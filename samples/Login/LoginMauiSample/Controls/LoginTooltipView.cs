
namespace LoginMauiSample.Controls;

/// Designated initializer.
/// If you need to show a tooltip for login, consider using the TooltipView.
/// See <see cref="TooltipView"/> for more information.
public class LoginTooltipView : ContentView
{
    /// <summary>
    /// Tooltipview will appear.
    /// </summary>
    public event EventHandler? Appearing;
    /// <summary>
    /// Tooltipview will not appear.
    /// </summary>
    public event EventHandler? NotAppearing;

    /// <summary>
    /// Identifies the <see cref="DisplayDuration"/> bindable property.
    /// </summary>
    public static readonly BindableProperty DisplayDurationProperty = BindableProperty.Create(nameof(DisplayDuration), typeof(TimeSpan), typeof(LoginTooltipView), TimeSpan.FromSeconds(6l));

    /// <summary>
    /// Gets or sets the amount of time in seconds the tooltip should be displayed.
    /// </summary>
    /// <remarks>
    /// Set this value to zero to make the tooltip remain visible until it is explicitly dismissed.
    /// The default value is six seconds.
    /// </remarks>
    public TimeSpan DisplayDuration
    {
        get => (TimeSpan)GetValue(DisplayDurationProperty);
        set => SetValue(DisplayDurationProperty, value);
    }

    /// <summary>
    /// A property that binds <see cref="Tagline"/>.
    /// First part of the label, that will be highlighted with different color. Can be nil.
    /// </summary>
    public static readonly BindableProperty TaglineDialogProperty =
        BindableProperty.Create(nameof(Tagline), typeof(string), typeof(LoginTooltipView), String.Empty, BindingMode.OneWay, null);

    /// <summary>
    /// First part of the label, that will be highlighted with different color. Can be nil.
    /// </summary>
    public string Tagline
    {
        get { return (string)GetValue(TaglineDialogProperty); }
        set { SetValue(TaglineDialogProperty, value); }
    }

    /// <summary>
    /// A property that binds the main <see cref="Message"/> to display.
    /// </summary>
    public static readonly BindableProperty MessageDialogProperty =
        BindableProperty.Create(nameof(Message), typeof(string), typeof(LoginTooltipView), String.Empty, BindingMode.OneWay, null);

    /// <summary>
    /// Main message to display.
    /// </summary>
    public string Message
    {
        get { return (string)GetValue(MessageDialogProperty); }
        set { SetValue(MessageDialogProperty, value); }
    }

    /// <summary>
    /// A property that binds the main <see cref="TooltipColorStyle"/> to use for the tooltip.
    /// </summary>
    public static readonly BindableProperty ColorStyleProperty =
        BindableProperty.Create(nameof(ColorStyle), typeof(TooltipColorStyle), typeof(LoginTooltipView), TooltipColorStyle.FriendlyBlue, BindingMode.OneWay, null);

    /// <summary>
    /// Color style to use for tooltip.
    /// </summary>
    public TooltipColorStyle ColorStyle
    {
        get { return (TooltipColorStyle)GetValue(ColorStyleProperty); }
        set { SetValue(ColorStyleProperty, value); }
    }

    public void PresentFrom(View anchorView)
    {
        (Handler as LoginTooltipViewHandler)?.PresentFrom(anchorView);
    }

    public void Dismiss()
    {
        (Handler as LoginTooltipViewHandler)?.Dismiss();
    }
    
    internal void RaiseAppearingEvent(object? sender, EventArgs e) => Appearing?.Invoke(sender, e);
    internal void RaiseNotAppearingEvent(object? sender, EventArgs e) => NotAppearing?.Invoke(sender, e);
}
