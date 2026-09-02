using FBSDKCoreKit;
using Foundation;
using ObjCRuntime;

namespace Facebook.Core
{
	// @protocol FBSDKAEMReporter
	interface IFBSDKAEMReporter {}
	
	[Protocol]
	interface FBSDKAEMReporter
	{
		// @required +(void)enable;
		[Static, Abstract]
		[Export ("enable")]
		void Enable ();

		// @required +(void)recordAndUpdateEvent:(NSString * _Nonnull)event currency:(NSString * _Nullable)currency value:(NSNumber * _Nullable)value parameters:(id)parameters;
		[Static, Abstract]
		[Export ("recordAndUpdateEvent:currency:value:parameters:")]
		void RecordAndUpdateEvent (string @event, [NullAllowed] string currency, [NullAllowed] NSNumber value, NSObject parameters);

		// @required +(void)setConversionFilteringEnabled:(id)isEnabled;
		[Static, Abstract]
		[Export ("setConversionFilteringEnabled:")]
		void SetConversionFilteringEnabled (NSObject isEnabled);

		// @required +(void)setCatalogMatchingEnabled:(id)isEnabled;
		[Static, Abstract]
		[Export ("setCatalogMatchingEnabled:")]
		void SetCatalogMatchingEnabled (NSObject isEnabled);

		// @required +(void)setAdvertiserRuleMatchInServerEnabled:(id)isEnabled;
		[Static, Abstract]
		[Export ("setAdvertiserRuleMatchInServerEnabled:")]
		void SetAdvertiserRuleMatchInServerEnabled (NSObject isEnabled);

		// @required +(void)handle:(NSURL * _Nullable)url;
		[Static, Abstract]
		[Export ("handle:")]
		void Handle ([NullAllowed] NSURL url);
	}

	// @interface FBSDKCoreKit_Swift_1768
	interface FBSDKCoreKit_Swift_1768
	{
	}

	// @interface FBSDKAppLink
	[DisableDefaultCtor]
	interface FBSDKAppLink
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nullable sourceURL;
		[NullAllowed, Export ("sourceURL", ArgumentSemantic.Copy)]
		NSURL SourceURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable webURL;
		[NullAllowed, Export ("webURL", ArgumentSemantic.Copy)]
		NSURL WebURL { get; }

		// @property (getter = isBackToReferrer, nonatomic) int backToReferrer;
		[Export ("backToReferrer")]
		int BackToReferrer { [Bind ("isBackToReferrer")] get; set; }

		// -(instancetype _Nonnull)initWithSourceURL:(NSURL * _Nullable)sourceURL targets:(id)targets webURL:(NSURL * _Nullable)webURL;
		[Export ("initWithSourceURL:targets:webURL:")]
		NativeHandle Constructor ([NullAllowed] NSURL sourceURL, NSObject targets, [NullAllowed] NSURL webURL);

		// +(id _Nonnull)appLinkWithSourceURL:(NSURL * _Nullable)sourceURL targets:(id)targets webURL:(NSURL * _Nullable)webURL __attribute__((warn_unused_result(""))) __attribute__((deprecated("
      Please use designated init to instantiate an AppLink. This method will be removed in future releases."
      ")));
		[Static]
		[Export ("appLinkWithSourceURL:targets:webURL:")]
		NSObject AppLinkWithSourceURL ([NullAllowed] NSURL sourceURL, NSObject targets, [NullAllowed] NSURL webURL);

		// -(instancetype _Nonnull)initWithSourceURL:(NSURL * _Nullable)sourceURL targets:(id)targets webURL:(NSURL * _Nullable)webURL isBackToReferrer:(id)isBackToReferrer __attribute__((objc_designated_initializer));
		[Export ("initWithSourceURL:targets:webURL:isBackToReferrer:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSURL sourceURL, NSObject targets, [NullAllowed] NSURL webURL, NSObject isBackToReferrer);
	}

	// @interface FBSDKAppLinkNavigation
	[Unavailable (PlatformName.iOSAppExtension)]
	[DisableDefaultCtor]
	interface FBSDKAppLinkNavigation
	{
		// @property (nonatomic, strong, class) id<FBSDKAppLinkResolving> _Nonnull defaultResolver;
		[Static]
		[Export ("defaultResolver", ArgumentSemantic.Strong)]
		FBSDKAppLinkResolving DefaultResolver { get; set; }

		// @property (readonly, nonatomic, strong) FBSDKAppLink * _Nullable appLink;
		[NullAllowed, Export ("appLink", ArgumentSemantic.Strong)]
		FBSDKAppLink AppLink { get; }

		// @property (readonly, nonatomic) int navigationType;
		[Export ("navigationType")]
		int NavigationType { get; }

		// -(instancetype _Nonnull)initWithAppLink:(FBSDKAppLink * _Nullable)appLink extras:(id)extras appLinkData:(id)appLinkData __attribute__((objc_designated_initializer));
		[Export ("initWithAppLink:extras:appLinkData:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] FBSDKAppLink appLink, NSObject extras, NSObject appLinkData);

		// -(instancetype _Nonnull)initWithAppLink:(FBSDKAppLink * _Nonnull)appLink extras:(id)extras appLinkData:(id)appLinkData settings:(id<FBSDKSettings> _Nonnull)settings __attribute__((deprecated("
      Please use init(appLink:extras:appLinkData:) to instantiate an `AppLinkNavigation`.
      This method will be removed in the next major version."
      ")));
		[Export ("initWithAppLink:extras:appLinkData:settings:")]
		NativeHandle Constructor (FBSDKAppLink appLink, NSObject extras, NSObject appLinkData, FBSDKSettings settings);

		// +(FBSDKAppLinkNavigation * _Nonnull)navigationWithAppLink:(FBSDKAppLink * _Nullable)appLink extras:(id)extras appLinkData:(id)appLinkData settings:(id<FBSDKSettings> _Nonnull)settings __attribute__((warn_unused_result(""))) __attribute__((deprecated("
      Please use designated init to instantiate an AppLinkNavigation. This method will be removed in future releases."
      ")));
		[Static]
		[Export ("navigationWithAppLink:extras:appLinkData:settings:")]
		FBSDKAppLinkNavigation NavigationWithAppLink ([NullAllowed] FBSDKAppLink appLink, NSObject extras, NSObject appLinkData, FBSDKSettings settings);

		// +(id)callbackAppLinkDataForAppWithName:(NSString * _Nonnull)appName url:(NSString * _Nonnull)url __attribute__((warn_unused_result("")));
		[Static]
		[Export ("callbackAppLinkDataForAppWithName:url:")]
		NSObject CallbackAppLinkDataForAppWithName (string appName, string url);

		// -(void)navigate:(id)handler;
		[Export ("navigate:")]
		void Navigate (NSObject handler);

		// +(void)resolveAppLink:(NSURL * _Nonnull)destination handler:(id)handler;
		[Static]
		[Export ("resolveAppLink:handler:")]
		void ResolveAppLink (NSURL destination, NSObject handler);

		// +(void)resolveAppLink:(NSURL * _Nonnull)destination resolver:(id<FBSDKAppLinkResolving> _Nonnull)resolver handler:(id)handler;
		[Static]
		[Export ("resolveAppLink:resolver:handler:")]
		void ResolveAppLink (NSURL destination, FBSDKAppLinkResolving resolver, NSObject handler);

		// +(void)navigateToAppLink:(FBSDKAppLink * _Nonnull)appLink handler:(id)handler;
		[Static]
		[Export ("navigateToAppLink:handler:")]
		void NavigateToAppLink (FBSDKAppLink appLink, NSObject handler);

		// +(id)navigationTypeForLink:(FBSDKAppLink * _Nonnull)appLink __attribute__((warn_unused_result("")));
		[Static]
		[Export ("navigationTypeForLink:")]
		NSObject NavigationTypeForLink (FBSDKAppLink appLink);

		// +(void)navigateToURL:(NSURL * _Nonnull)destination handler:(id)handler;
		[Static]
		[Export ("navigateToURL:handler:")]
		void NavigateToURL (NSURL destination, NSObject handler);

		// +(void)navigateToURL:(NSURL * _Nonnull)destination resolver:(id<FBSDKAppLinkResolving> _Nonnull)resolver handler:(id)handler;
		[Static]
		[Export ("navigateToURL:resolver:handler:")]
		void NavigateToURL (NSURL destination, FBSDKAppLinkResolving resolver, NSObject handler);
	}

	// @interface FBSDKAppLinkResolver <FBSDKAppLinkResolving>
	interface FBSDKAppLinkResolver : IFBSDKAppLinkResolving
	{
		// -(void)appLinkFromURL:(NSURL * _Nonnull)url handler:(id)handler;
		[Export ("appLinkFromURL:handler:")]
		void AppLinkFromURL (NSURL url, NSObject handler);

		// -(void)appLinksFrom:(id)urls handler:(id)handler __attribute__((availability(ios_app_extension, unavailable)));
		[Unavailable (PlatformName.iOSAppExtension)]
		[Export ("appLinksFrom:handler:")]
		void AppLinksFrom (NSObject urls, NSObject handler);
	}

	// @interface FBSDKAppLinkTarget <FBSDKAppLinkTarget>
	[DisableDefaultCtor]
	interface FBSDKAppLinkTarget : IFBSDKAppLinkTarget
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nullable URL;
		[NullAllowed, Export ("URL", ArgumentSemantic.Copy)]
		NSURL URL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable appStoreId;
		[NullAllowed, Export ("appStoreId")]
		string AppStoreId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appName;
		[Export ("appName")]
		string AppName { get; }

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nullable)url appStoreId:(NSString * _Nullable)appStoreId appName:(NSString * _Nonnull)appName __attribute__((objc_designated_initializer));
		[Export ("initWithURL:appStoreId:appName:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSURL url, [NullAllowed] string appStoreId, string appName);

		// +(FBSDKAppLinkTarget * _Nonnull)appLinkTargetWithURL:(NSURL * _Nullable)url appStoreId:(NSString * _Nullable)appStoreId appName:(NSString * _Nonnull)appName __attribute__((warn_unused_result(""))) __attribute__((deprecated("
      Please use designated init to instantiate an AppLinkTarget. This method will be removed in future releases."
      ")));
		[Static]
		[Export ("appLinkTargetWithURL:appStoreId:appName:")]
		FBSDKAppLinkTarget AppLinkTargetWithURL ([NullAllowed] NSURL url, [NullAllowed] string appStoreId, string appName);
	}

	// @interface FBSDKApplicationDelegate
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
		NSObject Application (UIApplication application, NSUserActivity userActivity);

		// -(id)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url options:(id)options;
		[Export ("application:openURL:options:")]
		NSObject Application (UIApplication application, NSURL url, NSObject options);

		// -(id)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation;
		[Export ("application:openURL:sourceApplication:annotation:")]
		NSObject Application (UIApplication application, NSURL url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)application:(UIApplication * _Nonnull)application didFinishLaunchingWithOptions:(id)launchOptions;
		[Export ("application:didFinishLaunchingWithOptions:")]
		NSObject Application (UIApplication application, NSObject launchOptions);

		// -(void)addObserver:(id<FBSDKApplicationObserving> _Nonnull)observer;
		[Export ("addObserver:")]
		void AddObserver (FBSDKApplicationObserving observer);

		// -(void)removeObserver:(id<FBSDKApplicationObserving> _Nonnull)observer;
		[Export ("removeObserver:")]
		void RemoveObserver (FBSDKApplicationObserving observer);
	}

	// @interface FBSDKAuthenticationTokenClaims
	[DisableDefaultCtor]
	interface FBSDKAuthenticationTokenClaims
	{
		// -(instancetype _Nullable)initWithEncodedClaims:(NSString * _Nonnull)encodedClaims nonce:(NSString * _Nonnull)expectedNonce;
		[Export ("initWithEncodedClaims:nonce:")]
		NativeHandle Constructor (string encodedClaims, string expectedNonce);
	}

	// @protocol FBSDKCAPIReporter
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKCAPIReporter
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(void)configureWithFactory:(id<FBSDKGraphRequestFactory> _Nonnull)factory settings:(id<FBSDKSettings> _Nonnull)settings;
		[Abstract]
		[Export ("configureWithFactory:settings:")]
		void ConfigureWithFactory (FBSDKGraphRequestFactory factory, FBSDKSettings settings);

		// @required -(void)recordEvent:(id)parameters;
		[Abstract]
		[Export ("recordEvent:")]
		void RecordEvent (NSObject parameters);
	}

	// @interface CoreUIApplication
	interface CoreUIApplication
	{
		// @property (readonly, nonatomic, strong, class) id<FBSDKInternalURLOpener> _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKInternalURLOpener Shared { get; }
	}

	// @interface FBSDKIcon
	interface FBSDKIcon
	{
		// -(id)pathWith:(id)size __attribute__((warn_unused_result("")));
		[Export ("pathWith:")]
		NSObject PathWith (NSObject size);

		// -(UIImage * _Nullable)imageWithSize:(id)size __attribute__((warn_unused_result("")));
		[Export ("imageWithSize:")]
		[return: NullAllowed]
		UIImage ImageWithSize (NSObject size);

		// -(UIImage * _Nullable)imageWithSize:(id)size color:(UIColor * _Nonnull)color __attribute__((warn_unused_result("")));
		[Export ("imageWithSize:color:")]
		[return: NullAllowed]
		UIImage ImageWithSize (NSObject size, UIColor color);

		// -(UIImage * _Nullable)imageWithSize:(id)size scale:(id)scale color:(UIColor * _Nonnull)color __attribute__((warn_unused_result("")));
		[Export ("imageWithSize:scale:color:")]
		[return: NullAllowed]
		UIImage ImageWithSize (NSObject size, NSObject scale, UIColor color);
	}

	// @interface FBSDKProfilePictureView
	interface FBSDKProfilePictureView
	{
		// @property (nonatomic) enum FBSDKProfilePictureMode pictureMode;
		[Export ("pictureMode", ArgumentSemantic.Assign)]
		FBSDKProfilePictureMode PictureMode { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull profileID;
		[Export ("profileID")]
		string ProfileID { get; set; }

		// @property (nonatomic) int bounds;
		[Export ("bounds")]
		int Bounds { get; set; }

		// @property (nonatomic) int contentMode;
		[Export ("contentMode")]
		int ContentMode { get; set; }

		// -(instancetype _Nonnull)initWith:(id)frame profile:(FBSDKProfile * _Nullable)profile __attribute__((objc_designated_initializer));
		[Export ("initWith:profile:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject frame, [NullAllowed] FBSDKProfile profile);

		// -(instancetype _Nonnull)initWithProfile:(FBSDKProfile * _Nullable)profile;
		[Export ("initWithProfile:")]
		NativeHandle Constructor ([NullAllowed] FBSDKProfile profile);

		// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCoder coder);

		// -(void)setNeedsImageUpdate;
		[Export ("setNeedsImageUpdate")]
		void SetNeedsImageUpdate ();
	}

	// @interface FBSDKAppEventsCAPIManager <FBSDKCAPIReporter>
	interface FBSDKAppEventsCAPIManager : IFBSDKCAPIReporter
	{
		// @property (readonly, nonatomic, strong, class) FBSDKAppEventsCAPIManager * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKAppEventsCAPIManager Shared { get; }

		// -(void)configureWithFactory:(id<FBSDKGraphRequestFactory> _Nonnull)factory settings:(id<FBSDKSettings> _Nonnull)settings;
		[Export ("configureWithFactory:settings:")]
		void ConfigureWithFactory (FBSDKGraphRequestFactory factory, FBSDKSettings settings);

		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(void)recordEvent:(id)parameters;
		[Export ("recordEvent:")]
		void RecordEvent (NSObject parameters);
	}

	// @interface FBSDKTransformerGraphRequestFactory
	interface FBSDKTransformerGraphRequestFactory
	{
		// @property (readonly, nonatomic, strong, class) FBSDKTransformerGraphRequestFactory * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKTransformerGraphRequestFactory Shared { get; }

		// -(void)configureWithDatasetID:(NSString * _Nonnull)datasetID url:(NSString * _Nonnull)url accessKey:(NSString * _Nonnull)accessKey;
		[Export ("configureWithDatasetID:url:accessKey:")]
		void ConfigureWithDatasetID (string datasetID, string url, string accessKey);

		// -(void)callCapiGatewayAPIWith:(id)parameters userAgent:(NSString * _Nonnull)userAgent;
		[Export ("callCapiGatewayAPIWith:userAgent:")]
		void CallCapiGatewayAPIWith (NSObject parameters, string userAgent);
	}

	// @protocol FBSDKMACARuleMatching
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKMACARuleMatching
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(id)processParameters:(id)params event:(NSString * _Nullable)event __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("processParameters:event:")]
		NSObject ProcessParameters (NSObject @params, [NullAllowed] string @event);
	}

	// @interface FBSDKProfile
	[DisableDefaultCtor]
	interface FBSDKProfile
	{
		// @property (readonly, copy, nonatomic) int userID;
		[Export ("userID", ArgumentSemantic.Copy)]
		int UserID { get; }

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
		NSURL LinkURL { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull refreshDate;
		[Export ("refreshDate", ArgumentSemantic.Copy)]
		NSDate RefreshDate { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable imageURL;
		[NullAllowed, Export ("imageURL", ArgumentSemantic.Copy)]
		NSURL ImageURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

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

		// @property (readonly, nonatomic) int isLimited;
		[Export ("isLimited")]
		int IsLimited { get; }

		// @property (nonatomic, class) int isUpdatedWithAccessTokenChange;
		[Static]
		[Export ("isUpdatedWithAccessTokenChange")]
		int IsUpdatedWithAccessTokenChange { get; set; }

		// -(instancetype _Nonnull)initWithUserID:(id)userID firstName:(NSString * _Nullable)firstName middleName:(NSString * _Nullable)middleName lastName:(NSString * _Nullable)lastName name:(NSString * _Nullable)name linkURL:(NSURL * _Nullable)linkURL refreshDate:(NSDate * _Nullable)refreshDate permissions:(id)permissions;
		[Export ("initWithUserID:firstName:middleName:lastName:name:linkURL:refreshDate:permissions:")]
		NativeHandle Constructor (NSObject userID, [NullAllowed] string firstName, [NullAllowed] string middleName, [NullAllowed] string lastName, [NullAllowed] string name, [NullAllowed] NSURL linkURL, [NullAllowed] NSDate refreshDate, NSObject permissions);

		// -(instancetype _Nonnull)initWithUserID:(id)userID firstName:(NSString * _Nullable)firstName middleName:(NSString * _Nullable)middleName lastName:(NSString * _Nullable)lastName name:(NSString * _Nullable)name linkURL:(NSURL * _Nullable)linkURL refreshDate:(NSDate * _Nullable)refreshDate imageURL:(NSURL * _Nullable)imageURL email:(NSString * _Nullable)email friendIDs:(id)friendIDs birthday:(NSDate * _Nullable)birthday ageRange:(FBSDKUserAgeRange * _Nullable)ageRange hometown:(FBSDKLocation * _Nullable)hometown location:(FBSDKLocation * _Nullable)location gender:(NSString * _Nullable)gender permissions:(id)permissions;
		[Export ("initWithUserID:firstName:middleName:lastName:name:linkURL:refreshDate:imageURL:email:friendIDs:birthday:ageRange:hometown:location:gender:permissions:")]
		NativeHandle Constructor (NSObject userID, [NullAllowed] string firstName, [NullAllowed] string middleName, [NullAllowed] string lastName, [NullAllowed] string name, [NullAllowed] NSURL linkURL, [NullAllowed] NSDate refreshDate, [NullAllowed] NSURL imageURL, [NullAllowed] string email, NSObject friendIDs, [NullAllowed] NSDate birthday, [NullAllowed] FBSDKUserAgeRange ageRange, [NullAllowed] FBSDKLocation hometown, [NullAllowed] FBSDKLocation location, [NullAllowed] string gender, NSObject permissions);

		// -(instancetype _Nonnull)initWithUserID:(id)userID firstName:(NSString * _Nullable)firstName middleName:(NSString * _Nullable)middleName lastName:(NSString * _Nullable)lastName name:(NSString * _Nullable)name linkURL:(NSURL * _Nullable)linkURL refreshDate:(NSDate * _Nullable)refreshDate imageURL:(NSURL * _Nullable)imageURL email:(NSString * _Nullable)email friendIDs:(id)friendIDs birthday:(NSDate * _Nullable)birthday ageRange:(FBSDKUserAgeRange * _Nullable)ageRange hometown:(FBSDKLocation * _Nullable)hometown location:(FBSDKLocation * _Nullable)location gender:(NSString * _Nullable)gender isLimited:(id)isLimited permissions:(id)permissions __attribute__((objc_designated_initializer));
		[Export ("initWithUserID:firstName:middleName:lastName:name:linkURL:refreshDate:imageURL:email:friendIDs:birthday:ageRange:hometown:location:gender:isLimited:permissions:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject userID, [NullAllowed] string firstName, [NullAllowed] string middleName, [NullAllowed] string lastName, [NullAllowed] string name, [NullAllowed] NSURL linkURL, [NullAllowed] NSDate refreshDate, [NullAllowed] NSURL imageURL, [NullAllowed] string email, NSObject friendIDs, [NullAllowed] NSDate birthday, [NullAllowed] FBSDKUserAgeRange ageRange, [NullAllowed] FBSDKLocation hometown, [NullAllowed] FBSDKLocation location, [NullAllowed] string gender, NSObject isLimited, NSObject permissions);

		// +(void)enableUpdatesOnAccessTokenChange:(id)enabled __attribute__((deprecated("This method is deprecated and will be removed in the next major release. Use `isUpdatedWithAccessTokenChange` instead.")));
		[Static]
		[Export ("enableUpdatesOnAccessTokenChange:")]
		void EnableUpdatesOnAccessTokenChange (NSObject enabled);
	}

	// @interface FBSDKCoreKit_Swift_2275 (FBSDKProfile)
	[Category]
	[BaseType (typeof(FBSDKProfile))]
	interface FBSDKProfile_FBSDKCoreKit_Swift_2275
	{
		// -(NSURL * _Nullable)imageURLForPictureMode:(enum FBSDKProfilePictureMode)pictureMode size:(id)size __attribute__((warn_unused_result("")));
		[Export ("imageURLForPictureMode:size:")]
		[return: NullAllowed]
		NSURL ImageURLForPictureMode (FBSDKProfilePictureMode pictureMode, NSObject size);
	}

	// @protocol FBSDKProfileProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKProfileProviding
	{
		// @required @property (nonatomic, strong, class) FBSDKProfile * _Nullable currentProfile;
		[Static, Abstract]
		[NullAllowed, Export ("currentProfile", ArgumentSemantic.Strong)]
		FBSDKProfile CurrentProfile { get; set; }

		// @required +(FBSDKProfile * _Nullable)fetchCachedProfile __attribute__((warn_unused_result("")));
		[Static, Abstract]
		[NullAllowed, Export ("fetchCachedProfile")]
		[Verify (MethodToProperty)]
		FBSDKProfile FetchCachedProfile { get; }
	}

	// @interface FBSDKCoreKit_Swift_2309 (FBSDKProfile) <FBSDKProfileProviding>
	[Category]
	[BaseType (typeof(FBSDKProfile))]
	interface FBSDKProfile_FBSDKCoreKit_Swift_2309 : IFBSDKProfileProviding
	{
		// @property (nonatomic, strong, class) FBSDKProfile * _Nullable currentProfile;
		[Static]
		[NullAllowed, Export ("currentProfile", ArgumentSemantic.Strong)]
		FBSDKProfile CurrentProfile { get; set; }

		// +(instancetype _Nullable)fetchCachedProfile __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fetchCachedProfile")]
		[return: NullAllowed]
		FBSDKProfile FetchCachedProfile ();
	}

	// @interface FBSDKCoreKit_Swift_2317 (FBSDKProfile)
	[Category]
	[BaseType (typeof(FBSDKProfile))]
	interface FBSDKProfile_FBSDKCoreKit_Swift_2317
	{
		// @property (readonly, nonatomic, class) int supportsSecureCoding;
		[Static]
		[Export ("supportsSecureCoding")]
		int SupportsSecureCoding { get; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder;
		[Export ("initWithCoder:")]
		NativeHandle Constructor (NSCoder decoder);

		// -(void)encodeWithCoder:(NSCoder * _Nonnull)encoder;
		[Export ("encodeWithCoder:")]
		void EncodeWithCoder (NSCoder encoder);
	}

	// @interface FBSDKCoreKit_Swift_2324 (FBSDKProfile)
	[Category]
	[BaseType (typeof(FBSDKProfile))]
	interface FBSDKProfile_FBSDKCoreKit_Swift_2324
	{
		// +(void)loadCurrentProfileWithCompletion:(id)completion;
		[Static]
		[Export ("loadCurrentProfileWithCompletion:")]
		void LoadCurrentProfileWithCompletion (NSObject completion);
	}

	// @interface FBSDKProtectedModeManager
	interface FBSDKProtectedModeManager
	{
		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(id)processParameters:(id)parameters eventName:(id)eventName __attribute__((warn_unused_result("")));
		[Export ("processParameters:eventName:")]
		NSObject ProcessParameters (NSObject parameters, NSObject eventName);

		// +(id)isProtectedModeAppliedWithParameters:(id)parameters __attribute__((warn_unused_result("")));
		[Static]
		[Export ("isProtectedModeAppliedWithParameters:")]
		NSObject IsProtectedModeAppliedWithParameters (NSObject parameters);
	}

	// @interface ServerConfigurationProvider
	interface ServerConfigurationProvider
	{
	}

	// @protocol FBSDKSettings
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSettings
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
		int IsDataProcessingRestricted { get; }

		// @required @property (readonly, nonatomic) int isAutoLogAppEventsEnabled;
		[Abstract]
		[Export ("isAutoLogAppEventsEnabled")]
		int IsAutoLogAppEventsEnabled { get; }

		// @required @property (nonatomic) int codelessDebugLogEnabled __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isCodelessDebugLogEnabled` instead.
      ")));
		[Abstract]
		[Export ("codelessDebugLogEnabled")]
		int CodelessDebugLogEnabled { get; set; }

		// @required @property (nonatomic) int isCodelessDebugLogEnabled;
		[Abstract]
		[Export ("isCodelessDebugLogEnabled")]
		int IsCodelessDebugLogEnabled { get; set; }

		// @required @property (nonatomic) int advertiserIDCollectionEnabled __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isAdvertiserIDCollectionEnabled` instead.
      ")));
		[Abstract]
		[Export ("advertiserIDCollectionEnabled")]
		int AdvertiserIDCollectionEnabled { get; set; }

		// @required @property (nonatomic) int isAdvertiserIDCollectionEnabled;
		[Abstract]
		[Export ("isAdvertiserIDCollectionEnabled")]
		int IsAdvertiserIDCollectionEnabled { get; set; }

		// @required @property (readonly, nonatomic) int isSetATETimeExceedsInstallTime __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isATETimeSufficientlyDelayed` instead.
      ")));
		[Abstract]
		[Export ("isSetATETimeExceedsInstallTime")]
		int IsSetATETimeExceedsInstallTime { get; }

		// @required @property (readonly, nonatomic) int isATETimeSufficientlyDelayed;
		[Abstract]
		[Export ("isATETimeSufficientlyDelayed")]
		int IsATETimeSufficientlyDelayed { get; }

		// @required @property (readonly, nonatomic) int isSKAdNetworkReportEnabled;
		[Abstract]
		[Export ("isSKAdNetworkReportEnabled")]
		int IsSKAdNetworkReportEnabled { get; }

		// @required @property (readonly, nonatomic) int advertisingTrackingStatus;
		[Abstract]
		[Export ("advertisingTrackingStatus")]
		int AdvertisingTrackingStatus { get; }

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
		int IsEventDataUsageLimited { get; set; }

		// @required @property (nonatomic) int shouldUseTokenOptimizations;
		[Abstract]
		[Export ("shouldUseTokenOptimizations")]
		int ShouldUseTokenOptimizations { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nonnull graphAPIVersion;
		[Abstract]
		[Export ("graphAPIVersion")]
		string GraphAPIVersion { get; set; }

		// @required @property (nonatomic) int isGraphErrorRecoveryEnabled;
		[Abstract]
		[Export ("isGraphErrorRecoveryEnabled")]
		int IsGraphErrorRecoveryEnabled { get; set; }

		// @required @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("\n      This property is deprecated and will be removed in the next major release.       Use `graphAPIDebugParameterValue` instead.\n      ") NSString * graphAPIDebugParamValue __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `graphAPIDebugParameterValue` instead.
      ")));
		[Abstract]
		[Export ("graphAPIDebugParamValue")]
		string GraphAPIDebugParamValue { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable graphAPIDebugParameterValue;
		[Abstract]
		[NullAllowed, Export ("graphAPIDebugParameterValue")]
		string GraphAPIDebugParameterValue { get; }

		// @required @property (nonatomic) int advertiserTrackingEnabled __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isAdvertiserTrackingEnabled` instead.
      ")));
		[Abstract]
		[Export ("advertiserTrackingEnabled")]
		int AdvertiserTrackingEnabled { get; set; }

		// @required @property (nonatomic) int isAdvertiserTrackingEnabled;
		[Abstract]
		[Export ("isAdvertiserTrackingEnabled")]
		int IsAdvertiserTrackingEnabled { get; set; }

		// @required @property (nonatomic) int shouldUseCachedValuesForExpensiveMetadata;
		[Abstract]
		[Export ("shouldUseCachedValuesForExpensiveMetadata")]
		int ShouldUseCachedValuesForExpensiveMetadata { get; set; }

		// @required @property (nonatomic) int isDomainErrorEnabled;
		[Abstract]
		[Export ("isDomainErrorEnabled")]
		int IsDomainErrorEnabled { get; set; }

		// @required @property (nonatomic) int limitedLoginAutoRefreshInterval;
		[Abstract]
		[Export ("limitedLoginAutoRefreshInterval")]
		int LimitedLoginAutoRefreshInterval { get; set; }

		// @required -(void)setDataProcessingOptions:(id)options;
		[Abstract]
		[Export ("setDataProcessingOptions:")]
		void SetDataProcessingOptions (NSObject options);

		// @required -(void)setDataProcessingOptions:(id)options country:(id)country state:(id)state;
		[Abstract]
		[Export ("setDataProcessingOptions:country:state:")]
		void SetDataProcessingOptions (NSObject options, NSObject country, NSObject state);

		// @required -(id)isLoggingBehaviorEnabled:(id)loggingBehavior __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("isLoggingBehaviorEnabled:")]
		NSObject IsLoggingBehaviorEnabled (NSObject loggingBehavior);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern id * _Nonnull loggingBehaviors;
		[Field ("loggingBehaviors", "__Internal")]
		unsafe NSObject* loggingBehaviors { get; }
	}

	// @interface FBSDKSettings
	interface FBSDKSettings
	{
		// @property (readonly, nonatomic, strong, class) FBSDKSettings * _Nonnull sharedSettings;
		[Static]
		[Export ("sharedSettings", ArgumentSemantic.Strong)]
		FBSDKSettings SharedSettings { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkVersion;
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull defaultGraphAPIVersion;
		[Export ("defaultGraphAPIVersion")]
		string DefaultGraphAPIVersion { get; }

		// @property (nonatomic) int JPEGCompressionQuality;
		[Export ("JPEGCompressionQuality")]
		int JPEGCompressionQuality { get; set; }

		// @property (nonatomic) int autoLogAppEventsEnabled __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isAutoLogAppEventsEnabled` instead.
      ")));
		[Export ("autoLogAppEventsEnabled")]
		int AutoLogAppEventsEnabled { get; set; }

		// @property (nonatomic) int isAutoLogAppEventsEnabled;
		[Export ("isAutoLogAppEventsEnabled")]
		int IsAutoLogAppEventsEnabled { get; set; }

		// @property (nonatomic) int codelessDebugLogEnabled __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isCodelessDebugLogEnabled` instead.
      ")));
		[Export ("codelessDebugLogEnabled")]
		int CodelessDebugLogEnabled { get; set; }

		// @property (nonatomic) int isCodelessDebugLogEnabled;
		[Export ("isCodelessDebugLogEnabled")]
		int IsCodelessDebugLogEnabled { get; set; }

		// @property (nonatomic) int advertiserIDCollectionEnabled __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isAdvertiserIDCollectionEnabled` instead.
      ")));
		[Export ("advertiserIDCollectionEnabled")]
		int AdvertiserIDCollectionEnabled { get; set; }

		// @property (nonatomic) int isAdvertiserIDCollectionEnabled;
		[Export ("isAdvertiserIDCollectionEnabled")]
		int IsAdvertiserIDCollectionEnabled { get; set; }

		// @property (nonatomic) int skAdNetworkReportEnabled __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isSKAdNetworkReportEnabled` instead.
      ")));
		[Export ("skAdNetworkReportEnabled")]
		int SkAdNetworkReportEnabled { get; set; }

		// @property (nonatomic) int isSKAdNetworkReportEnabled;
		[Export ("isSKAdNetworkReportEnabled")]
		int IsSKAdNetworkReportEnabled { get; set; }

		// @property (nonatomic) int isEventDataUsageLimited;
		[Export ("isEventDataUsageLimited")]
		int IsEventDataUsageLimited { get; set; }

		// @property (nonatomic) int shouldUseCachedValuesForExpensiveMetadata;
		[Export ("shouldUseCachedValuesForExpensiveMetadata")]
		int ShouldUseCachedValuesForExpensiveMetadata { get; set; }

		// @property (nonatomic) int isGraphErrorRecoveryEnabled;
		[Export ("isGraphErrorRecoveryEnabled")]
		int IsGraphErrorRecoveryEnabled { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable appID;
		[NullAllowed, Export ("appID")]
		string AppID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable appURLSchemeSuffix;
		[NullAllowed, Export ("appURLSchemeSuffix")]
		string AppURLSchemeSuffix { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable clientToken;
		[NullAllowed, Export ("clientToken")]
		string ClientToken { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable facebookDomainPart;
		[NullAllowed, Export ("facebookDomainPart")]
		string FacebookDomainPart { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull graphAPIVersion;
		[Export ("graphAPIVersion")]
		string GraphAPIVersion { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable userAgentSuffix;
		[NullAllowed, Export ("userAgentSuffix")]
		string UserAgentSuffix { get; set; }

		// @property (nonatomic) int advertiserTrackingEnabled __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isAdvertiserTrackingEnabled` instead.
      ")));
		[Export ("advertiserTrackingEnabled")]
		int AdvertiserTrackingEnabled { get; set; }

		// @property (nonatomic) int isAdvertiserTrackingEnabled;
		[Export ("isAdvertiserTrackingEnabled")]
		int IsAdvertiserTrackingEnabled { get; set; }

		// @property (nonatomic) int advertisingTrackingStatus;
		[Export ("advertisingTrackingStatus")]
		int AdvertisingTrackingStatus { get; set; }

		// @property (readonly, nonatomic) int isDataProcessingRestricted;
		[Export ("isDataProcessingRestricted")]
		int IsDataProcessingRestricted { get; }

		// -(void)setDataProcessingOptions:(id)options;
		[Export ("setDataProcessingOptions:")]
		void SetDataProcessingOptions (NSObject options);

		// -(void)setDataProcessingOptions:(id)options country:(id)country state:(id)state;
		[Export ("setDataProcessingOptions:country:state:")]
		void SetDataProcessingOptions (NSObject options, NSObject country, NSObject state);

		// -(void)enableLoggingBehavior:(id)loggingBehavior;
		[Export ("enableLoggingBehavior:")]
		void EnableLoggingBehavior (NSObject loggingBehavior);

		// -(void)disableLoggingBehavior:(id)loggingBehavior;
		[Export ("disableLoggingBehavior:")]
		void DisableLoggingBehavior (NSObject loggingBehavior);

		// -(id)isLoggingBehaviorEnabled:(id)loggingBehavior __attribute__((warn_unused_result("")));
		[Export ("isLoggingBehaviorEnabled:")]
		NSObject IsLoggingBehaviorEnabled (NSObject loggingBehavior);

		// @property (nonatomic) int shouldUseTokenOptimizations;
		[Export ("shouldUseTokenOptimizations")]
		int ShouldUseTokenOptimizations { get; set; }

		// @property (readonly, nonatomic) int isSetATETimeExceedsInstallTime __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `isATETimeSufficientlyDelayed` instead.
      ")));
		[Export ("isSetATETimeExceedsInstallTime")]
		int IsSetATETimeExceedsInstallTime { get; }

		// @property (readonly, nonatomic) int isATETimeSufficientlyDelayed;
		[Export ("isATETimeSufficientlyDelayed")]
		int IsATETimeSufficientlyDelayed { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable installTimestamp;
		[NullAllowed, Export ("installTimestamp", ArgumentSemantic.Copy)]
		NSDate InstallTimestamp { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable advertiserTrackingEnabledTimestamp;
		[NullAllowed, Export ("advertiserTrackingEnabledTimestamp", ArgumentSemantic.Copy)]
		NSDate AdvertiserTrackingEnabledTimestamp { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("\n      This property is deprecated and will be removed in the next major release.       Use `graphAPIDebugParameterValue` instead.\n      ") NSString * graphAPIDebugParamValue __attribute__((deprecated("
      This property is deprecated and will be removed in the next major release.       Use `graphAPIDebugParameterValue` instead.
      ")));
		[Export ("graphAPIDebugParamValue")]
		string GraphAPIDebugParamValue { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable graphAPIDebugParameterValue;
		[NullAllowed, Export ("graphAPIDebugParameterValue")]
		string GraphAPIDebugParameterValue { get; }

		// @property (nonatomic) int limitedLoginAutoRefreshInterval;
		[Export ("limitedLoginAutoRefreshInterval")]
		int LimitedLoginAutoRefreshInterval { get; set; }

		// @property (nonatomic) int isDomainErrorEnabled;
		[Export ("isDomainErrorEnabled")]
		int IsDomainErrorEnabled { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable addToMessagingCustomerBaseForWhatsApp;
		[NullAllowed, Export ("addToMessagingCustomerBaseForWhatsApp", ArgumentSemantic.Strong)]
		NSNumber AddToMessagingCustomerBaseForWhatsApp { get; set; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern id * _Nonnull loggingBehaviors;
		[Field ("loggingBehaviors", "__Internal")]
		unsafe NSObject* loggingBehaviors { get; }
	}

	// @interface FBSDKCoreKit_Swift_2582 (FBSDKSettings)
	[Category]
	[BaseType (typeof(FBSDKSettings))]
	interface FBSDKSettings_FBSDKCoreKit_Swift_2582
	{
		// -(void)recordInstall;
		[Export ("recordInstall")]
		void RecordInstall ();

		// -(void)logIfSDKSettingsChanged;
		[Export ("logIfSDKSettingsChanged")]
		void LogIfSDKSettingsChanged ();
	}

	// @interface FBSDKShimGraphRequestInterceptor
	interface FBSDKShimGraphRequestInterceptor
	{
		// @property (readonly, nonatomic, strong, class) FBSDKShimGraphRequestInterceptor * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKShimGraphRequestInterceptor Shared { get; }

		// -(id)shouldInterceptRequest:(NSURLRequest * _Nonnull)request __attribute__((warn_unused_result("")));
		[Export ("shouldInterceptRequest:")]
		NSObject ShouldInterceptRequest (NSURLRequest request);

		// -(void)executeWithRequest:(NSURLRequest * _Nonnull)request completionHandler:(id)completionHandler;
		[Export ("executeWithRequest:completionHandler:")]
		void ExecuteWithRequest (NSURLRequest request, NSObject completionHandler);
	}

	// @protocol _FBSDKAccessTokenExpiring
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface _FBSDKAccessTokenExpiring
	{
	}

	// @interface _FBSDKAccessTokenExpirer <_FBSDKAccessTokenExpiring>
	[DisableDefaultCtor]
	interface _FBSDKAccessTokenExpirer : I_FBSDKAccessTokenExpiring
	{
		// -(instancetype _Nonnull)initWithNotificationCenter:(id<_FBSDKNotificationPosting,FBSDKNotificationDelivering> _Nonnull)notificationCenter __attribute__((objc_designated_initializer));
		[Export ("initWithNotificationCenter:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject<_FBSDKNotificationPosting, FBSDKNotificationDelivering> notificationCenter);
	}

	// @interface _BridgeAPI
	[DisableDefaultCtor]
	interface _BridgeAPI
	{
		// -(void)viewControllerDidDisappear:(FBSDKContainerViewController * _Nonnull)viewController animated:(id)animated;
		[Export ("viewControllerDidDisappear:animated:")]
		void ViewControllerDidDisappear (FBSDKContainerViewController viewController, NSObject animated);
	}

	// @interface FBSDKCoreKit_Swift_2637 (_BridgeAPI)
	[Category]
	[BaseType (typeof(_BridgeAPI))]
	interface _BridgeAPI_FBSDKCoreKit_Swift_2637
	{
		// -(void)safariViewControllerDidFinish:(SFSafariViewController * _Nonnull)safariViewController;
		[Export ("safariViewControllerDidFinish:")]
		void SafariViewControllerDidFinish (SFSafariViewController safariViewController);
	}

	// @interface FBSDKCoreKit_Swift_2643 (_BridgeAPI)
	[iOS (13,0)]
	[Category]
	[BaseType (typeof(_BridgeAPI))]
	interface _BridgeAPI_FBSDKCoreKit_Swift_2643
	{
		// -(id)presentationAnchorForWebAuthenticationSession:(ASWebAuthenticationSession * _Nonnull)session __attribute__((warn_unused_result("")));
		[Export ("presentationAnchorForWebAuthenticationSession:")]
		NSObject PresentationAnchorForWebAuthenticationSession (ASWebAuthenticationSession session);
	}

	// @interface FBSDKCoreKit_Swift_2650 (_BridgeAPI)
	[Category]
	[BaseType (typeof(_BridgeAPI))]
	interface _BridgeAPI_FBSDKCoreKit_Swift_2650
	{
		// -(void)openURL:(NSURL * _Nonnull)url sender:(id<FBSDKURLOpening> _Nullable)sender handler:(id)handler;
		[Export ("openURL:sender:handler:")]
		void OpenURL (NSURL url, [NullAllowed] FBSDKURLOpening sender, NSObject handler);

		// -(void)openBridgeAPIRequest:(id<FBSDKBridgeAPIRequest> _Nonnull)request useSafariViewController:(id)useSafariViewController fromViewController:(UIViewController * _Nullable)fromViewController completionBlock:(id)completionBlock;
		[Export ("openBridgeAPIRequest:useSafariViewController:fromViewController:completionBlock:")]
		void OpenBridgeAPIRequest (FBSDKBridgeAPIRequest request, NSObject useSafariViewController, [NullAllowed] UIViewController fromViewController, NSObject completionBlock);

		// -(void)openURLWithSafariViewController:(NSURL * _Nonnull)url sender:(id<FBSDKURLOpening> _Nullable)sender fromViewController:(UIViewController * _Nullable)fromViewController handler:(id)handler;
		[Export ("openURLWithSafariViewController:sender:fromViewController:handler:")]
		void OpenURLWithSafariViewController (NSURL url, [NullAllowed] FBSDKURLOpening sender, [NullAllowed] UIViewController fromViewController, NSObject handler);
	}

	// @interface FBSDKCoreKit_Swift_2656 (_BridgeAPI)
	[Category]
	[BaseType (typeof(_BridgeAPI))]
	interface _BridgeAPI_FBSDKCoreKit_Swift_2656
	{
		// -(void)applicationWillResignActive:(UIApplication * _Nullable)application;
		[Export ("applicationWillResignActive:")]
		void ApplicationWillResignActive ([NullAllowed] UIApplication application);

		// -(void)applicationDidBecomeActive:(UIApplication * _Nullable)application;
		[Export ("applicationDidBecomeActive:")]
		void ApplicationDidBecomeActive ([NullAllowed] UIApplication application);

		// -(void)applicationDidEnterBackground:(UIApplication * _Nullable)application;
		[Export ("applicationDidEnterBackground:")]
		void ApplicationDidEnterBackground ([NullAllowed] UIApplication application);

		// -(id)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		NSObject Application (UIApplication application, NSURL url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)application:(UIApplication * _Nonnull)application didFinishLaunchingWithOptions:(id)launchOptions __attribute__((warn_unused_result("")));
		[Export ("application:didFinishLaunchingWithOptions:")]
		NSObject Application (UIApplication application, NSObject launchOptions);
	}

	// @interface FBSDKBridgeAPIProtocolNativeV1
	[DisableDefaultCtor]
	interface FBSDKBridgeAPIProtocolNativeV1
	{
		// -(instancetype _Nonnull)initWithAppScheme:(NSString * _Nullable)appScheme;
		[Export ("initWithAppScheme:")]
		NativeHandle Constructor ([NullAllowed] string appScheme);

		// -(instancetype _Nonnull)initWithAppScheme:(NSString * _Nullable)appScheme pasteboard:(id<FBSDKPasteboard> _Nullable)pasteboard dataLengthThreshold:(id)dataLengthThreshold includeAppIcon:(id)shouldIncludeAppIcon __attribute__((objc_designated_initializer));
		[Export ("initWithAppScheme:pasteboard:dataLengthThreshold:includeAppIcon:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string appScheme, [NullAllowed] FBSDKPasteboard pasteboard, NSObject dataLengthThreshold, NSObject shouldIncludeAppIcon);

		// -(NSURL * _Nullable)requestURLWithActionID:(NSString * _Nonnull)actionID scheme:(NSString * _Nonnull)scheme methodName:(NSString * _Nonnull)methodName parameters:(id)parameters error:(id)error __attribute__((warn_unused_result("")));
		[Export ("requestURLWithActionID:scheme:methodName:parameters:error:")]
		[return: NullAllowed]
		NSURL RequestURLWithActionID (string actionID, string scheme, string methodName, NSObject parameters, NSObject error);

		// -(id)responseParametersForActionID:(NSString * _Nonnull)actionID queryParameters:(id)queryParameters cancelled:(id)cancelledRef error:(id)error __attribute__((warn_unused_result("")));
		[Export ("responseParametersForActionID:queryParameters:cancelled:error:")]
		NSObject ResponseParametersForActionID (string actionID, NSObject queryParameters, NSObject cancelledRef, NSObject error);
	}

	// @interface FBSDKBridgeAPIRequestFactory
	interface FBSDKBridgeAPIRequestFactory
	{
		// -(id<FBSDKBridgeAPIRequest> _Nullable)bridgeAPIRequestWithProtocolType:(id)protocolType scheme:(NSString * _Nonnull)scheme methodName:(NSString * _Nullable)methodName parameters:(id)parameters userInfo:(id)userInfo __attribute__((warn_unused_result("")));
		[Export ("bridgeAPIRequestWithProtocolType:scheme:methodName:parameters:userInfo:")]
		[return: NullAllowed]
		FBSDKBridgeAPIRequest BridgeAPIRequestWithProtocolType (NSObject protocolType, string scheme, [NullAllowed] string methodName, NSObject parameters, NSObject userInfo);
	}

	// @interface FBSDKDialogConfigurationMapBuilder
	interface FBSDKDialogConfigurationMapBuilder
	{
		// -(id)buildDialogConfigurationMapWithRawConfigurations:(id)rawConfigurations __attribute__((warn_unused_result("")));
		[Export ("buildDialogConfigurationMapWithRawConfigurations:")]
		NSObject BuildDialogConfigurationMapWithRawConfigurations (NSObject rawConfigurations);
	}

	// @interface FBSDKErrorFactory
	interface FBSDKErrorFactory
	{
		// -(id)errorWithCode:(id)code userInfo:(id)userInfo message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("errorWithCode:userInfo:message:underlyingError:")]
		NSObject ErrorWithCode (NSObject code, NSObject userInfo, [NullAllowed] string message, NSObject underlyingError);

		// -(id)errorWithDomain:(NSString * _Nonnull)domain code:(id)code userInfo:(id)userInfo message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("errorWithDomain:code:userInfo:message:underlyingError:")]
		NSObject ErrorWithDomain (string domain, NSObject code, NSObject userInfo, [NullAllowed] string message, NSObject underlyingError);

		// -(id)invalidArgumentErrorWithName:(NSString * _Nonnull)name value:(id _Nullable)value message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("invalidArgumentErrorWithName:value:message:underlyingError:")]
		NSObject InvalidArgumentErrorWithName (string name, [NullAllowed] NSObject value, [NullAllowed] string message, NSObject underlyingError);

		// -(id)invalidArgumentErrorWithDomain:(NSString * _Nonnull)domain name:(NSString * _Nonnull)name value:(id _Nullable)value message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("invalidArgumentErrorWithDomain:name:value:message:underlyingError:")]
		NSObject InvalidArgumentErrorWithDomain (string domain, string name, [NullAllowed] NSObject value, [NullAllowed] string message, NSObject underlyingError);

		// -(id)requiredArgumentErrorWithName:(NSString * _Nonnull)name message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("requiredArgumentErrorWithName:message:underlyingError:")]
		NSObject RequiredArgumentErrorWithName (string name, [NullAllowed] string message, NSObject underlyingError);

		// -(id)requiredArgumentErrorWithDomain:(NSString * _Nonnull)domain name:(NSString * _Nonnull)name message:(NSString * _Nullable)message underlyingError:(id)underlyingError __attribute__((warn_unused_result("")));
		[Export ("requiredArgumentErrorWithDomain:name:message:underlyingError:")]
		NSObject RequiredArgumentErrorWithDomain (string domain, string name, [NullAllowed] string message, NSObject underlyingError);

		// -(id)unknownErrorWithMessage:(NSString * _Nullable)message userInfo:(id)userInfo __attribute__((warn_unused_result("")));
		[Export ("unknownErrorWithMessage:userInfo:")]
		NSObject UnknownErrorWithMessage ([NullAllowed] string message, NSObject userInfo);
	}

	// @interface FBSDKCloseIcon
	interface FBSDKCloseIcon
	{
		// -(UIImage * _Nullable)imageWithSize:(id)size __attribute__((warn_unused_result("")));
		[Export ("imageWithSize:")]
		[return: NullAllowed]
		UIImage ImageWithSize (NSObject size);
	}

	// @interface FBSDKLogo : FBSDKIcon
	[BaseType (typeof(FBSDKIcon))]
	interface FBSDKLogo
	{
		// -(id)pathWith:(id)size __attribute__((warn_unused_result("")));
		[Export ("pathWith:")]
		NSObject PathWith (NSObject size);
	}

	// @interface FBSDKFeatureManager
	interface FBSDKFeatureManager
	{
		// @property (readonly, nonatomic, strong, class) FBSDKFeatureManager * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKFeatureManager Shared { get; }

		// -(id)isEnabled:(id)feature __attribute__((warn_unused_result("")));
		[Export ("isEnabled:")]
		NSObject IsEnabled (NSObject feature);

		// -(void)checkFeature:(id)feature completionBlock:(id)completionBlock;
		[Export ("checkFeature:completionBlock:")]
		void CheckFeature (NSObject feature, NSObject completionBlock);

		// -(void)disableFeature:(id)feature;
		[Export ("disableFeature:")]
		void DisableFeature (NSObject feature);
	}

	// @interface FBSDKHumanSilhouetteIcon : FBSDKIcon
	[BaseType (typeof(FBSDKIcon))]
	interface FBSDKHumanSilhouetteIcon
	{
		// -(id)pathWith:(id)size __attribute__((warn_unused_result("")));
		[Export ("pathWith:")]
		NSObject PathWith (NSObject size);
	}

	// @interface FBSDKMeasurementEvent
	interface FBSDKMeasurementEvent
	{
		// -(void)postNotificationForEventName:(NSString * _Nonnull)eventName args:(id)arguments;
		[Export ("postNotificationForEventName:args:")]
		void PostNotificationForEventName (string eventName, NSObject arguments);
	}

	// @interface FBSDKPaymentObserver
	[Deprecated (PlatformName.iOS, 18, 0)]
	[DisableDefaultCtor]
	interface FBSDKPaymentObserver
	{
		// -(instancetype _Nonnull)initWithPaymentQueue:(SKPaymentQueue * _Nonnull)paymentQueue paymentProductRequestorFactory:(id<FBSDKPaymentProductRequestorCreating> _Nonnull)paymentProductRequestorFactory __attribute__((objc_designated_initializer));
		[Export ("initWithPaymentQueue:paymentProductRequestorFactory:")]
		[DesignatedInitializer]
		NativeHandle Constructor (SKPaymentQueue paymentQueue, FBSDKPaymentProductRequestorCreating paymentProductRequestorFactory);

		// -(void)startObservingTransactions;
		[Export ("startObservingTransactions")]
		void StartObservingTransactions ();

		// -(void)stopObservingTransactions;
		[Export ("stopObservingTransactions")]
		void StopObservingTransactions ();
	}

	// @interface FBSDKCoreKit_Swift_2778 (FBSDKPaymentObserver)
	[Deprecated (PlatformName.iOS, 18, 0)]
	[Category]
	[BaseType (typeof(FBSDKPaymentObserver))]
	interface FBSDKPaymentObserver_FBSDKCoreKit_Swift_2778
	{
		// -(void)paymentQueue:(SKPaymentQueue * _Nonnull)queue updatedTransactions:(id)transactions;
		[Export ("paymentQueue:updatedTransactions:")]
		void PaymentQueue (SKPaymentQueue queue, NSObject transactions);
	}

	// @interface FBSDKPaymentProductRequestorFactory <FBSDKPaymentProductRequestorCreating>
	[Deprecated (PlatformName.iOS, 18, 0)]
	interface FBSDKPaymentProductRequestorFactory : IFBSDKPaymentProductRequestorCreating
	{
		// -(FBSDKPaymentProductRequestor * _Nonnull)createRequestorWithTransaction:(SKPaymentTransaction * _Nonnull)transaction __attribute__((warn_unused_result("")));
		[Export ("createRequestorWithTransaction:")]
		FBSDKPaymentProductRequestor CreateRequestorWithTransaction (SKPaymentTransaction transaction);
	}

	// @interface FBSDKRestrictiveEventFilter
	[DisableDefaultCtor]
	interface FBSDKRestrictiveEventFilter
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull eventName;
		[Export ("eventName")]
		string EventName { get; }

		// -(instancetype _Nonnull)initWithEventName:(NSString * _Nonnull)eventName restrictiveParameters:(id)restrictiveParameters __attribute__((objc_designated_initializer));
		[Export ("initWithEventName:restrictiveParameters:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string eventName, NSObject restrictiveParameters);
	}

	// @interface FBSDKSKAdNetworkEvent
	[DisableDefaultCtor]
	interface FBSDKSKAdNetworkEvent
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable eventName;
		[NullAllowed, Export ("eventName")]
		string EventName { get; }

		// -(instancetype _Nullable)initWithJSON:(id)json __attribute__((objc_designated_initializer));
		[Export ("initWithJSON:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject json);
	}

	// @interface FBSDKViewImpressionLogger
	[DisableDefaultCtor]
	interface FBSDKViewImpressionLogger
	{
		// -(instancetype _Nonnull)initWithEventName:(id)eventName __attribute__((objc_designated_initializer));
		[Export ("initWithEventName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject eventName);

		// +(FBSDKViewImpressionLogger * _Nonnull)retrieveLoggerWith:(id)eventName __attribute__((warn_unused_result("")));
		[Static]
		[Export ("retrieveLoggerWith:")]
		FBSDKViewImpressionLogger RetrieveLoggerWith (NSObject eventName);

		// -(void)logImpressionWithIdentifier:(NSString * _Nonnull)identifier parameters:(id)parameters;
		[Export ("logImpressionWithIdentifier:parameters:")]
		void LogImpressionWithIdentifier (string identifier, NSObject parameters);
	}

	// @interface FBSDKWebDialog
	[DisableDefaultCtor]
	interface FBSDKWebDialog
	{
		// @property (nonatomic) int shouldDeferVisibility;
		[Export ("shouldDeferVisibility")]
		int ShouldDeferVisibility { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKWebDialogDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKWebDialogDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name parameters:(id)parameters webViewFrame:(id)webViewFrame path:(NSString * _Nullable)path __attribute__((objc_designated_initializer));
		[Export ("initWithName:parameters:webViewFrame:path:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, NSObject parameters, NSObject webViewFrame, [NullAllowed] string path);

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name;
		[Export ("initWithName:")]
		NativeHandle Constructor (string name);

		// -(void)show;
		[Export ("show")]
		void Show ();
	}

	// @interface FBSDKCoreKit_Swift_2844 (FBSDKWebDialog)
	[Category]
	[BaseType (typeof(FBSDKWebDialog))]
	interface FBSDKWebDialog_FBSDKCoreKit_Swift_2844
	{
		// -(void)webDialogView:(FBSDKWebDialogView * _Nonnull)webDialogView didCompleteWithResults:(id)results;
		[Export ("webDialogView:didCompleteWithResults:")]
		void WebDialogView (FBSDKWebDialogView webDialogView, NSObject results);

		// -(void)webDialogView:(FBSDKWebDialogView * _Nonnull)webDialogView didFailWithError:(id)error;
		[Export ("webDialogView:didFailWithError:")]
		void WebDialogView (FBSDKWebDialogView webDialogView, NSObject error);

		// -(void)webDialogViewDidCancel:(FBSDKWebDialogView * _Nonnull)webDialogView;
		[Export ("webDialogViewDidCancel:")]
		void WebDialogViewDidCancel (FBSDKWebDialogView webDialogView);

		// -(void)webDialogViewDidFinishLoad:(FBSDKWebDialogView * _Nonnull)webDialogView;
		[Export ("webDialogViewDidFinishLoad:")]
		void WebDialogViewDidFinishLoad (FBSDKWebDialogView webDialogView);
	}

	// @interface FBSDKWebViewFactory
	interface FBSDKWebViewFactory
	{
		// -(id<FBSDKWebView> _Nonnull)createWebViewWithFrame:(id)frame __attribute__((warn_unused_result("")));
		[Export ("createWebViewWithFrame:")]
		FBSDKWebView CreateWebViewWithFrame (NSObject frame);
	}
}
