using System;
using FBSDKLoginKit;
using Foundation;
using ObjCRuntime;

namespace Facebook.Login
{
	// @interface FBSDKCodeVerifier
	interface FBSDKCodeVerifier
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull challenge;
		[Export ("challenge")]
		string Challenge { get; }

		// -(instancetype _Nullable)initWithString:(NSString * _Nonnull)string;
		[Export ("initWithString:")]
		NativeHandle Constructor (string @string);
	}

	// @interface FBSDKDeviceLoginCodeInfo
	[DisableDefaultCtor]
	interface FBSDKDeviceLoginCodeInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull loginCode;
		[Export ("loginCode")]
		string LoginCode { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull verificationURL;
		[Export ("verificationURL", ArgumentSemantic.Copy)]
		NSURL VerificationURL { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull expirationDate;
		[Export ("expirationDate", ArgumentSemantic.Copy)]
		NSDate ExpirationDate { get; }

		// @property (readonly, nonatomic) int pollingInterval;
		[Export ("pollingInterval")]
		int PollingInterval { get; }

		// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier loginCode:(NSString * _Nonnull)loginCode verificationURL:(NSURL * _Nonnull)verificationURL expirationDate:(NSDate * _Nonnull)expirationDate pollingInterval:(id)pollingInterval __attribute__((objc_designated_initializer));
		[Export ("initWithIdentifier:loginCode:verificationURL:expirationDate:pollingInterval:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string identifier, string loginCode, NSURL verificationURL, NSDate expirationDate, NSObject pollingInterval);
	}

	// @interface FBSDKDeviceLoginManager
	[DisableDefaultCtor]
	interface FBSDKDeviceLoginManager
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKDeviceLoginManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKDeviceLoginManagerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable redirectURL;
		[NullAllowed, Export ("redirectURL", ArgumentSemantic.Copy)]
		NSURL RedirectURL { get; set; }

		// -(instancetype _Nonnull)initWithPermissions:(id)permissions enableSmartLogin:(id)enableSmartLogin __attribute__((objc_designated_initializer));
		[Export ("initWithPermissions:enableSmartLogin:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject permissions, NSObject enableSmartLogin);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();
	}

	// @interface FBSDKLoginKit_Swift_1532 (FBSDKDeviceLoginManager)
	[Category]
	[BaseType (typeof(FBSDKDeviceLoginManager))]
	interface FBSDKDeviceLoginManager_FBSDKLoginKit_Swift_1532
	{
		// -(void)netService:(NSNetService * _Nonnull)service didNotPublish:(id)errorValues;
		[Export ("netService:didNotPublish:")]
		void NetService (NSNetService service, NSObject errorValues);
	}

	// @protocol FBSDKDeviceLoginManagerDelegate
	[Protocol, Model]
	interface FBSDKDeviceLoginManagerDelegate
	{
		// @required -(void)deviceLoginManager:(FBSDKDeviceLoginManager * _Nonnull)loginManager startedWithCodeInfo:(FBSDKDeviceLoginCodeInfo * _Nonnull)codeInfo;
		[Abstract]
		[Export ("deviceLoginManager:startedWithCodeInfo:")]
		void StartedWithCodeInfo (FBSDKDeviceLoginManager loginManager, FBSDKDeviceLoginCodeInfo codeInfo);

		// @required -(void)deviceLoginManager:(FBSDKDeviceLoginManager * _Nonnull)loginManager completedWithResult:(FBSDKDeviceLoginManagerResult * _Nullable)result error:(id)error;
		[Abstract]
		[Export ("deviceLoginManager:completedWithResult:error:")]
		void CompletedWithResult (FBSDKDeviceLoginManager loginManager, [NullAllowed] FBSDKDeviceLoginManagerResult result, NSObject error);
	}

	// @interface FBSDKDeviceLoginManagerResult
	[DisableDefaultCtor]
	interface FBSDKDeviceLoginManagerResult
	{
		// @property (readonly, nonatomic, strong) FBSDKAccessToken * _Nullable accessToken;
		[NullAllowed, Export ("accessToken", ArgumentSemantic.Strong)]
		FBSDKAccessToken AccessToken { get; }

		// @property (readonly, nonatomic) int isCancelled;
		[Export ("isCancelled")]
		int IsCancelled { get; }

		// -(instancetype _Nonnull)initWithToken:(FBSDKAccessToken * _Nullable)token isCancelled:(id)cancelled __attribute__((objc_designated_initializer));
		[Export ("initWithToken:isCancelled:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] FBSDKAccessToken token, NSObject cancelled);
	}

	// @interface FBSDKLoginButton
	interface FBSDKLoginButton
	{
		// @property (nonatomic) enum FBSDKDefaultAudience defaultAudience;
		[Export ("defaultAudience", ArgumentSemantic.Assign)]
		FBSDKDefaultAudience DefaultAudience { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKLoginButtonDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKLoginButtonDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) enum FBSDKLoginButtonTooltipBehavior tooltipBehavior;
		[Export ("tooltipBehavior", ArgumentSemantic.Assign)]
		FBSDKLoginButtonTooltipBehavior TooltipBehavior { get; set; }

		// @property (nonatomic) enum FBSDKTooltipColorStyle tooltipColorStyle;
		[Export ("tooltipColorStyle", ArgumentSemantic.Assign)]
		FBSDKTooltipColorStyle TooltipColorStyle { get; set; }

		// @property (nonatomic) enum FBSDKLoginTracking loginTracking;
		[Export ("loginTracking", ArgumentSemantic.Assign)]
		FBSDKLoginTracking LoginTracking { get; set; }

		// @property (nonatomic) enum FBSDKAppSwitch appSwitch;
		[Export ("appSwitch", ArgumentSemantic.Assign)]
		FBSDKAppSwitch AppSwitch { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable nonce;
		[NullAllowed, Export ("nonce")]
		string Nonce { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable messengerPageId;
		[NullAllowed, Export ("messengerPageId")]
		string MessengerPageId { get; set; }

		// @property (nonatomic) int authType;
		[Export ("authType")]
		int AuthType { get; set; }

		// @property (nonatomic, strong) FBSDKCodeVerifier * _Nonnull codeVerifier;
		[Export ("codeVerifier", ArgumentSemantic.Strong)]
		FBSDKCodeVerifier CodeVerifier { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject frame);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(id)imageRectForContentRect:(id)contentRect __attribute__((warn_unused_result("")));
		[Export ("imageRectForContentRect:")]
		NSObject ImageRectForContentRect (NSObject contentRect);

		// -(id)titleRectForContentRect:(id)contentRect __attribute__((warn_unused_result("")));
		[Export ("titleRectForContentRect:")]
		NSObject TitleRectForContentRect (NSObject contentRect);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(id)sizeThatFits:(id)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		NSObject SizeThatFits (NSObject size);
	}

	// @interface FBSDKTooltipView
	[DisableDefaultCtor]
	interface FBSDKTooltipView
	{
		// @property (nonatomic) int displayDuration;
		[Export ("displayDuration")]
		int DisplayDuration { get; set; }

		// @property (nonatomic) enum FBSDKTooltipColorStyle colorStyle;
		[Export ("colorStyle", ArgumentSemantic.Assign)]
		FBSDKTooltipColorStyle ColorStyle { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable message;
		[NullAllowed, Export ("message")]
		string Message { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable tagline;
		[NullAllowed, Export ("tagline")]
		string Tagline { get; set; }

		// -(instancetype _Nonnull)initWithTagline:(NSString * _Nullable)tagline message:(NSString * _Nullable)message colorStyle:(enum FBSDKTooltipColorStyle)colorStyle __attribute__((objc_designated_initializer));
		[Export ("initWithTagline:message:colorStyle:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string tagline, [NullAllowed] string message, FBSDKTooltipColorStyle colorStyle);

		// -(void)presentFromView:(id)anchorView;
		[Export ("presentFromView:")]
		void PresentFromView (NSObject anchorView);

		// -(void)presentInView:(id)view withArrowPosition:(id)arrowPosition direction:(enum FBSDKTooltipViewArrowDirection)direction;
		[Export ("presentInView:withArrowPosition:direction:")]
		void PresentInView (NSObject view, NSObject arrowPosition, FBSDKTooltipViewArrowDirection direction);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();

		// -(void)drawRect:(id)rect;
		[Export ("drawRect:")]
		void DrawRect (NSObject rect);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

	// @interface FBSDKLoginTooltipView : FBSDKTooltipView
	[BaseType (typeof(FBSDKTooltipView))]
	interface FBSDKLoginTooltipView
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKLoginTooltipViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKLoginTooltipViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) int forceDisplay;
		[Export ("forceDisplay")]
		int ForceDisplay { get; set; }

		// @property (nonatomic) int shouldForceDisplay;
		[Export ("shouldForceDisplay")]
		int ShouldForceDisplay { get; set; }

		// -(instancetype _Nonnull)initWithTagline:(NSString * _Nullable)tagline message:(NSString * _Nullable)message colorStyle:(enum FBSDKTooltipColorStyle)colorStyle __attribute__((objc_designated_initializer));
		[Export ("initWithTagline:message:colorStyle:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string tagline, [NullAllowed] string message, FBSDKTooltipColorStyle colorStyle);

		// -(void)presentInView:(id)view withArrowPosition:(id)arrowPosition direction:(enum FBSDKTooltipViewArrowDirection)direction;
		[Export ("presentInView:withArrowPosition:direction:")]
		void PresentInView (NSObject view, NSObject arrowPosition, FBSDKTooltipViewArrowDirection direction);
	}

	// @interface FBSDKPermission
	[DisableDefaultCtor]
	interface FBSDKPermission
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// @property (readonly, nonatomic) int hash;
		[Export ("hash")]
		int Hash { get; }

		// -(instancetype _Nullable)initWithString:(NSString * _Nonnull)string __attribute__((objc_designated_initializer));
		[Export ("initWithString:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string @string);

		// +(id)permissionsFromRawPermissions:(id)rawPermissions __attribute__((warn_unused_result("")));
		[Static]
		[Export ("permissionsFromRawPermissions:")]
		NSObject PermissionsFromRawPermissions (NSObject rawPermissions);

		// +(id)rawPermissionsFromPermissions:(id)permissions __attribute__((warn_unused_result("")));
		[Static]
		[Export ("rawPermissionsFromPermissions:")]
		NSObject RawPermissionsFromPermissions (NSObject permissions);

		// -(id)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		NSObject IsEqual ([NullAllowed] NSObject @object);
	}

	// @protocol FBSDKLoginButtonDelegate
	[Protocol, Model]
	interface FBSDKLoginButtonDelegate
	{
		// @required -(void)loginButton:(FBSDKLoginButton * _Nonnull)loginButton didCompleteWithResult:(FBSDKLoginManagerLoginResult * _Nullable)result error:(id)error;
		[Abstract]
		[Export ("loginButton:didCompleteWithResult:error:")]
		void LoginButton (FBSDKLoginButton loginButton, [NullAllowed] FBSDKLoginManagerLoginResult result, NSObject error);

		// @required -(void)loginButtonDidLogOut:(FBSDKLoginButton * _Nonnull)loginButton;
		[Abstract]
		[Export ("loginButtonDidLogOut:")]
		void LoginButtonDidLogOut (FBSDKLoginButton loginButton);

		// @optional -(id)loginButtonWillLogin:(FBSDKLoginButton * _Nonnull)loginButton __attribute__((warn_unused_result("")));
		[Export ("loginButtonWillLogin:")]
		NSObject LoginButtonWillLogin (FBSDKLoginButton loginButton);
	}

	// @interface FBSDKLoginConfiguration
	[DisableDefaultCtor]
	interface FBSDKLoginConfiguration
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull nonce;
		[Export ("nonce")]
		string Nonce { get; }

		// @property (readonly, nonatomic) enum FBSDKLoginTracking tracking;
		[Export ("tracking")]
		FBSDKLoginTracking Tracking { get; }

		// @property (readonly, nonatomic) enum FBSDKAppSwitch appSwitch;
		[Export ("appSwitch")]
		FBSDKAppSwitch AppSwitch { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable messengerPageId;
		[NullAllowed, Export ("messengerPageId")]
		string MessengerPageId { get; }

		// @property (readonly, nonatomic) int authType;
		[Export ("authType")]
		int AuthType { get; }

		// @property (readonly, nonatomic, strong) FBSDKCodeVerifier * _Nonnull codeVerifier;
		[Export ("codeVerifier", ArgumentSemantic.Strong)]
		FBSDKCodeVerifier CodeVerifier { get; }

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId;
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:appSwitch:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType;
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:authType:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId, NSObject authType);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:authType:appSwitch:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId, NSObject authType, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce;
		[Export ("initWithPermissions:tracking:nonce:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, string nonce);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:nonce:appSwitch:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, string nonce, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking messengerPageId:(NSString * _Nullable)messengerPageId;
		[Export ("initWithPermissions:tracking:messengerPageId:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, [NullAllowed] string messengerPageId);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking messengerPageId:(NSString * _Nullable)messengerPageId appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:messengerPageId:appSwitch:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, [NullAllowed] string messengerPageId, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType;
		[Export ("initWithPermissions:tracking:messengerPageId:authType:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, [NullAllowed] string messengerPageId, NSObject authType);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:messengerPageId:authType:appSwitch:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, [NullAllowed] string messengerPageId, NSObject authType, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType appSwitch:(enum FBSDKAppSwitch)appSwitch codeVerifier:(FBSDKCodeVerifier * _Nonnull)codeVerifier __attribute__((objc_designated_initializer));
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:authType:appSwitch:codeVerifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId, NSObject authType, FBSDKAppSwitch appSwitch, FBSDKCodeVerifier codeVerifier);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking;
		[Export ("initWithPermissions:tracking:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:appSwitch:")]
		NativeHandle Constructor (NSObject permissions, FBSDKLoginTracking tracking, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithTracking:(enum FBSDKLoginTracking)tracking;
		[Export ("initWithTracking:")]
		NativeHandle Constructor (FBSDKLoginTracking tracking);

		// -(instancetype _Nullable)initWithTracking:(enum FBSDKLoginTracking)tracking appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithTracking:appSwitch:")]
		NativeHandle Constructor (FBSDKLoginTracking tracking, FBSDKAppSwitch appSwitch);
	}

	// @interface FBSDKLoginManager
	interface FBSDKLoginManager
	{
		// @property (nonatomic) enum FBSDKDefaultAudience defaultAudience;
		[Export ("defaultAudience", ArgumentSemantic.Assign)]
		FBSDKDefaultAudience DefaultAudience { get; set; }

		// -(instancetype _Nonnull)initWithDefaultAudience:(enum FBSDKDefaultAudience)defaultAudience;
		[Export ("initWithDefaultAudience:")]
		NativeHandle Constructor (FBSDKDefaultAudience defaultAudience);

		// -(void)logInFromViewController:(UIViewController * _Nullable)viewController configuration:(FBSDKLoginConfiguration * _Nullable)configuration completion:(id)completion;
		[Export ("logInFromViewController:configuration:completion:")]
		void LogInFromViewController ([NullAllowed] UIViewController viewController, [NullAllowed] FBSDKLoginConfiguration configuration, NSObject completion);

		// -(void)logInWithPermissions:(id)permissions fromViewController:(UIViewController * _Nullable)viewController handler:(id)handler;
		[Export ("logInWithPermissions:fromViewController:handler:")]
		void LogInWithPermissions (NSObject permissions, [NullAllowed] UIViewController viewController, NSObject handler);

		// -(void)reauthorizeDataAccess:(UIViewController * _Nullable)viewController handler:(id)handler;
		[Export ("reauthorizeDataAccess:handler:")]
		void ReauthorizeDataAccess ([NullAllowed] UIViewController viewController, NSObject handler);

		// -(void)logOut;
		[Export ("logOut")]
		void LogOut ();
	}

	// @interface FBSDKLoginKit_Swift_2074 (FBSDKLoginManager)
	[Category]
	[BaseType (typeof(FBSDKLoginManager))]
	interface FBSDKLoginManager_FBSDKLoginKit_Swift_2074
	{
		// -(void)refreshLimitedLoginFromViewController:(UIViewController * _Nullable)viewController fallbackPolicy:(enum FBSDKRefreshFallbackPolicy)fallbackPolicy completion:(void (^ _Nonnull)(FBSDKProfile * _Nullable, int * _Nullable))completion;
		[Export ("refreshLimitedLoginFromViewController:fallbackPolicy:completion:")]
		unsafe void RefreshLimitedLoginFromViewController ([NullAllowed] UIViewController viewController, FBSDKRefreshFallbackPolicy fallbackPolicy, Action<FBSDKProfile, int*> completion);
	}

	// @interface FBSDKLoginKit_Swift_2085 (FBSDKLoginManager)
	[Category]
	[BaseType (typeof(FBSDKLoginManager))]
	interface FBSDKLoginManager_FBSDKLoginKit_Swift_2085
	{
		// +(FBSDKLoginManager * _Nonnull)makeOpener __attribute__((warn_unused_result("")));
		[Static]
		[Export ("makeOpener")]
		[Verify (MethodToProperty)]
		FBSDKLoginManager MakeOpener { get; }

		// -(id)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		NSObject Application ([NullAllowed] UIApplication application, [NullAllowed] NSURL url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		NSObject CanOpenURL (NSURL url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(void)applicationDidBecomeActive:(UIApplication * _Nonnull)application;
		[Export ("applicationDidBecomeActive:")]
		void ApplicationDidBecomeActive (UIApplication application);

		// -(id)isAuthenticationURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("isAuthenticationURL:")]
		NSObject IsAuthenticationURL (NSURL url);

		// -(id)shouldStopPropagationOfURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("shouldStopPropagationOfURL:")]
		NSObject ShouldStopPropagationOfURL (NSURL url);
	}

	// @interface FBSDKLoginManagerLoginResult
	[DisableDefaultCtor]
	interface FBSDKLoginManagerLoginResult
	{
		// @property (readonly, nonatomic, strong) FBSDKAccessToken * _Nullable token;
		[NullAllowed, Export ("token", ArgumentSemantic.Strong)]
		FBSDKAccessToken Token { get; }

		// @property (readonly, nonatomic, strong) FBSDKAuthenticationToken * _Nullable authenticationToken;
		[NullAllowed, Export ("authenticationToken", ArgumentSemantic.Strong)]
		FBSDKAuthenticationToken AuthenticationToken { get; }

		// @property (readonly, nonatomic) int isCancelled;
		[Export ("isCancelled")]
		int IsCancelled { get; }

		// -(instancetype _Nonnull)initWithToken:(FBSDKAccessToken * _Nullable)token authenticationToken:(FBSDKAuthenticationToken * _Nullable)authenticationToken isCancelled:(id)isCancelled grantedPermissions:(id)grantedPermissions declinedPermissions:(id)declinedPermissions __attribute__((objc_designated_initializer));
		[Export ("initWithToken:authenticationToken:isCancelled:grantedPermissions:declinedPermissions:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] FBSDKAccessToken token, [NullAllowed] FBSDKAuthenticationToken authenticationToken, NSObject isCancelled, NSObject grantedPermissions, NSObject declinedPermissions);
	}

	// @protocol FBSDKLoginTooltipViewDelegate
	[Protocol, Model]
	interface FBSDKLoginTooltipViewDelegate
	{
		// @optional -(id)loginTooltipView:(FBSDKLoginTooltipView * _Nonnull)view shouldAppear:(id)appIsEligible __attribute__((warn_unused_result("")));
		[Export ("loginTooltipView:shouldAppear:")]
		NSObject LoginTooltipView (FBSDKLoginTooltipView view, NSObject appIsEligible);

		// @optional -(void)loginTooltipViewWillAppear:(FBSDKLoginTooltipView * _Nonnull)view;
		[Export ("loginTooltipViewWillAppear:")]
		void LoginTooltipViewWillAppear (FBSDKLoginTooltipView view);

		// @optional -(void)loginTooltipViewWillNotAppear:(FBSDKLoginTooltipView * _Nonnull)view;
		[Export ("loginTooltipViewWillNotAppear:")]
		void LoginTooltipViewWillNotAppear (FBSDKLoginTooltipView view);
	}

	// @interface FBSDKLoginCompletionParameters
	interface FBSDKLoginCompletionParameters
	{
		// @property (nonatomic, strong) FBSDKAuthenticationToken * _Nullable authenticationToken;
		[NullAllowed, Export ("authenticationToken", ArgumentSemantic.Strong)]
		FBSDKAuthenticationToken AuthenticationToken { get; set; }

		// @property (nonatomic, strong) FBSDKProfile * _Nullable profile;
		[NullAllowed, Export ("profile", ArgumentSemantic.Strong)]
		FBSDKProfile Profile { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accessTokenString;
		[NullAllowed, Export ("accessTokenString")]
		string AccessTokenString { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable nonceString;
		[NullAllowed, Export ("nonceString")]
		string NonceString { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable authenticationTokenString;
		[NullAllowed, Export ("authenticationTokenString")]
		string AuthenticationTokenString { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable code;
		[NullAllowed, Export ("code")]
		string Code { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable appID;
		[NullAllowed, Export ("appID")]
		string AppID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable userID;
		[NullAllowed, Export ("userID")]
		string UserID { get; set; }

		// @property (nonatomic) int * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Assign)]
		unsafe int* Error { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable expirationDate;
		[NullAllowed, Export ("expirationDate", ArgumentSemantic.Copy)]
		NSDate ExpirationDate { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable dataAccessExpirationDate;
		[NullAllowed, Export ("dataAccessExpirationDate", ArgumentSemantic.Copy)]
		NSDate DataAccessExpirationDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable challenge;
		[NullAllowed, Export ("challenge")]
		string Challenge { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable graphDomain;
		[NullAllowed, Export ("graphDomain")]
		string GraphDomain { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable userTokenNonce;
		[NullAllowed, Export ("userTokenNonce")]
		string UserTokenNonce { get; set; }
	}
}
