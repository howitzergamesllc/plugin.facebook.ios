
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;
using CoreGraphics;

using UIKit;
using StoreKit;
using SafariServices;
using AuthenticationServices;

using Facebook.CoreBasics;

namespace Facebook.Core
{
	
	///
	/// From APIDefinitionsSwift FBSDKCoreKit-Swift.h
	/// 
	
	// @protocol FBSDKAEMReporter
	interface IFBSDKAEMReporter {}
	
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKAEMReporter
	{
		// @required +(void)enable;
		[Static, Abstract]
		[Export ("enable")]
		void Enable ();

		// @required +(void)recordAndUpdateEvent:(NSString * _Nonnull)event currency:(NSString * _Nullable)currency value:(NSNumber * _Nullable)value parameters:(id)parameters;
		[Static, Abstract]
		[Export ("recordAndUpdateEvent:currency:value:parameters:")]
		void RecordAndUpdateEvent (string @event, [NullAllowed] string currency, [NullAllowed] NSNumber value, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// @required +(void)setConversionFilteringEnabled:(id)isEnabled;
		[Static, Abstract]
		[Export ("setConversionFilteringEnabled:")]
		void SetConversionFilteringEnabled (bool isEnabled);

		// @required +(void)setCatalogMatchingEnabled:(id)isEnabled;
		[Static, Abstract]
		[Export ("setCatalogMatchingEnabled:")]
		void SetCatalogMatchingEnabled (bool isEnabled);

		// @required +(void)setAdvertiserRuleMatchInServerEnabled:(id)isEnabled;
		[Static, Abstract]
		[Export ("setAdvertiserRuleMatchInServerEnabled:")]
		void SetAdvertiserRuleMatchInServerEnabled (bool isEnabled);

		// @required +(void)handle:(NSURL * _Nullable)url;
		[Static, Abstract]
		[Export ("handle:")]
		void HandleUrl ([NullAllowed] NSUrl url);
	}

	// @interface FBSDKAppLink
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppLink : FBSDKAppLinkProtocol
	{
		// extern NS_SWIFT_NAME(AppLinkParseEventName) NSString *const FBSDKAppLinkParseEventName __attribute__((swift_name("AppLinkParseEventName")));
		[Field ("FBSDKAppLinkParseEventName", "__Internal")]
		NSString ParseEventName { get; }

		// extern NS_SWIFT_NAME(AppLinkNavigateInEventName) NSString *const FBSDKAppLinkNavigateInEventName __attribute__((swift_name("AppLinkNavigateInEventName")));
		[Field ("FBSDKAppLinkNavigateInEventName", "__Internal")]
		NSString NavigateInEventName { get; }

		// extern NS_SWIFT_NAME(AppLinkNavigateOutEventName) NSString *const FBSDKAppLinkNavigateOutEventName __attribute__((swift_name("AppLinkNavigateOutEventName")));
		[Field ("FBSDKAppLinkNavigateOutEventName", "__Internal")]
		NSString NavigateOutEventName { get; }

		// extern NS_SWIFT_NAME(AppLinkNavigateBackToReferrerEventName) NSString *const FBSDKAppLinkNavigateBackToReferrerEventName __attribute__((swift_name("AppLinkNavigateBackToReferrerEventName")));
		[Field ("FBSDKAppLinkNavigateBackToReferrerEventName", "__Internal")]
		NSString NavigateBackToReferrerEventName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkDataParameterName;
		[Field ("FBSDKAppLinkDataParameterName", "__Internal")]
		NSString DataParameterName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkUserAgentKeyName;
		[Field ("FBSDKAppLinkUserAgentKeyName", "__Internal")]
		NSString UserAgentKeyName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkVersionKeyName;
		[Field ("FBSDKAppLinkVersionKeyName", "__Internal")]
		NSString VersionKeyName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkRefererAppLink;
		[Field ("FBSDKAppLinkRefererAppLink", "__Internal")]
		NSString RefererAppLink { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkRefererAppName;
		[Field ("FBSDKAppLinkRefererAppName", "__Internal")]
		NSString RefererAppName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkRefererUrl;
		[Field ("FBSDKAppLinkRefererUrl", "__Internal")]
		NSString RefererUrl { get; }

		// -(instancetype _Nonnull)initWithSourceURL:(NSURL * _Nullable)sourceURL targets:(id)targets webURL:(NSURL * _Nullable)webURL;
		[Export ("initWithSourceURL:targets:webURL:")]
		NativeHandle Constructor ([NullAllowed] NSUrl sourceURL, FBSDKAppLinkTarget[] targets, [NullAllowed] NSUrl webURL);

		// +(id _Nonnull)appLinkWithSourceURL:(NSURL * _Nullable)sourceURL targets:(id)targets webURL:(NSURL * _Nullable)webURL __attribute__((warn_unused_result(""))) __attribute__((deprecated("
        [Obsolete("Please use designated init to instantiate an AppLink. This method will be removed in future releases.")]
		[Static]
		[Export ("appLinkWithSourceURL:targets:webURL:")]
		NSObject AppLinkWithSourceURL ([NullAllowed] NSUrl sourceURL, FBSDKAppLinkTarget[] targets, [NullAllowed] NSUrl webURL);

		// -(instancetype _Nonnull)initWithSourceURL:(NSURL * _Nullable)sourceURL targets:(id)targets webURL:(NSURL * _Nullable)webURL isBackToReferrer:(id)isBackToReferrer __attribute__((objc_designated_initializer));
		[Export ("initWithSourceURL:targets:webURL:isBackToReferrer:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSUrl sourceURL, FBSDKAppLinkTarget[] targets, [NullAllowed] NSUrl webURL, bool isBackToReferrer);
	}

	// @interface FBSDKAppLinkNavigation
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppLinkNavigation
	{
		// @property (nonatomic, strong, class) id<FBSDKAppLinkResolving> _Nonnull defaultResolver;
		[Static]
		[Export ("defaultResolver", ArgumentSemantic.Strong)]
		IFBSDKAppLinkResolving DefaultResolver { get; set; }

		// @property (readonly, nonatomic, strong) FBSDKAppLink * _Nullable appLink;
		[NullAllowed, Export ("appLink", ArgumentSemantic.Strong)]
		FBSDKAppLink AppLink { get; }

		// @property (readonly, nonatomic) int navigationType;
		[Export ("navigationType")]
		FBSDKAppLinkNavigationType NavigationType { get; }

		// -(instancetype _Nonnull)initWithAppLink:(FBSDKAppLink * _Nullable)appLink extras:(id)extras appLinkData:(id)appLinkData __attribute__((objc_designated_initializer));
		[Export ("initWithAppLink:extras:appLinkData:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] FBSDKAppLink appLink, NSDictionary<NSString, NSObject> extras, NSDictionary<NSString, NSObject> appLinkData);

		// -(instancetype _Nonnull)initWithAppLink:(FBSDKAppLink * _Nonnull)appLink extras:(id)extras appLinkData:(id)appLinkData settings:(id<FBSDKSettings> _Nonnull)settings __attribute__((deprecated("
        [Obsolete("Please use init(appLink:extras:appLinkData:) to instantiate an `AppLinkNavigation`. This method will be removed in the next major version.")]
		[Export ("initWithAppLink:extras:appLinkData:settings:")]
		NativeHandle Constructor (FBSDKAppLink appLink, NSDictionary<NSString, NSObject> extras, NSDictionary<NSString, NSObject> appLinkData, IFBSDKSettingsProtocol settings);

		// +(FBSDKAppLinkNavigation * _Nonnull)navigationWithAppLink:(FBSDKAppLink * _Nullable)appLink extras:(id)extras appLinkData:(id)appLinkData settings:(id<FBSDKSettings> _Nonnull)settings __attribute__((warn_unused_result(""))) __attribute__((deprecated("
        [Obsolete("Please use designated init to instantiate an AppLinkNavigation. This method will be removed in future releases.")]
		[Static]
		[Export ("navigationWithAppLink:extras:appLinkData:settings:")]
		FBSDKAppLinkNavigation NavigationWithAppLink ([NullAllowed] FBSDKAppLink appLink, NSObject extras, NSObject appLinkData, IFBSDKSettingsProtocol settings);

		// +(id)callbackAppLinkDataForAppWithName:(NSString * _Nonnull)appName url:(NSString * _Nonnull)url __attribute__((warn_unused_result("")));
		[Static]
		[Export ("callbackAppLinkDataForAppWithName:url:")]
		NSDictionary<NSString, NSDictionary<NSString, NSString>> CallbackAppLinkData (string appName, string url);

		// -(void)navigate:(id)handler;
		[Export ("navigate:")]
		void Navigate (FBSDKAppLinkNavigationBlock handler);

		// +(void)resolveAppLink:(NSURL * _Nonnull)destination handler:(id)handler;
		[Static]
		[Export ("resolveAppLink:handler:")]
		void ResolveAppLink (NSUrl destination, FBSDKAppLinkNavigationBlock handler);

		// +(void)resolveAppLink:(NSURL * _Nonnull)destination resolver:(id<FBSDKAppLinkResolving> _Nonnull)resolver handler:(id)handler;
		[Static]
		[Export ("resolveAppLink:resolver:handler:")]
		void ResolveAppLink (NSUrl destination, IFBSDKAppLinkResolving resolver, FBSDKAppLinkNavigationBlock handler);

		// +(void)navigateToAppLink:(FBSDKAppLink * _Nonnull)appLink handler:(id)handler;
		[Static]
		[Export ("navigateToAppLink:handler:")]
		void NavigateToAppLink (FBSDKAppLink appLink, FBSDKAppLinkNavigationBlock handler);

		// +(id)navigationTypeForLink:(FBSDKAppLink * _Nonnull)appLink __attribute__((warn_unused_result("")));
		[Static]
		[Export ("navigationTypeForLink:")]
		FBSDKAppLinkNavigationBlock NavigationTypeForLink (FBSDKAppLink appLink);

		// +(void)navigateToURL:(NSURL * _Nonnull)destination handler:(id)handler;
		[Static]
		[Export ("navigateToURL:handler:")]
		void NavigateToURL (NSUrl destination, FBSDKAppLinkNavigationBlock handler);

		// +(void)navigateToURL:(NSURL * _Nonnull)destination resolver:(id<FBSDKAppLinkResolving> _Nonnull)resolver handler:(id)handler;
		[Static]
		[Export ("navigateToURL:resolver:handler:")]
		void NavigateToURL (NSUrl destination, IFBSDKAppLinkResolving resolver, FBSDKAppLinkNavigationBlock handler);
	}

	// @interface FBSDKAppLinkResolver <FBSDKAppLinkResolving>
	[BaseType(typeof(NSObject))]
	interface FBSDKAppLinkResolver : FBSDKAppLinkResolving
	{
		// -(void)appLinkFromURL:(NSURL * _Nonnull)url handler:(id)handler;
		[Export ("appLinkFromURL:handler:")]
		void AppLinkFromURL (NSUrl url, FBSDKAppLinksBlock handler);

		// -(void)appLinksFrom:(id)urls handler:(id)handler __attribute__((availability(ios_app_extension, unavailable)));
		[Export ("appLinksFrom:handler:")]
		void AppLinksFrom (NSArray<NSUrl> urls, FBSDKAppLinksBlock handler);
	}

	// @interface FBSDKAppLinkTarget <FBSDKAppLinkTarget>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppLinkTarget : FBSDKAppLinkTargetProtocol
	{
		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url appStoreId:(NSString * _Nullable)appStoreId appName:(NSString * _Nonnull)appName __attribute__((objc_designated_initializer));
		[Export ("initWithURL:appStoreId:appName:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSUrl url, [NullAllowed] string appStoreId, string appName);

		// +(FBSDKAppLinkTarget * _Nonnull)appLinkTargetWithURL:(NSURL * _Nullable)url appStoreId:(NSString * _Nullable)appStoreId appName:(NSString * _Nonnull)appName __attribute__((warn_unused_result(""))) __attribute__((deprecated("
        [Obsolete("Please use designated init to instantiate an AppLinkTarget. This method will be removed in future releases.")]
		[Static]
		[Export ("appLinkTargetWithURL:appStoreId:appName:")]
		FBSDKAppLinkTarget AppLinkTargetWithURL ([NullAllowed] NSUrl url, [NullAllowed] string appStoreId, string appName);
	}

	// @interface FBSDKApplicationDelegate
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKApplicationDelegate
	{
		// @property (readonly, nonatomic, strong, class) FBSDKApplicationDelegate * _Nonnull sharedInstance;
		[Static]
		[Export ("sharedInstance", ArgumentSemantic.Strong)]
		FBSDKApplicationDelegate SharedInstance { get; }

		// -(void)initializeSDK;
		[Export ("initializeSDK")]
		void InitializeSDK ();

		// -(id)application:(UIApplication * _Nonnull)application continueUserActivity:(NSUserActivity * _Nonnull)userActivity;
		[Export ("application:continueUserActivity:")]
		bool Application (UIApplication application, NSUserActivity userActivity);

		// -(id)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url options:(id)options;
		[Export ("application:openURL:options:")]
		bool OpenUrl (UIApplication application, NSUrl url, NSDictionary options);

		// -(id)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation;
		[Export ("application:openURL:sourceApplication:annotation:")]
		bool OpenUrl (UIApplication application, NSUrl url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)application:(UIApplication * _Nonnull)application didFinishLaunchingWithOptions:(id)launchOptions;
		[Export ("application:didFinishLaunchingWithOptions:")]
		bool DidFinishLaunching (UIApplication application, [NullAllowed] NSDictionary launchOptions);

		// -(void)addObserver:(id<FBSDKApplicationObserving> _Nonnull)observer;
		[Export ("addObserver:")]
		void AddApplicationObserver (IFBSDKApplicationObserving observer);

		// -(void)removeObserver:(id<FBSDKApplicationObserving> _Nonnull)observer;
		[Export ("removeObserver:")]
		void RemoveApplicationObserver (IFBSDKApplicationObserving observer);
	}

	// @interface FBSDKAuthenticationTokenClaims
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAuthenticationTokenClaims
	{
		// -(instancetype _Nullable)initWithEncodedClaims:(NSString * _Nonnull)encodedClaims nonce:(NSString * _Nonnull)expectedNonce;
		[Export ("initWithEncodedClaims:nonce:")]
		NativeHandle Constructor (string encodedClaims, string expectedNonce);
	}

	// @protocol FBSDKCAPIReporter
	interface IFBSDKCAPIReporter {}
	
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKCAPIReporter
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(void)configureWithFactory:(id<FBSDKGraphRequestFactory> _Nonnull)factory settings:(id<FBSDKSettings> _Nonnull)settings;
		[Abstract]
		[Export ("configureWithFactory:settings:")]
		void Configure (IFBSDKGraphRequestFactoryProtocol factory, IFBSDKSettingsProtocol settings);

		// @required -(void)recordEvent:(id)parameters;
		[Abstract]
		[Export ("recordEvent:")]
		void RecordEvent (NSDictionary<NSString, NSObject> parameters);
	}

	// @interface FBSDKIcon
	[BaseType(typeof(NSObject))]
	interface FBSDKIcon
	{
		// -(id)pathWith:(id)size __attribute__((warn_unused_result("")));
		[Export ("pathWith:")]
		CGPath PathWith (CGSize size);

		// -(UIImage * _Nullable)imageWithSize:(id)size __attribute__((warn_unused_result("")));
		[Export ("imageWithSize:")]
		[return: NullAllowed]
		UIImage ImageWithSize (CGSize size);

		// -(UIImage * _Nullable)imageWithSize:(id)size color:(UIColor * _Nonnull)color __attribute__((warn_unused_result("")));
		[Export ("imageWithSize:color:")]
		[return: NullAllowed]
		UIImage ImageWithSize (CGSize size, UIColor color);

		// -(UIImage * _Nullable)imageWithSize:(id)size scale:(id)scale color:(UIColor * _Nonnull)color __attribute__((warn_unused_result("")));
		[Export ("imageWithSize:scale:color:")]
		[return: NullAllowed]
		UIImage ImageWithSize (CGSize size, double scale, UIColor color);
	}

	// @interface FBSDKProfilePictureView
	[BaseType(typeof(UIView))]
	interface FBSDKProfilePictureView
	{
		// @property (nonatomic) enum FBSDKProfilePictureMode pictureMode;
		[Export ("pictureMode", ArgumentSemantic.Assign)]
		FBSDKProfilePictureMode PictureMode { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull profileID;
		[Export ("profileID")]
		string ProfileID { get; set; }

		// -(instancetype _Nonnull)initWith:(id)frame profile:(FBSDKProfile * _Nullable)profile __attribute__((objc_designated_initializer));
		[Export ("initWith:profile:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame, [NullAllowed] FBSDKProfile profile);

		// -(instancetype _Nonnull)initWithProfile:(FBSDKProfile * _Nullable)profile;
		[Export ("initWithProfile:")]
		NativeHandle Constructor ([NullAllowed] FBSDKProfile profile);

		// - (nonnull instancetype)initWithFrame:(CGRect)frame OBJC_DESIGNATED_INITIALIZER;
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(void)setNeedsImageUpdate;
		[Export ("setNeedsImageUpdate")]
		void SetNeedsImageUpdate ();
	}

	// @protocol FBSDKMACARuleMatching
	interface IFBSDKMACARuleMatching {}
	
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKMACARuleMatching
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(id)processParameters:(id)params event:(NSString * _Nullable)event __attribute__((warn_unused_result("")));
		[Abstract]
		[NullAllowed, Export ("processParameters:event:")]
		NSDictionary ProcessParameters ([NullAllowed] NSDictionary @params, [NullAllowed] string @event);
	}

	// @interface FBSDKProfile
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKProfile : FBSDKProfileProviding
	{
		// extern NS_SWIFT_NAME(ProfileDidChange) const NSNotificationName FBSDKProfileDidChangeNotification __attribute__((swift_name("ProfileDidChange")));
		[Field ("FBSDKProfileDidChangeNotification", "__Internal")]
		NSString ProfileDidChangeNotification { get; }

		// extern NS_SWIFT_NAME(ProfileChangeOldKey) NSString *const FBSDKProfileChangeOldKey __attribute__((swift_name("ProfileChangeOldKey")));
		[Field ("FBSDKProfileChangeOldKey", "__Internal")]
		NSString ProfileChangeOldKey { get; }

		// extern NS_SWIFT_NAME(ProfileChangeNewKey) NSString *const FBSDKProfileChangeNewKey __attribute__((swift_name("ProfileChangeNewKey")));
		[Field ("FBSDKProfileChangeNewKey", "__Internal")]
		NSString ProfileChangeNewKey { get; }

		// @property (readonly, copy, nonatomic) FBSDKUserIdentifier userID;
		[Export ("userID", ArgumentSemantic.Copy)]
		string UserID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName")]
		string FirstName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable middleName;
		[NullAllowed, Export ("middleName")]
		string MiddleName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName")]
		string LastName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable linkURL;
		[NullAllowed, Export ("linkURL", ArgumentSemantic.Copy)]
		NSUrl LinkURL { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull refreshDate;
		[Export ("refreshDate", ArgumentSemantic.Copy)]
		NSDate RefreshDate { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable imageURL;
		[NullAllowed, Export ("imageURL", ArgumentSemantic.Copy)]
		NSUrl ImageURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }
		
		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable friendIDs;
		[NullAllowed, Export ("friendIDs", ArgumentSemantic.Copy)]
		string[] FriendIDs { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable birthday;
		[NullAllowed, Export ("birthday", ArgumentSemantic.Copy)]
		NSDate Birthday { get; }

		// @property (readonly, nonatomic, strong) FBSDKUserAgeRange * _Nullable ageRange;
		[NullAllowed, Export ("ageRange", ArgumentSemantic.Strong)]
		FBSDKUserAgeRange AgeRange { get; }

		// @property (readonly, nonatomic, strong) FBSDKLocation * _Nullable hometown;
		[NullAllowed, Export ("hometown", ArgumentSemantic.Strong)]
		FBSDKLocation Hometown { get; }

		// @property (readonly, nonatomic, strong) FBSDKLocation * _Nullable location;
		[NullAllowed, Export ("location", ArgumentSemantic.Strong)]
		FBSDKLocation Location { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable gender;
		[NullAllowed, Export ("gender")]
		string Gender { get; }

		// @property (readonly, copy, nonatomic) NSSet<NSString *> * _Nullable permissions;
		[NullAllowed, Export ("permissions", ArgumentSemantic.Copy)]
		NSSet<NSString> Permissions { get; }

		// @property (readonly, nonatomic) int isLimited;
		[Export ("isLimited")]
		bool IsLimited { get; }

		// @property (nonatomic, class) int isUpdatedWithAccessTokenChange;
		[Static]
		[Export ("isUpdatedWithAccessTokenChange")]
		bool IsUpdatedWithAccessTokenChange { get; set; }

		// -(instancetype _Nonnull)initWithUserID:(FBSDKUserIdentifier)userID firstName:(NSString * _Nullable)firstName middleName:(NSString * _Nullable)middleName lastName:(NSString * _Nullable)lastName name:(NSString * _Nullable)name linkURL:(NSURL * _Nullable)linkURL refreshDate:(NSDate * _Nullable)refreshDate permissions:(id)permissions;
		[Export ("initWithUserID:firstName:middleName:lastName:name:linkURL:refreshDate:permissions:")]
		NativeHandle Constructor (string userID, [NullAllowed] string firstName, [NullAllowed] string middleName, [NullAllowed] string lastName, [NullAllowed] string name, [NullAllowed] NSUrl linkURL, [NullAllowed] NSDate refreshDate, [NullAllowed] NSSet<NSString> permissions);

		// -(instancetype _Nonnull)initWithUserID:(FBSDKUserIdentifier)userID firstName:(NSString * _Nullable)firstName middleName:(NSString * _Nullable)middleName lastName:(NSString * _Nullable)lastName name:(NSString * _Nullable)name linkURL:(NSURL * _Nullable)linkURL refreshDate:(NSDate * _Nullable)refreshDate imageURL:(NSURL * _Nullable)imageURL email:(NSString * _Nullable)email friendIDs:(id)friendIDs birthday:(NSDate * _Nullable)birthday ageRange:(FBSDKUserAgeRange * _Nullable)ageRange hometown:(FBSDKLocation * _Nullable)hometown location:(FBSDKLocation * _Nullable)location gender:(NSString * _Nullable)gender permissions:(id)permissions;
		[Export ("initWithUserID:firstName:middleName:lastName:name:linkURL:refreshDate:imageURL:email:friendIDs:birthday:ageRange:hometown:location:gender:permissions:")]
		NativeHandle Constructor (string userID, [NullAllowed] string firstName, [NullAllowed] string middleName, [NullAllowed] string lastName, [NullAllowed] string name, [NullAllowed] NSUrl linkURL, [NullAllowed] NSDate refreshDate, [NullAllowed] NSUrl imageURL, [NullAllowed] string email, [NullAllowed] string[] friendIDs, [NullAllowed] NSDate birthday, [NullAllowed] FBSDKUserAgeRange ageRange, [NullAllowed] FBSDKLocation hometown, [NullAllowed] FBSDKLocation location, [NullAllowed] string gender, [NullAllowed] NSSet<NSString> permissions);

		// -(instancetype _Nonnull)initWithUserID:(FBSDKUserIdentifier)userID firstName:(NSString * _Nullable)firstName middleName:(NSString * _Nullable)middleName lastName:(NSString * _Nullable)lastName name:(NSString * _Nullable)name linkURL:(NSURL * _Nullable)linkURL refreshDate:(NSDate * _Nullable)refreshDate imageURL:(NSURL * _Nullable)imageURL email:(NSString * _Nullable)email friendIDs:(id)friendIDs birthday:(NSDate * _Nullable)birthday ageRange:(FBSDKUserAgeRange * _Nullable)ageRange hometown:(FBSDKLocation * _Nullable)hometown location:(FBSDKLocation * _Nullable)location gender:(NSString * _Nullable)gender isLimited:(id)isLimited permissions:(id)permissions __attribute__((objc_designated_initializer));
		[Export ("initWithUserID:firstName:middleName:lastName:name:linkURL:refreshDate:imageURL:email:friendIDs:birthday:ageRange:hometown:location:gender:isLimited:permissions:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string userID, [NullAllowed] string firstName, [NullAllowed] string middleName, [NullAllowed] string lastName, [NullAllowed] string name, [NullAllowed] NSUrl linkURL, [NullAllowed] NSDate refreshDate, [NullAllowed] NSUrl imageURL, [NullAllowed] string email, [NullAllowed] string[] friendIDs, [NullAllowed] NSDate birthday, [NullAllowed] FBSDKUserAgeRange ageRange, [NullAllowed] FBSDKLocation hometown, [NullAllowed] FBSDKLocation location, [NullAllowed] string gender, bool isLimited, [NullAllowed] NSSet<NSString> permissions);

		// +(void)enableUpdatesOnAccessTokenChange:(id)enabled __attribute__((deprecated("This method is deprecated and will be removed in the next major release. Use `isUpdatedWithAccessTokenChange` instead.")));
		[Static]
		[Export ("enableUpdatesOnAccessTokenChange:")]
		void EnableUpdatesOnAccessTokenChange (bool enabled);

		///
		/// FBSDKProfile_Extension
		/// 
		
		// -(NSURL * _Nullable)imageURLForPictureMode:(enum FBSDKProfilePictureMode)pictureMode size:(id)size __attribute__((warn_unused_result("")));
		[Export ("imageURLForPictureMode:size:")]
		[return: NullAllowed]
		NSUrl GetImageURL (FBSDKProfilePictureMode pictureMode, CGSize size);

		// @property (readonly, nonatomic, class) int supportsSecureCoding;
		[Static]
		[Export ("supportsSecureCoding")]
		bool SupportsSecureCoding { get; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder;
		[Export ("initWithCoder:")]
		NativeHandle Constructor (NSCoder decoder);

		// -(void)encodeWithCoder:(NSCoder * _Nonnull)encoder;
		[Export ("encodeWithCoder:")]
		void EncodeWithCoder (NSCoder encoder);

		// +(void)loadCurrentProfileWithCompletion:(id)completion;
		[Static]
		[Async]
		[Export ("loadCurrentProfileWithCompletion:")]
		void LoadCurrentProfile (FBSDKProfileBlock completion);
	}
	
	// @protocol FBSDKProfileProviding
	interface IFBSDKProfileProviding {}
	
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKProfileProviding
	{
		// @required @property (nonatomic, strong, class) FBSDKProfile * _Nullable currentProfile;
		[Static, Abstract]
		[NullAllowed, Export ("currentProfile", ArgumentSemantic.Strong)]
		FBSDKProfile CurrentProfile { get; set; }

		// @required +(FBSDKProfile * _Nullable)fetchCachedProfile __attribute__((warn_unused_result("")));
		[Static, Abstract]
		[NullAllowed, Export ("fetchCachedProfile")]
		FBSDKProfile FetchCachedProfile ();
	}

	// @interface FBSDKProtectedModeManager
	[BaseType(typeof(NSObject))]
	interface FBSDKProtectedModeManager
	{
		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(id)processParameters:(id)parameters eventName:(id)eventName __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("processParameters:eventName:")]
		NSDictionary<NSString, NSObject> ProcessParameters ([NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] string eventName);

		// +(id)isProtectedModeAppliedWithParameters:(id)parameters __attribute__((warn_unused_result("")));
		[Static]
		[Export ("isProtectedModeAppliedWithParameters:")]
		bool IsProtectedMode ([NullAllowed] NSDictionary<NSString, NSObject> parameters);
	}

	// @interface ServerConfigurationProvider
	interface ServerConfigurationProvider
	{
	}

	// @protocol FBSDKSettings
	interface IFBSDKSettingsProtocol {}
	
	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKSettingsProtocol
	{
		// @required @property (copy, nonatomic) NSString * _Nullable appID;
		[Abstract]
		[NullAllowed, Export ("appID")]
		string AppID { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable clientToken;
		[Abstract]
		[NullAllowed, Export ("clientToken")]
		string ClientToken { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable userAgentSuffix;
		[Abstract]
		[NullAllowed, Export ("userAgentSuffix")]
		string UserAgentSuffix { get; set; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull sdkVersion;
		[Abstract]
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// @required @property (copy, nonatomic) NSString * _Nullable displayName;
		[Abstract]
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable facebookDomainPart;
		[Abstract]
		[NullAllowed, Export ("facebookDomainPart")]
		string FacebookDomainPart { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable appURLSchemeSuffix;
		[Abstract]
		[NullAllowed, Export ("appURLSchemeSuffix")]
		string AppURLSchemeSuffix { get; set; }

		// @required @property (readonly, nonatomic) int isDataProcessingRestricted;
		[Abstract]
		[Export ("isDataProcessingRestricted")]
		bool IsDataProcessingRestricted { get; }

		// @required @property (readonly, nonatomic) int isAutoLogAppEventsEnabled;
		[Abstract]
		[Export ("isAutoLogAppEventsEnabled")]
		bool IsAutoLogAppEventsEnabled { get; }

		// @required @property (nonatomic) int codelessDebugLogEnabled __attribute__((deprecated("
        [Obsolete("This property is deprecated and will be removed in the next major release. Use `isCodelessDebugLogEnabled` instead.")]
		[Abstract]
		[Export ("codelessDebugLogEnabled")]
		bool CodelessDebugLogEnabled { get; set; }

		// @required @property (nonatomic) int isCodelessDebugLogEnabled;
		[Abstract]
		[Export ("isCodelessDebugLogEnabled")]
		bool IsCodelessDebugLogEnabled { get; set; }

		// @required @property (nonatomic) int advertiserIDCollectionEnabled __attribute__((deprecated("
        [Obsolete("This property is deprecated and will be removed in the next major release. Use `isAdvertiserIDCollectionEnabled` instead.")]
		[Abstract]
		[Export ("advertiserIDCollectionEnabled")]
		bool AdvertiserIDCollectionEnabled { get; set; }

		// @required @property (nonatomic) int isAdvertiserIDCollectionEnabled;
		[Abstract]
		[Export ("isAdvertiserIDCollectionEnabled")]
		bool IsAdvertiserIDCollectionEnabled { get; set; }

		// @required @property (readonly, nonatomic) int isSetATETimeExceedsInstallTime __attribute__((deprecated("
        [Obsolete("This property is deprecated and will be removed in the next major release. Use `isATETimeSufficientlyDelayed` instead.")]
		[Abstract]
		[Export ("isSetATETimeExceedsInstallTime")]
		bool IsSetATETimeExceedsInstallTime { get; }

		// @required @property (readonly, nonatomic) int isATETimeSufficientlyDelayed;
		[Abstract]
		[Export ("isATETimeSufficientlyDelayed")]
		bool IsATETimeSufficientlyDelayed { get; }

		// @required @property (readonly, nonatomic) int isSKAdNetworkReportEnabled;
		[Abstract]
		[Export ("isSKAdNetworkReportEnabled")]
		bool IsSKAdNetworkReportEnabled { get; }

		// @required @property (readonly, nonatomic) int advertisingTrackingStatus;
		[Abstract]
		[Export ("advertisingTrackingStatus")]
		FBSDKAdvertisingTrackingStatus AdvertisingTrackingStatus { get; }

		// @required @property (readonly, copy, nonatomic) NSDate * _Nullable installTimestamp;
		[Abstract]
		[NullAllowed, Export ("installTimestamp", ArgumentSemantic.Copy)]
		NSDate InstallTimestamp { get; }

		// @required @property (readonly, copy, nonatomic) NSDate * _Nullable advertiserTrackingEnabledTimestamp;
		[Abstract]
		[NullAllowed, Export ("advertiserTrackingEnabledTimestamp", ArgumentSemantic.Copy)]
		NSDate AdvertiserTrackingEnabledTimestamp { get; }

		// @required @property (nonatomic) int isEventDataUsageLimited;
		[Abstract]
		[Export ("isEventDataUsageLimited")]
		bool IsEventDataUsageLimited { get; set; }

		// @required @property (nonatomic) int shouldUseTokenOptimizations;
		[Abstract]
		[Export ("shouldUseTokenOptimizations")]
		bool ShouldUseTokenOptimizations { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nonnull graphAPIVersion;
		[Abstract]
		[Export ("graphAPIVersion")]
		string GraphAPIVersion { get; set; }

		// @required @property (nonatomic) int isGraphErrorRecoveryEnabled;
		[Abstract]
		[Export ("isGraphErrorRecoveryEnabled")]
		bool IsGraphErrorRecoveryEnabled { get; set; }

		// @required @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("\n      This property is deprecated and will be removed in the next major release.       Use `graphAPIDebugParameterValue` instead.\n      ") NSString * graphAPIDebugParamValue __attribute__((deprecated("
        [Obsolete("This property is deprecated and will be removed in the next major release. Use `graphAPIDebugParameterValue` instead.")]
		[Abstract]
		[Export ("graphAPIDebugParamValue")]
		string GraphAPIDebugParamValue { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable graphAPIDebugParameterValue;
		[Abstract]
		[NullAllowed, Export ("graphAPIDebugParameterValue")]
		string GraphAPIDebugParameterValue { get; }

		// @required @property (nonatomic) int advertiserTrackingEnabled __attribute__((deprecated("
        [Obsolete("This property is deprecated and will be removed in the next major release. Use `isAdvertiserTrackingEnabled` instead.")]
		[Abstract]
		[Export ("advertiserTrackingEnabled")]
		bool AdvertiserTrackingEnabled { get; set; }

		// @required @property (nonatomic) int isAdvertiserTrackingEnabled;
		[Abstract]
		[Export ("isAdvertiserTrackingEnabled")]
		bool IsAdvertiserTrackingEnabled { get; set; }

		// @required @property (nonatomic) int shouldUseCachedValuesForExpensiveMetadata;
		[Abstract]
		[Export ("shouldUseCachedValuesForExpensiveMetadata")]
		bool ShouldUseCachedValuesForExpensiveMetadata { get; set; }

		// @required @property (nonatomic) int isDomainErrorEnabled;
		[Abstract]
		[Export ("isDomainErrorEnabled")]
		bool IsDomainErrorEnabled { get; set; }

		// @required @property (nonatomic) NSTimeInterval limitedLoginAutoRefreshInterval;
		[Abstract]
		[Export ("limitedLoginAutoRefreshInterval")]
		double LimitedLoginAutoRefreshInterval { get; set; }

		// @required - (void)setDataProcessingOptions:(NSArray<NSString *> * _Nullable)options;
		[Abstract]
		[Export ("setDataProcessingOptions:")]
		void SetDataProcessingOptions ([NullAllowed] string[] options);

		// @required - (void)setDataProcessingOptions:(NSArray<NSString *> * _Nullable)options country:(int32_t)country state:(int32_t)state;
		[Abstract]
		[Export ("setDataProcessingOptions:country:state:")]
		void SetDataProcessingOptions ([NullAllowed] string[] options, int country, int state);

		// @required - (BOOL)isLoggingBehaviorEnabled:(FBSDKLoggingBehavior _Nonnull)loggingBehavior SWIFT_WARN_UNUSED_RESULT;
		[Abstract]
		[Export ("isLoggingBehaviorEnabled:")]
		bool IsLoggingBehaviorEnabled (string loggingBehavior);
	}

	// @interface FBSDKSettings : NSObject <FBSDKSettingsLogging, FBSDKSettings, FBSDKClientTokenProviding>
	[BaseType(typeof(NSObject))]
	interface FBSDKSettings : FBSDKSettingsLogging, FBSDKSettingsProtocol, FBSDKClientTokenProviding
	{
		// @property (readonly, nonatomic, strong, class) FBSDKSettings * _Nonnull sharedSettings;
		[Static]
		[Export ("sharedSettings", ArgumentSemantic.Strong)]
		FBSDKSettings SharedSettings { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull defaultGraphAPIVersion;
		[Export ("defaultGraphAPIVersion")]
		string DefaultGraphAPIVersion { get; }

		// @property (nonatomic) int JPEGCompressionQuality;
		[Export ("JPEGCompressionQuality")]
		double JPEGCompressionQuality { get; set; }

		// -(void)enableLoggingBehavior:(id)loggingBehavior;
		[Export ("enableLoggingBehavior:")]
		void EnableLoggingBehavior (string loggingBehavior);

		// -(void)disableLoggingBehavior:(id)loggingBehavior;
		[Export ("disableLoggingBehavior:")]
		void DisableLoggingBehavior (string loggingBehavior);

		// @property (nonatomic, strong) NSNumber * _Nullable addToMessagingCustomerBaseForWhatsApp;
		[NullAllowed, Export ("addToMessagingCustomerBaseForWhatsApp", ArgumentSemantic.Strong)]
		NSNumber AddToMessagingCustomerBaseForWhatsApp { get; set; }
	}

	// @interface FBSDKShimGraphRequestInterceptor
	[BaseType(typeof(NSObject))]
	interface FBSDKShimGraphRequestInterceptor
	{
		// @property (readonly, nonatomic, strong, class) FBSDKShimGraphRequestInterceptor * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKShimGraphRequestInterceptor Shared { get; }

		// -(id)shouldInterceptRequest:(NSURLRequest * _Nonnull)request __attribute__((warn_unused_result("")));
		[Export ("shouldInterceptRequest:")]
		bool ShouldInterceptRequest (NSUrlRequest request);

		// -(void)executeWithRequest:(NSURLRequest * _Nonnull)request completionHandler:(id)completionHandler;
		[Export ("executeWithRequest:completionHandler:")]
		void ExecuteWithRequest (NSUrlRequest request, FBSDKURLSessionTaskBlock completionHandler);
		
		///
		/// FBSDKSettings_Extension
		/// 
		
		// -(void)recordInstall;
		[Export ("recordInstall")]
		void RecordInstall ();

		// -(void)logIfSDKSettingsChanged;
		[Export ("logIfSDKSettingsChanged")]
		void LogIfSDKSettingsChanged ();
	}

	// @interface FBSDKBridgeAPIProtocolNativeV1
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKBridgeAPIProtocolNativeV1
	{
		// -(instancetype _Nonnull)initWithAppScheme:(NSString * _Nullable)appScheme;
		[Export ("initWithAppScheme:")]
		NativeHandle Constructor ([NullAllowed] string appScheme);

		// -(instancetype _Nonnull)initWithAppScheme:(NSString * _Nullable)appScheme pasteboard:(id<FBSDKPasteboard> _Nullable)pasteboard dataLengthThreshold:(id)dataLengthThreshold includeAppIcon:(id)shouldIncludeAppIcon __attribute__((objc_designated_initializer));
		[Export ("initWithAppScheme:pasteboard:dataLengthThreshold:includeAppIcon:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string appScheme, [NullAllowed] IFBSDKPasteboard pasteboard, nuint dataLengthThreshold, bool shouldIncludeAppIcon);

		// -(NSURL * _Nullable)requestURLWithActionID:(NSString * _Nonnull)actionID scheme:(NSString * _Nonnull)scheme methodName:(NSString * _Nonnull)methodName parameters:(id)parameters error:(id)error __attribute__((warn_unused_result("")));
		[Export ("requestURLWithActionID:scheme:methodName:parameters:error:")]
		[return: NullAllowed]
		NSUrl RequestUrl (string actionID, string scheme, string methodName, NSDictionary<NSString, NSObject> parameters, NSError error);

		// -(id)responseParametersForActionID:(NSString * _Nonnull)actionID queryParameters:(id)queryParameters cancelled:(id)cancelledRef error:(id)error __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("responseParametersForActionID:queryParameters:cancelled:error:")]
		NSDictionary<NSString, NSObject> ResponseParameters(string actionID, NSDictionary<NSString, NSObject> queryParameters, bool cancelledRef, [NullAllowed] NSError error);
	}

	// @interface FBSDKBridgeAPIRequestFactory
	[BaseType(typeof(NSObject))]
	interface FBSDKBridgeAPIRequestFactory
	{
		// -(id<FBSDKBridgeAPIRequest> _Nullable)bridgeAPIRequestWithProtocolType:(id)protocolType scheme:(NSString * _Nonnull)scheme methodName:(NSString * _Nullable)methodName parameters:(id)parameters userInfo:(id)userInfo __attribute__((warn_unused_result("")));
		[Export ("bridgeAPIRequestWithProtocolType:scheme:methodName:parameters:userInfo:")]
		[return: NullAllowed]
		IFBSDKBridgeAPIRequestProtocol BridgeAPIRequest (FBSDKBridgeAPIProtocolType protocolType, string scheme, [NullAllowed] string methodName, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] NSDictionary<NSString, NSObject> userInfo);
	}

	// @interface FBSDKDialogConfigurationMapBuilder
	[BaseType(typeof(NSObject))]
	interface FBSDKDialogConfigurationMapBuilder
	{
		// -(id)buildDialogConfigurationMapWithRawConfigurations:(id)rawConfigurations __attribute__((warn_unused_result("")));
		[Export ("buildDialogConfigurationMapWithRawConfigurations:")]
		NSDictionary<NSString, FBSDKDialogConfiguration> BuildDialogConfigurationMapWithRawConfigurations (NSArray<NSDictionary<NSString, NSObject>> rawConfigurations);
	}

	// @interface FBSDKErrorFactory
	[BaseType(typeof(NSObject))]
	interface FBSDKErrorFactory
	{
		// -(id)errorWithCode:(id)code userInfo:(id)userInfo message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("errorWithCode:userInfo:message:underlyingError:")]
		NSError ErrorWithCode (int code, [NullAllowed] NSDictionary<NSString, NSObject> userInfo, [NullAllowed] string message, NSError underlyingError);

		// -(id)errorWithDomain:(NSString * _Nonnull)domain code:(id)code userInfo:(id)userInfo message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("errorWithDomain:code:userInfo:message:underlyingError:")]
		NSError ErrorWithDomain (string domain, int code, [NullAllowed] NSDictionary<NSString, NSObject> userInfo, [NullAllowed] string message, NSError underlyingError);

		// -(id)invalidArgumentErrorWithName:(NSString * _Nonnull)name value:(id _Nullable)value message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("invalidArgumentErrorWithName:value:message:underlyingError:")]
		NSError InvalidArgumentErrorWithName (string name, [NullAllowed] NSDictionary<NSString, NSObject> value, [NullAllowed] string message, NSError underlyingError);

		// -(id)invalidArgumentErrorWithDomain:(NSString * _Nonnull)domain name:(NSString * _Nonnull)name value:(id _Nullable)value message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("invalidArgumentErrorWithDomain:name:value:message:underlyingError:")]
		NSError InvalidArgumentErrorWithDomain (string domain, string name, [NullAllowed] NSDictionary<NSString, NSObject> value, [NullAllowed] string message, NSError underlyingError);

		// -(id)requiredArgumentErrorWithName:(NSString * _Nonnull)name message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("requiredArgumentErrorWithName:message:underlyingError:")]
		NSError RequiredArgumentErrorWithName (string name, [NullAllowed] string message, NSError underlyingError);

		// -(id)requiredArgumentErrorWithDomain:(NSString * _Nonnull)domain name:(NSString * _Nonnull)name message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("requiredArgumentErrorWithDomain:name:message:underlyingError:")]
		NSError RequiredArgumentErrorWithDomain (string domain, string name, [NullAllowed] string message, NSError underlyingError);

		// -(id)unknownErrorWithMessage:(NSString * _Nullable)message userInfo:(id)userInfo __attribute__((warn_unused_result("")));
		[Export ("unknownErrorWithMessage:userInfo:")]
		NSError UnknownErrorWithMessage ([NullAllowed] string message, [NullAllowed] NSDictionary<NSString, NSObject> userInfo);
	}

	// @interface FBSDKCloseIcon
	[BaseType(typeof(NSObject))]
	interface FBSDKCloseIcon
	{
		// -(UIImage * _Nullable)imageWithSize:(id)size __attribute__((warn_unused_result("")));
		[Export ("imageWithSize:")]
		[return: NullAllowed]
		UIImage ImageWithSize (CGSize size);
	}

	// @interface FBSDKLogo : FBSDKIcon
	[BaseType (typeof(FBSDKIcon))]
	interface FBSDKLogo
	{
	}

	// @interface FBSDKFeatureManager
	[BaseType(typeof(NSObject))]
	interface FBSDKFeatureManager
	{
		// @property (readonly, nonatomic, strong, class) FBSDKFeatureManager * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKFeatureManager Shared { get; }

		// -(id)isEnabled:(id)feature __attribute__((warn_unused_result("")));
		[Export ("isEnabled:")]
		bool IsEnabled (FBSDKFeature feature);

		// -(void)checkFeature:(id)feature completionBlock:(id)completionBlock;
		[Export ("checkFeature:completionBlock:")]
		void CheckFeature (FBSDKFeature feature, FBSDKFeatureManagerBlock completionBlock);

		// -(void)disableFeature:(id)feature;
		[Export ("disableFeature:")]
		void DisableFeature (FBSDKFeature feature);
	}

	// @interface FBSDKHumanSilhouetteIcon : FBSDKIcon
	[BaseType (typeof(FBSDKIcon))]
	interface FBSDKHumanSilhouetteIcon
	{
	}

	// @interface FBSDKMeasurementEvent
	[BaseType(typeof(NSObject))]
	interface FBSDKMeasurementEvent
	{
		// -(void)postNotificationForEventName:(NSString * _Nonnull)eventName args:(id)arguments;
		[Export ("postNotificationForEventName:args:")]
		void PostNotification (string eventName, NSDictionary<NSString, NSObject> arguments);
	}

	// @interface FBSDKRestrictiveEventFilter
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKRestrictiveEventFilter
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull eventName;
		[Export ("eventName")]
		string EventName { get; }

		// -(instancetype _Nonnull)initWithEventName:(NSString * _Nonnull)eventName restrictiveParameters:(id)restrictiveParameters __attribute__((objc_designated_initializer));
		[Export ("initWithEventName:restrictiveParameters:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string eventName, NSDictionary<NSString, NSObject> restrictiveParameters);
	}

	// @interface FBSDKSKAdNetworkEvent
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKSKAdNetworkEvent
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable eventName;
		[NullAllowed, Export ("eventName")]
		string EventName { get; }

		// -(instancetype _Nullable)initWithJSON:(id)json __attribute__((objc_designated_initializer));
		[Export ("initWithJSON:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSDictionary<NSString, NSObject> json);
	}

	// @interface FBSDKViewImpressionLogger
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKViewImpressionLogger
	{
		// -(instancetype _Nonnull)initWithEventName:(id)eventName __attribute__((objc_designated_initializer));
		[Export ("initWithEventName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string eventName);

		// +(FBSDKViewImpressionLogger * _Nonnull)retrieveLoggerWith:(id)eventName __attribute__((warn_unused_result("")));
		[Static]
		[Export ("retrieveLoggerWith:")]
		FBSDKViewImpressionLogger RetrieveLogger (string eventName);

		// -(void)logImpressionWithIdentifier:(NSString * _Nonnull)identifier parameters:(id)parameters;
		[Export ("logImpressionWithIdentifier:parameters:")]
		void LogImpression (string identifier, [NullAllowed] NSDictionary<NSString, NSObject> parameters);
	}

	// @interface FBSDKWebDialog
	[BaseType (typeof (NSObject),
	Delegates = new string [] { "Delegate" },
	Events = new Type [] { typeof (FBSDKWebDialogDelegate) })]
	[DisableDefaultCtor]
	interface FBSDKWebDialog
	{
		// @property (nonatomic) BOOL shouldDeferVisibility;
		[Export ("shouldDeferVisibility")]
		bool ShouldDeferVisibility { get; set; }

		// @property (nonatomic, weak) id<FBSDKWebDialogDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKWebDialogDelegate Delegate { get; set; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name parameters:(id)parameters webViewFrame:(id)webViewFrame path:(NSString * _Nullable)path __attribute__((objc_designated_initializer));
		[Export ("initWithName:parameters:webViewFrame:path:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, [NullAllowed] NSDictionary<NSString, NSObject> parameters, CGRect webViewFrame, [NullAllowed] string path);

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name;
		[Export ("initWithName:")]
		NativeHandle Constructor (string name);

		// -(void)show;
		[Export ("show")]
		void Show ();
	}

	// @interface FBSDKWebViewFactory
	[BaseType(typeof(NSObject))]
	interface FBSDKWebViewFactory
	{
		// -(id<FBSDKWebView> _Nonnull)createWebViewWithFrame:(id)frame __attribute__((warn_unused_result("")));
		[Export ("createWebViewWithFrame:")]
		IFBSDKWebView CreateWebViewWithFrame (CGRect frame);
	}
}
