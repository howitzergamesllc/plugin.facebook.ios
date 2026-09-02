
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

namespace Facebook.GamingServices
{
	// @protocol FBSDKValidatable
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKValidatable
	{
		// @required -(id)validateAndReturnError:(id)error;
		[Abstract]
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);
	}

	// @interface FBSDKChooseContextContent <FBSDKValidatable>
	interface FBSDKChooseContextContent : IFBSDKValidatable
	{
		// @property (nonatomic) enum FBSDKChooseContextFilter filter;
		[Export ("filter", ArgumentSemantic.Assign)]
		FBSDKChooseContextFilter Filter { get; set; }

		// @property (nonatomic) int maxParticipants;
		[Export ("maxParticipants")]
		int MaxParticipants { get; set; }

		// @property (nonatomic) int minParticipants;
		[Export ("minParticipants")]
		int MinParticipants { get; set; }

		// +(NSString * _Nonnull)filtersNameForFilters:(enum FBSDKChooseContextFilter)filter __attribute__((warn_unused_result("")));
		[Static]
		[Export ("filtersNameForFilters:")]
		string FiltersNameForFilters (FBSDKChooseContextFilter filter);

		// -(id)validateAndReturnError:(id)error;
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);

		// -(id)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		NSObject IsEqual ([NullAllowed] NSObject @object);
	}

	// @protocol FBSDKDialog
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKDialog
	{
		[Wrap ("WeakDelegate"), Abstract]
		[NullAllowed]
		FBSDKContextDialogDelegate Delegate { get; set; }

		// @required @property (nonatomic, weak) id<FBSDKContextDialogDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @required @property (nonatomic, strong) id<FBSDKValidatable> _Nullable dialogContent;
		[Abstract]
		[NullAllowed, Export ("dialogContent", ArgumentSemantic.Strong)]
		FBSDKValidatable DialogContent { get; set; }

		// @required -(id)show __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }

		// @required -(id)validateAndReturnError:(id)error;
		[Abstract]
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);
	}

	// @interface FBSDKContextWebDialog
	[DisableDefaultCtor]
	interface FBSDKContextWebDialog
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKContextDialogDelegate Delegate { get; set; }

		// @property (nonatomic, strong) id<FBSDKContextDialogDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) id<FBSDKValidatable> _Nullable dialogContent;
		[NullAllowed, Export ("dialogContent", ArgumentSemantic.Strong)]
		FBSDKValidatable DialogContent { get; set; }

		// @property (nonatomic, strong) FBSDKWebDialog * _Nullable currentWebDialog;
		[NullAllowed, Export ("currentWebDialog", ArgumentSemantic.Strong)]
		FBSDKWebDialog CurrentWebDialog { get; set; }

		// -(id)show __attribute__((warn_unused_result("")));
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }

		// -(id)validateAndReturnError:(id)error;
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);

		// -(void)webDialog:(FBSDKWebDialog * _Nonnull)webDialog didCompleteWithResults:(id)results;
		[Export ("webDialog:didCompleteWithResults:")]
		void WebDialog (FBSDKWebDialog webDialog, NSObject results);

		// -(void)webDialog:(FBSDKWebDialog * _Nonnull)webDialog didFailWithError:(id)error;
		[Export ("webDialog:didFailWithError:")]
		void WebDialog (FBSDKWebDialog webDialog, NSObject error);

		// -(void)webDialogDidCancel:(FBSDKWebDialog * _Nonnull)webDialog;
		[Export ("webDialogDidCancel:")]
		void WebDialogDidCancel (FBSDKWebDialog webDialog);

		// -(id)createWebDialogFrameWithWidth:(id)width height:(id)height windowFinder:(id<_FBSDKWindowFinding> _Nonnull)windowFinder __attribute__((warn_unused_result("")));
		[Export ("createWebDialogFrameWithWidth:height:windowFinder:")]
		NSObject CreateWebDialogFrameWithWidth (NSObject width, NSObject height, _FBSDKWindowFinding windowFinder);
	}

	// @interface FBSDKChooseContextDialog : FBSDKContextWebDialog
	[BaseType (typeof(FBSDKContextWebDialog))]
	interface FBSDKChooseContextDialog
	{
		// -(instancetype _Nonnull)initWithContent:(FBSDKChooseContextContent * _Nonnull)content delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate;
		[Export ("initWithContent:delegate:")]
		NativeHandle Constructor (FBSDKChooseContextContent content, FBSDKContextDialogDelegate @delegate);

		// -(id)show __attribute__((warn_unused_result("")));
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }

		// -(id)validateAndReturnError:(id)error;
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);

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
	}

	// @protocol FBSDKShowable
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKShowable
	{
		// @required -(id)show __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }
	}

	// @interface FBSDKGamingServicesKit_Swift_1196 (FBSDKChooseContextDialog) <FBSDKShowable>
	[Category]
	[BaseType (typeof(FBSDKChooseContextDialog))]
	interface FBSDKChooseContextDialog_FBSDKGamingServicesKit_Swift_1196 : IFBSDKShowable
	{
	}

	// @protocol FBSDKContextDialogDelegate
	[Protocol, Model]
	interface FBSDKContextDialogDelegate
	{
		// @required -(void)contextDialogDidComplete:(FBSDKContextWebDialog * _Nonnull)contextDialog;
		[Abstract]
		[Export ("contextDialogDidComplete:")]
		void ContextDialogDidComplete (FBSDKContextWebDialog contextDialog);

		// @required -(void)contextDialog:(FBSDKContextWebDialog * _Nonnull)contextDialog didFailWithError:(id)error;
		[Abstract]
		[Export ("contextDialog:didFailWithError:")]
		void ContextDialog (FBSDKContextWebDialog contextDialog, NSObject error);

		// @required -(void)contextDialogDidCancel:(FBSDKContextWebDialog * _Nonnull)contextDialog;
		[Abstract]
		[Export ("contextDialogDidCancel:")]
		void ContextDialogDidCancel (FBSDKContextWebDialog contextDialog);
	}

	// @interface FBSDKContextDialogPresenter
	interface FBSDKContextDialogPresenter
	{
		// -(id)makeAndShowCreateContextDialogWithContent:(FBSDKCreateContextContent * _Nonnull)content delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate error:(id)error;
		[Export ("makeAndShowCreateContextDialogWithContent:delegate:error:")]
		NSObject MakeAndShowCreateContextDialogWithContent (FBSDKCreateContextContent content, FBSDKContextDialogDelegate @delegate, NSObject error);

		// -(id)makeAndShowSwitchContextDialogWithContent:(FBSDKSwitchContextContent * _Nonnull)content delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate error:(id)error;
		[Export ("makeAndShowSwitchContextDialogWithContent:delegate:error:")]
		NSObject MakeAndShowSwitchContextDialogWithContent (FBSDKSwitchContextContent content, FBSDKContextDialogDelegate @delegate, NSObject error);

		// -(void)makeAndShowChooseContextDialogWithContent:(FBSDKChooseContextContent * _Nonnull)content delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate;
		[Export ("makeAndShowChooseContextDialogWithContent:delegate:")]
		void MakeAndShowChooseContextDialogWithContent (FBSDKChooseContextContent content, FBSDKContextDialogDelegate @delegate);
	}

	// @interface FBSDKCreateContextContent <FBSDKValidatable>
	[DisableDefaultCtor]
	interface FBSDKCreateContextContent : IFBSDKValidatable
	{
		// @property (copy, nonatomic) NSString * _Nonnull playerID;
		[Export ("playerID")]
		string PlayerID { get; set; }

		// -(instancetype _Nonnull)initDialogContentWithPlayerID:(NSString * _Nonnull)playerID __attribute__((objc_designated_initializer));
		[Export ("initDialogContentWithPlayerID:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string playerID);

		// -(id)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		NSObject IsEqual ([NullAllowed] NSObject @object);

		// -(id)validateAndReturnError:(id)error;
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);
	}

	// @interface FBSDKCreateContextDialog : FBSDKContextWebDialog
	[BaseType (typeof(FBSDKContextWebDialog))]
	interface FBSDKCreateContextDialog
	{
		// -(instancetype _Nonnull)initWithContent:(FBSDKCreateContextContent * _Nonnull)content windowFinder:(id<_FBSDKWindowFinding> _Nonnull)windowFinder delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithContent:windowFinder:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKCreateContextContent content, _FBSDKWindowFinding windowFinder, FBSDKContextDialogDelegate @delegate);

		// -(id)show __attribute__((warn_unused_result("")));
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }

		// -(id)validateAndReturnError:(id)error;
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);
	}

	// @interface FBSDKGamingServicesKit_Swift_1278 (FBSDKCreateContextDialog) <FBSDKShowable>
	[Category]
	[BaseType (typeof(FBSDKCreateContextDialog))]
	interface FBSDKCreateContextDialog_FBSDKGamingServicesKit_Swift_1278 : IFBSDKShowable
	{
	}

	// @interface FBSDKFriendFinderDialog
	interface FBSDKFriendFinderDialog
	{
		// +(void)launchFriendFinderDialogWithCompletionHandler:(id)completionHandler;
		[Static]
		[Export ("launchFriendFinderDialogWithCompletionHandler:")]
		void LaunchFriendFinderDialogWithCompletionHandler (NSObject completionHandler);
	}

	// @interface FBSDKGameRequestContent
	interface FBSDKGameRequestContent
	{
		// @property (nonatomic) enum FBSDKGameRequestActionType actionType;
		[Export ("actionType", ArgumentSemantic.Assign)]
		FBSDKGameRequestActionType ActionType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable data;
		[NullAllowed, Export ("data")]
		string Data { get; set; }

		// @property (nonatomic) enum FBSDKGameRequestFilter filters;
		[Export ("filters", ArgumentSemantic.Assign)]
		FBSDKGameRequestFilter Filters { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull objectID;
		[Export ("objectID")]
		string ObjectID { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull cta;
		[Export ("cta")]
		string Cta { get; set; }

		// -(id)validateWithOptions:(id)options error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject options, NSObject error);

		// -(id)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		NSObject IsEqual ([NullAllowed] NSObject @object);

		// -(id)isEqualToGameRequestContent:(FBSDKGameRequestContent * _Nonnull)content __attribute__((warn_unused_result("")));
		[Export ("isEqualToGameRequestContent:")]
		NSObject IsEqualToGameRequestContent (FBSDKGameRequestContent content);

		// @property (readonly, nonatomic, class) int supportsSecureCoding;
		[Static]
		[Export ("supportsSecureCoding")]
		int SupportsSecureCoding { get; }

		// -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)decoder;
		[Export ("initWithCoder:")]
		NativeHandle Constructor (NSCoder decoder);

		// -(void)encodeWithCoder:(NSCoder * _Nonnull)encoder;
		[Export ("encodeWithCoder:")]
		void EncodeWithCoder (NSCoder encoder);
	}

	// @interface FBSDKGameRequestDialog
	[DisableDefaultCtor]
	interface FBSDKGameRequestDialog
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKGameRequestDialogDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKGameRequestDialogDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) FBSDKGameRequestContent * _Nonnull content;
		[Export ("content", ArgumentSemantic.Strong)]
		FBSDKGameRequestContent Content { get; set; }

		// @property (nonatomic) int isFrictionlessRequestsEnabled;
		[Export ("isFrictionlessRequestsEnabled")]
		int IsFrictionlessRequestsEnabled { get; set; }

		// @property (readonly, nonatomic) int canShow;
		[Export ("canShow")]
		int CanShow { get; }

		// -(instancetype _Nonnull)initWithContent:(FBSDKGameRequestContent * _Nonnull)content delegate:(id<FBSDKGameRequestDialogDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithContent:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKGameRequestContent content, [NullAllowed] FBSDKGameRequestDialogDelegate @delegate);

		// +(FBSDKGameRequestDialog * _Nonnull)dialogWithContent:(FBSDKGameRequestContent * _Nonnull)content delegate:(id<FBSDKGameRequestDialogDelegate> _Nullable)delegate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("dialogWithContent:delegate:")]
		FBSDKGameRequestDialog DialogWithContent (FBSDKGameRequestContent content, [NullAllowed] FBSDKGameRequestDialogDelegate @delegate);

		// +(FBSDKGameRequestDialog * _Nonnull)showWithContent:(FBSDKGameRequestContent * _Nonnull)content delegate:(id<FBSDKGameRequestDialogDelegate> _Nullable)delegate;
		[Static]
		[Export ("showWithContent:delegate:")]
		FBSDKGameRequestDialog ShowWithContent (FBSDKGameRequestContent content, [NullAllowed] FBSDKGameRequestDialogDelegate @delegate);

		// -(id)show;
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }

		// -(id)validateWithError:(id)error;
		[Export ("validateWithError:")]
		NSObject ValidateWithError (NSObject error);
	}

	// @interface FBSDKGamingServicesKit_Swift_1389 (FBSDKGameRequestDialog)
	[Category]
	[BaseType (typeof(FBSDKGameRequestDialog))]
	interface FBSDKGameRequestDialog_FBSDKGamingServicesKit_Swift_1389
	{
		// -(void)webDialog:(FBSDKWebDialog * _Nonnull)webDialog didCompleteWithResults:(id)results;
		[Export ("webDialog:didCompleteWithResults:")]
		void WebDialog (FBSDKWebDialog webDialog, NSObject results);

		// -(void)webDialog:(FBSDKWebDialog * _Nonnull)webDialog didFailWithError:(id)error;
		[Export ("webDialog:didFailWithError:")]
		void WebDialog (FBSDKWebDialog webDialog, NSObject error);

		// -(void)webDialogDidCancel:(FBSDKWebDialog * _Nonnull)webDialog;
		[Export ("webDialogDidCancel:")]
		void WebDialogDidCancel (FBSDKWebDialog webDialog);
	}

	// @interface FBSDKGamingServicesKit_Swift_1395 (FBSDKGameRequestDialog)
	[Category]
	[BaseType (typeof(FBSDKGameRequestDialog))]
	interface FBSDKGameRequestDialog_FBSDKGamingServicesKit_Swift_1395
	{
		// -(id)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)potentialURL sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		NSObject Application ([NullAllowed] UIApplication application, [NullAllowed] NSURL potentialURL, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		NSObject CanOpenURL (NSURL url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(void)applicationDidBecomeActive:(UIApplication * _Nonnull)application;
		[Export ("applicationDidBecomeActive:")]
		void ApplicationDidBecomeActive (UIApplication application);

		// -(id)isAuthenticationURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("isAuthenticationURL:")]
		NSObject IsAuthenticationURL (NSURL url);
	}

	// @protocol FBSDKGameRequestDialogDelegate
	[Protocol, Model]
	interface FBSDKGameRequestDialogDelegate
	{
		// @required -(void)gameRequestDialog:(FBSDKGameRequestDialog * _Nonnull)gameRequestDialog didCompleteWithResults:(id)results;
		[Abstract]
		[Export ("gameRequestDialog:didCompleteWithResults:")]
		void GameRequestDialog (FBSDKGameRequestDialog gameRequestDialog, NSObject results);

		// @required -(void)gameRequestDialog:(FBSDKGameRequestDialog * _Nonnull)gameRequestDialog didFailWithError:(id)error;
		[Abstract]
		[Export ("gameRequestDialog:didFailWithError:")]
		void GameRequestDialog (FBSDKGameRequestDialog gameRequestDialog, NSObject error);

		// @required -(void)gameRequestDialogDidCancel:(FBSDKGameRequestDialog * _Nonnull)gameRequestDialog;
		[Abstract]
		[Export ("gameRequestDialogDidCancel:")]
		void GameRequestDialogDidCancel (FBSDKGameRequestDialog gameRequestDialog);
	}

	// @interface FBSDKGameRequestURLProvider
	interface FBSDKGameRequestURLProvider
	{
		// +(NSURL * _Nullable)createDeepLinkURLWithQueryDictionary:(id)queryDictionary __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createDeepLinkURLWithQueryDictionary:")]
		[return: NullAllowed]
		NSURL CreateDeepLinkURLWithQueryDictionary (NSObject queryDictionary);

		// +(NSString * _Nullable)filtersNameForFilters:(enum FBSDKGameRequestFilter)filters __attribute__((warn_unused_result("")));
		[Static]
		[Export ("filtersNameForFilters:")]
		[return: NullAllowed]
		string FiltersNameForFilters (FBSDKGameRequestFilter filters);

		// +(NSString * _Nullable)actionTypeNameForActionType:(enum FBSDKGameRequestActionType)actionType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("actionTypeNameForActionType:")]
		[return: NullAllowed]
		string ActionTypeNameForActionType (FBSDKGameRequestActionType actionType);
	}

	// @interface FBSDKGamingContext
	[DisableDefaultCtor]
	interface FBSDKGamingContext
	{
		// @property (nonatomic, strong, class) FBSDKGamingContext * _Nullable currentContext;
		[Static]
		[NullAllowed, Export ("currentContext", ArgumentSemantic.Strong)]
		FBSDKGamingContext CurrentContext { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic) int size;
		[Export ("size")]
		int Size { get; }

		// -(instancetype _Nullable)initWithIdentifier:(NSString * _Nonnull)identifier size:(id)size __attribute__((objc_designated_initializer));
		[Export ("initWithIdentifier:size:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string identifier, NSObject size);
	}

	// @interface FBSDKGamingGroupIntegration
	[DisableDefaultCtor]
	interface FBSDKGamingGroupIntegration
	{
		// +(void)openGroupPageWithCompletionHandler:(id)completionHandler;
		[Static]
		[Export ("openGroupPageWithCompletionHandler:")]
		void OpenGroupPageWithCompletionHandler (NSObject completionHandler);
	}

	// @interface FBSDKGamingImageUploader
	[DisableDefaultCtor]
	interface FBSDKGamingImageUploader
	{
		// +(void)uploadImageWithConfiguration:(FBSDKGamingImageUploaderConfiguration * _Nonnull)configuration andResultCompletion:(id)completion;
		[Static]
		[Export ("uploadImageWithConfiguration:andResultCompletion:")]
		void UploadImageWithConfiguration (FBSDKGamingImageUploaderConfiguration configuration, NSObject completion);

		// +(void)uploadImageWithConfiguration:(FBSDKGamingImageUploaderConfiguration * _Nonnull)configuration completion:(id)completion andProgressHandler:(id)progressHandler;
		[Static]
		[Export ("uploadImageWithConfiguration:completion:andProgressHandler:")]
		void UploadImageWithConfiguration (FBSDKGamingImageUploaderConfiguration configuration, NSObject completion, NSObject progressHandler);
	}

	// @interface FBSDKGamingServicesKit_Swift_1485 (FBSDKGamingImageUploader)
	[Category]
	[BaseType (typeof(FBSDKGamingImageUploader))]
	interface FBSDKGamingImageUploader_FBSDKGamingServicesKit_Swift_1485
	{
		// -(void)requestConnection:(id<FBSDKGraphRequestConnecting> _Nonnull)connection didSendBodyData:(id)bytesWritten totalBytesWritten:(id)totalBytesWritten totalBytesExpectedToWrite:(id)totalBytesExpectedToWrite;
		[Export ("requestConnection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:")]
		void RequestConnection (FBSDKGraphRequestConnecting connection, NSObject bytesWritten, NSObject totalBytesWritten, NSObject totalBytesExpectedToWrite);
	}

	// @interface FBSDKGamingImageUploaderConfiguration
	[DisableDefaultCtor]
	interface FBSDKGamingImageUploaderConfiguration
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable caption;
		[NullAllowed, Export ("caption")]
		string Caption { get; }

		// @property (readonly, nonatomic) int shouldLaunchMediaDialog;
		[Export ("shouldLaunchMediaDialog")]
		int ShouldLaunchMediaDialog { get; }

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image caption:(NSString * _Nullable)caption shouldLaunchMediaDialog:(id)shouldLaunchMediaDialog __attribute__((objc_designated_initializer));
		[Export ("initWithImage:caption:shouldLaunchMediaDialog:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UIImage image, [NullAllowed] string caption, NSObject shouldLaunchMediaDialog);
	}

	// @interface FBSDKGamingPayload
	[DisableDefaultCtor]
	interface FBSDKGamingPayload
	{
		// @property (nonatomic, strong) FBSDKURL * _Nonnull URL;
		[Export ("URL", ArgumentSemantic.Strong)]
		FBSDKURL URL { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull payload;
		[Export ("payload")]
		string Payload { get; set; }

		// -(instancetype _Nonnull)initWithURL:(FBSDKURL * _Nonnull)URL __attribute__((objc_designated_initializer));
		[Export ("initWithURL:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKURL URL);
	}

	// @protocol FBSDKGamingPayloadDelegate
	[Protocol, Model]
	interface FBSDKGamingPayloadDelegate
	{
		// @optional -(void)parsedGameRequestURLContaining:(FBSDKGamingPayload * _Nonnull)payload gameRequestID:(NSString * _Nonnull)gameRequestID;
		[Export ("parsedGameRequestURLContaining:gameRequestID:")]
		void ParsedGameRequestURLContaining (FBSDKGamingPayload payload, string gameRequestID);

		// @optional -(void)parsedGamingContextURLContaining:(FBSDKGamingPayload * _Nonnull)payload;
		[Export ("parsedGamingContextURLContaining:")]
		void ParsedGamingContextURLContaining (FBSDKGamingPayload payload);

		// @optional -(void)parsedTournamentURLContaining:(FBSDKGamingPayload * _Nonnull)payload tournamentID:(NSString * _Nonnull)tournamentID;
		[Export ("parsedTournamentURLContaining:tournamentID:")]
		void ParsedTournamentURLContaining (FBSDKGamingPayload payload, string tournamentID);
	}

	// @interface FBSDKGamingPayloadObserver
	[DisableDefaultCtor]
	interface FBSDKGamingPayloadObserver
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKGamingPayloadDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKGamingPayloadDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithDelegate:(id<FBSDKGamingPayloadDelegate> _Nullable)delegate;
		[Export ("initWithDelegate:")]
		NativeHandle Constructor ([NullAllowed] FBSDKGamingPayloadDelegate @delegate);
	}

	// @interface FBSDKGamingServicesKit_Swift_1538 (FBSDKGamingPayloadObserver)
	[Category]
	[BaseType (typeof(FBSDKGamingPayloadObserver))]
	interface FBSDKGamingPayloadObserver_FBSDKGamingServicesKit_Swift_1538
	{
		// -(id)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		NSObject Application (UIApplication application, NSURL url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);
	}

	// @interface FBSDKGamingVideoUploader
	[DisableDefaultCtor]
	interface FBSDKGamingVideoUploader
	{
		// +(void)uploadVideoWithConfiguration:(FBSDKGamingVideoUploaderConfiguration * _Nonnull)configuration andResultCompletion:(id)completion;
		[Static]
		[Export ("uploadVideoWithConfiguration:andResultCompletion:")]
		void UploadVideoWithConfiguration (FBSDKGamingVideoUploaderConfiguration configuration, NSObject completion);

		// +(void)uploadVideoWithConfiguration:(FBSDKGamingVideoUploaderConfiguration * _Nonnull)configuration completion:(id)completion andProgressHandler:(id)progressHandler;
		[Static]
		[Export ("uploadVideoWithConfiguration:completion:andProgressHandler:")]
		void UploadVideoWithConfiguration (FBSDKGamingVideoUploaderConfiguration configuration, NSObject completion, NSObject progressHandler);
	}

	// @interface FBSDKGamingVideoUploaderConfiguration
	[DisableDefaultCtor]
	interface FBSDKGamingVideoUploaderConfiguration
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull videoURL;
		[Export ("videoURL", ArgumentSemantic.Copy)]
		NSURL VideoURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable caption;
		[NullAllowed, Export ("caption")]
		string Caption { get; }

		// -(instancetype _Nonnull)initWithVideoURL:(NSURL * _Nonnull)videoURL caption:(NSString * _Nullable)caption __attribute__((objc_designated_initializer));
		[Export ("initWithVideoURL:caption:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSURL videoURL, [NullAllowed] string caption);
	}

	// @interface ShareTournamentDialog
	[DisableDefaultCtor]
	interface ShareTournamentDialog
	{
		// -(id)isAuthenticationURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("isAuthenticationURL:")]
		NSObject IsAuthenticationURL (NSURL url);

		// -(id)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		NSObject Application ([NullAllowed] UIApplication application, [NullAllowed] NSURL url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		NSObject CanOpenURL (NSURL url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(void)applicationDidBecomeActive:(UIApplication * _Nonnull)application;
		[Export ("applicationDidBecomeActive:")]
		void ApplicationDidBecomeActive (UIApplication application);
	}

	// @interface FBSDKSwitchContextContent <FBSDKValidatable>
	[DisableDefaultCtor]
	interface FBSDKSwitchContextContent : IFBSDKValidatable
	{
		// -(instancetype _Nonnull)initDialogContentWithContextID:(NSString * _Nonnull)contextID __attribute__((objc_designated_initializer));
		[Export ("initDialogContentWithContextID:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string contextID);

		// -(id)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		NSObject IsEqual ([NullAllowed] NSObject @object);

		// -(id)validateAndReturnError:(id)error;
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);
	}

	// @interface FBSDKSwitchContextDialog : FBSDKContextWebDialog <FBSDKShowable>
	[BaseType (typeof(FBSDKContextWebDialog))]
	interface FBSDKSwitchContextDialog : IFBSDKShowable
	{
		// -(instancetype _Nonnull)initWithContent:(FBSDKSwitchContextContent * _Nonnull)content windowFinder:(id<_FBSDKWindowFinding> _Nonnull)windowFinder delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithContent:windowFinder:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKSwitchContextContent content, _FBSDKWindowFinding windowFinder, FBSDKContextDialogDelegate @delegate);

		// -(id)show __attribute__((warn_unused_result("")));
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }

		// -(id)validateAndReturnError:(id)error;
		[Export ("validateAndReturnError:")]
		NSObject ValidateAndReturnError (NSObject error);
	}
}
