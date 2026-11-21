
using UIKit;
using Foundation;
using Facebook.Core;

namespace ShareMauiSample;

[Register("SceneDelegate")]
public class SceneDelegate : MauiUISceneDelegate
{
    public override bool OpenUrl(UIScene scene, NSSet<UIOpenUrlContext> urlContexts)
    {
        if(urlContexts.ToArray().FirstOrDefault() is not UIOpenUrlContext context)
            return base.OpenUrl(scene, urlContexts);

        var url = context.Url;
        var options = context.Options;

        var dictionary = new NSDictionary(new NSString("UIApplicationOpenURLOptionsSourceApplicationKey"), new NSString(options.SourceApplication ?? ""),
        new NSString("UIApplicationOpenURLOptionsAnnotationKey"), options.Annotation ?? null);

        return FBSDKApplicationDelegate.SharedInstance.OpenUrl(UIApplication.SharedApplication, url, dictionary);
    }
}
