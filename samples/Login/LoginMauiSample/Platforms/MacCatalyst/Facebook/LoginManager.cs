
using Facebook.Login;
using UIKit;

namespace LoginMauiSample;

public sealed class LoginManager : ILoginManager
{
    private readonly FBSDKLoginManager _loginManager;

    public LoginManager()
    {
        _loginManager = new FBSDKLoginManager();
        defaultAudience = DefaultAudience.Friends;
    }

    public LoginManager(DefaultAudience defaultAudience)
    {
        _loginManager = new FBSDKLoginManager(defaultAudience.ToNativeDefaultAudience());
        this.defaultAudience = defaultAudience;
    }

    readonly DefaultAudience defaultAudience;

    public Task<ILoginResult> LoginAsync(LoginConfiguration configuration)
    {
        var tcs = new TaskCompletionSource<ILoginResult>();
        var viewController = GetViewController();

        _loginManager.LogIn(viewController, configuration.ToNativeConfiguration(), CreateLoginResultHandler(tcs));

        return tcs.Task;
    }    

    public Task<ILoginResult> LoginAsync(IEnumerable<string> permissions)
    {
        var tcs = new TaskCompletionSource<ILoginResult>();
        var viewController = GetViewController();

        _loginManager.LogIn(permissions?.ToArray().ToNativePermissions() ?? [], viewController, CreateLoginResultHandler(tcs));

        return tcs.Task;
    }
    public Task<ILoginResult> ReauthorizeDataAccessAsync()
    {
        var tcs = new TaskCompletionSource<ILoginResult>();
        var viewController = GetViewController();

        _loginManager.ReauthorizeDataAccess(viewController, CreateLoginResultHandler(tcs));

        return tcs.Task;
    }
    
    public void Logout()
    {
        _loginManager.LogOut();
    }

    private static UIViewController? GetViewController()
    {
		return UIApplication.SharedApplication?
			.ConnectedScenes?
			.OfType<UIWindowScene>()?
			.SelectMany(s => s.Windows)?
			.FirstOrDefault(w => w.IsKeyWindow)?
			.RootViewController;
    }

    private FBSDKLoginManagerLoginResultBlock CreateLoginResultHandler(TaskCompletionSource<ILoginResult> tcs)
    {
        return new FBSDKLoginManagerLoginResultBlock((result, error) =>
        {
            if (error != null)
            {
                tcs.TrySetException(error.ToLoginException());
                return;
            }
            if(result is not null)
            {
                tcs.TrySetResult(result.ToLoginResult());
                return;
            }
            
            tcs.TrySetException(new LoginException(LoginErrorCode.Unknown, "Facebook login completed without a result or error."));
        });
    }
}