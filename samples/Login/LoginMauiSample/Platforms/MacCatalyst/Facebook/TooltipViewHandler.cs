
using Facebook.Login;
using Microsoft.Maui.Handlers;
using UIKit;

namespace LoginMauiSample.Controls;

public partial class LoginTooltipViewHandler : ViewHandler<LoginTooltipView, FBSDKLoginTooltipView>
{
    public static IPropertyMapper<LoginTooltipView, LoginTooltipViewHandler> PropertyMapper
        = new PropertyMapper<LoginTooltipView, LoginTooltipViewHandler>(ViewMapper)        
        {
            [nameof(LoginTooltipView.DisplayDuration)] = MapDisplayDuration,
            [nameof(LoginTooltipView.Tagline)] = MapTagline,
            [nameof(LoginTooltipView.Message)] = MapMessage,
            [nameof(LoginTooltipView.ColorStyle)] = MapColorStyle,
        };

    public LoginTooltipViewHandler() : base(PropertyMapper) { }

    protected override void ConnectHandler(FBSDKLoginTooltipView platformView)
    {
        platformView.WillAppear += OnTooltipWillAppear;
        platformView.WillNotAppear += OnTooltipWillNotAppear;
        base.ConnectHandler(platformView);
    }

    protected override void DisconnectHandler(FBSDKLoginTooltipView platformView)
    {
        platformView.WillAppear -= OnTooltipWillAppear;
        platformView.WillNotAppear -= OnTooltipWillNotAppear;
        base.DisconnectHandler(platformView);
    }

    protected override FBSDKLoginTooltipView CreatePlatformView()
    {
        var tooltipView = new FBSDKLoginTooltipView();
        return tooltipView;
    }

    public void PresentFrom(View anchorView)
    {
        if (anchorView.Handler?.PlatformView is UIView nativeView)
        {
            PlatformView.PresentFromView(nativeView);
        }
    }

    public void Dismiss()
    {
        PlatformView.Dismiss();
    }
    
    private static void MapDisplayDuration(LoginTooltipViewHandler handler, LoginTooltipView view)
    {
        handler.PlatformView.DisplayDuration = view.DisplayDuration.TotalSeconds;
    }
    
    private static void MapTagline(LoginTooltipViewHandler handler, LoginTooltipView view)
    {
        handler.PlatformView.Tagline = view.Tagline;
    }

    private static void MapMessage(LoginTooltipViewHandler handler, LoginTooltipView view)
    {
        handler.PlatformView.Message = view.Message;
    }
    
    private static void MapColorStyle(LoginTooltipViewHandler handler, LoginTooltipView view)
    {
        handler.PlatformView.ColorStyle = view.ColorStyle.ToNativeTooltipColorStyle();
    }

    private void OnTooltipWillAppear(object? sender, EventArgs e) => VirtualView.RaiseAppearingEvent(this, e);
    private void OnTooltipWillNotAppear(object? sender, EventArgs e) => VirtualView.RaiseNotAppearingEvent(this, e);
}