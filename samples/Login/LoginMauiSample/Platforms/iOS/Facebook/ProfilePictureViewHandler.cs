
using CoreGraphics;
using Facebook.Core;
using Microsoft.Maui.Handlers;

namespace LoginMauiSample.Controls;

public partial class ProfilePictureViewHandler : ViewHandler<ProfilePictureView, FBSDKProfilePictureView>
{
    public static IPropertyMapper<ProfilePictureView, ProfilePictureViewHandler> PropertyMapper
        = new PropertyMapper<ProfilePictureView, ProfilePictureViewHandler>(ViewMapper)        
        {
            [nameof(ProfilePictureView.Profile)] = MapProfile,
            [nameof(ProfilePictureView.PictureMode)] = MapPictureMode,
        };

    public ProfilePictureViewHandler() : base(PropertyMapper) { }

    protected override void ConnectHandler(FBSDKProfilePictureView platformView)
    {
        base.ConnectHandler(platformView);
    }

    protected override void DisconnectHandler(FBSDKProfilePictureView platformView)
    {
        base.DisconnectHandler(platformView);
    }

    protected override FBSDKProfilePictureView CreatePlatformView()
    {
        var profilePictureView = new FBSDKProfilePictureView(CGRect.Empty);
        return profilePictureView;
    }
    
    private static void MapProfile(ProfilePictureViewHandler handler, ProfilePictureView view)
    {
        if(view.Profile is null)
            return;

        handler.PlatformView.ProfileID = view.Profile.UserId;
        handler.PlatformView.SetNeedsImageUpdate();
    }
    
    private static void MapPictureMode(ProfilePictureViewHandler handler, ProfilePictureView view)
    {
        handler.PlatformView.PictureMode = view.PictureMode.ToNativePictureMode();
        handler.PlatformView.SetNeedsImageUpdate();
    }
}