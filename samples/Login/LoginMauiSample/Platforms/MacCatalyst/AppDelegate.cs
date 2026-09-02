using Foundation;
using Facebook.Core;
using UIKit;

namespace LoginMauiSample;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{	
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary? launchOptions)
    {
        FBSDKApplicationDelegate.SharedInstance.DidFinishLaunching(application, launchOptions);
        return base.FinishedLaunching(application, launchOptions);;
    }
    public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
    {
        return FBSDKApplicationDelegate.SharedInstance.OpenUrl(app, url, options);
    }
    public override bool ContinueUserActivity(UIApplication application, NSUserActivity userActivity, UIApplicationRestorationHandler completionHandler)
    {
        FBSDKApplicationDelegate.SharedInstance.Application(application, userActivity);
        return base.ContinueUserActivity(application, userActivity, completionHandler);
    }

    public override void OnActivated(UIApplication application)
    {
        FBSDKAppEvents.Shared.ActivateApp();
        base.OnActivated(application);
    }
}
