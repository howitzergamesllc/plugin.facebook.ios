using Foundation;
using UIKit;
using Facebook.Core;

namespace ShareMauiSample;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary? launchOptions)
    {
        //FBSDKApplicationDelegate.SharedInstance.InitializeSDK();
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
        Console.WriteLine("OnActivated");
        FBSDKAppEvents.Shared.ActivateApp();
        base.OnActivated(application);
    }

    public override void OnResignActivation(UIApplication application)
    {
        Console.WriteLine("OnResignActivation");
        base.OnResignActivation(application);
    }

    public override void DidEnterBackground(UIApplication application)
    {
        Console.WriteLine("DidEnterBackground");
        base.DidEnterBackground(application);
    }

    public override void WillEnterForeground(UIApplication application)
    {
        Console.WriteLine("WillEnterForeground");
        base.WillEnterForeground(application);
    }
}
