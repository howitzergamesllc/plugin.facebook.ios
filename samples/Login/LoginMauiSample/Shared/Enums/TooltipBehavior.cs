namespace LoginMauiSample;

/// <summary>
/// Specifies how the login tooltip is displayed for a login button.
/// </summary>
public enum TooltipBehavior
{
    /// <summary>
    /// Uses the default behavior. The tooltip is displayed only if the
    /// application is eligible, which may be determined by a server request.
    /// </summary>
    Automatic = 0,

    /// <summary>
    /// Forces the tooltip to be displayed. This option is primarily intended
    /// for UI testing scenarios.
    /// </summary>
    ForceDisplay = 1,

    /// <summary>
    /// Disables the tooltip. More granular control can still be achieved by
    /// creating and configuring a <c>LoginTooltipView</c> instance manually.
    /// </summary>
    Disable = 2,

    /// <summary>
    /// The type was unknown. This could be an update to the facebook-ios-sdk.
    /// </summary>
    Unknown = -1,
}