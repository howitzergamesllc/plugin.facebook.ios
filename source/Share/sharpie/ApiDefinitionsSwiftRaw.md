using FBSDKShareKit;
using Foundation;
using ObjCRuntime;

namespace Facebook.Share
{
	// @interface FBSDKAppInviteContent
	[DisableDefaultCtor]
	interface FBSDKAppInviteContent
	{
		// @property (copy, nonatomic) NSURL * _Nullable appInvitePreviewImageURL;
		[NullAllowed, Export ("appInvitePreviewImageURL", ArgumentSemantic.Copy)]
		NSURL AppInvitePreviewImageURL { get; set; }

		// @property (copy, nonatomic) NSURL * _Nonnull appLinkURL;
		[Export ("appLinkURL", ArgumentSemantic.Copy)]
		NSURL AppLinkURL { get; set; }

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
		NativeHandle Constructor (NSURL appLinkURL);
	}

	// @protocol FBSDKSharingValidatable
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSharingValidatable
	{
		// @required -(id)validateWithOptions:(id)options error:(id)error;
		[Abstract]
		[Export ("validateWithOptions:error:")]
		NSObject Error (NSObject options, NSObject error);
	}

	// @interface FBSDKShareKit_Swift_1364 (FBSDKAppInviteContent) <FBSDKSharingValidatable>
	[Category]
	[BaseType (typeof(FBSDKAppInviteContent))]
	interface FBSDKAppInviteContent_FBSDKShareKit_Swift_1364 : IFBSDKSharingValidatable
	{
		// -(id)validateWithOptions:(id)bridgeOptions error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject bridgeOptions, NSObject error);
	}

	// @interface FBSDKCameraEffectArguments
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
		void SetArray (NSObject array, string key);

		// -(id)arrayForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("arrayForKey:")]
		NSObject ArrayForKey (string key);
	}

	// @interface FBSDKCameraEffectTextures
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
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSharingButton
	{
		// @required @property (nonatomic, strong) id<FBSDKSharingContent> _Nullable shareContent;
		[Abstract]
		[NullAllowed, Export ("shareContent", ArgumentSemantic.Strong)]
		FBSDKSharingContent ShareContent { get; set; }
	}

	// @interface FBSDKSendButton
	interface FBSDKSendButton
	{
		// @property (nonatomic, strong) FBSDKMessageDialog * _Nullable dialog;
		[NullAllowed, Export ("dialog", ArgumentSemantic.Strong)]
		FBSDKMessageDialog Dialog { get; set; }

		// @property (nonatomic, strong) id<FBSDKSharingContent> _Nullable shareContent;
		[NullAllowed, Export ("shareContent", ArgumentSemantic.Strong)]
		FBSDKSharingContent ShareContent { get; set; }

		// @property (readonly, nonatomic) int impressionTrackingEventName;
		[Export ("impressionTrackingEventName")]
		int ImpressionTrackingEventName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull impressionTrackingIdentifier;
		[Export ("impressionTrackingIdentifier")]
		string ImpressionTrackingIdentifier { get; }

		// @property (readonly, getter = isImplicitlyDisabled, nonatomic) int implicitlyDisabled;
		[Export ("implicitlyDisabled")]
		int ImplicitlyDisabled { [Bind ("isImplicitlyDisabled")] get; }

		// -(void)configureButton;
		[Export ("configureButton")]
		void ConfigureButton ();

		// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCoder coder);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern id * _Nullable analyticsParameters;
		[Field ("analyticsParameters", "__Internal")]
		[NullAllowed]
		unsafe NSObject* analyticsParameters { get; }
	}

	// @interface FBSDKShareButton <FBSDKSharingButton>
	interface FBSDKShareButton : IFBSDKSharingButton
	{
		// @property (nonatomic, strong) id<FBSDKSharingContent> _Nullable shareContent;
		[NullAllowed, Export ("shareContent", ArgumentSemantic.Strong)]
		FBSDKSharingContent ShareContent { get; set; }

		// @property (readonly, nonatomic) int impressionTrackingEventName;
		[Export ("impressionTrackingEventName")]
		int ImpressionTrackingEventName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull impressionTrackingIdentifier;
		[Export ("impressionTrackingIdentifier")]
		string ImpressionTrackingIdentifier { get; }

		// @property (readonly, getter = isImplicitlyDisabled, nonatomic) int implicitlyDisabled;
		[Export ("implicitlyDisabled")]
		int ImplicitlyDisabled { [Bind ("isImplicitlyDisabled")] get; }

		// -(void)configureButton;
		[Export ("configureButton")]
		void ConfigureButton ();

		// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSObject frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCoder coder);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern id * _Nullable analyticsParameters;
		[Field ("analyticsParameters", "__Internal")]
		[NullAllowed]
		unsafe NSObject* analyticsParameters { get; }
	}

	// @interface FBSDKHashtag
	[DisableDefaultCtor]
	interface FBSDKHashtag
	{
		// @property (copy, nonatomic) NSString * _Nonnull stringRepresentation;
		[Export ("stringRepresentation")]
		string StringRepresentation { get; set; }

		// -(instancetype _Nonnull)initWithString:(NSString * _Nonnull)string __attribute__((objc_designated_initializer));
		[Export ("initWithString:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string @string);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// @property (readonly, nonatomic) int isValid;
		[Export ("isValid")]
		int IsValid { get; }

		// @property (readonly, nonatomic) int hash;
		[Export ("hash")]
		int Hash { get; }

		// -(id)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		NSObject IsEqual ([NullAllowed] NSObject @object);
	}

	// @protocol FBSDKSharing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSharing
	{
		[Wrap ("WeakDelegate"), Abstract]
		[NullAllowed]
		FBSDKSharingDelegate Delegate { get; set; }

		// @required @property (nonatomic, weak) id<FBSDKSharingDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @required @property (nonatomic, strong) id<FBSDKSharingContent> _Nullable shareContent;
		[Abstract]
		[NullAllowed, Export ("shareContent", ArgumentSemantic.Strong)]
		FBSDKSharingContent ShareContent { get; set; }

		// @required @property (nonatomic) int shouldFailOnDataError;
		[Abstract]
		[Export ("shouldFailOnDataError")]
		int ShouldFailOnDataError { get; set; }

		// @required -(id)validateWithError:(id)error;
		[Abstract]
		[Export ("validateWithError:")]
		NSObject ValidateWithError (NSObject error);
	}

	// @protocol FBSDKSharingDialog <FBSDKSharing>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSharingDialog : IFBSDKSharing
	{
		// @required @property (readonly, nonatomic) int canShow;
		[Abstract]
		[Export ("canShow")]
		int CanShow { get; }

		// @required -(id)show;
		[Abstract]
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }
	}

	// @interface FBSDKMessageDialog <FBSDKSharingDialog>
	[DisableDefaultCtor]
	interface FBSDKMessageDialog : IFBSDKSharingDialog
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKSharingDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKSharingDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) id<FBSDKSharingContent> _Nullable shareContent;
		[NullAllowed, Export ("shareContent", ArgumentSemantic.Strong)]
		FBSDKSharingContent ShareContent { get; set; }

		// @property (nonatomic) int shouldFailOnDataError;
		[Export ("shouldFailOnDataError")]
		int ShouldFailOnDataError { get; set; }

		// -(instancetype _Nonnull)initWithContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate;
		[Export ("initWithContent:delegate:")]
		NativeHandle Constructor ([NullAllowed] FBSDKSharingContent content, [NullAllowed] FBSDKSharingDelegate @delegate);

		// +(FBSDKMessageDialog * _Nonnull)dialogWithContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("dialogWithContent:delegate:")]
		FBSDKMessageDialog DialogWithContent ([NullAllowed] FBSDKSharingContent content, [NullAllowed] FBSDKSharingDelegate @delegate);

		// +(FBSDKMessageDialog * _Nonnull)showWithContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("showWithContent:delegate:")]
		FBSDKMessageDialog ShowWithContent ([NullAllowed] FBSDKSharingContent content, [NullAllowed] FBSDKSharingDelegate @delegate);

		// @property (readonly, nonatomic) int canShow;
		[Export ("canShow")]
		int CanShow { get; }

		// -(id)show;
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }

		// -(id)validateWithError:(id)error;
		[Export ("validateWithError:")]
		NSObject ValidateWithError (NSObject error);
	}

	// @interface FBSDKShareCameraEffectContent
	interface FBSDKShareCameraEffectContent
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

		// @property (copy, nonatomic) NSURL * _Nullable contentURL;
		[NullAllowed, Export ("contentURL", ArgumentSemantic.Copy)]
		NSURL ContentURL { get; set; }

		// @property (nonatomic, strong) FBSDKHashtag * _Nullable hashtag;
		[NullAllowed, Export ("hashtag", ArgumentSemantic.Strong)]
		FBSDKHashtag Hashtag { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeID;
		[NullAllowed, Export ("placeID")]
		string PlaceID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable ref;
		[NullAllowed, Export ("ref")]
		string Ref { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable pageID;
		[NullAllowed, Export ("pageID")]
		string PageID { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable shareUUID;
		[NullAllowed, Export ("shareUUID")]
		string ShareUUID { get; }
	}

	// @protocol FBSDKSharingContent <FBSDKSharingValidatable>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSharingContent : IFBSDKSharingValidatable
	{
		// @required @property (copy, nonatomic) NSURL * _Nullable contentURL;
		[Abstract]
		[NullAllowed, Export ("contentURL", ArgumentSemantic.Copy)]
		NSURL ContentURL { get; set; }

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
		NSObject BridgeOptions (NSObject existingParameters, NSObject bridgeOptions);
	}

	// @interface FBSDKShareKit_Swift_1631 (FBSDKShareCameraEffectContent) <FBSDKSharingContent>
	[Category]
	[BaseType (typeof(FBSDKShareCameraEffectContent))]
	interface FBSDKShareCameraEffectContent_FBSDKShareKit_Swift_1631 : IFBSDKSharingContent
	{
		// -(id)addParameters:(id)existingParameters bridgeOptions:(id)bridgeOptions __attribute__((warn_unused_result("")));
		[Export ("addParameters:bridgeOptions:")]
		NSObject AddParameters (NSObject existingParameters, NSObject bridgeOptions);

		// -(id)validateWithOptions:(id)bridgeOptions error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject bridgeOptions, NSObject error);
	}

	// @interface FBSDKShareDialog <FBSDKSharingDialog>
	[DisableDefaultCtor]
	interface FBSDKShareDialog : IFBSDKSharingDialog
	{
		// @property (nonatomic, weak) UIViewController * _Nullable fromViewController;
		[NullAllowed, Export ("fromViewController", ArgumentSemantic.Weak)]
		UIViewController FromViewController { get; set; }

		// @property (nonatomic) enum FBSDKShareDialogMode mode;
		[Export ("mode", ArgumentSemantic.Assign)]
		FBSDKShareDialogMode Mode { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKSharingDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKSharingDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) id<FBSDKSharingContent> _Nullable shareContent;
		[NullAllowed, Export ("shareContent", ArgumentSemantic.Strong)]
		FBSDKSharingContent ShareContent { get; set; }

		// @property (nonatomic) int shouldFailOnDataError;
		[Export ("shouldFailOnDataError")]
		int ShouldFailOnDataError { get; set; }

		// -(instancetype _Nonnull)initWithViewController:(UIViewController * _Nullable)viewController content:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithViewController:content:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIViewController viewController, [NullAllowed] FBSDKSharingContent content, [NullAllowed] FBSDKSharingDelegate @delegate);

		// +(FBSDKShareDialog * _Nonnull)dialogWithViewController:(UIViewController * _Nullable)viewController withContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("dialogWithViewController:withContent:delegate:")]
		FBSDKShareDialog DialogWithViewController ([NullAllowed] UIViewController viewController, [NullAllowed] FBSDKSharingContent content, [NullAllowed] FBSDKSharingDelegate @delegate);

		// +(FBSDKShareDialog * _Nonnull)showFromViewController:(UIViewController * _Nullable)viewController withContent:(id<FBSDKSharingContent> _Nullable)content delegate:(id<FBSDKSharingDelegate> _Nullable)delegate;
		[Static]
		[Export ("showFromViewController:withContent:delegate:")]
		FBSDKShareDialog ShowFromViewController ([NullAllowed] UIViewController viewController, [NullAllowed] FBSDKSharingContent content, [NullAllowed] FBSDKSharingDelegate @delegate);
	}

	// @interface FBSDKShareKit_Swift_1679 (FBSDKShareDialog)
	[Category]
	[BaseType (typeof(FBSDKShareDialog))]
	interface FBSDKShareDialog_FBSDKShareKit_Swift_1679
	{
	}

	// @interface FBSDKShareKit_Swift_1703 (FBSDKShareDialog)
	[Category]
	[BaseType (typeof(FBSDKShareDialog))]
	interface FBSDKShareDialog_FBSDKShareKit_Swift_1703
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

	// @interface FBSDKShareKit_Swift_1709 (FBSDKShareDialog)
	[Category]
	[BaseType (typeof(FBSDKShareDialog))]
	interface FBSDKShareDialog_FBSDKShareKit_Swift_1709
	{
		// @property (readonly, nonatomic) int canShow;
		[Export ("canShow")]
		int CanShow { get; }

		// -(id)show;
		[Export ("show")]
		[Verify (MethodToProperty)]
		NSObject Show { get; }

		// -(id)validateWithError:(id)error;
		[Export ("validateWithError:")]
		NSObject ValidateWithError (NSObject error);
	}

	// @interface FBSDKShareLinkContent
	interface FBSDKShareLinkContent
	{
		// @property (copy, nonatomic) NSString * _Nullable quote;
		[NullAllowed, Export ("quote")]
		string Quote { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable contentURL;
		[NullAllowed, Export ("contentURL", ArgumentSemantic.Copy)]
		NSURL ContentURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable entityURI;
		[NullAllowed, Export ("entityURI")]
		string EntityURI { get; set; }

		// @property (nonatomic) int isMusicAttachmentAllowed;
		[Export ("isMusicAttachmentAllowed")]
		int IsMusicAttachmentAllowed { get; set; }

		// @property (nonatomic, strong) FBSDKHashtag * _Nullable hashtag;
		[NullAllowed, Export ("hashtag", ArgumentSemantic.Strong)]
		FBSDKHashtag Hashtag { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeID;
		[NullAllowed, Export ("placeID")]
		string PlaceID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable ref;
		[NullAllowed, Export ("ref")]
		string Ref { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable pageID;
		[NullAllowed, Export ("pageID")]
		string PageID { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable shareUUID;
		[NullAllowed, Export ("shareUUID")]
		string ShareUUID { get; }
	}

	// @interface FBSDKShareKit_Swift_1762 (FBSDKShareLinkContent) <FBSDKSharingContent>
	[Category]
	[BaseType (typeof(FBSDKShareLinkContent))]
	interface FBSDKShareLinkContent_FBSDKShareKit_Swift_1762 : IFBSDKSharingContent
	{
		// -(id)addParameters:(id)existingParameters bridgeOptions:(id)bridgeOptions __attribute__((warn_unused_result("")));
		[Export ("addParameters:bridgeOptions:")]
		NSObject AddParameters (NSObject existingParameters, NSObject bridgeOptions);
	}

	// @interface FBSDKShareKit_Swift_1771 (FBSDKShareLinkContent) <FBSDKSharingValidatable>
	[Category]
	[BaseType (typeof(FBSDKShareLinkContent))]
	interface FBSDKShareLinkContent_FBSDKShareKit_Swift_1771 : IFBSDKSharingValidatable
	{
		// -(id)validateWithOptions:(id)bridgeOptions error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject bridgeOptions, NSObject error);
	}

	// @protocol FBSDKShareMedia
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKShareMedia
	{
	}

	// @interface FBSDKShareMediaContent
	interface FBSDKShareMediaContent
	{
		// @property (copy, nonatomic) NSURL * _Nullable contentURL;
		[NullAllowed, Export ("contentURL", ArgumentSemantic.Copy)]
		NSURL ContentURL { get; set; }

		// @property (nonatomic, strong) FBSDKHashtag * _Nullable hashtag;
		[NullAllowed, Export ("hashtag", ArgumentSemantic.Strong)]
		FBSDKHashtag Hashtag { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeID;
		[NullAllowed, Export ("placeID")]
		string PlaceID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable ref;
		[NullAllowed, Export ("ref")]
		string Ref { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable pageID;
		[NullAllowed, Export ("pageID")]
		string PageID { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable shareUUID;
		[NullAllowed, Export ("shareUUID")]
		string ShareUUID { get; }
	}

	// @interface FBSDKShareKit_Swift_1807 (FBSDKShareMediaContent) <FBSDKSharingContent>
	[Category]
	[BaseType (typeof(FBSDKShareMediaContent))]
	interface FBSDKShareMediaContent_FBSDKShareKit_Swift_1807 : IFBSDKSharingContent
	{
		// -(id)addParameters:(id)existingParameters bridgeOptions:(id)bridgeOptions __attribute__((warn_unused_result("")));
		[Export ("addParameters:bridgeOptions:")]
		NSObject AddParameters (NSObject existingParameters, NSObject bridgeOptions);
	}

	// @interface FBSDKShareKit_Swift_1816 (FBSDKShareMediaContent) <FBSDKSharingValidatable>
	[Category]
	[BaseType (typeof(FBSDKShareMediaContent))]
	interface FBSDKShareMediaContent_FBSDKShareKit_Swift_1816 : IFBSDKSharingValidatable
	{
		// -(id)validateWithOptions:(id)bridgeOptions error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject bridgeOptions, NSObject error);
	}

	// @interface FBSDKSharePhoto <FBSDKShareMedia>
	[DisableDefaultCtor]
	interface FBSDKSharePhoto : IFBSDKShareMedia
	{
		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable imageURL;
		[NullAllowed, Export ("imageURL", ArgumentSemantic.Copy)]
		NSURL ImageURL { get; set; }

		// @property (nonatomic, strong) PHAsset * _Nullable photoAsset;
		[NullAllowed, Export ("photoAsset", ArgumentSemantic.Strong)]
		PHAsset PhotoAsset { get; set; }

		// @property (nonatomic) int isUserGenerated;
		[Export ("isUserGenerated")]
		int IsUserGenerated { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable caption;
		[NullAllowed, Export ("caption")]
		string Caption { get; set; }

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image isUserGenerated:(id)isUserGenerated;
		[Export ("initWithImage:isUserGenerated:")]
		NativeHandle Constructor (UIImage image, NSObject isUserGenerated);

		// -(instancetype _Nonnull)initWithImageURL:(NSURL * _Nonnull)imageURL isUserGenerated:(id)isUserGenerated;
		[Export ("initWithImageURL:isUserGenerated:")]
		NativeHandle Constructor (NSURL imageURL, NSObject isUserGenerated);

		// -(instancetype _Nonnull)initWithPhotoAsset:(PHAsset * _Nonnull)photoAsset isUserGenerated:(id)isUserGenerated;
		[Export ("initWithPhotoAsset:isUserGenerated:")]
		NativeHandle Constructor (PHAsset photoAsset, NSObject isUserGenerated);
	}

	// @interface FBSDKShareKit_Swift_1865 (FBSDKSharePhoto) <FBSDKSharingValidatable>
	[Category]
	[BaseType (typeof(FBSDKSharePhoto))]
	interface FBSDKSharePhoto_FBSDKShareKit_Swift_1865 : IFBSDKSharingValidatable
	{
		// -(id)validateWithOptions:(id)bridgeOptions error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject bridgeOptions, NSObject error);
	}

	// @interface FBSDKSharePhotoContent
	interface FBSDKSharePhotoContent
	{
		// @property (copy, nonatomic) NSURL * _Nullable contentURL;
		[NullAllowed, Export ("contentURL", ArgumentSemantic.Copy)]
		NSURL ContentURL { get; set; }

		// @property (nonatomic, strong) FBSDKHashtag * _Nullable hashtag;
		[NullAllowed, Export ("hashtag", ArgumentSemantic.Strong)]
		FBSDKHashtag Hashtag { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeID;
		[NullAllowed, Export ("placeID")]
		string PlaceID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable ref;
		[NullAllowed, Export ("ref")]
		string Ref { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable pageID;
		[NullAllowed, Export ("pageID")]
		string PageID { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable shareUUID;
		[NullAllowed, Export ("shareUUID")]
		string ShareUUID { get; }
	}

	// @interface FBSDKShareKit_Swift_1896 (FBSDKSharePhotoContent) <FBSDKSharingContent>
	[Category]
	[BaseType (typeof(FBSDKSharePhotoContent))]
	interface FBSDKSharePhotoContent_FBSDKShareKit_Swift_1896 : IFBSDKSharingContent
	{
		// -(id)addParameters:(id)existingParameters bridgeOptions:(id)bridgeOptions __attribute__((warn_unused_result("")));
		[Export ("addParameters:bridgeOptions:")]
		NSObject AddParameters (NSObject existingParameters, NSObject bridgeOptions);
	}

	// @interface FBSDKShareKit_Swift_1905 (FBSDKSharePhotoContent) <FBSDKSharingValidatable>
	[Category]
	[BaseType (typeof(FBSDKSharePhotoContent))]
	interface FBSDKSharePhotoContent_FBSDKShareKit_Swift_1905 : IFBSDKSharingValidatable
	{
		// -(id)validateWithOptions:(id)bridgeOptions error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject bridgeOptions, NSObject error);
	}

	// @interface FBSDKShareVideo <FBSDKShareMedia>
	[DisableDefaultCtor]
	interface FBSDKShareVideo : IFBSDKShareMedia
	{
		// @property (copy, nonatomic) NSData * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Copy)]
		NSData Data { get; set; }

		// @property (nonatomic, strong) PHAsset * _Nullable videoAsset;
		[NullAllowed, Export ("videoAsset", ArgumentSemantic.Strong)]
		PHAsset VideoAsset { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable videoURL;
		[NullAllowed, Export ("videoURL", ArgumentSemantic.Copy)]
		NSURL VideoURL { get; set; }

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
		NativeHandle Constructor (NSURL videoURL, [NullAllowed] FBSDKSharePhoto previewPhoto);
	}

	// @interface FBSDKShareKit_Swift_1944 (FBSDKShareVideo) <FBSDKSharingValidatable>
	[Category]
	[BaseType (typeof(FBSDKShareVideo))]
	interface FBSDKShareVideo_FBSDKShareKit_Swift_1944 : IFBSDKSharingValidatable
	{
		// -(id)validateWithOptions:(id)bridgeOptions error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject bridgeOptions, NSObject error);
	}

	// @interface FBSDKShareVideoContent
	interface FBSDKShareVideoContent
	{
		// @property (nonatomic, strong) FBSDKShareVideo * _Nonnull video;
		[Export ("video", ArgumentSemantic.Strong)]
		FBSDKShareVideo Video { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable contentURL;
		[NullAllowed, Export ("contentURL", ArgumentSemantic.Copy)]
		NSURL ContentURL { get; set; }

		// @property (nonatomic, strong) FBSDKHashtag * _Nullable hashtag;
		[NullAllowed, Export ("hashtag", ArgumentSemantic.Strong)]
		FBSDKHashtag Hashtag { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeID;
		[NullAllowed, Export ("placeID")]
		string PlaceID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable ref;
		[NullAllowed, Export ("ref")]
		string Ref { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable pageID;
		[NullAllowed, Export ("pageID")]
		string PageID { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable shareUUID;
		[NullAllowed, Export ("shareUUID")]
		string ShareUUID { get; }
	}

	// @interface FBSDKShareKit_Swift_1975 (FBSDKShareVideoContent) <FBSDKSharingContent>
	[Category]
	[BaseType (typeof(FBSDKShareVideoContent))]
	interface FBSDKShareVideoContent_FBSDKShareKit_Swift_1975 : IFBSDKSharingContent
	{
		// -(id)addParameters:(id)existingParameters bridgeOptions:(id)bridgeOptions __attribute__((warn_unused_result("")));
		[Export ("addParameters:bridgeOptions:")]
		NSObject AddParameters (NSObject existingParameters, NSObject bridgeOptions);
	}

	// @interface FBSDKShareKit_Swift_1984 (FBSDKShareVideoContent) <FBSDKSharingValidatable>
	[Category]
	[BaseType (typeof(FBSDKShareVideoContent))]
	interface FBSDKShareVideoContent_FBSDKShareKit_Swift_1984 : IFBSDKSharingValidatable
	{
		// -(id)validateWithOptions:(id)bridgeOptions error:(id)error;
		[Export ("validateWithOptions:error:")]
		NSObject ValidateWithOptions (NSObject bridgeOptions, NSObject error);
	}

	// @protocol FBSDKSharingDelegate
	[Protocol, Model]
	interface FBSDKSharingDelegate
	{
		// @required -(void)sharer:(id<FBSDKSharing> _Nonnull)sharer didCompleteWithResults:(id)results;
		[Abstract]
		[Export ("sharer:didCompleteWithResults:")]
		void Sharer (FBSDKSharing sharer, NSObject results);

		// @required -(void)sharer:(id<FBSDKSharing> _Nonnull)sharer didFailWithError:(id)error;
		[Abstract]
		[Export ("sharer:didFailWithError:")]
		void Sharer (FBSDKSharing sharer, NSObject error);

		// @required -(void)sharerDidCancel:(id<FBSDKSharing> _Nonnull)sharer;
		[Abstract]
		[Export ("sharerDidCancel:")]
		void SharerDidCancel (FBSDKSharing sharer);
	}
}
