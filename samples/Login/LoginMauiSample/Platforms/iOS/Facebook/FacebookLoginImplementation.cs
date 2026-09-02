
using Facebook.Core;
using Foundation;

namespace LoginMauiSample;

[Preserve(AllMembers = true)]
internal sealed class FacebookLoginImplementation : NSObject, IFacebookLogin
{
    public event EventHandler<AccessTokenChangedEventArgs>? AccessTokenChanged;

    public event EventHandler<ProfileChangedEventArgs>? ProfileChanged;

	public bool AutomaticallyUpdateProfileOnAccessTokenChange 
    { 
        get => FBSDKProfile.IsUpdatedWithAccessTokenChange;
        set => FBSDKProfile.IsUpdatedWithAccessTokenChange = value; 
    }

    private bool _initialized;

    internal static void Initialize(bool automaticallyUpdateProfileOnAccessTokenChange = true)
    {
        var instance = (FacebookLoginImplementation) CrossFacebookLogin.Current;

        if (instance._initialized)
            return;

        instance.AutomaticallyUpdateProfileOnAccessTokenChange = automaticallyUpdateProfileOnAccessTokenChange;
        instance.RegisterNotifications();

        instance._initialized = true;
    }

    private void RegisterNotifications()
    {
        NSNotificationCenter.DefaultCenter.AddObserver(FBSDKAccessToken.FBSDKAccessTokenDidChangeNotification, AccessTokenDidChange);
        NSNotificationCenter.DefaultCenter.AddObserver(FBSDKProfile.ProfileDidChangeNotification, ProfileDidChange);
    }

    private void AccessTokenDidChange(NSNotification notification)
    {
        AccessTokenChanged?.Invoke(this, new AccessTokenChangedEventArgs(CurrentAccessToken));
    }

    private void ProfileDidChange(NSNotification notification)
    {
        ProfileChanged?.Invoke(this, new ProfileChangedEventArgs(CurrentProfile));
    }

    public IAccessToken? CurrentAccessToken => FBSDKAccessToken.CurrentAccessToken.ToToken();

    public void RefreshCurrentAccessToken(Action? tokenRefreshedAction) => FBSDKAccessToken.RefreshCurrentAccessTokenWithCompletion(SetCompletionAction(tokenRefreshedAction));

    public FBSDKGraphRequestCompletion SetCompletionAction(Action? tokenRefreshedAction)
    {
        return new FBSDKGraphRequestCompletion((s, r, e) =>
        {
            if(e is not null)
            {
                Console.WriteLine($"RefreshCurrentAccessToken GraphRequest Error: {e.DebugDescription}");
                return;
            }
            if(r is null)
            {
                Console.WriteLine("RefreshCurrentAccessToken GraphRequest Result Null.");
                return;
            }

            if(tokenRefreshedAction is not null)
                tokenRefreshedAction();
        });
    }

    public async Task<IProfile?> LoadCurrentProfileAsync()
    {
        var profile = await FBSDKProfile.LoadCurrentProfileAsync();
        return profile.ToProfile();
    }

    public IProfile? CurrentProfile => FBSDKProfile.CurrentProfile.ToProfile();

	public ILoginManager CreateLoginManager(DefaultAudience defaultAudience = default) =>
		new LoginManager(defaultAudience);

	public IDeviceLoginManager CreateDeviceLoginManager(string[]? permissions, bool enableSmartLogin = true) =>
		new DeviceLoginManager(permissions ?? [], enableSmartLogin);
}