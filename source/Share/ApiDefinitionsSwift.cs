
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;
using UIKit;
using Photos;
using CoreGraphics;

using Facebook.Core;

namespace Facebook.Share
{
	// @interface FBSDKAppInviteContent
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface FBSDKAppInviteContent : FBSDKSharingValidatable
	{
		// @property (copy, nonatomic) NSURL * _Nullable appInvitePreviewImageURL;
		[NullAllowed, Export ("appInvitePreviewImageURL", ArgumentSemantic.Copy)]
		NSUrl AppInvitePreviewImageURL { get; set; }

		// @property (copy, nonatomic) NSURL * _Nonnull appLinkURL;
		[Export ("appLinkURL", ArgumentSemantic.Copy)]
		NSUrl AppLinkURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable promotionCode;
		[NullAllowed, Export ("promotionCode")]
		string PromotionCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable promotionText;
		[NullAllowed, Export ("promotionText")]
		string PromotionText { get; set; }

		// @property (nonatomic) enum FBSDKAppInviteDestination destination;
		[Export ("destination", ArgumentSemantic.Assign)]
		FBSDKAppInviteDestination Destination { get; set; }

		// -(instancetype _Nonnull)initWithAppLinkURL:(NSURL * _Nonnull)appLinkURL __attribute__((objc_designated_initializer));
		[Export ("initWithAppLinkURL:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSUrl appLinkURL);
	}

	// @protocol FBSDKSharingValidatable
	interface IFBSDKSharingValidatable {}
	
	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKSharingValidatable
	{
		// @required -(id)validateWithOptions:(id)options error:(id)error;
		[Abstract]
		[Export ("validateWithOptions:error:")]
		bool Validate (FBSDKShareBridgeOptions options, [NullAllowed] out NSError error);
	}

	// @interface FBSDKCameraEffectArguments
	[BaseType(typeof(NSObject))]
	interface FBSDKCameraEffectArguments
	{
		// -(void)setString:(NSString * _Nullable)string forKey:(NSString * _Nonnull)key;
		[Export ("setString:forKey:")]
		void SetString ([NullAllowed] string @string, string key);

		// -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("stringForKey:")]
		[return: NullAllowed]
		string StringForKey (string key);

		// -(void)setArray:(id)array forKey:(NSString * _Nonnull)key;
		[Export ("setArray:forKey:")]
		void SetArray (string[] array, string key);

		// -(id)arrayForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("arrayForKey:")]
		string[] ArrayForKey (string key);
	}

	// @interface FBSDKCameraEffectTextures
	[BaseType(typeof(NSObject))]
	interface FBSDKCameraEffectTextures
	{
		// -(void)setImage:(UIImage * _Nullable)image forKey:(NSString * _Nonnull)key;
		[Export ("setImage:forKey:")]
		void SetImage ([NullAllowed] UIImage image, string key);

		// -(UIImage * _Nullable)imageForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("imageForKey:")]
		[return: NullAllowed]
		UIImage ImageForKey (string key);
	}

	// @protocol FBSDKSharingButton
	interface IFBSDKSharingButton {}
	
	[Protocol]
	interface FBSDKSharingButton
	{
		// @required @property (nonatomic, strong) id<FBSDKSharingContent> _Nullable shareContent;
		[Abstract]
		[NullAllowed, Export ("shareContent", ArgumentSemantic.Strong)]
		IFBSDKSharingContent ShareContent { get; set; }
	}

	// @interface FBSDKSendButton
	[BaseType(typeof(FBSDKButton))]
	interface FBSDKSendButton : IFBSDKButtonImpressionLogging, FBSDKSharingButton
	{
		// @property (nonatomic, strong) FBSDKMessageDialog * _Nullable dialog;
		[NullAllowed, Export ("dialog", ArgumentSemantic.Strong)]
		FBSDKMessageDialog Dialog { get; set; }

		// -(void)configureButton;
		[Export ("configureButton")]
		void ConfigureButton ();
	}

	// @interface FBSDKShareButton <FBSDKSharingButton>
	[BaseType(typeof(FBSDKButton))]
	interface FBSDKShareButton : FBSDKSharingButton
	{
		// @property (readonly, nonatomic) int impressionTrackingEventName;
		[Export ("impressionTrackingEventName")]
		int ImpressionTrackingEventName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull impressionTrackingIdentifier;
		[Export ("impressionTrackingIdentifier")]
		string ImpressionTrackingIdentifier { get; }

		// -(void)configureButton;
		[Export ("configureButton")]
		void ConfigureButton ();
	}

	// @interface FBSDKHashtag
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface FBSDKHashtag
	{
		// @property (copy, nonatomic) NSString * _Nonnull stringRepresentation;
		[Export ("stringRepresentation")]
		string StringRepresentation { get; set; }

		// -(instancetype _Nonnull)initWithString:(NSString * _Nonnull)string __attribute__((objc_designated_initializer));
		[Export ("initWithString:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string @string);

		// @property (readonly, nonatomic) int isValid;
		[Export ("isValid")]
		bool IsValid { get; }

		// @property (readonly, nonatomic) int hash;
		[Export ("hash")]
		int Hash { get; }
	}
	
	// @protocol FBSDKSharing
	interface IFBSDKSharing {}

	[Model]
	[Protocol]
	[BaseType (typeof (NSObject),
	Delegates = new string [] { "Delegate" },
	Events = new Type [] { typeof (FBSDKSharingDelegate) })]
	interface FBSDKSharing : FBSDKSharingValidatable
	{
		// @required @property (nonatomic, weak) id<FBSDKSharingDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IFBSDKSharingDelegate Delegate { get; set; }

		// @required @property (nonatomic, strong) id<FBSDKSharingContent> _Nullable shareContent;
		[Abstract]
		[NullAllowed, Export ("shareContent", ArgumentSemantic.Strong)]
		IFBSDKSharingContent ShareContent { get; set; }

		// @required @property (nonatomic) int shouldFailOnDataError;
		[Abstract]
		[Export ("shouldFailOnDataError")]
		bool ShouldFailOnDataError { get; set; }
	}

	// @protocol FBSDKSharingDialog <FBSDKSharing>
	interface IFBSDKSharingDialog {}
	
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKSharingDialog : FBSDKSharing
	{
		// @required @property (readonly, nonatomic) int canShow;
		[Abstract]
		[Export ("canShow")]
		bool CanShow { get; }

		// @required -(id)show;
		[Abstract]
		[Export ("show")]
		bool Show();
	}

	// @interface FBSDKMessageDialog <FBSDKSharingDialog>
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface FBSDKMessageDialog : FBSDKSharingDialog, FBSDKSharingValidatable
	{
		// -(instancetype _Nonnull)initWithContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate;
		[Export ("initWithContent:delegate:")]
		NativeHandle Constructor ([NullAllowed] IFBSDKSharingContent content, [NullAllowed] IFBSDKSharingDelegate @delegate);

		// +(FBSDKMessageDialog * _Nonnull)dialogWithContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("dialogWithContent:delegate:")]
		FBSDKMessageDialog DialogWithContent ([NullAllowed] IFBSDKSharingContent content, [NullAllowed] IFBSDKSharingDelegate @delegate);

		// +(FBSDKMessageDialog * _Nonnull)showWithContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("showWithContent:delegate:")]
		FBSDKMessageDialog ShowWithContent ([NullAllowed] IFBSDKSharingContent content, [NullAllowed] IFBSDKSharingDelegate @delegate);
	}

	// @interface FBSDKShareCameraEffectContent
	[BaseType(typeof(NSObject))]
	interface FBSDKShareCameraEffectContent : FBSDKSharingContent, FBSDKSharingValidatable
	{
		// @property (copy, nonatomic) NSString * _Nonnull effectID;
		[Export ("effectID")]
		string EffectID { get; set; }

		// @property (nonatomic, strong) FBSDKCameraEffectArguments * _Nonnull effectArguments;
		[Export ("effectArguments", ArgumentSemantic.Strong)]
		FBSDKCameraEffectArguments EffectArguments { get; set; }

		// @property (nonatomic, strong) FBSDKCameraEffectTextures * _Nonnull effectTextures;
		[Export ("effectTextures", ArgumentSemantic.Strong)]
		FBSDKCameraEffectTextures EffectTextures { get; set; }
	}

	// @protocol FBSDKSharingContent <FBSDKSharingValidatable>
	interface IFBSDKSharingContent {}
	
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKSharingContent : FBSDKSharingValidatable
	{
		// @required @property (copy, nonatomic) NSURL * _Nullable contentURL;
		[Abstract]
		[NullAllowed, Export ("contentURL", ArgumentSemantic.Copy)]
		NSUrl ContentURL { get; set; }

		// @required @property (nonatomic, strong) FBSDKHashtag * _Nullable hashtag;
		[Abstract]
		[NullAllowed, Export ("hashtag", ArgumentSemantic.Strong)]
		FBSDKHashtag Hashtag { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable placeID;
		[Abstract]
		[NullAllowed, Export ("placeID")]
		string PlaceID { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable ref;
		[Abstract]
		[NullAllowed, Export ("ref")]
		string Ref { get; set; }

		//@property (nonatomic, copy) NSArray<NSString *> * _Nonnull peopleIDs;
		[Export("peopleIDs", ArgumentSemantic.Copy)]
		string[] PeopleIDs { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable pageID;
		[Abstract]
		[NullAllowed, Export ("pageID")]
		string PageID { get; set; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable shareUUID;
		[Abstract]
		[NullAllowed, Export ("shareUUID")]
		string ShareUUID { get; }

		// @required -(id)addParameters:(id)existingParameters bridgeOptions:(id)bridgeOptions __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("addParameters:bridgeOptions:")]
		NSDictionary<NSString, NSObject> BridgeOptions (NSDictionary<NSString, NSObject> existingParameters, FBSDKShareBridgeOptions bridgeOptions);
	}

	// @interface FBSDKShareDialog <FBSDKSharingDialog>
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface FBSDKShareDialog : FBSDKSharingDialog, IFBSDKWebDialogDelegate
	{
		// @property (nonatomic, weak) UIViewController * _Nullable fromViewController;
		[NullAllowed, Export ("fromViewController", ArgumentSemantic.Weak)]
		UIViewController FromViewController { get; set; }

		// @property (nonatomic) enum FBSDKShareDialogMode mode;
		[Export ("mode", ArgumentSemantic.Assign)]
		FBSDKShareDialogMode Mode { get; set; }
		
		// -(instancetype _Nonnull)initWithViewController:(UIViewController * _Nullable)viewController content:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithViewController:content:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIViewController viewController, [NullAllowed] IFBSDKSharingContent content, [NullAllowed] IFBSDKSharingDelegate @delegate);

		// +(FBSDKShareDialog * _Nonnull)dialogWithViewController:(UIViewController * _Nullable)viewController withContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("dialogWithViewController:withContent:delegate:")]
		FBSDKShareDialog DialogWithViewController ([NullAllowed] UIViewController viewController, [NullAllowed] IFBSDKSharingContent content, [NullAllowed] IFBSDKSharingDelegate @delegate);

		// +(FBSDKShareDialog * _Nonnull)showFromViewController:(UIViewController * _Nullable)viewController withContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate;
		[Static]
		[Export ("showFromViewController:withContent:delegate:")]
		FBSDKShareDialog ShowFromViewController ([NullAllowed] UIViewController viewController, [NullAllowed] IFBSDKSharingContent content, [NullAllowed] IFBSDKSharingDelegate @delegate);
	}

	// @interface FBSDKShareLinkContent
	[BaseType (typeof (NSObject))]
	interface FBSDKShareLinkContent : FBSDKSharingContent, FBSDKSharingValidatable
	{
		// @property (copy, nonatomic) NSString * _Nullable quote;
		[NullAllowed, Export ("quote")]
		string Quote { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable entityURI;
		[NullAllowed, Export ("entityURI")]
		string EntityURI { get; set; }

		// @property (nonatomic) int isMusicAttachmentAllowed;
		[Export ("isMusicAttachmentAllowed")]
		bool IsMusicAttachmentAllowed { get; set; }
	}

	// @protocol FBSDKShareMedia
	interface IFBSDKShareMedia {}
	
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface FBSDKShareMedia
	{
	}

	// @interface FBSDKShareMediaContent
	[BaseType (typeof (NSObject))]
	interface FBSDKShareMediaContent : FBSDKSharingContent, FBSDKSharingValidatable
	{    
		// @property (nonatomic, copy) NSArray<id<FBSDKShareMedia>> * _Nonnull media;
		[Export("media", ArgumentSemantic.Copy)]
		IFBSDKShareMedia[] Media { get; set; }
	}

	// @interface FBSDKSharePhoto <FBSDKShareMedia>
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface FBSDKSharePhoto : FBSDKShareMedia, FBSDKSharingValidatable
	{
		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable imageURL;
		[NullAllowed, Export ("imageURL", ArgumentSemantic.Copy)]
		NSUrl ImageURL { get; set; }

		// @property (nonatomic, strong) PHAsset * _Nullable photoAsset;
		[NullAllowed, Export ("photoAsset", ArgumentSemantic.Strong)]
		PHAsset PhotoAsset { get; set; }

		// @property (nonatomic) int isUserGenerated;
		[Export ("isUserGenerated")]
		bool IsUserGenerated { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable caption;
		[NullAllowed, Export ("caption")]
		string Caption { get; set; }

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image isUserGenerated:(id)isUserGenerated;
		[Export ("initWithImage:isUserGenerated:")]
		NativeHandle Constructor (UIImage image, bool isUserGenerated);

		// -(instancetype _Nonnull)initWithImageURL:(NSURL * _Nonnull)imageURL isUserGenerated:(id)isUserGenerated;
		[Export ("initWithImageURL:isUserGenerated:")]
		NativeHandle Constructor (NSUrl imageURL, bool isUserGenerated);

		// -(instancetype _Nonnull)initWithPhotoAsset:(PHAsset * _Nonnull)photoAsset isUserGenerated:(id)isUserGenerated;
		[Export ("initWithPhotoAsset:isUserGenerated:")]
		NativeHandle Constructor (PHAsset photoAsset, bool isUserGenerated);
	}

	// @interface FBSDKSharePhotoContent
	[BaseType (typeof (NSObject))]
	interface FBSDKSharePhotoContent : FBSDKSharingContent, FBSDKSharingValidatable
	{
		// @property (nonatomic, copy) NSArray<FBSDKSharePhoto *> * _Nonnull photos;
		[Export("photos", ArgumentSemantic.Copy)]
		FBSDKSharePhoto[] Photos { get; set; }
	}

	// @interface FBSDKShareVideo <FBSDKShareMedia>
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface FBSDKShareVideo : FBSDKShareMedia, FBSDKSharingValidatable
	{
		// @property (copy, nonatomic) NSData * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Copy)]
		NSData Data { get; set; }

		// @property (nonatomic, strong) PHAsset * _Nullable videoAsset;
		[NullAllowed, Export ("videoAsset", ArgumentSemantic.Strong)]
		PHAsset VideoAsset { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable videoURL;
		[NullAllowed, Export ("videoURL", ArgumentSemantic.Copy)]
		NSUrl VideoURL { get; set; }

		// @property (nonatomic, strong) FBSDKSharePhoto * _Nullable previewPhoto;
		[NullAllowed, Export ("previewPhoto", ArgumentSemantic.Strong)]
		FBSDKSharePhoto PreviewPhoto { get; set; }

		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data previewPhoto:(FBSDKSharePhoto * _Nullable)previewPhoto;
		[Export ("initWithData:previewPhoto:")]
		NativeHandle Constructor (NSData data, [NullAllowed] FBSDKSharePhoto previewPhoto);

		// -(instancetype _Nonnull)initWithVideoAsset:(PHAsset * _Nonnull)videoAsset previewPhoto:(FBSDKSharePhoto * _Nullable)previewPhoto;
		[Export ("initWithVideoAsset:previewPhoto:")]
		NativeHandle Constructor (PHAsset videoAsset, [NullAllowed] FBSDKSharePhoto previewPhoto);

		// -(instancetype _Nonnull)initWithVideoURL:(NSURL * _Nonnull)videoURL previewPhoto:(FBSDKSharePhoto * _Nullable)previewPhoto;
		[Export ("initWithVideoURL:previewPhoto:")]
		NativeHandle Constructor (NSUrl videoURL, [NullAllowed] FBSDKSharePhoto previewPhoto);
	}

	// @interface FBSDKShareVideoContent
	[BaseType (typeof (NSObject))]
	interface FBSDKShareVideoContent : FBSDKSharingContent, FBSDKSharingValidatable
	{
		// @property (nonatomic, strong) FBSDKShareVideo * _Nonnull video;
		[Export ("video", ArgumentSemantic.Strong)]
		FBSDKShareVideo Video { get; set; }
	}

	// @protocol FBSDKSharingDelegate
	interface IFBSDKSharingDelegate {}

	[Model]
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKSharingDelegate
	{
		// @required -(void)sharer:(id<FBSDKSharing> _Nonnull)sharer didCompleteWithResults:(id)results;
		[Abstract]
		[EventArgs ("SharingCompleted")]
		[EventName ("Completed")]
		[Export ("sharer:didCompleteWithResults:")]
		void DidComplete (IFBSDKSharing sharer, NSDictionary<NSString, NSObject> results);

		// @required -(void)sharer:(id<FBSDKSharing> _Nonnull)sharer didFailWithError:(id)error;
		[Abstract]
		[EventArgs ("SharingFailed")]
		[EventName ("Failed")]
		[Export ("sharer:didFailWithError:")]
		void DidFail (IFBSDKSharing sharer, NSError error);

		// @required -(void)sharerDidCancel:(id<FBSDKSharing> _Nonnull)sharer;
		[Abstract]
		[EventArgs ("SharingCancelled")]
		[EventName ("Cancelled")]
		[Export ("sharerDidCancel:")]
		void DidCancel (IFBSDKSharing sharer);
	}
}
