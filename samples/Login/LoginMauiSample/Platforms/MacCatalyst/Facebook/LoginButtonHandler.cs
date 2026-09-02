using Foundation;
using UIKit;
using Facebook.Login;
using Microsoft.Maui.Handlers;
using CoreGraphics;
using System.Diagnostics;

namespace LoginMauiSample.Controls;

public partial class LoginButtonHandler : ViewHandler<LoginButton, FBSDKLoginButton>
{
    public static IPropertyMapper<LoginButton, LoginButtonHandler> PropertyMapper
        = new PropertyMapper<LoginButton, LoginButtonHandler>(ViewMapper)
        {        
            [nameof(LoginButton.DefaultAudience)] = MapDefaultAudience,
            [nameof(LoginButton.Permissions)] = MapPermissions,
            [nameof(LoginButton.LoginTracking)] = MapLoginTracking,
            [nameof(LoginButton.TooltipBehavior)] = MapTooltipBehavior,
            [nameof(LoginButton.TooltipColorStyle)] = MapTooltipColorStyle,
            [nameof(LoginButton.AppSwitch)] = MapAppSwitch,
            [nameof(LoginButton.Nonce)] = MapNonce,
            [nameof(LoginButton.MessengerPageId)] = MapMessengerPageId,
            [nameof(LoginButton.AuthType)] = MapAuthType,
        };

    public LoginButtonHandler() : base(PropertyMapper) { }

    protected override void ConnectHandler(FBSDKLoginButton platformView)
    {
        platformView.TouchUpInside += OnTouchUpInside;
        platformView.TouchUpOutside += OnTouchUpOutside;
        platformView.TouchDown += OnTouchDown;
        platformView.Completed += OnLoggedIn;
        platformView.LoggedOut += OnLoggedOut;
        base.ConnectHandler(platformView);
    }

    protected override void DisconnectHandler(FBSDKLoginButton platformView)
    {
        platformView.TouchUpInside -= OnTouchUpInside;
        platformView.TouchUpOutside -= OnTouchUpOutside;
        platformView.TouchDown -= OnTouchDown;
        platformView.Completed -= OnLoggedIn;
        platformView.LoggedOut -= OnLoggedOut;
        base.DisconnectHandler(platformView);
    }

    protected override FBSDKLoginButton CreatePlatformView()
    {
        var button = new FBSDKLoginButton(CGRect.Empty);
        return button;
    }

    public static void MapDefaultAudience(LoginButtonHandler handler, LoginButton view)
    {
        handler.PlatformView.DefaultAudience = view.DefaultAudience.ToNativeDefaultAudience();
    }

    public static void MapPermissions(LoginButtonHandler handler, LoginButton view)
    {
        if (view.Permissions is null || view.Permissions.Count == 0)
            return;

        var permissions = view.Permissions.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

        if (permissions.Length == 0)
            return;

        handler.PlatformView.Permissions = permissions;
    }

    public static void MapTooltipBehavior(LoginButtonHandler handler, LoginButton view)
    {
        handler.PlatformView.TooltipBehavior = view.TooltipBehavior.ToNativeTooltipBehavior();
    }

    public static void MapTooltipColorStyle(LoginButtonHandler handler, LoginButton view)
    {
        handler.PlatformView.TooltipColorStyle = view.TooltipColorStyle.ToNativeTooltipColorStyle();
    }

    public static void MapLoginTracking(LoginButtonHandler handler, LoginButton view)
    {
        handler.PlatformView.LoginTracking = view.LoginTracking.ToNativeLoginTracking();
    }

    public static void MapAppSwitch(LoginButtonHandler handler, LoginButton view)
    {
        handler.PlatformView.AppSwitch = view.AppSwitch.ToNativeAppSwitch();
    }

    public static void MapNonce(LoginButtonHandler handler, LoginButton view)
    {
        if(String.IsNullOrEmpty(view.Nonce))
            return;

        handler.PlatformView.Nonce = view.Nonce;
    }

    public static void MapMessengerPageId(LoginButtonHandler handler, LoginButton view)
    {
        handler.PlatformView.MessengerPageId = view.MessengerPageId;
    }

    public static void MapAuthType(LoginButtonHandler handler, LoginButton view)
    {
        handler.PlatformView.AuthType = view.AuthType.ToNativeAuthType();
    }
    /*
    public override void PlatformArrange(Rect frame)
    {    
        base.PlatformArrange(frame);

        PlatformView.Frame = new CoreGraphics.CGRect(frame.X, frame.Y, frame.Width, frame.Height);

        var height = (float)frame.Height;
        var padding = height * 0.05f;

        var existingImage = PlatformView.ImageForState(UIControlState.Normal);
        var existingTitle = PlatformView.Title(UIControlState.Normal);
        var existingCornerRaidus = PlatformView.Layer.CornerRadius;
        
        var existingBackgroundColor = PlatformView.BackgroundColor;
        var existingTitleColor = PlatformView.TitleColor(UIControlState.Normal);
        var existingFont = PlatformView.TitleLabel.Font;

        var configuration = PlatformView.Configuration ?? UIButtonConfiguration.FilledButtonConfiguration;

        var background = OperatingSystem.IsIOSVersionAtLeast(18, 0) ? UIBackgroundConfiguration.ListCellConfiguration
            : UIBackgroundConfiguration.ListPlainCellConfiguration;

        background.BackgroundColor = UIColor.SystemBlue;
        background.CornerRadius = existingCornerRaidus;

        configuration.CornerStyle = UIButtonConfigurationCornerStyle.Fixed;
        configuration.Background = background;

        configuration.Image = ResizeImage(existingImage, height * 0.75f);
        
        configuration.Title = existingTitle;
        configuration.TitleTextAttributesTransformer = TransformUIButtonText(existingFont, existingTitleColor);

        configuration.BaseBackgroundColor = existingBackgroundColor;
        configuration.BaseForegroundColor = existingTitleColor;

        configuration.ContentInsets = new NSDirectionalEdgeInsets(padding, padding, padding, padding);

        configuration.ImagePlacement = NSDirectionalRectEdge.Leading;

        configuration.TitleAlignment = UIButtonConfigurationTitleAlignment.Center;

        PlatformView.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;

        PlatformView.Configuration = configuration;
    }
    

    public UIImage ResizeImage(UIImage image, nfloat size)
    {
        if(OperatingSystem.IsIOSVersionAtLeast(17, 0))
        {
            var renderer = new UIGraphicsImageRenderer(
                new CoreGraphics.CGSize(size, size));

            return renderer.CreateImage(context =>
            {
                image.Draw(new CoreGraphics.CGRect(0, 0, size, size));
            });
        }
        else
        {
            UIGraphics.BeginImageContextWithOptions(new CoreGraphics.CGSize(size, size), false, 0);

            image.Draw(new CoreGraphics.CGRect(0, 0, size, size));

            var resized = UIGraphics.GetImageFromCurrentImageContext();

            UIGraphics.EndImageContext();

            return resized!;
        }
    }

    private UIConfigurationTextAttributesTransformerHandler TransformUIButtonText(UIFont existingFont, UIColor existingTitleColor) 
    {
        return new UIConfigurationTextAttributesTransformerHandler(attributes =>
        {
            var mutable = new NSMutableDictionary(attributes);

            mutable[UIStringAttributeKey.Font] = existingFont;

            if (existingTitleColor != null)
                mutable[UIStringAttributeKey.ForegroundColor] = existingTitleColor;

            return mutable;
        });
    }*/
    
    private void OnLoggedIn(object? sender, FBSDKLoginCompletedEventArgs e) => 
        VirtualView?.RaiseLoginCompleted(this, new LoggedInEventArgs(e.Result?.ToLoginResult(), e.Error?.ToLoginException()));

    private void OnLoggedOut(object? sender, EventArgs e) => VirtualView?.RaiseLogoutCompleted(this, new LoggedOutEventArgs());

    private void OnTouchDown(object? sender, EventArgs e) => VirtualView?.RaisePressedEvent(this, e);

    private void OnTouchUpOutside(object? sender, EventArgs e) => VirtualView?.RaiseReleasedEvent(this, e);

    private void OnTouchUpInside(object? sender, EventArgs e)
    {
        VirtualView?.RaiseClickedEvent(this, e);
    }
}