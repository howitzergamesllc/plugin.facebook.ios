
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;
using UIKit;

using Facebook.Core;

namespace Facebook.GamingServices
{
	// @protocol FBSDKValidatable
	interface IFBSDKValidatable {}
	
	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKValidatable
	{
		// @required -(id)validateAndReturnError:(id)error;
		[Abstract]
		[Export ("validateAndReturnError:")]
		NSObject Validate (NSError error);
	}

	// @interface FBSDKChooseContextContent <FBSDKValidatable>
	[BaseType(typeof(NSObject))]
	interface FBSDKChooseContextContent : FBSDKValidatable
	{
		// @property (nonatomic) enum FBSDKChooseContextFilter filter;
		[Export ("filter", ArgumentSemantic.Assign)]
		FBSDKChooseContextFilter FilterType { get; set; }

		// @property (nonatomic) int maxParticipants;
		[Export ("maxParticipants")]
		int MaxParticipants { get; set; }

		// @property (nonatomic) int minParticipants;
		[Export ("minParticipants")]
		int MinParticipants { get; set; }

		// +(NSString * _Nonnull)filtersNameForFilters:(enum FBSDKChooseContextFilter)filter __attribute__((warn_unused_result("")));
		[Static]
		[Export ("filtersNameForFilters:")]
		string Filter (FBSDKChooseContextFilter filter);
	}

	// @protocol FBSDKDialog
	interface IFBSDKDialog {}
	
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKDialog
	{
		// @required @property (nonatomic, weak) id<FBSDKContextDialogDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKContextDialogDelegate Delegate { get; set; }

		// @required @property (nonatomic, strong) id<FBSDKValidatable> _Nullable dialogContent;
		[Abstract]
		[NullAllowed, Export ("dialogContent", ArgumentSemantic.Strong)]
		IFBSDKValidatable DialogContent { get; set; }

		// @required -(id)show __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("show")]
		NSObject Show { get; }
	}

	// @interface FBSDKContextWebDialog
	[BaseType (typeof (NSObject),
	Delegates = new string [] { "Delegate" },
	Events = new Type [] { typeof (FBSDKContextDialogDelegate) })]
	[DisableDefaultCtor]
	interface FBSDKContextWebDialog : FBSDKShowable, FBSDKValidatable, IFBSDKWebDialogDelegate
	{
		// @property (nonatomic, strong) id<FBSDKContextDialogDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKContextDialogDelegate Delegate { get; set; }

		// @property (nonatomic, strong) id<FBSDKValidatable> _Nullable dialogContent;
		[NullAllowed, Export ("dialogContent", ArgumentSemantic.Strong)]
		IFBSDKValidatable DialogContent { get; set; }

		// @property (nonatomic, strong) FBSDKWebDialog * _Nullable currentWebDialog;
		[NullAllowed, Export ("currentWebDialog", ArgumentSemantic.Strong)]
		FBSDKWebDialog CurrentWebDialog { get; set; }

		// -(id)createWebDialogFrameWithWidth:(id)width height:(id)height windowFinder:(id<_FBSDKWindowFinding> _Nonnull)windowFinder __attribute__((warn_unused_result("")));
		[Export ("createWebDialogFrameWithWidth:height:windowFinder:")]
		NSObject CreateWebDialogFrameWithWidth (NSObject width, NSObject height, NSObject windowFinder);
	}

	// @interface FBSDKChooseContextDialog : FBSDKContextWebDialog
	[BaseType (typeof(FBSDKContextWebDialog))]
	interface FBSDKChooseContextDialog : IFBSDKShowable, IFBSDKValidatable, IFBSDKURLOpening
	{
		// -(instancetype _Nonnull)initWithContent:(FBSDKChooseContextContent * _Nonnull)content delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate;
		[Export ("initWithContent:delegate:")]
		NativeHandle Constructor (FBSDKChooseContextContent content, IFBSDKContextDialogDelegate @delegate);

		// -(id)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		new NSObject OpenUrl ([NullAllowed] UIApplication application, [NullAllowed] NSUrl url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		new NSObject CanOpenURL (NSUrl url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(void)applicationDidBecomeActive:(UIApplication * _Nonnull)application;
		[Export ("applicationDidBecomeActive:")]
		new void DidBecomeActive (UIApplication application);

		// -(id)isAuthenticationURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("isAuthenticationURL:")]
		new NSObject IsAuthenticationURL (NSUrl url);
	}

	// @protocol FBSDKShowable
	interface IFBSDKShowable {}
	
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKShowable
	{
		// @required -(id)show __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("show")]
		NSObject Show { get; }
	}

	// @protocol FBSDKContextDialogDelegate
	interface IFBSDKContextDialogDelegate {}

	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKContextDialogDelegate
	{
		// @required -(void)contextDialogDidComplete:(FBSDKContextWebDialog * _Nonnull)contextDialog;
		[Abstract]
		[EventArgs ("ContextDialog")]
		[EventName ("Completed")]
		[Export ("contextDialogDidComplete:")]
		void DidComplete (FBSDKContextWebDialog contextDialog);

		// @required -(void)contextDialog:(FBSDKContextWebDialog * _Nonnull)contextDialog didFailWithError:(id)error;
		[Abstract]
		[EventArgs ("ContextDialogFailed")]
		[EventName ("Failed")]
		[Export ("contextDialog:didFailWithError:")]
		void DidFail (FBSDKContextWebDialog contextDialog, NSObject error);

		// @required -(void)contextDialogDidCancel:(FBSDKContextWebDialog * _Nonnull)contextDialog;
		[Abstract]		
		[EventArgs ("ContextDialog")]
		[EventName ("Cancelled")]
		[Export ("contextDialogDidCancel:")]
		void DidCancel (FBSDKContextWebDialog contextDialog);
	}

	// @interface FBSDKContextDialogPresenter
	[BaseType(typeof(NSObject))]
	interface FBSDKContextDialogPresenter
	{
		// -(id)makeAndShowCreateContextDialogWithContent:(FBSDKCreateContextContent * _Nonnull)content delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate error:(id)error;
		[Export ("makeAndShowCreateContextDialogWithContent:delegate:error:")]
		NSObject MakeAndShowCreateContextDialogWithContent (FBSDKCreateContextContent content, IFBSDKContextDialogDelegate @delegate, NSError error);

		// -(id)makeAndShowSwitchContextDialogWithContent:(FBSDKSwitchContextContent * _Nonnull)content delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate error:(id)error;
		[Export ("makeAndShowSwitchContextDialogWithContent:delegate:error:")]
		NSObject MakeAndShowSwitchContextDialogWithContent (FBSDKSwitchContextContent content, IFBSDKContextDialogDelegate @delegate, NSError error);

		// -(void)makeAndShowChooseContextDialogWithContent:(FBSDKChooseContextContent * _Nonnull)content delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate;
		[Export ("makeAndShowChooseContextDialogWithContent:delegate:")]
		void MakeAndShowChooseContextDialogWithContent (FBSDKChooseContextContent content, IFBSDKContextDialogDelegate @delegate);
	}

	// @interface FBSDKCreateContextContent <FBSDKValidatable>
	[BaseType(typeof(NSObject))]
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
	}

	// @interface FBSDKCreateContextDialog : FBSDKContextWebDialog
	[BaseType (typeof(FBSDKContextWebDialog))]
	interface FBSDKCreateContextDialog : IFBSDKShowable, IFBSDKValidatable
	{
		// -(instancetype _Nonnull)initWithContent:(FBSDKCreateContextContent * _Nonnull)content windowFinder:(id<_FBSDKWindowFinding> _Nonnull)windowFinder delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithContent:windowFinder:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKCreateContextContent content, NSObject windowFinder, IFBSDKContextDialogDelegate @delegate);
	}

	delegate void FBSDKFriendFinderDialogCompletionHandler(bool success, [NullAllowed] NSError error);

	// @interface FBSDKFriendFinderDialog
	[BaseType(typeof(NSObject))]
	interface FBSDKFriendFinderDialog
	{
		// +(void)launchFriendFinderDialogWithCompletionHandler:(id)completionHandler;
		[Static]
		[Export ("launchFriendFinderDialogWithCompletionHandler:")]
		void Launch (FBSDKFriendFinderDialogCompletionHandler completionHandler);
	}

	// @interface FBSDKGameRequestContent
	[BaseType(typeof(NSObject))]
	interface FBSDKGameRequestContent : IFBSDKValidatable
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

		// -(id)isEqualToGameRequestContent:(FBSDKGameRequestContent * _Nonnull)content __attribute__((warn_unused_result("")));
		[Export ("isEqualToGameRequestContent:")]
		NSObject IsEqualGameRequest (FBSDKGameRequestContent content);

		// @property (readonly, nonatomic, class) int supportsSecureCoding;
		[Static]
		[Export ("supportsSecureCoding")]
		int SupportsSecureCoding { get; }

		// -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)decoder;
		[Export ("initWithCoder:")]
		NativeHandle Constructor (NSCoder decoder);

		// -(void)encodeWithCoder:(NSCoder * _Nonnull)encoder;
		[Export ("encodeWithCoder:")]
		void Encode (NSCoder encoder);
	}

	// @interface FBSDKGameRequestDialog
	[BaseType (typeof (NSObject),
	Delegates = new string [] { "Delegate" },
	Events = new Type [] { typeof (FBSDKGameRequestDialogDelegate) })]
	[DisableDefaultCtor]
	interface FBSDKGameRequestDialog : IFBSDKURLOpening, IFBSDKShowable, IFBSDKValidatable
	{
		// @property (nonatomic, weak) id<FBSDKGameRequestDialogDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKGameRequestDialogDelegate Delegate { get; set; }

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
		NativeHandle Constructor (FBSDKGameRequestContent content, [NullAllowed] IFBSDKGameRequestDialogDelegate @delegate);

		// +(FBSDKGameRequestDialog * _Nonnull)dialogWithContent:(FBSDKGameRequestContent * _Nonnull)content delegate:(id<FBSDKGameRequestDialogDelegate> _Nullable)delegate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("dialogWithContent:delegate:")]
		FBSDKGameRequestDialog DialogWithContent (FBSDKGameRequestContent content, [NullAllowed] IFBSDKGameRequestDialogDelegate @delegate);

		// +(FBSDKGameRequestDialog * _Nonnull)showWithContent:(FBSDKGameRequestContent * _Nonnull)content delegate:(id<FBSDKGameRequestDialogDelegate> _Nullable)delegate;
		[Static]
		[Export ("showWithContent:delegate:")]
		FBSDKGameRequestDialog ShowWithContent (FBSDKGameRequestContent content, [NullAllowed] IFBSDKGameRequestDialogDelegate @delegate);

		///
		/// From FBSDKGameRequestDialog_Extension
		/// 
				// -(id)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)potentialURL sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		new NSObject OpenUrl ([NullAllowed] UIApplication application, [NullAllowed] NSUrl potentialURL, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		new NSObject CanOpenURL (NSUrl url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(void)applicationDidBecomeActive:(UIApplication * _Nonnull)application;
		[Export ("applicationDidBecomeActive:")]
		new void DidBecomeActive (UIApplication application);

		// -(id)isAuthenticationURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("isAuthenticationURL:")]
		new NSObject IsAuthenticationURL (NSUrl url);
	}

	// @protocol FBSDKGameRequestDialogDelegate
	interface IFBSDKGameRequestDialogDelegate {}
	
	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKGameRequestDialogDelegate
	{
		// @required -(void)gameRequestDialog:(FBSDKGameRequestDialog * _Nonnull)gameRequestDialog didCompleteWithResults:(id)results;
		[Abstract]
		[EventArgs ("GameRequestDialogCompleted")]
		[EventName ("Completed")]
		[Export ("gameRequestDialog:didCompleteWithResults:")]
		void DidComplete (FBSDKGameRequestDialog gameRequestDialog, NSObject results);

		// @required -(void)gameRequestDialog:(FBSDKGameRequestDialog * _Nonnull)gameRequestDialog didFailWithError:(id)error;
		[Abstract]
		[EventArgs ("GameRequestDialogFailed")]
		[EventName ("Failed")]
		[Export ("gameRequestDialog:didFailWithError:")]
		void DidFail (FBSDKGameRequestDialog gameRequestDialog, NSError error);

		// @required -(void)gameRequestDialogDidCancel:(FBSDKGameRequestDialog * _Nonnull)gameRequestDialog;
		[Abstract]
		[EventArgs ("GameRequestDialogCancelled")]
		[EventName ("Canceled")]
		[Export ("gameRequestDialogDidCancel:")]
		void DidCancel (FBSDKGameRequestDialog gameRequestDialog);
	}

	// @interface FBSDKGameRequestURLProvider
	[BaseType(typeof(NSObject))]
	interface FBSDKGameRequestURLProvider
	{
		// +(NSURL * _Nullable)createDeepLinkURLWithQueryDictionary:(id)queryDictionary __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createDeepLinkURLWithQueryDictionary:")]
		[return: NullAllowed]
		NSUrl CreateLink (NSObject queryDictionary);

		// +(NSString * _Nullable)filtersNameForFilters:(enum FBSDKGameRequestFilter)filters __attribute__((warn_unused_result("")));
		[Static]
		[Export ("filtersNameForFilters:")]
		[return: NullAllowed]
		string Filter (FBSDKGameRequestFilter filters);

		// +(NSString * _Nullable)actionTypeNameForActionType:(enum FBSDKGameRequestActionType)actionType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("actionTypeNameForActionType:")]
		[return: NullAllowed]
		string GetActionTypeName (FBSDKGameRequestActionType actionType);
	}

	// @interface FBSDKGamingContext
	[BaseType(typeof(NSObject))]
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

	delegate void FBSDKGroupPageCompletionHandler(bool success, [NullAllowed] NSError error);

	// @interface FBSDKGamingGroupIntegration
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGamingGroupIntegration
	{
		// +(void)openGroupPageWithCompletionHandler:(id)completionHandler;
		[Static]
		[Export ("openGroupPageWithCompletionHandler:")]
		void OpenGroupPageWithCompletionHandler (FBSDKGroupPageCompletionHandler completionHandler);
	}

	delegate void FBSDKGamingImageUploaderCompletionHandler(bool success, [NullAllowed] NSDictionary<NSString, NSObject> result, [NullAllowed] NSError error);

	delegate void FBSDKGamingImageUploaderProgressHandler(long bytesSent, long totalBytesSent, long totalBytesExpectedToSend);

	// @interface FBSDKGamingImageUploader
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGamingImageUploader
	{
		// +(void)uploadImageWithConfiguration:(FBSDKGamingImageUploaderConfiguration * _Nonnull)configuration andResultCompletion:(id)completion;
		[Static]
		[Export ("uploadImageWithConfiguration:andResultCompletion:")]
		void UploadImageWithConfiguration (FBSDKGamingImageUploaderConfiguration configuration, FBSDKGamingImageUploaderCompletionHandler completion);

		// +(void)uploadImageWithConfiguration:(FBSDKGamingImageUploaderConfiguration * _Nonnull)configuration completion:(id)completion andProgressHandler:(id)progressHandler;
		[Static]
		[Export ("uploadImageWithConfiguration:completion:andProgressHandler:")]
		void UploadImageWithConfiguration (FBSDKGamingImageUploaderConfiguration configuration, FBSDKGamingImageUploaderCompletionHandler completion, FBSDKGamingImageUploaderProgressHandler progressHandler);

		/// 
		/// FBSDKGamingIMageUploader_Extension
		/// 

		// -(void)requestConnection:(id<FBSDKGraphRequestConnecting> _Nonnull)connection didSendBodyData:(id)bytesWritten totalBytesWritten:(id)totalBytesWritten totalBytesExpectedToWrite:(id)totalBytesExpectedToWrite;
		[Export ("requestConnection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:")]
		void DidSendData (IFBSDKGraphRequestConnecting connection, NSObject bytesWritten, NSObject totalBytesWritten, NSObject totalBytesExpectedToWrite);
	}

	// @interface FBSDKGamingImageUploaderConfiguration
	[BaseType(typeof(NSObject))]
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
		NativeHandle Constructor (UIImage image, [NullAllowed] string caption, bool shouldLaunchMediaDialog);
	}

	// @interface FBSDKGamingPayload
	[BaseType(typeof(NSObject))]
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
	interface IFBSDKGamingPayloadDelegate {}

	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKGamingPayloadDelegate
	{
		// @optional -(void)parsedGameRequestURLContaining:(FBSDKGamingPayload * _Nonnull)payload gameRequestID:(NSString * _Nonnull)gameRequestID;
		[EventArgs ("GamingPayloadRequest")]
		[EventName ("ParsedGameRequest")]
		[Export ("parsedGameRequestURLContaining:gameRequestID:")]
		void ParsedGameRequest (FBSDKGamingPayload payload, string gameRequestID);

		// @optional -(void)parsedGamingContextURLContaining:(FBSDKGamingPayload * _Nonnull)payload;
		[EventArgs ("GamingPayloadContext")]
		[EventName ("ParsedGamingContext")]
		[Export ("parsedGamingContextURLContaining:")]
		void ParsedGamingContext (FBSDKGamingPayload payload);

		// @optional -(void)parsedTournamentURLContaining:(FBSDKGamingPayload * _Nonnull)payload tournamentID:(NSString * _Nonnull)tournamentID;
		[EventArgs ("GamingPayloadTournament")]
		[EventName ("ParsedTournament")]
		[Export ("parsedTournamentURLContaining:tournamentID:")]
		void ParsedTournament (FBSDKGamingPayload payload, string tournamentID);
	}

	// @interface FBSDKGamingPayloadObserver
	[BaseType (typeof (NSObject),
	Delegates = new string [] { "Delegate" },
	Events = new Type [] { typeof (FBSDKGamingPayloadDelegate) })]
	[DisableDefaultCtor]
	interface FBSDKGamingPayloadObserver : IFBSDKURLOpening
	{
		// @property (nonatomic, weak) id<FBSDKGamingPayloadDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKGamingPayloadDelegate Delegate { get; set; }

		// -(instancetype _Nonnull)initWithDelegate:(id<FBSDKGamingPayloadDelegate> _Nullable)delegate;
		[Export ("initWithDelegate:")]
		NativeHandle Constructor ([NullAllowed] IFBSDKGamingPayloadDelegate @delegate);

		///
		/// FBSDKGamingPayloadObserver_Extension
		/// 
		
		// -(id)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		new NSObject OpenUrl (UIApplication application, NSUrl url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		new NSObject CanOpenURL (NSUrl url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

	}

	delegate void FBSDKGamingVideoUploaderCompletionHandler(bool success, [NullAllowed] NSDictionary<NSString, NSObject> result, [NullAllowed] NSError error);
    
	delegate void FBSDKGamingVideoUploaderProgressHandler(long bytesSent, long totalBytesSent, long totalBytesExpectedToSend);

	// @interface FBSDKGamingVideoUploader
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGamingVideoUploader
	{
		// +(void)uploadVideoWithConfiguration:(FBSDKGamingVideoUploaderConfiguration * _Nonnull)configuration andResultCompletion:(id)completion;
		[Static]
		[Export ("uploadVideoWithConfiguration:andResultCompletion:")]
		void UploadVideoWithConfiguration (FBSDKGamingVideoUploaderConfiguration configuration, FBSDKGamingVideoUploaderCompletionHandler completion);

		// +(void)uploadVideoWithConfiguration:(FBSDKGamingVideoUploaderConfiguration * _Nonnull)configuration completion:(id)completion andProgressHandler:(id)progressHandler;
		[Static]
		[Export ("uploadVideoWithConfiguration:completion:andProgressHandler:")]
		void UploadVideoWithConfiguration (FBSDKGamingVideoUploaderConfiguration configuration, FBSDKGamingVideoUploaderCompletionHandler completion, FBSDKGamingVideoUploaderProgressHandler progressHandler);
	}

	// @interface FBSDKGamingVideoUploaderConfiguration
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGamingVideoUploaderConfiguration
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull videoURL;
		[Export ("videoURL", ArgumentSemantic.Copy)]
		NSUrl VideoURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable caption;
		[NullAllowed, Export ("caption")]
		string Caption { get; }

		// -(instancetype _Nonnull)initWithVideoURL:(NSURL * _Nonnull)videoURL caption:(NSString * _Nullable)caption __attribute__((objc_designated_initializer));
		[Export ("initWithVideoURL:caption:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSUrl videoURL, [NullAllowed] string caption);
	}

	// @interface ShareTournamentDialog
	[BaseType(typeof(NSObject), Name = "_TtC22FBSDKGamingServicesKit21ShareTournamentDialog")]
	[DisableDefaultCtor]
	interface ShareTournamentDialog : IFBSDKURLOpening
	{
		// -(id)isAuthenticationURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("isAuthenticationURL:")]
		new NSObject IsAuthenticationURL (NSUrl url);

		// -(id)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("application:openURL:sourceApplication:annotation:")]
		new NSObject OpenUrl ([NullAllowed] UIApplication application, [NullAllowed] NSUrl url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(id)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation __attribute__((warn_unused_result("")));
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		new NSObject CanOpenURL (NSUrl url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// -(void)applicationDidBecomeActive:(UIApplication * _Nonnull)application;
		[Export ("applicationDidBecomeActive:")]
		new void DidBecomeActive (UIApplication application);
	}

	// @interface FBSDKSwitchContextContent <FBSDKValidatable>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKSwitchContextContent : IFBSDKValidatable
	{
		// -(instancetype _Nonnull)initDialogContentWithContextID:(NSString * _Nonnull)contextID __attribute__((objc_designated_initializer));
		[Export ("initDialogContentWithContextID:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string contextID);
	}

	// @interface FBSDKSwitchContextDialog : FBSDKContextWebDialog <FBSDKShowable>
	[BaseType (typeof(FBSDKContextWebDialog))]
	interface FBSDKSwitchContextDialog : IFBSDKShowable, IFBSDKValidatable
	{
		// -(instancetype _Nonnull)initWithContent:(FBSDKSwitchContextContent * _Nonnull)content windowFinder:(id<_FBSDKWindowFinding> _Nonnull)windowFinder delegate:(id<FBSDKContextDialogDelegate> _Nonnull)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithContent:windowFinder:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKSwitchContextContent content, NSObject windowFinder, IFBSDKContextDialogDelegate @delegate);
	}
}
