
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;
using UIKit;
using CoreGraphics;

using Facebook.Core;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Facebook.Login
{
	// @interface FBSDKCodeVerifier
	[BaseType(typeof(NSObject))]
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
	[BaseType(typeof(NSObject))]
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
		NSUrl VerificationURL { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull expirationDate;
		[Export ("expirationDate", ArgumentSemantic.Copy)]
		NSDate ExpirationDate { get; }

		// @property (readonly, nonatomic) int pollingInterval;
		[Export ("pollingInterval")]
		nuint PollingInterval { get; }

		// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier loginCode:(NSString * _Nonnull)loginCode verificationURL:(NSURL * _Nonnull)verificationURL expirationDate:(NSDate * _Nonnull)expirationDate pollingInterval:(id)pollingInterval __attribute__((objc_designated_initializer));
		[Export ("initWithIdentifier:loginCode:verificationURL:expirationDate:pollingInterval:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string identifier, string loginCode, NSUrl verificationURL, NSDate expirationDate, NSObject pollingInterval);
	}
	
	// @interface FBSDKDeviceLoginManager
	[BaseType (typeof (NSObject),
	Delegates = new string [] { "Delegate" },
	Events = new Type [] { typeof (FBSDKDeviceLoginManagerDelegate) })]
	[DisableDefaultCtor]
	interface FBSDKDeviceLoginManager
	{
		// @property (nonatomic, weak) id<FBSDKDeviceLoginManagerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKDeviceLoginManagerDelegate Delegate { get; set; }
		
		// @property (nonatomic, readonly, copy) NSArray<NSString *> * _Nonnull permissions;
		[Export ("permissions")]
		string[] Permissions { get; }

		// @property (copy, nonatomic) NSURL * _Nullable redirectURL;
		[NullAllowed, Export ("redirectURL", ArgumentSemantic.Copy)]
		NSUrl RedirectURL { get; set; }

		// -(instancetype _Nonnull)initWithPermissions:(id)permissions enableSmartLogin:(id)enableSmartLogin __attribute__((objc_designated_initializer));
		[Export ("initWithPermissions:enableSmartLogin:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string[] permissions, bool enableSmartLogin);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		///
		/// FBSDKDeviceLoginManager_Extension
		/// 
		
		// -(void)netService:(NSNetService * _Nonnull)service didNotPublish:(id)errorValues;
		[Export ("netService:didNotPublish:")]
		void NetService(NSNetService service, NSDictionary<NSString, NSNumber> errorValues);
	}

	// @protocol FBSDKDeviceLoginManagerDelegate
	interface IFBSDKDeviceLoginManagerDelegate {}

	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKDeviceLoginManagerDelegate
	{
		// @required -(void)deviceLoginManager:(FBSDKDeviceLoginManager * _Nonnull)loginManager startedWithCodeInfo:(FBSDKDeviceLoginCodeInfo * _Nonnull)codeInfo;
		[Abstract]
		[EventArgs ("FBSDKDeviceLoginStarted")]
		[EventName ("Started")]
		[Export ("deviceLoginManager:startedWithCodeInfo:")]
		void Started (FBSDKDeviceLoginManager loginManager, FBSDKDeviceLoginCodeInfo codeInfo);

		// @required -(void)deviceLoginManager:(FBSDKDeviceLoginManager * _Nonnull)loginManager completedWithResult:(FBSDKDeviceLoginManagerResult * _Nullable)result error:(id)error;
		[Abstract]
		[EventArgs ("FBSDKDeviceLoginCompleted")]
		[EventName ("Completed")]
		[Export ("deviceLoginManager:completedWithResult:error:")]
		void CompletedWithResult (FBSDKDeviceLoginManager loginManager, [NullAllowed] FBSDKDeviceLoginManagerResult result, [NullAllowed] NSError error);
	}

	// @interface FBSDKDeviceLoginManagerResult
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface FBSDKDeviceLoginManagerResult
	{
		// @property (readonly, nonatomic, strong) FBSDKAccessToken * _Nullable accessToken;
		[NullAllowed, Export ("accessToken", ArgumentSemantic.Strong)]
		FBSDKAccessToken AccessToken { get; }

		// @property (readonly, nonatomic) int isCancelled;
		[Export ("isCancelled")]
		bool IsCancelled { get; }

		// -(instancetype _Nonnull)initWithToken:(FBSDKAccessToken * _Nullable)token isCancelled:(id)cancelled __attribute__((objc_designated_initializer));
		[Export ("initWithToken:isCancelled:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] FBSDKAccessToken token, bool cancelled);
	}

	// @interface FBSDKLoginButton
	[BaseType (typeof (FBSDKButton),
	Delegates = new string [] { "Delegate" },
	Events = new Type [] { typeof (FBSDKLoginButtonDelegate) })]
	interface FBSDKLoginButton
	{
		// @property (nonatomic) enum FBSDKDefaultAudience defaultAudience;
		[Export ("defaultAudience", ArgumentSemantic.Assign)]
		FBSDKDefaultAudience DefaultAudience { get; set; }

		// @property (nonatomic, weak) id<FBSDKLoginButtonDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKLoginButtonDelegate Delegate { get; set; }

		// @property (nonatomic, copy) NSArray<NSString *> * _Nonnull permissions;
		[Export ("permissions", ArgumentSemantic.Copy)]
		string[] Permissions { get; set; }

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
		[NullAllowed, Export ("authType")]
		NSString AuthType { get; set; }

		// @property (nonatomic, strong) FBSDKCodeVerifier * _Nonnull codeVerifier;
		[Export ("codeVerifier", ArgumentSemantic.Strong)]
		FBSDKCodeVerifier CodeVerifier { get; set; }

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// (nonnull instancetype)initWithFrame:(CGRect)frame OBJC_DESIGNATED_INITIALIZER;
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);
	}

	// @interface FBSDKTooltipView
	[BaseType(typeof(UIView))]
	[DisableDefaultCtor]
	interface FBSDKTooltipView
	{
		// @property (nonatomic) NSTimeInterval displayDuration;
		[Export("displayDuration")]
		double DisplayDuration { get; set; }

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
		void PresentFromView (UIView anchorView);

		// -(void)presentInView:(id)view withArrowPosition:(id)arrowPosition direction:(enum FBSDKTooltipViewArrowDirection)direction;
		[Export ("presentInView:withArrowPosition:direction:")]
		void PresentInView (UIView view, CGPoint arrowPosition, FBSDKTooltipViewArrowDirection direction);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();

		// -(void)drawRect:(id)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);
	}

	// @interface FBSDKLoginTooltipView : FBSDKTooltipView
	[BaseType (typeof (FBSDKTooltipView),
	Delegates = new string [] { "Delegate" },
	Events = new Type [] { typeof (FBSDKLoginTooltipViewDelegate) })]
	interface FBSDKLoginTooltipView
	{
		// @property (nonatomic, weak) id<FBSDKLoginTooltipViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKLoginTooltipViewDelegate Delegate { get; set; }

		// @property (nonatomic) int forceDisplay;
		[Export ("forceDisplay")]
		bool ForceDisplay { get; set; }

		// @property (nonatomic) int shouldForceDisplay;
		[Export ("shouldForceDisplay")]
		bool ShouldForceDisplay { get; set; }

		// -(instancetype _Nonnull)initWithTagline:(NSString * _Nullable)tagline message:(NSString * _Nullable)message colorStyle:(enum FBSDKTooltipColorStyle)colorStyle __attribute__((objc_designated_initializer));
		[Export ("initWithTagline:message:colorStyle:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string tagline, [NullAllowed] string message, FBSDKTooltipColorStyle colorStyle);

		// -(void)presentInView:(id)view withArrowPosition:(id)arrowPosition direction:(enum FBSDKTooltipViewArrowDirection)direction;
		[Export ("presentInView:withArrowPosition:direction:")]
		void Present (UIView view, NSObject arrowPosition, FBSDKTooltipViewArrowDirection direction);
	}

	// @interface FBSDKPermission
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKPermission
	{
		// -(instancetype _Nullable)initWithString:(NSString * _Nonnull)string __attribute__((objc_designated_initializer));
		[NullAllowed, Export("initWithString:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string @string);

		// +(id)permissionsFromRawPermissions:(id)rawPermissions __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("permissionsFromRawPermissions:")]
		FBSDKPermission[] GetPermissions (NSSet<NSString> rawPermissions);

		// +(id)rawPermissionsFromPermissions:(id)permissions __attribute__((warn_unused_result("")));
		[Static]
		[Export ("rawPermissionsFromPermissions:")]
		NSSet<NSString> GetRawPermissions (FBSDKPermission[] permissions);
	}

	delegate bool FBSDKLoginButtonWillLogin (FBSDKLoginButton loginButton);

	// @protocol FBSDKLoginButtonDelegate
	interface IFBSDKLoginButtonDelegate {}

	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKLoginButtonDelegate
	{
		// @required -(void)loginButton:(FBSDKLoginButton * _Nonnull)loginButton didCompleteWithResult:(FBSDKLoginManagerLoginResult * _Nullable)result error:(id)error;
		[Abstract]
		[EventArgs ("FBSDKLoginCompleted")]
		[EventName ("Completed")]
		[Export ("loginButton:didCompleteWithResult:error:")]
		void DidComplete (FBSDKLoginButton loginButton, [NullAllowed] FBSDKLoginManagerLoginResult result, [NullAllowed] NSError error);

		// @required -(void)loginButtonDidLogOut:(FBSDKLoginButton * _Nonnull)loginButton;
		[Abstract]
		[EventArgs ("FBSDKLogoutCompleted")]
		[EventName ("LoggedOut")]
		[Export ("loginButtonDidLogOut:")]
		void DidLogOut (FBSDKLoginButton loginButton);

		// @optional -(id)loginButtonWillLogin:(FBSDKLoginButton * _Nonnull)loginButton __attribute__((warn_unused_result("")));
		[DefaultValue(true)]
		[DelegateName ("FBSDKLoginButtonWillLogin")]
		[Export ("loginButtonWillLogin:")]
		bool WillLogIn (FBSDKLoginButton loginButton);
	}

	[Static]
	interface FBSDKLoginAuthType
	{
		[Field("FBSDKLoginAuthTypeRerequest", "__Internal")]
		NSString Rerequest { get; }

		[Field("FBSDKLoginAuthTypeReauthorize", "__Internal")]
		NSString Reauthorize { get; }
	}

	// @interface FBSDKLoginConfiguration
	[BaseType(typeof(NSObject))]
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

		//@property (nonatomic, readonly, copy) NSSet<FBSDKPermission *> * _Nonnull requestedPermissions;
		[Export("requestedPermissions", ArgumentSemantic.Copy)]
		FBSDKPermission[] RequestedPermissions { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable messengerPageId;
		[NullAllowed, Export ("messengerPageId")]
		string MessengerPageId { get; }

		// @property (readonly, nonatomic) int authType;
		[NullAllowed]
		[Export("authType", ArgumentSemantic.Copy)]
		NSString AuthType { get; }

		// @property (readonly, nonatomic, strong) FBSDKCodeVerifier * _Nonnull codeVerifier;
		[Export ("codeVerifier", ArgumentSemantic.Strong)]
		FBSDKCodeVerifier CodeVerifier { get; }

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId;
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:appSwitch:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType;
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:authType:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId, NSString authType);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:authType:appSwitch:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId, NSString authType, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce;
		[Export ("initWithPermissions:tracking:nonce:")]
		NativeHandle ConstructorNonce (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, string nonce);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:nonce:appSwitch:")]
		NativeHandle ConstructorNonce (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, string nonce, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking messengerPageId:(NSString * _Nullable)messengerPageId;
		[Export ("initWithPermissions:tracking:messengerPageId:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, [NullAllowed] string messengerPageId);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking messengerPageId:(NSString * _Nullable)messengerPageId appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:messengerPageId:appSwitch:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, [NullAllowed] string messengerPageId, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType;
		[Export ("initWithPermissions:tracking:messengerPageId:authType:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, [NullAllowed] string messengerPageId, NSString authType);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:messengerPageId:authType:appSwitch:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, [NullAllowed] string messengerPageId, NSString authType, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking nonce:(NSString * _Nonnull)nonce messengerPageId:(NSString * _Nullable)messengerPageId authType:(id)authType appSwitch:(enum FBSDKAppSwitch)appSwitch codeVerifier:(FBSDKCodeVerifier * _Nonnull)codeVerifier __attribute__((objc_designated_initializer));
		[Export ("initWithPermissions:tracking:nonce:messengerPageId:authType:appSwitch:codeVerifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, string nonce, [NullAllowed] string messengerPageId, NSString authType, FBSDKAppSwitch appSwitch, FBSDKCodeVerifier codeVerifier);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking;
		[Export ("initWithPermissions:tracking:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking);

		// -(instancetype _Nullable)initWithPermissions:(id)permissions tracking:(enum FBSDKLoginTracking)tracking appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithPermissions:tracking:appSwitch:")]
		NativeHandle Constructor (FBSDKPermission[] permissions, FBSDKLoginTracking tracking, FBSDKAppSwitch appSwitch);

		// -(instancetype _Nullable)initWithTracking:(enum FBSDKLoginTracking)tracking;
		[Export ("initWithTracking:")]
		NativeHandle Constructor (FBSDKLoginTracking tracking);

		// -(instancetype _Nullable)initWithTracking:(enum FBSDKLoginTracking)tracking appSwitch:(enum FBSDKAppSwitch)appSwitch;
		[Export ("initWithTracking:appSwitch:")]
		NativeHandle Constructor (FBSDKLoginTracking tracking, FBSDKAppSwitch appSwitch);
	}

	// typedef void (^FBSDKProfileBlock)(FBSDKProfile * _Nullable, NSError * _Nullable);
	delegate void FBSDKProfileBlock ([NullAllowed] FBSDKProfile profile, [NullAllowed] NSError error);

	delegate void FBSDKLoginManagerLoginResultBlock([NullAllowed] FBSDKLoginManagerLoginResult result, [NullAllowed] NSError error);

	// @interface FBSDKLoginManager
	[BaseType(typeof(NSObject))]
	interface FBSDKLoginManager : IFBSDKURLOpening
	{
		// @property (nonatomic) enum FBSDKDefaultAudience defaultAudience;
		[Export ("defaultAudience", ArgumentSemantic.Assign)]
		FBSDKDefaultAudience DefaultAudience { get; set; }

		// -(instancetype _Nonnull)initWithDefaultAudience:(enum FBSDKDefaultAudience)defaultAudience;
		[Export ("initWithDefaultAudience:")]
		NativeHandle Constructor (FBSDKDefaultAudience defaultAudience);

		// -(void)logInFromViewController:(UIViewController * _Nullable)viewController configuration:(FBSDKLoginConfiguration * _Nullable)configuration completion:(id)completion;
		[Export ("logInFromViewController:configuration:completion:")]
		void LogIn ([NullAllowed] UIViewController viewController, [NullAllowed] FBSDKLoginConfiguration configuration, [NullAllowed] FBSDKLoginManagerLoginResultBlock completion);

		// -(void)logInWithPermissions:(id)permissions fromViewController:(UIViewController * _Nullable)viewController handler:(id)handler;
		[Export ("logInWithPermissions:fromViewController:handler:")]
		void LogIn (FBSDKPermission[] permissions, [NullAllowed] UIViewController viewController, [NullAllowed] FBSDKLoginManagerLoginResultBlock handler);

		// -(void)reauthorizeDataAccess:(UIViewController * _Nullable)viewController handler:(id)handler;
		[Export ("reauthorizeDataAccess:handler:")]
		void ReauthorizeDataAccess ([NullAllowed] UIViewController viewController,  [NullAllowed] FBSDKLoginManagerLoginResultBlock handler);

		// -(void)logOut;
		[Export ("logOut")]
		void LogOut ();

		///
		/// FBSDKLoginManager_Extension
		/// 
		
		// -(void)refreshLimitedLoginFromViewController:(UIViewController * _Nullable)viewController fallbackPolicy:(enum FBSDKRefreshFallbackPolicy)fallbackPolicy completion:(void (^ _Nonnull)(FBSDKProfile * _Nullable, int * _Nullable))completion;
		[Export ("refreshLimitedLoginFromViewController:fallbackPolicy:completion:")]
		void RefreshLimitedLoginFromViewController ([NullAllowed] UIViewController viewController, FBSDKRefreshFallbackPolicy fallbackPolicy, FBSDKProfileBlock completion);

		// @required -(BOOL)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation;
		[Abstract]
		[Export ("application:openURL:sourceApplication:annotation:")]
		new bool OpenUrl ([NullAllowed] UIApplication application, [NullAllowed] NSUrl url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// @required -(BOOL)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation;
		[Abstract]
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		new bool CanOpenURL (NSUrl url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// @required -(void)applicationDidBecomeActive:(UIApplication * _Nonnull)application;
		[Abstract]
		[Export ("applicationDidBecomeActive:")]
		new void DidBecomeActive (UIApplication application);

		// @required -(BOOL)isAuthenticationURL:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("isAuthenticationURL:")]
		new bool IsAuthenticationURL (NSUrl url);

		// @optional +(instancetype _Nonnull)makeOpener;
		[Static]
		[Export ("makeOpener")]
		FBSDKURLOpening MakeOpener ();

		// @optional -(BOOL)shouldStopPropagationOfURL:(NSURL * _Nonnull)url;
		[Export ("shouldStopPropagationOfURL:")]
		new bool ShouldStopPropagationOfURL (NSUrl url);
	}

	// @interface FBSDKLoginManagerLoginResult
	[BaseType(typeof(NSObject))]
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
		bool IsCancelled { get; }

		// @property (readonly, nonatomic, copy) NSSet<NSString *> * grantedPermissions;
		[Export("grantedPermissions")]
		NSSet<NSString> GrantedPermissions { get; }

		// @property (readonly, nonatomic, copy) NSSet<NSString *> * declinedPermissions;
		[Export("declinedPermissions")]
		NSSet<NSString> DeclinedPermissions { get; }

		// -(instancetype _Nonnull)initWithToken:(FBSDKAccessToken * _Nullable)token authenticationToken:(FBSDKAuthenticationToken * _Nullable)authenticationToken isCancelled:(id)isCancelled grantedPermissions:(id)grantedPermissions declinedPermissions:(id)declinedPermissions __attribute__((objc_designated_initializer));
		[Export ("initWithToken:authenticationToken:isCancelled:grantedPermissions:declinedPermissions:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] FBSDKAccessToken token, [NullAllowed] FBSDKAuthenticationToken authenticationToken, bool isCancelled, FBSDKPermission[] grantedPermissions, FBSDKPermission[] declinedPermissions);
	}

	delegate NSObject FBSDKLoginTooltipShouldAppear (FBSDKLoginTooltipView view, bool appIsEligible);
	delegate NSObject FBSDKLoginTooltipWillAppear (FBSDKLoginTooltipView loginButton);
	delegate NSObject FBSDKLoginTooltipWillNotAppear (FBSDKLoginTooltipView loginButton);

	// @protocol FBSDKLoginTooltipViewDelegate
	interface IFBSDKLoginTooltipViewDelegate {}

	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKLoginTooltipViewDelegate
	{
		// @optional -(id)loginTooltipView:(FBSDKLoginTooltipView * _Nonnull)view shouldAppear:(id)appIsEligible __attribute__((warn_unused_result("")));
		[DefaultValue (null)]
		[DelegateName ("FBSDKLoginTooltipShouldAppear")]
		[Export ("loginTooltipView:shouldAppear:")]
		bool ShouldAppear (FBSDKLoginTooltipView view, bool appIsEligible);

		// @optional -(void)loginTooltipViewWillAppear:(FBSDKLoginTooltipView * _Nonnull)view;
		[DefaultValue (null)]
		[DelegateName ("FBSDKLoginTooltipWillAppear")]
		[Export ("loginTooltipViewWillAppear:")]
		void WillAppear (FBSDKLoginTooltipView view);

		// @optional -(void)loginTooltipViewWillNotAppear:(FBSDKLoginTooltipView * _Nonnull)view;
		[DefaultValue (null)]
		[DelegateName ("FBSDKLoginTooltipWillNotAppear")]
		[Export ("loginTooltipViewWillNotAppear:")]
		void WillNotAppear (FBSDKLoginTooltipView view);
	}

	// @interface FBSDKLoginCompletionParameters
	[BaseType(typeof(NSObject))]
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
		IntPtr Error { get; set; }

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
