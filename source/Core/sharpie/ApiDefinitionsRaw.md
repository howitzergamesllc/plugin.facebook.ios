
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

using FBSDKCoreKit;

namespace Facebook.Core
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorAccessTokens;
		[Field ("FBSDKLoggingBehaviorAccessTokens", "__Internal")]
		NSString FBSDKLoggingBehaviorAccessTokens { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorPerformanceCharacteristics;
		[Field ("FBSDKLoggingBehaviorPerformanceCharacteristics", "__Internal")]
		NSString FBSDKLoggingBehaviorPerformanceCharacteristics { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorAppEvents;
		[Field ("FBSDKLoggingBehaviorAppEvents", "__Internal")]
		NSString FBSDKLoggingBehaviorAppEvents { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorInformational;
		[Field ("FBSDKLoggingBehaviorInformational", "__Internal")]
		NSString FBSDKLoggingBehaviorInformational { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorCacheErrors;
		[Field ("FBSDKLoggingBehaviorCacheErrors", "__Internal")]
		NSString FBSDKLoggingBehaviorCacheErrors { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorUIControlErrors;
		[Field ("FBSDKLoggingBehaviorUIControlErrors", "__Internal")]
		NSString FBSDKLoggingBehaviorUIControlErrors { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorGraphAPIDebugWarning;
		[Field ("FBSDKLoggingBehaviorGraphAPIDebugWarning", "__Internal")]
		NSString FBSDKLoggingBehaviorGraphAPIDebugWarning { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorGraphAPIDebugInfo;
		[Field ("FBSDKLoggingBehaviorGraphAPIDebugInfo", "__Internal")]
		NSString FBSDKLoggingBehaviorGraphAPIDebugInfo { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorNetworkRequests;
		[Field ("FBSDKLoggingBehaviorNetworkRequests", "__Internal")]
		NSString FBSDKLoggingBehaviorNetworkRequests { get; }

		// extern const FBSDKLoggingBehavior _Nonnull FBSDKLoggingBehaviorDeveloperErrors;
		[Field ("FBSDKLoggingBehaviorDeveloperErrors", "__Internal")]
		NSString FBSDKLoggingBehaviorDeveloperErrors { get; }
	}

	// @protocol FBSDKLogging
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKLogging
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull contents;
		[Abstract]
		[Export ("contents")]
		string Contents { get; }

		// @required @property (readonly, copy, nonatomic) FBSDKLoggingBehavior _Nonnull loggingBehavior;
		[Abstract]
		[Export ("loggingBehavior")]
		string LoggingBehavior { get; }

		// @required -(instancetype _Nonnull)initWithLoggingBehavior:(FBSDKLoggingBehavior _Nonnull)loggingBehavior;
		[Abstract]
		[Export ("initWithLoggingBehavior:")]
		NativeHandle Constructor (string loggingBehavior);

		// @required +(void)singleShotLogEntry:(FBSDKLoggingBehavior _Nonnull)loggingBehavior logEntry:(NSString * _Nonnull)logEntry;
		[Static, Abstract]
		[Export ("singleShotLogEntry:logEntry:")]
		void SingleShotLogEntry (string loggingBehavior, string logEntry);

		// @required -(void)logEntry:(NSString * _Nonnull)logEntry;
		[Abstract]
		[Export ("logEntry:")]
		void LogEntry (string logEntry);
	}

	// @protocol __FBSDKLoggerCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface __FBSDKLoggerCreating
	{
		// @required -(id<FBSDKLogging> _Nonnull)createLoggerWithLoggingBehavior:(FBSDKLoggingBehavior _Nonnull)loggingBehavior;
		[Abstract]
		[Export ("createLoggerWithLoggingBehavior:")]
		FBSDKLogging CreateLoggerWithLoggingBehavior (string loggingBehavior);
	}

	// @protocol _FBSDKNotificationPosting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface _FBSDKNotificationPosting
	{
		// @required -(void)fb_postNotificationName:(NSNotificationName _Nonnull)name object:(id _Nullable)object userInfo:(NSDictionary<NSString *,id> * _Nullable)userInfo __attribute__((swift_name("fb_post(name:object:userInfo:)")));
		[Abstract]
		[Export ("fb_postNotificationName:object:userInfo:")]
		void Object (string name, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> userInfo);
	}

	// @protocol _FBSDKWindowFinding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface _FBSDKWindowFinding
	{
		// @required -(UIWindow * _Nullable)findWindow;
		[Abstract]
		[NullAllowed, Export ("findWindow")]
		[Verify (MethodToProperty)]
		UIWindow FindWindow { get; }
	}

	// @protocol FBSDKAccessTokenProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAccessTokenProviding
	{
		// @required @property (copy, nonatomic, class) NS_SWIFT_NAME(current) FBSDKAccessToken * currentAccessToken __attribute__((swift_name("current")));
		[Static, Abstract]
		[Export ("currentAccessToken", ArgumentSemantic.Copy)]
		FBSDKAccessToken CurrentAccessToken { get; set; }

		// @required @property (copy, nonatomic, class) id<FBSDKTokenCaching> _Nullable tokenCache;
		[Static, Abstract]
		[NullAllowed, Export ("tokenCache", ArgumentSemantic.Copy)]
		FBSDKTokenCaching TokenCache { get; set; }
	}

	// @protocol FBSDKTokenStringProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKTokenStringProviding
	{
		// @required @property (readonly, copy, nonatomic, class) NSString * _Nullable tokenString;
		[Static, Abstract]
		[NullAllowed, Export ("tokenString")]
		string TokenString { get; }
	}

	// typedef void (^FBSDKGraphRequestCompletion)(id<FBSDKGraphRequestConnecting> _Nullable, id _Nullable, NSError * _Nullable);
	delegate void FBSDKGraphRequestCompletion ([NullAllowed] FBSDKGraphRequestConnecting arg0, [NullAllowed] NSObject arg1, [NullAllowed] NSError arg2);

	// @protocol FBSDKGraphRequestConnecting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKGraphRequestConnecting
	{
		// @required @property (assign, nonatomic) NSTimeInterval timeout;
		[Abstract]
		[Export ("timeout")]
		double Timeout { get; set; }

		[Wrap ("WeakDelegate"), Abstract]
		[NullAllowed]
		FBSDKGraphRequestConnectionDelegate Delegate { get; set; }

		// @required @property (nonatomic, weak) id<FBSDKGraphRequestConnectionDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @required -(void)addRequest:(id<FBSDKGraphRequest> _Nonnull)request completion:(FBSDKGraphRequestCompletion _Nonnull)handler;
		[Abstract]
		[Export ("addRequest:completion:")]
		void AddRequest (FBSDKGraphRequest request, FBSDKGraphRequestCompletion handler);

		// @required -(void)start;
		[Abstract]
		[Export ("start")]
		void Start ();

		// @required -(void)cancel;
		[Abstract]
		[Export ("cancel")]
		void Cancel ();

		// @required @property (readonly, nonatomic) NSMutableArray<FBSDKGraphRequestMetadata *> * _Nonnull requests;
		[Abstract]
		[Export ("requests")]
		NSMutableArray<FBSDKGraphRequestMetadata> Requests { get; }
	}

	// @protocol FBSDKGraphRequestConnectionDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FBSDKGraphRequestConnectionDelegate
	{
		// @optional -(void)requestConnectionWillBeginLoading:(id<FBSDKGraphRequestConnecting> _Nonnull)connection;
		[Export ("requestConnectionWillBeginLoading:")]
		void RequestConnectionWillBeginLoading (FBSDKGraphRequestConnecting connection);

		// @optional -(void)requestConnectionDidFinishLoading:(id<FBSDKGraphRequestConnecting> _Nonnull)connection;
		[Export ("requestConnectionDidFinishLoading:")]
		void RequestConnectionDidFinishLoading (FBSDKGraphRequestConnecting connection);

		// @optional -(void)requestConnection:(id<FBSDKGraphRequestConnecting> _Nonnull)connection didFailWithError:(NSError * _Nonnull)error;
		[Export ("requestConnection:didFailWithError:")]
		void RequestConnection (FBSDKGraphRequestConnecting connection, NSError error);

		// @optional -(void)requestConnection:(id<FBSDKGraphRequestConnecting> _Nonnull)connection didSendBodyData:(NSInteger)bytesWritten totalBytesWritten:(NSInteger)totalBytesWritten totalBytesExpectedToWrite:(NSInteger)totalBytesExpectedToWrite;
		[Export ("requestConnection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:")]
		void RequestConnection (FBSDKGraphRequestConnecting connection, nint bytesWritten, nint totalBytesWritten, nint totalBytesExpectedToWrite);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NS_SWIFT_NAME(NonJSONResponseProperty) NSString *const FBSDKNonJSONResponseProperty __attribute__((swift_name("NonJSONResponseProperty")));
		[Field ("FBSDKNonJSONResponseProperty", "__Internal")]
		NSString FBSDKNonJSONResponseProperty { get; }
	}

	// @interface FBSDKGraphRequestConnection : NSObject <FBSDKGraphRequestConnecting>
	[BaseType (typeof(NSObject))]
	interface FBSDKGraphRequestConnection : IFBSDKGraphRequestConnecting
	{
		// @property (assign, nonatomic, class) NSTimeInterval defaultConnectionTimeout;
		[Static]
		[Export ("defaultConnectionTimeout")]
		double DefaultConnectionTimeout { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKGraphRequestConnectionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKGraphRequestConnectionDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) NSTimeInterval timeout;
		[Export ("timeout")]
		double Timeout { get; set; }

		// @property (readonly, retain, nonatomic) NSHTTPURLResponse * _Nullable urlResponse;
		[NullAllowed, Export ("urlResponse", ArgumentSemantic.Retain)]
		NSHTTPURLResponse UrlResponse { get; }

		// @property (nonatomic) NSOperationQueue * _Nullable delegateQueue;
		[NullAllowed, Export ("delegateQueue", ArgumentSemantic.Assign)]
		NSOperationQueue DelegateQueue { get; set; }

		// -(void)addRequest:(id<FBSDKGraphRequest> _Nonnull)request completion:(FBSDKGraphRequestCompletion _Nonnull)completion;
		[Export ("addRequest:completion:")]
		void AddRequest (FBSDKGraphRequest request, FBSDKGraphRequestCompletion completion);

		// -(void)addRequest:(id<FBSDKGraphRequest> _Nonnull)request name:(NSString * _Nonnull)name completion:(FBSDKGraphRequestCompletion _Nonnull)completion;
		[Export ("addRequest:name:completion:")]
		void AddRequest (FBSDKGraphRequest request, string name, FBSDKGraphRequestCompletion completion);

		// -(void)addRequest:(id<FBSDKGraphRequest> _Nonnull)request parameters:(NSDictionary<NSString *,id> * _Nullable)parameters completion:(FBSDKGraphRequestCompletion _Nonnull)completion;
		[Export ("addRequest:parameters:completion:")]
		void AddRequest (FBSDKGraphRequest request, [NullAllowed] NSDictionary<NSString, NSObject> parameters, FBSDKGraphRequestCompletion completion);

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)overrideGraphAPIVersion:(NSString * _Nonnull)version;
		[Export ("overrideGraphAPIVersion:")]
		void OverrideGraphAPIVersion (string version);

		// +(void)setCanMakeRequests;
		[Static]
		[Export ("setCanMakeRequests")]
		void SetCanMakeRequests ();

		// +(void)setDidFetchDomainConfiguration;
		[Static]
		[Export ("setDidFetchDomainConfiguration")]
		void SetDidFetchDomainConfiguration ();

		// +(void)configureWithURLSessionProxyFactory:(id<FBSDKURLSessionProxyProviding> _Nonnull)proxyFactory errorConfigurationProvider:(id<FBSDKErrorConfigurationProviding> _Nonnull)errorConfigurationProvider piggybackManager:(id<FBSDKGraphRequestPiggybackManaging> _Nonnull)piggybackManager settings:(id<FBSDKSettings> _Nonnull)settings graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)factory eventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger operatingSystemVersionComparer:(id<FBSDKOperatingSystemVersionComparing> _Nonnull)operatingSystemVersionComparer macCatalystDeterminator:(id<FBSDKMacCatalystDetermining> _Nonnull)macCatalystDeterminator accessTokenProvider:(Class<FBSDKAccessTokenProviding> _Nonnull)accessTokenProvider errorFactory:(id<FBSDKErrorCreating> _Nonnull)errorFactory authenticationTokenProvider:(Class<FBSDKAuthenticationTokenProviding> _Nonnull)authenticationTokenProvider __attribute__((swift_name("configure(urlSessionProxyFactory:errorConfigurationProvider:piggybackManager:settings:graphRequestConnectionFactory:eventLogger:operatingSystemVersionComparer:macCatalystDeterminator:accessTokenProvider:errorFactory:authenticationTokenProvider:)")));
		[Static]
		[Export ("configureWithURLSessionProxyFactory:errorConfigurationProvider:piggybackManager:settings:graphRequestConnectionFactory:eventLogger:operatingSystemVersionComparer:macCatalystDeterminator:accessTokenProvider:errorFactory:authenticationTokenProvider:")]
		void ConfigureWithURLSessionProxyFactory (FBSDKURLSessionProxyProviding proxyFactory, FBSDKErrorConfigurationProviding errorConfigurationProvider, FBSDKGraphRequestPiggybackManaging piggybackManager, FBSDKSettings settings, FBSDKGraphRequestConnectionFactory factory, FBSDKEventLogging eventLogger, FBSDKOperatingSystemVersionComparing operatingSystemVersionComparer, FBSDKMacCatalystDetermining macCatalystDeterminator, FBSDKAccessTokenProviding accessTokenProvider, FBSDKErrorCreating errorFactory, FBSDKAuthenticationTokenProviding authenticationTokenProvider);
	}

	// @protocol FBSDKTokenCaching
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKTokenCaching
	{
		// @required @property (copy, nonatomic) FBSDKAccessToken * _Nullable accessToken;
		[Abstract]
		[NullAllowed, Export ("accessToken", ArgumentSemantic.Copy)]
		FBSDKAccessToken AccessToken { get; set; }

		// @required @property (copy, nonatomic) FBSDKAuthenticationToken * _Nullable authenticationToken;
		[Abstract]
		[NullAllowed, Export ("authenticationToken", ArgumentSemantic.Copy)]
		FBSDKAuthenticationToken AuthenticationToken { get; set; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NS_SWIFT_NAME(AccessTokenDidChange) const NSNotificationName FBSDKAccessTokenDidChangeNotification __attribute__((swift_name("AccessTokenDidChange")));
		[Field ("FBSDKAccessTokenDidChangeNotification", "__Internal")]
		NSString FBSDKAccessTokenDidChangeNotification { get; }

		// extern NS_SWIFT_NAME(AccessTokenDidChangeUserIDKey) NSString *const FBSDKAccessTokenDidChangeUserIDKey __attribute__((swift_name("AccessTokenDidChangeUserIDKey")));
		[Field ("FBSDKAccessTokenDidChangeUserIDKey", "__Internal")]
		NSString FBSDKAccessTokenDidChangeUserIDKey { get; }

		// extern NS_SWIFT_NAME(AccessTokenChangeOldKey) NSString *const FBSDKAccessTokenChangeOldKey __attribute__((swift_name("AccessTokenChangeOldKey")));
		[Field ("FBSDKAccessTokenChangeOldKey", "__Internal")]
		NSString FBSDKAccessTokenChangeOldKey { get; }

		// extern NS_SWIFT_NAME(AccessTokenChangeNewKey) NSString *const FBSDKAccessTokenChangeNewKey __attribute__((swift_name("AccessTokenChangeNewKey")));
		[Field ("FBSDKAccessTokenChangeNewKey", "__Internal")]
		NSString FBSDKAccessTokenChangeNewKey { get; }

		// extern NS_SWIFT_NAME(AccessTokenDidExpireKey) NSString *const FBSDKAccessTokenDidExpireKey __attribute__((swift_name("AccessTokenDidExpireKey")));
		[Field ("FBSDKAccessTokenDidExpireKey", "__Internal")]
		NSString FBSDKAccessTokenDidExpireKey { get; }
	}

	// @interface FBSDKAccessToken : NSObject <NSCopying, NSObject, NSSecureCoding, FBSDKAccessTokenProviding, FBSDKTokenStringProviding>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAccessToken : INSCopying, INSSecureCoding, IFBSDKAccessTokenProviding, IFBSDKTokenStringProviding
	{
		// @property (copy, nonatomic, class) NS_SWIFT_NAME(current) FBSDKAccessToken * currentAccessToken __attribute__((swift_name("current")));
		[Static]
		[Export ("currentAccessToken", ArgumentSemantic.Copy)]
		FBSDKAccessToken CurrentAccessToken { get; set; }

		// @property (readonly, getter = isCurrentAccessTokenActive, assign, nonatomic, class) BOOL currentAccessTokenIsActive;
		[Static]
		[Export ("currentAccessTokenIsActive")]
		bool CurrentAccessTokenIsActive { [Bind ("isCurrentAccessTokenActive")] get; }

		// @property (copy, nonatomic, class) id<FBSDKTokenCaching> _Nullable tokenCache;
		[Static]
		[NullAllowed, Export ("tokenCache", ArgumentSemantic.Copy)]
		FBSDKTokenCaching TokenCache { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appID;
		[Export ("appID")]
		string AppID { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull dataAccessExpirationDate;
		[Export ("dataAccessExpirationDate", ArgumentSemantic.Copy)]
		NSDate DataAccessExpirationDate { get; }

		// @property (readonly, copy, nonatomic) NS_REFINED_FOR_SWIFT NSSet<NSString *> * declinedPermissions __attribute__((swift_private));
		[Export ("declinedPermissions", ArgumentSemantic.Copy)]
		NSSet<NSString> DeclinedPermissions { get; }

		// @property (readonly, copy, nonatomic) NS_REFINED_FOR_SWIFT NSSet<NSString *> * expiredPermissions __attribute__((swift_private));
		[Export ("expiredPermissions", ArgumentSemantic.Copy)]
		NSSet<NSString> ExpiredPermissions { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull expirationDate;
		[Export ("expirationDate", ArgumentSemantic.Copy)]
		NSDate ExpirationDate { get; }

		// @property (readonly, copy, nonatomic) NS_REFINED_FOR_SWIFT NSSet<NSString *> * permissions __attribute__((swift_private));
		[Export ("permissions", ArgumentSemantic.Copy)]
		NSSet<NSString> Permissions { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull refreshDate;
		[Export ("refreshDate", ArgumentSemantic.Copy)]
		NSDate RefreshDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull tokenString;
		[Export ("tokenString")]
		string TokenString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull userID;
		[Export ("userID")]
		string UserID { get; }

		// @property (readonly, getter = isExpired, assign, nonatomic) BOOL expired;
		[Export ("expired")]
		bool Expired { [Bind ("isExpired")] get; }

		// @property (readonly, getter = isDataAccessExpired, assign, nonatomic) BOOL dataAccessExpired;
		[Export ("dataAccessExpired")]
		bool DataAccessExpired { [Bind ("isDataAccessExpired")] get; }

		// -(instancetype _Nonnull)initWithTokenString:(NSString * _Nonnull)tokenString permissions:(NSArray<NSString *> * _Nonnull)permissions declinedPermissions:(NSArray<NSString *> * _Nonnull)declinedPermissions expiredPermissions:(NSArray<NSString *> * _Nonnull)expiredPermissions appID:(NSString * _Nonnull)appID userID:(NSString * _Nonnull)userID expirationDate:(NSDate * _Nullable)expirationDate refreshDate:(NSDate * _Nullable)refreshDate dataAccessExpirationDate:(NSDate * _Nullable)dataAccessExpirationDate __attribute__((objc_designated_initializer));
		[Export ("initWithTokenString:permissions:declinedPermissions:expiredPermissions:appID:userID:expirationDate:refreshDate:dataAccessExpirationDate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string tokenString, string[] permissions, string[] declinedPermissions, string[] expiredPermissions, string appID, string userID, [NullAllowed] NSDate expirationDate, [NullAllowed] NSDate refreshDate, [NullAllowed] NSDate dataAccessExpirationDate);

		// -(BOOL)hasGranted:(NSString * _Nonnull)permission __attribute__((swift_name("hasGranted(permission:)")));
		[Export ("hasGranted:")]
		bool HasGranted (string permission);

		// -(BOOL)isEqualToAccessToken:(FBSDKAccessToken * _Nonnull)token;
		[Export ("isEqualToAccessToken:")]
		bool IsEqualToAccessToken (FBSDKAccessToken token);

		// +(void)refreshCurrentAccessTokenWithCompletion:(FBSDKGraphRequestCompletion _Nullable)completion;
		[Static]
		[Export ("refreshCurrentAccessTokenWithCompletion:")]
		void RefreshCurrentAccessTokenWithCompletion ([NullAllowed] FBSDKGraphRequestCompletion completion);

		// +(void)configureWithTokenCache:(id<FBSDKTokenCaching> _Nonnull)tokenCache graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)graphRequestConnectionFactory graphRequestPiggybackManager:(id<FBSDKGraphRequestPiggybackManaging> _Nonnull)graphRequestPiggybackManager errorFactory:(id<FBSDKErrorCreating> _Nonnull)errorFactory __attribute__((swift_name("configure(tokenCache:graphRequestConnectionFactory:graphRequestPiggybackManager:errorFactory:)")));
		[Static]
		[Export ("configureWithTokenCache:graphRequestConnectionFactory:graphRequestPiggybackManager:errorFactory:")]
		void ConfigureWithTokenCache (FBSDKTokenCaching tokenCache, FBSDKGraphRequestConnectionFactory graphRequestConnectionFactory, FBSDKGraphRequestPiggybackManaging graphRequestPiggybackManager, FBSDKErrorCreating errorFactory);
	}

	// @protocol FBSDKAdvertiserIDProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAdvertiserIDProviding
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nullable advertiserID;
		[Abstract]
		[NullAllowed, Export ("advertiserID")]
		string AdvertiserID { get; }
	}

	// @protocol FBSDKAutoSetup
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAutoSetup
	{
		// @required -(void)configureWithSwizzler:(Class<FBSDKSwizzling> _Nonnull)swizzler aemReporter:(Class<FBSDKAEMReporter> _Nonnull)aemReporter eventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger crashHandler:(id<FBSDKCrashHandler> _Nonnull)crashHandler featureChecker:(id<FBSDKFeatureDisabling> _Nonnull)featureChecker appEventsUtility:(id<FBSDKAppEventsUtility> _Nonnull)appEventsUtility __attribute__((swift_name("configure(swizzler:reporter:eventLogger:crashHandler:featureChecker:appEventsUtility:)")));
		[Abstract]
		[Export ("configureWithSwizzler:aemReporter:eventLogger:crashHandler:featureChecker:appEventsUtility:")]
		void ConfigureWithSwizzler (FBSDKSwizzling swizzler, FBSDKAEMReporter aemReporter, FBSDKEventLogging eventLogger, FBSDKCrashHandler crashHandler, FBSDKFeatureDisabling featureChecker, FBSDKAppEventsUtility appEventsUtility);

		// @required -(void)enableAutoSetup:(BOOL)proxyEnabled;
		[Abstract]
		[Export ("enableAutoSetup:")]
		void EnableAutoSetup (bool proxyEnabled);

		// @required -(void)logAutoSetupStatus:(BOOL)optin source:(NSString * _Nonnull)source;
		[Abstract]
		[Export ("logAutoSetupStatus:source:")]
		void LogAutoSetupStatus (bool optin, string source);
	}

	// @interface FBSDKAEMManager : NSObject <FBSDKAutoSetup>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAEMManager : IFBSDKAutoSetup
	{
		// @property (readonly, nonatomic, strong, class) FBSDKAEMManager * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKAEMManager Shared { get; }

		// -(void)configureWithSwizzler:(Class<FBSDKSwizzling> _Nonnull)swizzler aemReporter:(Class<FBSDKAEMReporter> _Nonnull)aemReporter eventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger crashHandler:(id<FBSDKCrashHandler> _Nonnull)crashHandler featureChecker:(id<FBSDKFeatureDisabling> _Nonnull)featureChecker appEventsUtility:(id<FBSDKAppEventsUtility> _Nonnull)appEventsUtility __attribute__((swift_name("configure(swizzler:reporter:eventLogger:crashHandler:featureChecker:appEventsUtility:)")));
		[Export ("configureWithSwizzler:aemReporter:eventLogger:crashHandler:featureChecker:appEventsUtility:")]
		void ConfigureWithSwizzler (FBSDKSwizzling swizzler, FBSDKAEMReporter aemReporter, FBSDKEventLogging eventLogger, FBSDKCrashHandler crashHandler, FBSDKFeatureDisabling featureChecker, FBSDKAppEventsUtility appEventsUtility);

		// -(void)enableAutoSetup:(BOOL)proxyEnabled;
		[Export ("enableAutoSetup:")]
		void EnableAutoSetup (bool proxyEnabled);

		// -(void)logAutoSetupStatus:(BOOL)optin source:(NSString * _Nonnull)source;
		[Export ("logAutoSetupStatus:source:")]
		void LogAutoSetupStatus (bool optin, string source);
	}

	// @protocol FBSDKAppAvailabilityChecker
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppAvailabilityChecker
	{
		// @required @property (readonly, assign, nonatomic) BOOL isMessengerAppInstalled;
		[Abstract]
		[Export ("isMessengerAppInstalled")]
		bool IsMessengerAppInstalled { get; }

		// @required @property (readonly, assign, nonatomic) BOOL isFacebookAppInstalled;
		[Abstract]
		[Export ("isFacebookAppInstalled")]
		bool IsFacebookAppInstalled { get; }
	}

	// @protocol FBSDKAppEventDropDetermining
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventDropDetermining
	{
		// @required @property (readonly, nonatomic) BOOL shouldDropAppEvents;
		[Abstract]
		[Export ("shouldDropAppEvents")]
		bool ShouldDropAppEvents { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const FBSDKAppEventName FBSDKAppEventNameAdClick;
		[Field ("FBSDKAppEventNameAdClick", "__Internal")]
		NSString FBSDKAppEventNameAdClick { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameAdImpression;
		[Field ("FBSDKAppEventNameAdImpression", "__Internal")]
		NSString FBSDKAppEventNameAdImpression { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameCompletedRegistration;
		[Field ("FBSDKAppEventNameCompletedRegistration", "__Internal")]
		NSString FBSDKAppEventNameCompletedRegistration { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameCompletedTutorial;
		[Field ("FBSDKAppEventNameCompletedTutorial", "__Internal")]
		NSString FBSDKAppEventNameCompletedTutorial { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameContact;
		[Field ("FBSDKAppEventNameContact", "__Internal")]
		NSString FBSDKAppEventNameContact { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameCustomizeProduct;
		[Field ("FBSDKAppEventNameCustomizeProduct", "__Internal")]
		NSString FBSDKAppEventNameCustomizeProduct { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameDonate;
		[Field ("FBSDKAppEventNameDonate", "__Internal")]
		NSString FBSDKAppEventNameDonate { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameFindLocation;
		[Field ("FBSDKAppEventNameFindLocation", "__Internal")]
		NSString FBSDKAppEventNameFindLocation { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameRated;
		[Field ("FBSDKAppEventNameRated", "__Internal")]
		NSString FBSDKAppEventNameRated { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSchedule;
		[Field ("FBSDKAppEventNameSchedule", "__Internal")]
		NSString FBSDKAppEventNameSchedule { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSearched;
		[Field ("FBSDKAppEventNameSearched", "__Internal")]
		NSString FBSDKAppEventNameSearched { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameStartTrial;
		[Field ("FBSDKAppEventNameStartTrial", "__Internal")]
		NSString FBSDKAppEventNameStartTrial { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSubmitApplication;
		[Field ("FBSDKAppEventNameSubmitApplication", "__Internal")]
		NSString FBSDKAppEventNameSubmitApplication { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSubscribe;
		[Field ("FBSDKAppEventNameSubscribe", "__Internal")]
		NSString FBSDKAppEventNameSubscribe { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameViewedContent;
		[Field ("FBSDKAppEventNameViewedContent", "__Internal")]
		NSString FBSDKAppEventNameViewedContent { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameAddedPaymentInfo;
		[Field ("FBSDKAppEventNameAddedPaymentInfo", "__Internal")]
		NSString FBSDKAppEventNameAddedPaymentInfo { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameAddedToCart;
		[Field ("FBSDKAppEventNameAddedToCart", "__Internal")]
		NSString FBSDKAppEventNameAddedToCart { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameAddedToWishlist;
		[Field ("FBSDKAppEventNameAddedToWishlist", "__Internal")]
		NSString FBSDKAppEventNameAddedToWishlist { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameInitiatedCheckout;
		[Field ("FBSDKAppEventNameInitiatedCheckout", "__Internal")]
		NSString FBSDKAppEventNameInitiatedCheckout { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNamePurchased;
		[Field ("FBSDKAppEventNamePurchased", "__Internal")]
		NSString FBSDKAppEventNamePurchased { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNamePurchaseRestored;
		[Field ("FBSDKAppEventNamePurchaseRestored", "__Internal")]
		NSString FBSDKAppEventNamePurchaseRestored { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSubscribeRestore;
		[Field ("FBSDKAppEventNameSubscribeRestore", "__Internal")]
		NSString FBSDKAppEventNameSubscribeRestore { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNamePurchaseFailed;
		[Field ("FBSDKAppEventNamePurchaseFailed", "__Internal")]
		NSString FBSDKAppEventNamePurchaseFailed { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSubscribeInitiatedCheckout;
		[Field ("FBSDKAppEventNameSubscribeInitiatedCheckout", "__Internal")]
		NSString FBSDKAppEventNameSubscribeInitiatedCheckout { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSubscribeFailed;
		[Field ("FBSDKAppEventNameSubscribeFailed", "__Internal")]
		NSString FBSDKAppEventNameSubscribeFailed { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameAchievedLevel;
		[Field ("FBSDKAppEventNameAchievedLevel", "__Internal")]
		NSString FBSDKAppEventNameAchievedLevel { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameUnlockedAchievement;
		[Field ("FBSDKAppEventNameUnlockedAchievement", "__Internal")]
		NSString FBSDKAppEventNameUnlockedAchievement { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSpentCredits;
		[Field ("FBSDKAppEventNameSpentCredits", "__Internal")]
		NSString FBSDKAppEventNameSpentCredits { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameInitializeSDK;
		[Field ("FBSDKAppEventNameInitializeSDK", "__Internal")]
		NSString FBSDKAppEventNameInitializeSDK { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameBackgroundStatusAvailable;
		[Field ("FBSDKAppEventNameBackgroundStatusAvailable", "__Internal")]
		NSString FBSDKAppEventNameBackgroundStatusAvailable { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameBackgroundStatusDenied;
		[Field ("FBSDKAppEventNameBackgroundStatusDenied", "__Internal")]
		NSString FBSDKAppEventNameBackgroundStatusDenied { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameBackgroundStatusRestricted;
		[Field ("FBSDKAppEventNameBackgroundStatusRestricted", "__Internal")]
		NSString FBSDKAppEventNameBackgroundStatusRestricted { get; }

		// extern const FBSDKAppEventName FBSDKAppEventNameSDKSettingsChanged;
		[Field ("FBSDKAppEventNameSDKSettingsChanged", "__Internal")]
		NSString FBSDKAppEventNameSDKSettingsChanged { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameContent;
		[Field ("FBSDKAppEventParameterNameContent", "__Internal")]
		NSString FBSDKAppEventParameterNameContent { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameContentID;
		[Field ("FBSDKAppEventParameterNameContentID", "__Internal")]
		NSString FBSDKAppEventParameterNameContentID { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameContentType;
		[Field ("FBSDKAppEventParameterNameContentType", "__Internal")]
		NSString FBSDKAppEventParameterNameContentType { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameCurrency;
		[Field ("FBSDKAppEventParameterNameCurrency", "__Internal")]
		NSString FBSDKAppEventParameterNameCurrency { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameDescription;
		[Field ("FBSDKAppEventParameterNameDescription", "__Internal")]
		NSString FBSDKAppEventParameterNameDescription { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameLevel;
		[Field ("FBSDKAppEventParameterNameLevel", "__Internal")]
		NSString FBSDKAppEventParameterNameLevel { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameMaxRatingValue;
		[Field ("FBSDKAppEventParameterNameMaxRatingValue", "__Internal")]
		NSString FBSDKAppEventParameterNameMaxRatingValue { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameNumItems;
		[Field ("FBSDKAppEventParameterNameNumItems", "__Internal")]
		NSString FBSDKAppEventParameterNameNumItems { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNamePaymentInfoAvailable;
		[Field ("FBSDKAppEventParameterNamePaymentInfoAvailable", "__Internal")]
		NSString FBSDKAppEventParameterNamePaymentInfoAvailable { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameRegistrationMethod;
		[Field ("FBSDKAppEventParameterNameRegistrationMethod", "__Internal")]
		NSString FBSDKAppEventParameterNameRegistrationMethod { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameSearchString;
		[Field ("FBSDKAppEventParameterNameSearchString", "__Internal")]
		NSString FBSDKAppEventParameterNameSearchString { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameSuccess;
		[Field ("FBSDKAppEventParameterNameSuccess", "__Internal")]
		NSString FBSDKAppEventParameterNameSuccess { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameAdType;
		[Field ("FBSDKAppEventParameterNameAdType", "__Internal")]
		NSString FBSDKAppEventParameterNameAdType { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameOrderID;
		[Field ("FBSDKAppEventParameterNameOrderID", "__Internal")]
		NSString FBSDKAppEventParameterNameOrderID { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameEventName;
		[Field ("FBSDKAppEventParameterNameEventName", "__Internal")]
		NSString FBSDKAppEventParameterNameEventName { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameLogTime;
		[Field ("FBSDKAppEventParameterNameLogTime", "__Internal")]
		NSString FBSDKAppEventParameterNameLogTime { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameImplicitlyLoggedPurchase;
		[Field ("FBSDKAppEventParameterNameImplicitlyLoggedPurchase", "__Internal")]
		NSString FBSDKAppEventParameterNameImplicitlyLoggedPurchase { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameTransactionDate;
		[Field ("FBSDKAppEventParameterNameTransactionDate", "__Internal")]
		NSString FBSDKAppEventParameterNameTransactionDate { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameProductTitle;
		[Field ("FBSDKAppEventParameterNameProductTitle", "__Internal")]
		NSString FBSDKAppEventParameterNameProductTitle { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameTransactionID;
		[Field ("FBSDKAppEventParameterNameTransactionID", "__Internal")]
		NSString FBSDKAppEventParameterNameTransactionID { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameInAppPurchaseType;
		[Field ("FBSDKAppEventParameterNameInAppPurchaseType", "__Internal")]
		NSString FBSDKAppEventParameterNameInAppPurchaseType { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameSubscriptionPeriod;
		[Field ("FBSDKAppEventParameterNameSubscriptionPeriod", "__Internal")]
		NSString FBSDKAppEventParameterNameSubscriptionPeriod { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameIsStartTrial;
		[Field ("FBSDKAppEventParameterNameIsStartTrial", "__Internal")]
		NSString FBSDKAppEventParameterNameIsStartTrial { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameHasFreeTrial;
		[Field ("FBSDKAppEventParameterNameHasFreeTrial", "__Internal")]
		NSString FBSDKAppEventParameterNameHasFreeTrial { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameTrialPeriod;
		[Field ("FBSDKAppEventParameterNameTrialPeriod", "__Internal")]
		NSString FBSDKAppEventParameterNameTrialPeriod { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameTrialPrice;
		[Field ("FBSDKAppEventParameterNameTrialPrice", "__Internal")]
		NSString FBSDKAppEventParameterNameTrialPrice { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameValidationResult;
		[Field ("FBSDKAppEventParameterNameValidationResult", "__Internal")]
		NSString FBSDKAppEventParameterNameValidationResult { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameIAPClientLibraryVersion;
		[Field ("FBSDKAppEventParameterNameIAPClientLibraryVersion", "__Internal")]
		NSString FBSDKAppEventParameterNameIAPClientLibraryVersion { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameIAPSDKLibraryVersions;
		[Field ("FBSDKAppEventParameterNameIAPSDKLibraryVersions", "__Internal")]
		NSString FBSDKAppEventParameterNameIAPSDKLibraryVersions { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameIAPReceiptData;
		[Field ("FBSDKAppEventParameterNameIAPReceiptData", "__Internal")]
		NSString FBSDKAppEventParameterNameIAPReceiptData { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameProductClassification;
		[Field ("FBSDKAppEventParameterNameProductClassification", "__Internal")]
		NSString FBSDKAppEventParameterNameProductClassification { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameConsumablesInPurchaseHistory;
		[Field ("FBSDKAppEventParameterNameConsumablesInPurchaseHistory", "__Internal")]
		NSString FBSDKAppEventParameterNameConsumablesInPurchaseHistory { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameOriginalTransactionID;
		[Field ("FBSDKAppEventParameterNameOriginalTransactionID", "__Internal")]
		NSString FBSDKAppEventParameterNameOriginalTransactionID { get; }

		// extern const FBSDKAppEventParameterName FBSDKAppEventParameterNameOriginalTransactionDate;
		[Field ("FBSDKAppEventParameterNameOriginalTransactionDate", "__Internal")]
		NSString FBSDKAppEventParameterNameOriginalTransactionDate { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductCategory;
		[Field ("FBSDKAppEventParameterProductCategory", "__Internal")]
		NSString FBSDKAppEventParameterProductCategory { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductCustomLabel0;
		[Field ("FBSDKAppEventParameterProductCustomLabel0", "__Internal")]
		NSString FBSDKAppEventParameterProductCustomLabel0 { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductCustomLabel1;
		[Field ("FBSDKAppEventParameterProductCustomLabel1", "__Internal")]
		NSString FBSDKAppEventParameterProductCustomLabel1 { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductCustomLabel2;
		[Field ("FBSDKAppEventParameterProductCustomLabel2", "__Internal")]
		NSString FBSDKAppEventParameterProductCustomLabel2 { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductCustomLabel3;
		[Field ("FBSDKAppEventParameterProductCustomLabel3", "__Internal")]
		NSString FBSDKAppEventParameterProductCustomLabel3 { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductCustomLabel4;
		[Field ("FBSDKAppEventParameterProductCustomLabel4", "__Internal")]
		NSString FBSDKAppEventParameterProductCustomLabel4 { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIOSUrl;
		[Field ("FBSDKAppEventParameterProductAppLinkIOSUrl", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIOSUrl { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIOSAppStoreID;
		[Field ("FBSDKAppEventParameterProductAppLinkIOSAppStoreID", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIOSAppStoreID { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIOSAppName;
		[Field ("FBSDKAppEventParameterProductAppLinkIOSAppName", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIOSAppName { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIPhoneUrl;
		[Field ("FBSDKAppEventParameterProductAppLinkIPhoneUrl", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIPhoneUrl { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIPhoneAppStoreID;
		[Field ("FBSDKAppEventParameterProductAppLinkIPhoneAppStoreID", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIPhoneAppStoreID { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIPhoneAppName;
		[Field ("FBSDKAppEventParameterProductAppLinkIPhoneAppName", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIPhoneAppName { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIPadUrl;
		[Field ("FBSDKAppEventParameterProductAppLinkIPadUrl", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIPadUrl { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIPadAppStoreID;
		[Field ("FBSDKAppEventParameterProductAppLinkIPadAppStoreID", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIPadAppStoreID { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkIPadAppName;
		[Field ("FBSDKAppEventParameterProductAppLinkIPadAppName", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkIPadAppName { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkAndroidUrl;
		[Field ("FBSDKAppEventParameterProductAppLinkAndroidUrl", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkAndroidUrl { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkAndroidPackage;
		[Field ("FBSDKAppEventParameterProductAppLinkAndroidPackage", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkAndroidPackage { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkAndroidAppName;
		[Field ("FBSDKAppEventParameterProductAppLinkAndroidAppName", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkAndroidAppName { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkWindowsPhoneUrl;
		[Field ("FBSDKAppEventParameterProductAppLinkWindowsPhoneUrl", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkWindowsPhoneUrl { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkWindowsPhoneAppID;
		[Field ("FBSDKAppEventParameterProductAppLinkWindowsPhoneAppID", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkWindowsPhoneAppID { get; }

		// extern FBSDKAppEventParameterProduct FBSDKAppEventParameterProductAppLinkWindowsPhoneAppName;
		[Field ("FBSDKAppEventParameterProductAppLinkWindowsPhoneAppName", "__Internal")]
		NSString FBSDKAppEventParameterProductAppLinkWindowsPhoneAppName { get; }

		// extern FBSDKAppEventParameterValue FBSDKAppEventParameterValueYes;
		[Field ("FBSDKAppEventParameterValueYes", "__Internal")]
		NSString FBSDKAppEventParameterValueYes { get; }

		// extern FBSDKAppEventParameterValue FBSDKAppEventParameterValueNo;
		[Field ("FBSDKAppEventParameterValueNo", "__Internal")]
		NSString FBSDKAppEventParameterValueNo { get; }

		// extern NS_SWIFT_NAME(readAccessURL) const NSAttributedStringDocumentReadingOptionKey NSReadAccessURLDocumentOption __attribute__((visibility("default"))) __attribute__((swift_name("readAccessURL"))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Mac (10, 15), iOS (13, 0)]
		[Field ("NSReadAccessURLDocumentOption", "__Internal")]
		NSString NSReadAccessURLDocumentOption { get; }
	}

	// @protocol FBSDKAppEventsConfiguring
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventsConfiguring
	{
		// @required -(void)configureWithGateKeeperManager:(Class<FBSDKGateKeeperManaging> _Nonnull)gateKeeperManager appEventsConfigurationProvider:(id<FBSDKAppEventsConfigurationProviding> _Nonnull)appEventsConfigurationProvider serverConfigurationProvider:(id<FBSDKServerConfigurationProviding> _Nonnull)serverConfigurationProvider graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory featureChecker:(id<FBSDKFeatureChecking> _Nonnull)featureChecker primaryDataStore:(id<FBSDKDataPersisting> _Nonnull)primaryDataStore logger:(Class<FBSDKLogging> _Nonnull)logger settings:(id<FBSDKSettings> _Nonnull)settings paymentObserver:(id<FBSDKPaymentObserving> _Nonnull)paymentObserver timeSpentRecorder:(id<FBSDKSourceApplicationTracking,FBSDKTimeSpentRecording> _Nonnull)timeSpentRecorder appEventsStateStore:(id<FBSDKAppEventsStatePersisting> _Nonnull)appEventsStateStore eventDeactivationParameterProcessor:(id<FBSDKAppEventsParameterProcessing> _Nonnull)eventDeactivationParameterProcessor restrictiveDataFilterParameterProcessor:(id<FBSDKAppEventsParameterProcessing> _Nonnull)restrictiveDataFilterParameterProcessor atePublisherFactory:(id<FBSDKATEPublisherCreating> _Nonnull)atePublisherFactory appEventsStateProvider:(id<FBSDKAppEventsStateProviding> _Nonnull)appEventsStateProvider advertiserIDProvider:(id<FBSDKAdvertiserIDProviding> _Nonnull)advertiserIDProvider userDataStore:(id<FBSDKUserDataPersisting> _Nonnull)userDataStore appEventsUtility:(id<FBSDKAppEventDropDetermining,FBSDKAppEventParametersExtracting,FBSDKAppEventsUtility,FBSDKLoggingNotifying> _Nonnull)appEventsUtility internalUtility:(id<FBSDKInternalUtility> _Nonnull)internalUtility capiReporter:(id<FBSDKCAPIReporter> _Nonnull)capiReporter protectedModeManager:(id<FBSDKAppEventsParameterProcessing> _Nonnull)protectedModeManager bannedParamsManager:(id<FBSDKMACARuleMatching> _Nonnull)bannedParamsManager stdParamEnforcementManager:(id<FBSDKMACARuleMatching> _Nonnull)stdParamEnforcementManager macaRuleMatchingManager:(id<FBSDKMACARuleMatching> _Nonnull)macaRuleMatchingManager vvpConfigManager:(id<FBSDKMACARuleMatching> _Nonnull)vvpConfigManager blocklistEventsManager:(id<FBSDKEventsProcessing> _Nonnull)blocklistEventsManager redactedEventsManager:(id<FBSDKEventsProcessing> _Nonnull)redactedEventsManager sensitiveParamsManager:(id<FBSDKAppEventsParameterProcessing> _Nonnull)sensitiveParamsManager transactionObserver:(id<FBSDKTransactionObserving> _Nonnull)transactionObserver failedTransactionLoggingFactory:(id<FBSDKIAPFailedTransactionLoggingCreating> _Nonnull)failedTransactionLoggingFactory iapDedupeProcessor:(id<FBSDKIAPDedupeProcessing> _Nonnull)iapDedupeProcessor iapTransactionCache:(id<FBSDKIAPTransactionCaching> _Nonnull)iapTransactionCache __attribute__((swift_name("configure(gateKeeperManager:appEventsConfigurationProvider:serverConfigurationProvider:graphRequestFactory:featureChecker:primaryDataStore:logger:settings:paymentObserver:timeSpentRecorder:appEventsStateStore:eventDeactivationParameterProcessor:restrictiveDataFilterParameterProcessor:atePublisherFactory:appEventsStateProvider:advertiserIDProvider:userDataStore:appEventsUtility:internalUtility:capiReporter:protectedModeManager:bannedParamsManager:stdParamEnforcementManager:macaRuleMatchingManager:vvpConfigManager:blocklistEventsManager:redactedEventsManager:sensitiveParamsManager:transactionObserver:failedTransactionLoggingFactory:iapDedupeProcessor:iapTransactionCache:)")));
		[Abstract]
		[Export ("configureWithGateKeeperManager:appEventsConfigurationProvider:serverConfigurationProvider:graphRequestFactory:featureChecker:primaryDataStore:logger:settings:paymentObserver:timeSpentRecorder:appEventsStateStore:eventDeactivationParameterProcessor:restrictiveDataFilterParameterProcessor:atePublisherFactory:appEventsStateProvider:advertiserIDProvider:userDataStore:appEventsUtility:internalUtility:capiReporter:protectedModeManager:bannedParamsManager:stdParamEnforcementManager:macaRuleMatchingManager:vvpConfigManager:blocklistEventsManager:redactedEventsManager:sensitiveParamsManager:transactionObserver:failedTransactionLoggingFactory:iapDedupeProcessor:iapTransactionCache:")]
		void ConfigureWithGateKeeperManager (FBSDKGateKeeperManaging gateKeeperManager, FBSDKAppEventsConfigurationProviding appEventsConfigurationProvider, FBSDKServerConfigurationProviding serverConfigurationProvider, FBSDKGraphRequestFactory graphRequestFactory, FBSDKFeatureChecking featureChecker, FBSDKDataPersisting primaryDataStore, FBSDKLogging logger, FBSDKSettings settings, FBSDKPaymentObserving paymentObserver, NSObject<FBSDKSourceApplicationTracking, FBSDKTimeSpentRecording> timeSpentRecorder, FBSDKAppEventsStatePersisting appEventsStateStore, FBSDKAppEventsParameterProcessing eventDeactivationParameterProcessor, FBSDKAppEventsParameterProcessing restrictiveDataFilterParameterProcessor, FBSDKATEPublisherCreating atePublisherFactory, FBSDKAppEventsStateProviding appEventsStateProvider, FBSDKAdvertiserIDProviding advertiserIDProvider, FBSDKUserDataPersisting userDataStore, NSObject<FBSDKAppEventDropDetermining, FBSDKAppEventParametersExtracting, FBSDKAppEventsUtility, FBSDKLoggingNotifying> appEventsUtility, FBSDKInternalUtility internalUtility, FBSDKCAPIReporter capiReporter, FBSDKAppEventsParameterProcessing protectedModeManager, FBSDKMACARuleMatching bannedParamsManager, FBSDKMACARuleMatching stdParamEnforcementManager, FBSDKMACARuleMatching macaRuleMatchingManager, FBSDKMACARuleMatching vvpConfigManager, FBSDKEventsProcessing blocklistEventsManager, FBSDKEventsProcessing redactedEventsManager, FBSDKAppEventsParameterProcessing sensitiveParamsManager, FBSDKTransactionObserving transactionObserver, FBSDKIAPFailedTransactionLoggingCreating failedTransactionLoggingFactory, FBSDKIAPDedupeProcessing iapDedupeProcessor, FBSDKIAPTransactionCaching iapTransactionCache);

		// @required -(void)configureNonTVComponentsWithOnDeviceMLModelManager:(id<FBSDKEventProcessing> _Nonnull)modelManager metadataIndexer:(id<FBSDKMetadataIndexing> _Nonnull)metadataIndexer skAdNetworkReporter:(id<FBSDKAppEventsReporter> _Nullable)skAdNetworkReporter skAdNetworkReporterV2:(id<FBSDKAppEventsReporter> _Nullable)skAdNetworkReporterV2 codelessIndexer:(Class<FBSDKCodelessIndexing> _Nonnull)codelessIndexer swizzler:(Class<FBSDKSwizzling> _Nonnull)swizzler aemReporter:(Class<FBSDKAEMReporter> _Nonnull)aemReporter __attribute__((swift_name("configureNonTVComponents(onDeviceMLModelManager:metadataIndexer:skAdNetworkReporter:skAdNetworkReporterV2:codelessIndexer:swizzler:aemReporter:)")));
		[Abstract]
		[Export ("configureNonTVComponentsWithOnDeviceMLModelManager:metadataIndexer:skAdNetworkReporter:skAdNetworkReporterV2:codelessIndexer:swizzler:aemReporter:")]
		void ConfigureNonTVComponentsWithOnDeviceMLModelManager (FBSDKEventProcessing modelManager, FBSDKMetadataIndexing metadataIndexer, [NullAllowed] FBSDKAppEventsReporter skAdNetworkReporter, [NullAllowed] FBSDKAppEventsReporter skAdNetworkReporterV2, FBSDKCodelessIndexing codelessIndexer, FBSDKSwizzling swizzler, FBSDKAEMReporter aemReporter);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern FBSDKAppEventUserDataType FBSDKAppEventEmail;
		[Field ("FBSDKAppEventEmail", "__Internal")]
		NSString FBSDKAppEventEmail { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventFirstName;
		[Field ("FBSDKAppEventFirstName", "__Internal")]
		NSString FBSDKAppEventFirstName { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventLastName;
		[Field ("FBSDKAppEventLastName", "__Internal")]
		NSString FBSDKAppEventLastName { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventPhone;
		[Field ("FBSDKAppEventPhone", "__Internal")]
		NSString FBSDKAppEventPhone { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventDateOfBirth;
		[Field ("FBSDKAppEventDateOfBirth", "__Internal")]
		NSString FBSDKAppEventDateOfBirth { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventGender;
		[Field ("FBSDKAppEventGender", "__Internal")]
		NSString FBSDKAppEventGender { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventCity;
		[Field ("FBSDKAppEventCity", "__Internal")]
		NSString FBSDKAppEventCity { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventState;
		[Field ("FBSDKAppEventState", "__Internal")]
		NSString FBSDKAppEventState { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventZip;
		[Field ("FBSDKAppEventZip", "__Internal")]
		NSString FBSDKAppEventZip { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventCountry;
		[Field ("FBSDKAppEventCountry", "__Internal")]
		NSString FBSDKAppEventCountry { get; }

		// extern FBSDKAppEventUserDataType FBSDKAppEventExternalId;
		[Field ("FBSDKAppEventExternalId", "__Internal")]
		NSString FBSDKAppEventExternalId { get; }
	}

	// @protocol FBSDKApplicationActivating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKApplicationActivating
	{
		// @required -(void)activateApp;
		[Abstract]
		[Export ("activateApp")]
		void ActivateApp ();
	}

	// @protocol FBSDKApplicationLifecycleObserving
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKApplicationLifecycleObserving
	{
		// @required -(void)startObservingApplicationLifecycleNotifications __attribute__((swift_name("startObservingApplicationLifecycleNotifications()")));
		[Abstract]
		[Export ("startObservingApplicationLifecycleNotifications")]
		void StartObservingApplicationLifecycleNotifications ();
	}

	// @protocol FBSDKApplicationStateSetting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKApplicationStateSetting
	{
		// @required -(void)setApplicationState:(UIApplicationState)state;
		[Abstract]
		[Export ("setApplicationState:")]
		void SetApplicationState (UIApplicationState state);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const FBSDKAppOperationalDataType FBSDKAppOperationalDataTypeIAPParameters;
		[Field ("FBSDKAppOperationalDataTypeIAPParameters", "__Internal")]
		NSString FBSDKAppOperationalDataTypeIAPParameters { get; }
	}

	// @protocol FBSDKEventLogging
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKEventLogging
	{
		// @required @property (readonly, nonatomic) FBSDKAppEventsFlushBehavior flushBehavior;
		[Abstract]
		[Export ("flushBehavior")]
		FBSDKAppEventsFlushBehavior FlushBehavior { get; }

		// @required -(void)flushForReason:(FBSDKAppEventsFlushReason)flushReason;
		[Abstract]
		[Export ("flushForReason:")]
		void FlushForReason (FBSDKAppEventsFlushReason flushReason);

		// @required -(void)logEvent:(FBSDKAppEventName _Nonnull)eventName parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters;
		[Abstract]
		[Export ("logEvent:parameters:")]
		void LogEvent (string eventName, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// @required -(void)logEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(double)valueToSum parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters;
		[Abstract]
		[Export ("logEvent:valueToSum:parameters:")]
		void LogEvent (string eventName, double valueToSum, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// @required -(void)logEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(NSNumber * _Nullable)valueToSum parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters accessToken:(FBSDKAccessToken * _Nullable)accessToken;
		[Abstract]
		[Export ("logEvent:valueToSum:parameters:accessToken:")]
		void LogEvent (string eventName, [NullAllowed] NSNumber valueToSum, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] FBSDKAccessToken accessToken);

		// @required -(void)logInternalEvent:(FBSDKAppEventName _Nonnull)eventName isImplicitlyLogged:(BOOL)isImplicitlyLogged;
		[Abstract]
		[Export ("logInternalEvent:isImplicitlyLogged:")]
		void LogInternalEvent (string eventName, bool isImplicitlyLogged);

		// @required -(void)logInternalEvent:(FBSDKAppEventName _Nonnull)eventName parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters isImplicitlyLogged:(BOOL)isImplicitlyLogged;
		[Abstract]
		[Export ("logInternalEvent:parameters:isImplicitlyLogged:")]
		void LogInternalEvent (string eventName, [NullAllowed] NSDictionary<NSString, NSObject> parameters, bool isImplicitlyLogged);

		// @required -(void)logInternalEvent:(FBSDKAppEventName _Nonnull)eventName parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters isImplicitlyLogged:(BOOL)isImplicitlyLogged accessToken:(FBSDKAccessToken * _Nullable)accessToken;
		[Abstract]
		[Export ("logInternalEvent:parameters:isImplicitlyLogged:accessToken:")]
		void LogInternalEvent (string eventName, [NullAllowed] NSDictionary<NSString, NSObject> parameters, bool isImplicitlyLogged, [NullAllowed] FBSDKAccessToken accessToken);

		// @required -(void)logInternalEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(double)valueToSum isImplicitlyLogged:(BOOL)isImplicitlyLogged;
		[Abstract]
		[Export ("logInternalEvent:valueToSum:isImplicitlyLogged:")]
		void LogInternalEvent (string eventName, double valueToSum, bool isImplicitlyLogged);

		// @required -(void)doLogEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(NSNumber * _Nullable)valueToSum parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters isImplicitlyLogged:(BOOL)isImplicitlyLogged accessToken:(FBSDKAccessToken * _Nullable)accessToken operationalParameters:(NSDictionary<FBSDKAppOperationalDataType,NSDictionary<NSString *,id> *> * _Nullable)operationalParameters;
		[Abstract]
		[Export ("doLogEvent:valueToSum:parameters:isImplicitlyLogged:accessToken:operationalParameters:")]
		void DoLogEvent (string eventName, [NullAllowed] NSNumber valueToSum, [NullAllowed] NSDictionary<NSString, NSObject> parameters, bool isImplicitlyLogged, [NullAllowed] FBSDKAccessToken accessToken, [NullAllowed] NSDictionary<NSString, NSDictionary<NSString, NSObject>> operationalParameters);
	}

	// @protocol FBSDKGraphRequestConnectionFactory
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKGraphRequestConnectionFactory
	{
		// @required -(id<FBSDKGraphRequestConnecting> _Nonnull)createGraphRequestConnection;
		[Abstract]
		[Export ("createGraphRequestConnection")]
		[Verify (MethodToProperty)]
		FBSDKGraphRequestConnecting CreateGraphRequestConnection { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern FBSDKHTTPMethod FBSDKHTTPMethodGET __attribute__((swift_name("get")));
		[Field ("FBSDKHTTPMethodGET", "__Internal")]
		NSString FBSDKHTTPMethodGET { get; }

		// extern FBSDKHTTPMethod FBSDKHTTPMethodPOST __attribute__((swift_name("post")));
		[Field ("FBSDKHTTPMethodPOST", "__Internal")]
		NSString FBSDKHTTPMethodPOST { get; }

		// extern FBSDKHTTPMethod FBSDKHTTPMethodDELETE __attribute__((swift_name("delete")));
		[Field ("FBSDKHTTPMethodDELETE", "__Internal")]
		NSString FBSDKHTTPMethodDELETE { get; }
	}

	// typedef void (^FBSDKGraphRequestCompletion)(id<FBSDKGraphRequestConnecting> _Nullable, id _Nullable, NSError * _Nullable);
	delegate void FBSDKGraphRequestCompletion ([NullAllowed] FBSDKGraphRequestConnecting arg0, [NullAllowed] NSObject arg1, [NullAllowed] NSError arg2);

	// typedef void (^FBSDKGraphRequestBlock)(FBSDKGraphRequestConnection * _Nullable, id _Nullable, NSError * _Nullable);
	delegate void FBSDKGraphRequestBlock ([NullAllowed] FBSDKGraphRequestConnection arg0, [NullAllowed] NSObject arg1, [NullAllowed] NSError arg2);

	// @protocol FBSDKGraphRequest
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKGraphRequest
	{
		// @required @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull parameters;
		[Abstract]
		[Export ("parameters", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Parameters { get; set; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable tokenString;
		[Abstract]
		[NullAllowed, Export ("tokenString")]
		string TokenString { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull graphPath;
		[Abstract]
		[Export ("graphPath")]
		string GraphPath { get; }

		// @required @property (readonly, copy, nonatomic) FBSDKHTTPMethod _Nonnull HTTPMethod;
		[Abstract]
		[Export ("HTTPMethod")]
		string HTTPMethod { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull version;
		[Abstract]
		[Export ("version")]
		string Version { get; }

		// @required @property (readonly, assign, nonatomic) FBSDKGraphRequestFlags flags;
		[Abstract]
		[Export ("flags", ArgumentSemantic.Assign)]
		FBSDKGraphRequestFlags Flags { get; }

		// @required @property (getter = isGraphErrorRecoveryDisabled, nonatomic) BOOL graphErrorRecoveryDisabled;
		[Abstract]
		[Export ("graphErrorRecoveryDisabled")]
		bool GraphErrorRecoveryDisabled { [Bind ("isGraphErrorRecoveryDisabled")] get; set; }

		// @required @property (readonly, nonatomic) BOOL hasAttachments;
		[Abstract]
		[Export ("hasAttachments")]
		bool HasAttachments { get; }

		// @required @property (readonly, assign, nonatomic) BOOL forAppEvents;
		[Abstract]
		[Export ("forAppEvents")]
		bool ForAppEvents { get; }

		// @required @property (readonly, assign, nonatomic) BOOL useAlternativeDefaultDomainPrefix;
		[Abstract]
		[Export ("useAlternativeDefaultDomainPrefix")]
		bool UseAlternativeDefaultDomainPrefix { get; }

		// @required -(id<FBSDKGraphRequestConnecting> _Nonnull)startWithCompletion:(FBSDKGraphRequestCompletion _Nullable)completion;
		[Abstract]
		[Export ("startWithCompletion:")]
		FBSDKGraphRequestConnecting StartWithCompletion ([NullAllowed] FBSDKGraphRequestCompletion completion);

		// @required -(NSString * _Nonnull)formattedDescription;
		[Abstract]
		[Export ("formattedDescription")]
		[Verify (MethodToProperty)]
		string FormattedDescription { get; }
	}

	// @interface FBSDKGraphRequest : NSObject <FBSDKGraphRequest>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGraphRequest : IFBSDKGraphRequest
	{
		// +(void)configureWithSettings:(id<FBSDKSettings> _Nonnull)settings currentAccessTokenStringProvider:(Class<FBSDKTokenStringProviding> _Nonnull)accessTokenProvider graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)_graphRequestConnectionFactory __attribute__((swift_name("configure(settings:currentAccessTokenStringProvider:graphRequestConnectionFactory:)")));
		[Static]
		[Export ("configureWithSettings:currentAccessTokenStringProvider:graphRequestConnectionFactory:")]
		void ConfigureWithSettings (FBSDKSettings settings, FBSDKTokenStringProviding accessTokenProvider, FBSDKGraphRequestConnectionFactory _graphRequestConnectionFactory);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath;
		[Export ("initWithGraphPath:")]
		NativeHandle Constructor (string graphPath);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Export ("initWithGraphPath:useAlternativeDefaultDomainPrefix:")]
		NativeHandle Constructor (string graphPath, bool useAlternativeDefaultDomainPrefix);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath HTTPMethod:(FBSDKHTTPMethod _Nonnull)method;
		[Export ("initWithGraphPath:HTTPMethod:")]
		NativeHandle Constructor (string graphPath, string method);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters;
		[Export ("initWithGraphPath:parameters:")]
		NativeHandle Constructor (string graphPath, NSDictionary<NSString, NSObject> parameters);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Export ("initWithGraphPath:parameters:useAlternativeDefaultDomainPrefix:")]
		NativeHandle Constructor (string graphPath, NSDictionary<NSString, NSObject> parameters, bool useAlternativeDefaultDomainPrefix);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters HTTPMethod:(FBSDKHTTPMethod _Nonnull)method;
		[Export ("initWithGraphPath:parameters:HTTPMethod:")]
		NativeHandle Constructor (string graphPath, NSDictionary<NSString, NSObject> parameters, string method);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters HTTPMethod:(FBSDKHTTPMethod _Nonnull)method useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Export ("initWithGraphPath:parameters:HTTPMethod:useAlternativeDefaultDomainPrefix:")]
		NativeHandle Constructor (string graphPath, NSDictionary<NSString, NSObject> parameters, string method, bool useAlternativeDefaultDomainPrefix);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString version:(NSString * _Nullable)version HTTPMethod:(FBSDKHTTPMethod _Nonnull)method;
		[Export ("initWithGraphPath:parameters:tokenString:version:HTTPMethod:")]
		NativeHandle Constructor (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string version, string method);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString version:(NSString * _Nullable)version HTTPMethod:(FBSDKHTTPMethod _Nonnull)method forAppEvents:(BOOL)forAppEvents;
		[Export ("initWithGraphPath:parameters:tokenString:version:HTTPMethod:forAppEvents:")]
		NativeHandle Constructor (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string version, string method, bool forAppEvents);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString version:(NSString * _Nullable)version HTTPMethod:(FBSDKHTTPMethod _Nonnull)method forAppEvents:(BOOL)forAppEvents useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix __attribute__((objc_designated_initializer));
		[Export ("initWithGraphPath:parameters:tokenString:version:HTTPMethod:forAppEvents:useAlternativeDefaultDomainPrefix:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string version, string method, bool forAppEvents, bool useAlternativeDefaultDomainPrefix);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nullable)parameters flags:(FBSDKGraphRequestFlags)requestFlags;
		[Export ("initWithGraphPath:parameters:flags:")]
		NativeHandle Constructor (string graphPath, [NullAllowed] NSDictionary<NSString, NSObject> parameters, FBSDKGraphRequestFlags requestFlags);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nullable)parameters flags:(FBSDKGraphRequestFlags)requestFlags useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Export ("initWithGraphPath:parameters:flags:useAlternativeDefaultDomainPrefix:")]
		NativeHandle Constructor (string graphPath, [NullAllowed] NSDictionary<NSString, NSObject> parameters, FBSDKGraphRequestFlags requestFlags, bool useAlternativeDefaultDomainPrefix);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nullable)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(NSString * _Nullable)HTTPMethod flags:(FBSDKGraphRequestFlags)flags;
		[Export ("initWithGraphPath:parameters:tokenString:HTTPMethod:flags:")]
		NativeHandle Constructor (string graphPath, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string HTTPMethod, FBSDKGraphRequestFlags flags);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nullable)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(NSString * _Nullable)HTTPMethod flags:(FBSDKGraphRequestFlags)flags useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Export ("initWithGraphPath:parameters:tokenString:HTTPMethod:flags:useAlternativeDefaultDomainPrefix:")]
		NativeHandle Constructor (string graphPath, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string HTTPMethod, FBSDKGraphRequestFlags flags, bool useAlternativeDefaultDomainPrefix);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nullable)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(NSString * _Nullable)method flags:(FBSDKGraphRequestFlags)requestFlags forAppEvents:(BOOL)forAppEvents;
		[Export ("initWithGraphPath:parameters:tokenString:HTTPMethod:flags:forAppEvents:")]
		NativeHandle Constructor (string graphPath, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string method, FBSDKGraphRequestFlags requestFlags, bool forAppEvents);

		// -(instancetype _Nonnull)initWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nullable)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(NSString * _Nullable)method flags:(FBSDKGraphRequestFlags)requestFlags forAppEvents:(BOOL)forAppEvents useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Export ("initWithGraphPath:parameters:tokenString:HTTPMethod:flags:forAppEvents:useAlternativeDefaultDomainPrefix:")]
		NativeHandle Constructor (string graphPath, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string method, FBSDKGraphRequestFlags requestFlags, bool forAppEvents, bool useAlternativeDefaultDomainPrefix);

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull parameters;
		[Export ("parameters", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Parameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable tokenString;
		[NullAllowed, Export ("tokenString")]
		string TokenString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull graphPath;
		[Export ("graphPath")]
		string GraphPath { get; }

		// @property (readonly, copy, nonatomic) FBSDKHTTPMethod _Nonnull HTTPMethod;
		[Export ("HTTPMethod")]
		string HTTPMethod { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull version;
		[Export ("version")]
		string Version { get; }

		// @property (readonly, assign, nonatomic) BOOL forAppEvents;
		[Export ("forAppEvents")]
		bool ForAppEvents { get; }

		// @property (readonly, assign, nonatomic) BOOL useAlternativeDefaultDomainPrefix;
		[Export ("useAlternativeDefaultDomainPrefix")]
		bool UseAlternativeDefaultDomainPrefix { get; }

		// -(void)setGraphErrorRecoveryDisabled:(BOOL)disable __attribute__((swift_name("setGraphErrorRecovery(disabled:)")));
		[Export ("setGraphErrorRecoveryDisabled:")]
		void SetGraphErrorRecoveryDisabled (bool disable);

		// -(id<FBSDKGraphRequestConnecting> _Nonnull)startWithCompletion:(FBSDKGraphRequestCompletion _Nullable)completion;
		[Export ("startWithCompletion:")]
		FBSDKGraphRequestConnecting StartWithCompletion ([NullAllowed] FBSDKGraphRequestCompletion completion);
	}

	// @protocol FBSDKSourceApplicationTracking
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSourceApplicationTracking
	{
		// @required -(void)setSourceApplication:(NSString * _Nullable)sourceApplication openURL:(NSURL * _Nullable)url;
		[Abstract]
		[Export ("setSourceApplication:openURL:")]
		void SetSourceApplication ([NullAllowed] string sourceApplication, [NullAllowed] NSURL url);

		// @required -(void)setSourceApplication:(NSString * _Nullable)sourceApplication isFromAppLink:(BOOL)isFromAppLink;
		[Abstract]
		[Export ("setSourceApplication:isFromAppLink:")]
		void SetSourceApplication ([NullAllowed] string sourceApplication, bool isFromAppLink);

		// @required -(void)registerAutoResetSourceApplication;
		[Abstract]
		[Export ("registerAutoResetSourceApplication")]
		void RegisterAutoResetSourceApplication ();
	}

	// @protocol FBSDKUserIDProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKUserIDProviding
	{
		// @required @property (copy, nonatomic) NSString * _Nullable userID;
		[Abstract]
		[NullAllowed, Export ("userID")]
		string UserID { get; set; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NS_SWIFT_NAME(AppEventsOverrideAppIDBundleKey) NSString *const FBSDKAppEventsOverrideAppIDBundleKey __attribute__((swift_name("AppEventsOverrideAppIDBundleKey")));
		[Field ("FBSDKAppEventsOverrideAppIDBundleKey", "__Internal")]
		NSString FBSDKAppEventsOverrideAppIDBundleKey { get; }
	}

	// @interface FBSDKAppEvents : NSObject <FBSDKEventLogging, FBSDKAppEventsConfiguring, FBSDKApplicationActivating, FBSDKApplicationLifecycleObserving, FBSDKApplicationStateSetting, FBSDKSourceApplicationTracking, FBSDKUserIDProviding>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppEvents : IFBSDKEventLogging, IFBSDKAppEventsConfiguring, IFBSDKApplicationActivating, IFBSDKApplicationLifecycleObserving, IFBSDKApplicationStateSetting, IFBSDKSourceApplicationTracking, IFBSDKUserIDProviding
	{
		// @property (readonly, nonatomic, strong, class) FBSDKAppEvents * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FBSDKAppEvents Shared { get; }

		// @property (nonatomic) FBSDKAppEventsFlushBehavior flushBehavior;
		[Export ("flushBehavior", ArgumentSemantic.Assign)]
		FBSDKAppEventsFlushBehavior FlushBehavior { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable loggingOverrideAppID;
		[NullAllowed, Export ("loggingOverrideAppID")]
		string LoggingOverrideAppID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable userID;
		[NullAllowed, Export ("userID")]
		string UserID { get; set; }

		// @property (readonly, nonatomic) NSString * _Nonnull anonymousID;
		[Export ("anonymousID")]
		string AnonymousID { get; }

		// -(void)logEvent:(FBSDKAppEventName _Nonnull)eventName;
		[Export ("logEvent:")]
		void LogEvent (string eventName);

		// -(void)logEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(double)valueToSum;
		[Export ("logEvent:valueToSum:")]
		void LogEvent (string eventName, double valueToSum);

		// -(void)logEvent:(FBSDKAppEventName _Nonnull)eventName parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters;
		[Export ("logEvent:parameters:")]
		void LogEvent (string eventName, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// -(void)logEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(double)valueToSum parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters;
		[Export ("logEvent:valueToSum:parameters:")]
		void LogEvent (string eventName, double valueToSum, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// -(void)logEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(NSNumber * _Nullable)valueToSum parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters accessToken:(FBSDKAccessToken * _Nullable)accessToken;
		[Export ("logEvent:valueToSum:parameters:accessToken:")]
		void LogEvent (string eventName, [NullAllowed] NSNumber valueToSum, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] FBSDKAccessToken accessToken);

		// -(void)logPurchase:(double)purchaseAmount currency:(NSString * _Nonnull)currency __attribute__((swift_name("logPurchase(amount:currency:)")));
		[Export ("logPurchase:currency:")]
		void LogPurchase (double purchaseAmount, string currency);

		// -(void)logPurchase:(double)purchaseAmount currency:(NSString * _Nonnull)currency parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters __attribute__((swift_name("logPurchase(amount:currency:parameters:)")));
		[Export ("logPurchase:currency:parameters:")]
		void LogPurchase (double purchaseAmount, string currency, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// -(void)logPurchase:(double)purchaseAmount currency:(NSString * _Nonnull)currency parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters accessToken:(FBSDKAccessToken * _Nullable)accessToken __attribute__((swift_name("logPurchase(amount:currency:parameters:accessToken:)")));
		[Export ("logPurchase:currency:parameters:accessToken:")]
		void LogPurchase (double purchaseAmount, string currency, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] FBSDKAccessToken accessToken);

		// -(void)logFailedStoreKit2Purchase:(NSString * _Nonnull)productID __attribute__((availability(ios, introduced=15.0)));
		[iOS (15,0)]
		[Export ("logFailedStoreKit2Purchase:")]
		void LogFailedStoreKit2Purchase (string productID);

		// -(void)logPushNotificationOpen:(NSDictionary<NSString *,id> * _Nonnull)payload __attribute__((swift_name("logPushNotificationOpen(payload:)")));
		[Export ("logPushNotificationOpen:")]
		void LogPushNotificationOpen (NSDictionary<NSString, NSObject> payload);

		// -(void)logPushNotificationOpen:(NSDictionary<NSString *,id> * _Nonnull)payload action:(NSString * _Nonnull)action __attribute__((swift_name("logPushNotificationOpen(payload:action:)")));
		[Export ("logPushNotificationOpen:action:")]
		void LogPushNotificationOpen (NSDictionary<NSString, NSObject> payload, string action);

		// -(void)logProductItem:(NSString * _Nonnull)itemID availability:(FBSDKProductAvailability)availability condition:(FBSDKProductCondition)condition description:(NSString * _Nonnull)description imageLink:(NSString * _Nonnull)imageLink link:(NSString * _Nonnull)link title:(NSString * _Nonnull)title priceAmount:(double)priceAmount currency:(NSString * _Nonnull)currency gtin:(NSString * _Nullable)gtin mpn:(NSString * _Nullable)mpn brand:(NSString * _Nullable)brand parameters:(NSDictionary<NSString *,id> * _Nullable)parameters __attribute__((swift_name("logProductItem(id:availability:condition:description:imageLink:link:title:priceAmount:currency:gtin:mpn:brand:parameters:)")));
		[Export ("logProductItem:availability:condition:description:imageLink:link:title:priceAmount:currency:gtin:mpn:brand:parameters:")]
		void LogProductItem (string itemID, FBSDKProductAvailability availability, FBSDKProductCondition condition, string description, string imageLink, string link, string title, double priceAmount, string currency, [NullAllowed] string gtin, [NullAllowed] string mpn, [NullAllowed] string brand, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// -(void)activateApp;
		[Export ("activateApp")]
		void ActivateApp ();

		// -(void)setPushNotificationsDeviceToken:(NSData * _Nullable)deviceToken;
		[Export ("setPushNotificationsDeviceToken:")]
		void SetPushNotificationsDeviceToken ([NullAllowed] NSData deviceToken);

		// -(void)setPushNotificationsDeviceTokenString:(NSString * _Nullable)deviceTokenString __attribute__((swift_name("setPushNotificationsDeviceToken(_:)")));
		[Export ("setPushNotificationsDeviceTokenString:")]
		void SetPushNotificationsDeviceTokenString ([NullAllowed] string deviceTokenString);

		// -(void)flush;
		[Export ("flush")]
		void Flush ();

		// -(FBSDKGraphRequest * _Nullable)requestForCustomAudienceThirdPartyIDWithAccessToken:(FBSDKAccessToken * _Nullable)accessToken __attribute__((swift_name("requestForCustomAudienceThirdPartyID(accessToken:)")));
		[Export ("requestForCustomAudienceThirdPartyIDWithAccessToken:")]
		[return: NullAllowed]
		FBSDKGraphRequest RequestForCustomAudienceThirdPartyIDWithAccessToken ([NullAllowed] FBSDKAccessToken accessToken);

		// -(void)setUserEmail:(NSString * _Nullable)email firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName phone:(NSString * _Nullable)phone dateOfBirth:(NSString * _Nullable)dateOfBirth gender:(NSString * _Nullable)gender city:(NSString * _Nullable)city state:(NSString * _Nullable)state zip:(NSString * _Nullable)zip country:(NSString * _Nullable)country __attribute__((swift_name("setUser(email:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:)")));
		[Export ("setUserEmail:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:")]
		void SetUserEmail ([NullAllowed] string email, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string phone, [NullAllowed] string dateOfBirth, [NullAllowed] string gender, [NullAllowed] string city, [NullAllowed] string state, [NullAllowed] string zip, [NullAllowed] string country);

		// -(NSString * _Nullable)getUserData;
		[NullAllowed, Export ("getUserData")]
		[Verify (MethodToProperty)]
		string UserData { get; }

		// -(void)clearUserData;
		[Export ("clearUserData")]
		void ClearUserData ();

		// -(void)setUserData:(NSString * _Nullable)data forType:(FBSDKAppEventUserDataType _Nonnull)type;
		[Export ("setUserData:forType:")]
		void SetUserData ([NullAllowed] string data, string type);

		// -(void)clearUserDataForType:(FBSDKAppEventUserDataType _Nonnull)type;
		[Export ("clearUserDataForType:")]
		void ClearUserDataForType (string type);

		// -(void)augmentHybridWebView:(WKWebView * _Nonnull)webView;
		[Export ("augmentHybridWebView:")]
		void AugmentHybridWebView (WKWebView webView);

		// -(void)setIsUnityInitialized:(BOOL)isUnityInitialized;
		[Export ("setIsUnityInitialized:")]
		void SetIsUnityInitialized (bool isUnityInitialized);

		// -(void)sendEventBindingsToUnity;
		[Export ("sendEventBindingsToUnity")]
		void SendEventBindingsToUnity ();

		// -(void)logInternalEvent:(FBSDKAppEventName _Nonnull)eventName parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters isImplicitlyLogged:(BOOL)isImplicitlyLogged;
		[Export ("logInternalEvent:parameters:isImplicitlyLogged:")]
		void LogInternalEvent (string eventName, [NullAllowed] NSDictionary<NSString, NSObject> parameters, bool isImplicitlyLogged);

		// -(void)logInternalEvent:(FBSDKAppEventName _Nonnull)eventName parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters isImplicitlyLogged:(BOOL)isImplicitlyLogged accessToken:(FBSDKAccessToken * _Nullable)accessToken;
		[Export ("logInternalEvent:parameters:isImplicitlyLogged:accessToken:")]
		void LogInternalEvent (string eventName, [NullAllowed] NSDictionary<NSString, NSObject> parameters, bool isImplicitlyLogged, [NullAllowed] FBSDKAccessToken accessToken);

		// -(void)flushForReason:(FBSDKAppEventsFlushReason)flushReason;
		[Export ("flushForReason:")]
		void FlushForReason (FBSDKAppEventsFlushReason flushReason);
	}

	// @protocol FBSDKAppEventsConfiguration
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[DisableDefaultCtor]
	interface FBSDKAppEventsConfiguration
	{
		// @required @property (readonly, assign, nonatomic) FBSDKAdvertisingTrackingStatus defaultATEStatus;
		[Abstract]
		[Export ("defaultATEStatus", ArgumentSemantic.Assign)]
		FBSDKAdvertisingTrackingStatus DefaultATEStatus { get; }

		// @required @property (readonly, assign, nonatomic) BOOL advertiserIDCollectionEnabled;
		[Abstract]
		[Export ("advertiserIDCollectionEnabled")]
		bool AdvertiserIDCollectionEnabled { get; }

		// @required @property (readonly, assign, nonatomic) BOOL eventCollectionEnabled;
		[Abstract]
		[Export ("eventCollectionEnabled")]
		bool EventCollectionEnabled { get; }

		// @required @property (readonly, assign, nonatomic) UInt64 iapObservationTime;
		[Abstract]
		[Export ("iapObservationTime")]
		ulong IapObservationTime { get; }

		// @required @property (readonly, assign, nonatomic) UInt64 iapManualAndAutoLogDedupWindow;
		[Abstract]
		[Export ("iapManualAndAutoLogDedupWindow")]
		ulong IapManualAndAutoLogDedupWindow { get; }

		// @required @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSArray<NSString *> *> * _Nonnull iapProdDedupConfiguration;
		[Abstract]
		[Export ("iapProdDedupConfiguration", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSArray<NSString>> IapProdDedupConfiguration { get; }

		// @required @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSArray<NSString *> *> * _Nonnull iapTestDedupConfiguration;
		[Abstract]
		[Export ("iapTestDedupConfiguration", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSArray<NSString>> IapTestDedupConfiguration { get; }

		// @required -(instancetype _Nonnull)initWithJSON:(NSDictionary<NSString *,id> * _Nullable)dict;
		[Abstract]
		[Export ("initWithJSON:")]
		NativeHandle Constructor ([NullAllowed] NSDictionary<NSString, NSObject> dict);

		// @required +(instancetype _Nonnull)defaultConfiguration;
		[Static, Abstract]
		[Export ("defaultConfiguration")]
		FBSDKAppEventsConfiguration DefaultConfiguration ();
	}

	// @interface FBSDKAppEventsConfiguration : NSObject <NSCopying, NSObject, NSSecureCoding, FBSDKAppEventsConfiguration>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppEventsConfiguration : INSCopying, INSSecureCoding, IFBSDKAppEventsConfiguration
	{
		// @property (readonly, assign, nonatomic) FBSDKAdvertisingTrackingStatus defaultATEStatus;
		[Export ("defaultATEStatus", ArgumentSemantic.Assign)]
		FBSDKAdvertisingTrackingStatus DefaultATEStatus { get; }

		// @property (readonly, assign, nonatomic) BOOL advertiserIDCollectionEnabled;
		[Export ("advertiserIDCollectionEnabled")]
		bool AdvertiserIDCollectionEnabled { get; }

		// @property (readonly, assign, nonatomic) BOOL eventCollectionEnabled;
		[Export ("eventCollectionEnabled")]
		bool EventCollectionEnabled { get; }

		// @property (readonly, assign, nonatomic) UInt64 iapObservationTime;
		[Export ("iapObservationTime")]
		ulong IapObservationTime { get; }

		// @property (readonly, assign, nonatomic) UInt64 iapManualAndAutoLogDedupWindow;
		[Export ("iapManualAndAutoLogDedupWindow")]
		ulong IapManualAndAutoLogDedupWindow { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSArray<NSString *> *> * _Nonnull iapProdDedupConfiguration;
		[Export ("iapProdDedupConfiguration", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSArray<NSString>> IapProdDedupConfiguration { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSArray<NSString *> *> * _Nonnull iapTestDedupConfiguration;
		[Export ("iapTestDedupConfiguration", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSArray<NSString>> IapTestDedupConfiguration { get; }

		// -(instancetype _Nonnull)initWithJSON:(NSDictionary<NSString *,id> * _Nullable)dict;
		[Export ("initWithJSON:")]
		NativeHandle Constructor ([NullAllowed] NSDictionary<NSString, NSObject> dict);

		// +(instancetype _Nonnull)defaultConfiguration;
		[Static]
		[Export ("defaultConfiguration")]
		FBSDKAppEventsConfiguration DefaultConfiguration ();
	}

	// typedef void (^FBSDKAppEventsConfigurationProvidingBlock)();
	delegate void FBSDKAppEventsConfigurationProvidingBlock ();

	// @protocol FBSDKAppEventsConfigurationProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventsConfigurationProviding
	{
		// @required @property (readonly, nonatomic) id<FBSDKAppEventsConfiguration> _Nonnull cachedAppEventsConfiguration;
		[Abstract]
		[Export ("cachedAppEventsConfiguration")]
		FBSDKAppEventsConfiguration CachedAppEventsConfiguration { get; }

		// @required -(void)loadAppEventsConfigurationWithBlock:(FBSDKAppEventsConfigurationProvidingBlock _Nonnull)block;
		[Abstract]
		[Export ("loadAppEventsConfigurationWithBlock:")]
		void LoadAppEventsConfigurationWithBlock (FBSDKAppEventsConfigurationProvidingBlock block);
	}

	// typedef void (^FBSDKAppEventsConfigurationManagerBlock)();
	delegate void FBSDKAppEventsConfigurationManagerBlock ();

	// @interface FBSDKAppEventsConfigurationManager : NSObject <FBSDKAppEventsConfigurationProviding>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppEventsConfigurationManager : IFBSDKAppEventsConfigurationProviding
	{
		// @property (readonly, nonatomic, class) FBSDKAppEventsConfigurationManager * _Nonnull shared;
		[Static]
		[Export ("shared")]
		FBSDKAppEventsConfigurationManager Shared { get; }

		// @property (readonly, nonatomic) id<FBSDKAppEventsConfiguration> _Nonnull cachedAppEventsConfiguration;
		[Export ("cachedAppEventsConfiguration")]
		FBSDKAppEventsConfiguration CachedAppEventsConfiguration { get; }

		// -(void)configureWithStore:(id<FBSDKDataPersisting> _Nonnull)store settings:(id<FBSDKSettings> _Nonnull)settings graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)graphRequestConnectionFactory __attribute__((swift_name("configure(store:settings:graphRequestFactory:graphRequestConnectionFactory:)")));
		[Export ("configureWithStore:settings:graphRequestFactory:graphRequestConnectionFactory:")]
		void ConfigureWithStore (FBSDKDataPersisting store, FBSDKSettings settings, FBSDKGraphRequestFactory graphRequestFactory, FBSDKGraphRequestConnectionFactory graphRequestConnectionFactory);

		// -(void)loadAppEventsConfigurationWithBlock:(FBSDKAppEventsConfigurationManagerBlock _Nonnull)block;
		[Export ("loadAppEventsConfigurationWithBlock:")]
		void LoadAppEventsConfigurationWithBlock (FBSDKAppEventsConfigurationManagerBlock block);
	}

	// @protocol FBSDKDeviceInformationProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKDeviceInformationProviding
	{
		// @required @property (readonly, nonatomic) NSString * _Nonnull storageKey;
		[Abstract]
		[Export ("storageKey")]
		string StorageKey { get; }

		// @required @property (readonly, nonatomic) NSString * _Nullable encodedDeviceInfo;
		[Abstract]
		[NullAllowed, Export ("encodedDeviceInfo")]
		string EncodedDeviceInfo { get; }

		// @required @property (nonatomic) NSString * _Nullable carrierName;
		[Abstract]
		[NullAllowed, Export ("carrierName")]
		string CarrierName { get; set; }

		// @required @property (nonatomic) NSString * _Nullable timeZoneAbbrev;
		[Abstract]
		[NullAllowed, Export ("timeZoneAbbrev")]
		string TimeZoneAbbrev { get; set; }

		// @required @property (nonatomic) NSString * _Nullable timeZoneName;
		[Abstract]
		[NullAllowed, Export ("timeZoneName")]
		string TimeZoneName { get; set; }

		// @required @property (nonatomic) NSString * _Nullable bundleIdentifier;
		[Abstract]
		[NullAllowed, Export ("bundleIdentifier")]
		string BundleIdentifier { get; set; }

		// @required @property (nonatomic) NSString * _Nullable longVersion;
		[Abstract]
		[NullAllowed, Export ("longVersion")]
		string LongVersion { get; set; }

		// @required @property (nonatomic) NSString * _Nullable shortVersion;
		[Abstract]
		[NullAllowed, Export ("shortVersion")]
		string ShortVersion { get; set; }

		// @required @property (nonatomic) NSString * _Nullable sysVersion;
		[Abstract]
		[NullAllowed, Export ("sysVersion")]
		string SysVersion { get; set; }

		// @required @property (nonatomic) NSString * _Nullable machine;
		[Abstract]
		[NullAllowed, Export ("machine")]
		string Machine { get; set; }

		// @required @property (nonatomic) NSString * _Nullable language;
		[Abstract]
		[NullAllowed, Export ("language")]
		string Language { get; set; }

		// @required @property (nonatomic) unsigned long long coreCount;
		[Abstract]
		[Export ("coreCount")]
		ulong CoreCount { get; set; }

		// @required @property (nonatomic) CGFloat width;
		[Abstract]
		[Export ("width")]
		nfloat Width { get; set; }

		// @required @property (nonatomic) CGFloat height;
		[Abstract]
		[Export ("height")]
		nfloat Height { get; set; }

		// @required @property (nonatomic) CGFloat density;
		[Abstract]
		[Export ("density")]
		nfloat Density { get; set; }
	}

	// @interface FBSDKAppEventsDeviceInfo : NSObject <FBSDKDeviceInformationProviding>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppEventsDeviceInfo : IFBSDKDeviceInformationProviding
	{
		// @property (readonly, nonatomic, class) FBSDKAppEventsDeviceInfo * _Nonnull shared;
		[Static]
		[Export ("shared")]
		FBSDKAppEventsDeviceInfo Shared { get; }

		// @property (readonly, nonatomic) id<FBSDKSettings> _Nullable settings;
		[NullAllowed, Export ("settings")]
		FBSDKSettings Settings { get; }

		// @property (nonatomic) NSString * _Nonnull carrierName;
		[Export ("carrierName")]
		string CarrierName { get; set; }

		// @property (nonatomic) NSString * _Nonnull timeZoneAbbrev;
		[Export ("timeZoneAbbrev")]
		string TimeZoneAbbrev { get; set; }

		// @property (nonatomic) NSString * _Nonnull timeZoneName;
		[Export ("timeZoneName")]
		string TimeZoneName { get; set; }

		// @property (nonatomic) NSString * _Nonnull bundleIdentifier;
		[Export ("bundleIdentifier")]
		string BundleIdentifier { get; set; }

		// @property (nonatomic) NSString * _Nonnull longVersion;
		[Export ("longVersion")]
		string LongVersion { get; set; }

		// @property (nonatomic) NSString * _Nonnull shortVersion;
		[Export ("shortVersion")]
		string ShortVersion { get; set; }

		// @property (nonatomic) NSString * _Nonnull sysVersion;
		[Export ("sysVersion")]
		string SysVersion { get; set; }

		// @property (nonatomic) NSString * _Nonnull machine;
		[Export ("machine")]
		string Machine { get; set; }

		// @property (nonatomic) NSString * _Nonnull language;
		[Export ("language")]
		string Language { get; set; }

		// @property (nonatomic) unsigned long long coreCount;
		[Export ("coreCount")]
		ulong CoreCount { get; set; }

		// @property (nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; set; }

		// @property (nonatomic) CGFloat height;
		[Export ("height")]
		nfloat Height { get; set; }

		// @property (nonatomic) CGFloat density;
		[Export ("density")]
		nfloat Density { get; set; }

		// -(void)configureWithSettings:(id<FBSDKSettings> _Nonnull)settings __attribute__((swift_name("configure(settings:)")));
		[Export ("configureWithSettings:")]
		void ConfigureWithSettings (FBSDKSettings settings);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const NSNotificationName FBSDKAppEventsLoggingResultNotification __attribute__((swift_name("AppEventsLoggingResult")));
		[Field ("FBSDKAppEventsLoggingResultNotification", "__Internal")]
		NSString FBSDKAppEventsLoggingResultNotification { get; }
	}

	// @protocol FBSDKAppEventsParameterProcessing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventsParameterProcessing
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)processParameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters eventName:(FBSDKAppEventName _Nullable)eventName;
		[Abstract]
		[Export ("processParameters:eventName:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSObject> ProcessParameters ([NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] string eventName);
	}

	// @protocol FBSDKAppEventsReporter
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventsReporter
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(void)recordAndUpdateEvent:(NSString * _Nonnull)event currency:(NSString * _Nullable)currency value:(NSNumber * _Nullable)value parameters:(NSDictionary<NSString *,id> * _Nullable)parameters __attribute__((swift_name("recordAndUpdate(event:currency:value:parameters:)")));
		[Abstract]
		[Export ("recordAndUpdateEvent:currency:value:parameters:")]
		void RecordAndUpdateEvent (string @event, [NullAllowed] string currency, [NullAllowed] NSNumber value, [NullAllowed] NSDictionary<NSString, NSObject> parameters);
	}

	// @protocol FBSDKEventsProcessing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKEventsProcessing
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(void)processEvents:(NSMutableArray<NSDictionary<NSString *,id> *> * _Nonnull)events;
		[Abstract]
		[Export ("processEvents:")]
		void ProcessEvents (NSMutableArray<NSDictionary<NSString, NSObject>> events);
	}

	// @interface FBSDKAppEventsState : NSObject <NSCopying, NSSecureCoding>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppEventsState : INSCopying, INSSecureCoding
	{
		// @property (nonatomic, class) NSArray<id<FBSDKEventsProcessing>> * _Nullable eventProcessors;
		[Static]
		[NullAllowed, Export ("eventProcessors", ArgumentSemantic.Assign)]
		FBSDKEventsProcessing[] EventProcessors { get; set; }

		// @property (readonly, copy, nonatomic) NSArray<NSDictionary<NSString *,id> *> * _Nonnull events;
		[Export ("events", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject>[] Events { get; }

		// @property (readonly, assign, nonatomic) NSUInteger numSkipped;
		[Export ("numSkipped")]
		nuint NumSkipped { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull tokenString;
		[Export ("tokenString")]
		string TokenString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appID;
		[Export ("appID")]
		string AppID { get; }

		// @property (readonly, getter = areAllEventsImplicit, nonatomic) BOOL allEventsImplicit;
		[Export ("allEventsImplicit")]
		bool AllEventsImplicit { [Bind ("areAllEventsImplicit")] get; }

		// -(instancetype _Nonnull)initWithToken:(NSString * _Nullable)tokenString appID:(NSString * _Nullable)appID __attribute__((objc_designated_initializer));
		[Export ("initWithToken:appID:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string tokenString, [NullAllowed] string appID);

		// -(void)addEvent:(NSDictionary<NSString *,id> * _Nonnull)eventDictionary isImplicit:(BOOL)isImplicit withOperationalParameters:(NSDictionary<FBSDKAppOperationalDataType,NSDictionary<NSString *,id> *> * _Nullable)operationalParameters;
		[Export ("addEvent:isImplicit:withOperationalParameters:")]
		void AddEvent (NSDictionary<NSString, NSObject> eventDictionary, bool isImplicit, [NullAllowed] NSDictionary<NSString, NSDictionary<NSString, NSObject>> operationalParameters);

		// -(void)addEventsFromAppEventState:(FBSDKAppEventsState * _Nonnull)appEventsState;
		[Export ("addEventsFromAppEventState:")]
		void AddEventsFromAppEventState (FBSDKAppEventsState appEventsState);

		// -(BOOL)isCompatibleWithAppEventsState:(FBSDKAppEventsState * _Nullable)appEventsState;
		[Export ("isCompatibleWithAppEventsState:")]
		bool IsCompatibleWithAppEventsState ([NullAllowed] FBSDKAppEventsState appEventsState);

		// -(BOOL)isCompatibleWithTokenString:(NSString * _Nonnull)tokenString appID:(NSString * _Nonnull)appID;
		[Export ("isCompatibleWithTokenString:appID:")]
		bool IsCompatibleWithTokenString (string tokenString, string appID);

		// -(NSDictionary<NSString *,NSString *> * _Nonnull)JSONStringForEventsAndOperationalParametersIncludingImplicitEvents:(BOOL)includeImplicitEvents;
		[Export ("JSONStringForEventsAndOperationalParametersIncludingImplicitEvents:")]
		NSDictionary<NSString, NSString> JSONStringForEventsAndOperationalParametersIncludingImplicitEvents (bool includeImplicitEvents);

		// -(NSString * _Nonnull)extractReceiptData;
		[Export ("extractReceiptData")]
		[Verify (MethodToProperty)]
		string ExtractReceiptData { get; }
	}

	// @protocol FBSDKAppEventsStatePersisting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventsStatePersisting
	{
		// @required -(void)clearPersistedAppEventsStates;
		[Abstract]
		[Export ("clearPersistedAppEventsStates")]
		void ClearPersistedAppEventsStates ();

		// @required -(void)persistAppEventsData:(FBSDKAppEventsState * _Nonnull)appEventsState;
		[Abstract]
		[Export ("persistAppEventsData:")]
		void PersistAppEventsData (FBSDKAppEventsState appEventsState);

		// @required -(NSArray<id> * _Nonnull)retrievePersistedAppEventsStates;
		[Abstract]
		[Export ("retrievePersistedAppEventsStates")]
		[Verify (MethodToProperty)]
		NSObject[] RetrievePersistedAppEventsStates { get; }
	}

	// @interface FBSDKAppEventsStateManager : NSObject <FBSDKAppEventsStatePersisting>
	[BaseType (typeof(NSObject))]
	interface FBSDKAppEventsStateManager : IFBSDKAppEventsStatePersisting
	{
		// @property (readonly, nonatomic, class) FBSDKAppEventsStateManager * _Nonnull shared;
		[Static]
		[Export ("shared")]
		FBSDKAppEventsStateManager Shared { get; }

		// -(void)clearPersistedAppEventsStates;
		[Export ("clearPersistedAppEventsStates")]
		void ClearPersistedAppEventsStates ();

		// -(void)persistAppEventsData:(FBSDKAppEventsState * _Nonnull)appEventsState;
		[Export ("persistAppEventsData:")]
		void PersistAppEventsData (FBSDKAppEventsState appEventsState);

		// -(NSArray<FBSDKAppEventsState *> * _Nonnull)retrievePersistedAppEventsStates;
		[Export ("retrievePersistedAppEventsStates")]
		[Verify (MethodToProperty)]
		FBSDKAppEventsState[] RetrievePersistedAppEventsStates { get; }
	}

	// @protocol FBSDKAppEventsStateProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventsStateProviding
	{
		// @required -(FBSDKAppEventsState * _Nonnull)createStateWithToken:(NSString * _Nonnull)tokenString appID:(NSString * _Nonnull)appID __attribute__((swift_name("createState(tokenString:appID:)")));
		[Abstract]
		[Export ("createStateWithToken:appID:")]
		FBSDKAppEventsState AppID (string tokenString, string appID);
	}

	// @protocol FBSDKAppEventParametersExtracting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventParametersExtracting
	{
		// @required -(NSMutableDictionary<NSString *,NSString *> * _Nonnull)activityParametersDictionaryForEvent:(NSString * _Nonnull)eventCategory shouldAccessAdvertisingID:(BOOL)shouldAccessAdvertisingID userID:(NSString * _Nullable)userID userData:(NSString * _Nullable)userData;
		[Abstract]
		[Export ("activityParametersDictionaryForEvent:shouldAccessAdvertisingID:userID:userData:")]
		NSMutableDictionary<NSString, NSString> ShouldAccessAdvertisingID (string eventCategory, bool shouldAccessAdvertisingID, [NullAllowed] string userID, [NullAllowed] string userData);
	}

	// @protocol FBSDKAppEventsUtility
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppEventsUtility
	{
		// @required @property (readonly, nonatomic) NSTimeInterval unixTimeNow;
		[Abstract]
		[Export ("unixTimeNow")]
		double UnixTimeNow { get; }

		// @required -(void)ensureOnMainThread:(NSString * _Nonnull)methodName className:(NSString * _Nonnull)className;
		[Abstract]
		[Export ("ensureOnMainThread:className:")]
		void EnsureOnMainThread (string methodName, string className);

		// @required -(NSTimeInterval)convertToUnixTime:(NSDate * _Nullable)date;
		[Abstract]
		[Export ("convertToUnixTime:")]
		double ConvertToUnixTime ([NullAllowed] NSDate date);

		// @required -(BOOL)validateIdentifier:(NSString * _Nullable)identifier;
		[Abstract]
		[Export ("validateIdentifier:")]
		bool ValidateIdentifier ([NullAllowed] string identifier);

		// @required -(NSString * _Nullable)tokenStringToUseFor:(FBSDKAccessToken * _Nullable)token loggingOverrideAppID:(NSString * _Nullable)loggingOverrideAppID;
		[Abstract]
		[Export ("tokenStringToUseFor:loggingOverrideAppID:")]
		[return: NullAllowed]
		string TokenStringToUseFor ([NullAllowed] FBSDKAccessToken token, [NullAllowed] string loggingOverrideAppID);

		// @required -(NSString * _Nonnull)flushReasonToString:(FBSDKAppEventsFlushReason)flushReason;
		[Abstract]
		[Export ("flushReasonToString:")]
		string FlushReasonToString (FBSDKAppEventsFlushReason flushReason);

		// @required -(void)saveCampaignIDs:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("saveCampaignIDs:")]
		void SaveCampaignIDs (NSURL url);

		// @required -(NSString * _Nullable)getCampaignIDs;
		[Abstract]
		[NullAllowed, Export ("getCampaignIDs")]
		[Verify (MethodToProperty)]
		string CampaignIDs { get; }
	}

	// @protocol FBSDKLoggingNotifying
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKLoggingNotifying
	{
		// @required -(void)logAndNotify:(NSString * _Nonnull)message;
		[Abstract]
		[Export ("logAndNotify:")]
		void LogAndNotify (string message);

		// @required -(void)logAndNotify:(NSString * _Nonnull)message allowLogAsDeveloperError:(BOOL)allowLogAsDeveloperError;
		[Abstract]
		[Export ("logAndNotify:allowLogAsDeveloperError:")]
		void AllowLogAsDeveloperError (string message, bool allowLogAsDeveloperError);
	}

	// @interface FBSDKAppEventsUtility : NSObject <FBSDKAdvertiserIDProviding, FBSDKAppEventDropDetermining, FBSDKAppEventParametersExtracting, FBSDKAppEventsUtility, FBSDKLoggingNotifying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppEventsUtility : IFBSDKAdvertiserIDProviding, IFBSDKAppEventDropDetermining, IFBSDKAppEventParametersExtracting, IFBSDKAppEventsUtility, IFBSDKLoggingNotifying
	{
		// @property (nonatomic, class) FBSDKAppEventsUtility * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Assign)]
		FBSDKAppEventsUtility Shared { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable advertiserID;
		[NullAllowed, Export ("advertiserID")]
		string AdvertiserID { get; }

		// @property (readonly, nonatomic) BOOL isDebugBuild;
		[Export ("isDebugBuild")]
		bool IsDebugBuild { get; }

		// @property (readonly, nonatomic) BOOL shouldDropAppEvents;
		[Export ("shouldDropAppEvents")]
		bool ShouldDropAppEvents { get; }

		// @property (nonatomic) id<FBSDKAppEventsConfigurationProviding> _Nullable appEventsConfigurationProvider;
		[NullAllowed, Export ("appEventsConfigurationProvider", ArgumentSemantic.Assign)]
		FBSDKAppEventsConfigurationProviding AppEventsConfigurationProvider { get; set; }

		// @property (nonatomic) id<FBSDKDeviceInformationProviding> _Nullable deviceInformationProvider;
		[NullAllowed, Export ("deviceInformationProvider", ArgumentSemantic.Assign)]
		FBSDKDeviceInformationProviding DeviceInformationProvider { get; set; }

		// @property (nonatomic) id<FBSDKSettings> _Nullable settings;
		[NullAllowed, Export ("settings", ArgumentSemantic.Assign)]
		FBSDKSettings Settings { get; set; }

		// @property (nonatomic) id<FBSDKInternalUtility> _Nullable internalUtility;
		[NullAllowed, Export ("internalUtility", ArgumentSemantic.Assign)]
		FBSDKInternalUtility InternalUtility { get; set; }

		// @property (nonatomic) id<FBSDKErrorCreating> _Nullable errorFactory;
		[NullAllowed, Export ("errorFactory", ArgumentSemantic.Assign)]
		FBSDKErrorCreating ErrorFactory { get; set; }

		// @property (nonatomic) id<FBSDKDataPersisting> _Nullable dataStore;
		[NullAllowed, Export ("dataStore", ArgumentSemantic.Assign)]
		FBSDKDataPersisting DataStore { get; set; }

		// -(BOOL)isSensitiveUserData:(NSString * _Nonnull)text;
		[Export ("isSensitiveUserData:")]
		bool IsSensitiveUserData (string text);

		// -(BOOL)isStandardEvent:(NSString * _Nullable)event;
		[Export ("isStandardEvent:")]
		bool IsStandardEvent ([NullAllowed] string @event);

		// -(void)configureWithAppEventsConfigurationProvider:(id<FBSDKAppEventsConfigurationProviding> _Nonnull)appEventsConfigurationProvider deviceInformationProvider:(id<FBSDKDeviceInformationProviding> _Nonnull)deviceInformationProvider settings:(id<FBSDKSettings> _Nonnull)settings internalUtility:(id<FBSDKInternalUtility> _Nonnull)internalUtility errorFactory:(id<FBSDKErrorCreating> _Nonnull)errorFactory dataStore:(id<FBSDKDataPersisting> _Nonnull)dataStore __attribute__((swift_name("configure(appEventsConfigurationProvider:deviceInformationProvider:settings:internalUtility:errorFactory:dataStore:)")));
		[Export ("configureWithAppEventsConfigurationProvider:deviceInformationProvider:settings:internalUtility:errorFactory:dataStore:")]
		void ConfigureWithAppEventsConfigurationProvider (FBSDKAppEventsConfigurationProviding appEventsConfigurationProvider, FBSDKDeviceInformationProviding deviceInformationProvider, FBSDKSettings settings, FBSDKInternalUtility internalUtility, FBSDKErrorCreating errorFactory, FBSDKDataPersisting dataStore);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const NSNotificationName FBSDKApplicationDidBecomeActiveNotification;
		[Field ("FBSDKApplicationDidBecomeActiveNotification", "__Internal")]
		NSString FBSDKApplicationDidBecomeActiveNotification { get; }
	}

	// @protocol FBSDKApplicationObserving
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKApplicationObserving
	{
		// @optional -(void)applicationDidBecomeActive:(UIApplication * _Nullable)application;
		[Export ("applicationDidBecomeActive:")]
		void ApplicationDidBecomeActive ([NullAllowed] UIApplication application);

		// @optional -(void)applicationWillResignActive:(UIApplication * _Nullable)application;
		[Export ("applicationWillResignActive:")]
		void ApplicationWillResignActive ([NullAllowed] UIApplication application);

		// @optional -(void)applicationDidEnterBackground:(UIApplication * _Nullable)application;
		[Export ("applicationDidEnterBackground:")]
		void ApplicationDidEnterBackground ([NullAllowed] UIApplication application);

		// @optional -(BOOL)application:(UIApplication * _Nonnull)application didFinishLaunchingWithOptions:(NSDictionary<UIApplicationLaunchOptionsKey,id> * _Nullable)launchOptions;
		[Export ("application:didFinishLaunchingWithOptions:")]
		bool Application (UIApplication application, [NullAllowed] NSDictionary<NSString, NSObject> launchOptions);

		// @optional -(BOOL)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation;
		[Export ("application:openURL:sourceApplication:annotation:")]
		bool Application (UIApplication application, NSURL url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);
	}

	// @protocol FBSDKAppLinkCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppLinkCreating
	{
		// @required -(id<FBSDKAppLink> _Nonnull)createAppLinkWithSourceURL:(NSURL * _Nullable)sourceURL targets:(NSArray<id<FBSDKAppLinkTarget>> * _Nonnull)targets webURL:(NSURL * _Nullable)webURL isBackToReferrer:(BOOL)isBackToReferrer __attribute__((swift_name("createAppLink(sourceURL:targets:webURL:isBackToReferrer:)")));
		[Abstract]
		[Export ("createAppLinkWithSourceURL:targets:webURL:isBackToReferrer:")]
		FBSDKAppLink Targets ([NullAllowed] NSURL sourceURL, FBSDKAppLinkTarget[] targets, [NullAllowed] NSURL webURL, bool isBackToReferrer);
	}

	// @protocol FBSDKAppLinkEventPosting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppLinkEventPosting
	{
		// @required -(void)postNotificationForEventName:(NSString * _Nonnull)name args:(NSDictionary<NSString *,id> * _Nonnull)args __attribute__((swift_name("postNotification(eventName:arguments:)")));
		[Abstract]
		[Export ("postNotificationForEventName:args:")]
		void Args (string name, NSDictionary<NSString, NSObject> args);
	}

	// typedef void (^FBSDKAppLinkNavigationBlock)(FBSDKAppLinkNavigationType, NSError * _Nullable);
	delegate void FBSDKAppLinkNavigationBlock (FBSDKAppLinkNavigationType arg0, [NullAllowed] NSError arg1);

	// @protocol FBSDKAppLink
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppLink
	{
		// @required @property (readonly, nonatomic, strong) NSURL * _Nullable sourceURL;
		[Abstract]
		[NullAllowed, Export ("sourceURL", ArgumentSemantic.Strong)]
		NSURL SourceURL { get; }

		// @required @property (readonly, copy, nonatomic) NSArray<id<FBSDKAppLinkTarget>> * _Nonnull targets;
		[Abstract]
		[Export ("targets", ArgumentSemantic.Copy)]
		FBSDKAppLinkTarget[] Targets { get; }

		// @required @property (readonly, nonatomic, strong) NSURL * _Nullable webURL;
		[Abstract]
		[NullAllowed, Export ("webURL", ArgumentSemantic.Strong)]
		NSURL WebURL { get; }

		// @required @property (readonly, getter = isBackToReferrer, assign, nonatomic) BOOL backToReferrer;
		[Abstract]
		[Export ("backToReferrer")]
		bool BackToReferrer { [Bind ("isBackToReferrer")] get; }
	}

	// @protocol FBSDKAppLinkResolverRequestBuilding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppLinkResolverRequestBuilding
	{
		// @required -(id<FBSDKGraphRequest> _Nonnull)requestForURLs:(NSArray<NSURL *> * _Nonnull)urls;
		[Abstract]
		[Export ("requestForURLs:")]
		FBSDKGraphRequest RequestForURLs (NSURL[] urls);

		// @required -(NSString * _Nullable)getIdiomSpecificField;
		[Abstract]
		[NullAllowed, Export ("getIdiomSpecificField")]
		[Verify (MethodToProperty)]
		string IdiomSpecificField { get; }
	}

	// typedef void (^FBSDKAppLinkBlock)(FBSDKAppLink * _Nullable, NSError * _Nullable);
	delegate void FBSDKAppLinkBlock ([NullAllowed] FBSDKAppLink arg0, [NullAllowed] NSError arg1);

	// @protocol FBSDKAppLinkResolving <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKAppLinkResolving
	{
		// @required -(void)appLinkFromURL:(NSURL * _Nonnull)url handler:(FBSDKAppLinkBlock _Nonnull)handler __attribute__((availability(ios_app_extension, unavailable)));
		[Unavailable (PlatformName.iOSAppExtension)]
		[Abstract]
		[Export ("appLinkFromURL:handler:")]
		void Handler (NSURL url, FBSDKAppLinkBlock handler);
	}

	// typedef void (^FBSDKAppLinksBlock)(NSDictionary<NSURL *,FBSDKAppLink *> * _Nonnull, NSError * _Nullable);
	delegate void FBSDKAppLinksBlock (NSDictionary<NSURL, FBSDKAppLink> arg0, [NullAllowed] NSError arg1);

	// @protocol FBSDKAppLinkTarget
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppLinkTarget
	{
		// @required +(instancetype _Nonnull)appLinkTargetWithURL:(NSURL * _Nullable)url appStoreId:(NSString * _Nullable)appStoreId appName:(NSString * _Nonnull)appName __attribute__((swift_name("init(url:appStoreId:appName:)")));
		[Static, Abstract]
		[Export ("appLinkTargetWithURL:appStoreId:appName:")]
		FBSDKAppLinkTarget AppStoreId ([NullAllowed] NSURL url, [NullAllowed] string appStoreId, string appName);

		// @required @property (readonly, nonatomic) NSURL * _Nullable URL;
		[Abstract]
		[NullAllowed, Export ("URL")]
		NSURL URL { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable appStoreId;
		[Abstract]
		[NullAllowed, Export ("appStoreId")]
		string AppStoreId { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull appName;
		[Abstract]
		[Export ("appName")]
		string AppName { get; }
	}

	// @protocol FBSDKAppLinkTargetCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppLinkTargetCreating
	{
		// @required -(id<FBSDKAppLinkTarget> _Nonnull)createAppLinkTargetWithURL:(NSURL * _Nullable)url appStoreId:(NSString * _Nullable)appStoreId appName:(NSString * _Nonnull)appName __attribute__((swift_name("createAppLinkTarget(url:appStoreId:appName:)")));
		[Abstract]
		[Export ("createAppLinkTargetWithURL:appStoreId:appName:")]
		FBSDKAppLinkTarget AppStoreId ([NullAllowed] NSURL url, [NullAllowed] string appStoreId, string appName);
	}

	// @protocol FBSDKAppLinkURL
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppLinkURL
	{
		// @required @property (readonly, nonatomic, strong) NSDictionary<NSString *,id> * _Nullable appLinkExtras;
		[Abstract]
		[NullAllowed, Export ("appLinkExtras", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSObject> AppLinkExtras { get; }
	}

	// @protocol FBSDKAppLinkURLCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppLinkURLCreating
	{
		// @required -(id<FBSDKAppLinkURL> _Nonnull)createAppLinkURLWithURL:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("createAppLinkURLWithURL:")]
		FBSDKAppLinkURL CreateAppLinkURLWithURL (NSURL url);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull FBSDKAppLinkDataParameterName;
		[Field ("FBSDKAppLinkDataParameterName", "__Internal")]
		NSString FBSDKAppLinkDataParameterName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkTargetKeyName;
		[Field ("FBSDKAppLinkTargetKeyName", "__Internal")]
		NSString FBSDKAppLinkTargetKeyName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkUserAgentKeyName;
		[Field ("FBSDKAppLinkUserAgentKeyName", "__Internal")]
		NSString FBSDKAppLinkUserAgentKeyName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkExtrasKeyName;
		[Field ("FBSDKAppLinkExtrasKeyName", "__Internal")]
		NSString FBSDKAppLinkExtrasKeyName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkVersionKeyName;
		[Field ("FBSDKAppLinkVersionKeyName", "__Internal")]
		NSString FBSDKAppLinkVersionKeyName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkRefererAppLink;
		[Field ("FBSDKAppLinkRefererAppLink", "__Internal")]
		NSString FBSDKAppLinkRefererAppLink { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkRefererAppName;
		[Field ("FBSDKAppLinkRefererAppName", "__Internal")]
		NSString FBSDKAppLinkRefererAppName { get; }

		// extern NSString *const _Nonnull FBSDKAppLinkRefererUrl;
		[Field ("FBSDKAppLinkRefererUrl", "__Internal")]
		NSString FBSDKAppLinkRefererUrl { get; }
	}

	// typedef void (^FBSDKURLBlock)(NSURL * _Nullable, NSError * _Nullable);
	delegate void FBSDKURLBlock ([NullAllowed] NSURL arg0, [NullAllowed] NSError arg1);

	// @interface FBSDKAppLinkUtility : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAppLinkUtility
	{
		// +(void)fetchDeferredAppLink:(FBSDKURLBlock _Nullable)handler;
		[Static]
		[Export ("fetchDeferredAppLink:")]
		void FetchDeferredAppLink ([NullAllowed] FBSDKURLBlock handler);

		// +(NSString * _Nullable)appInvitePromotionCodeFromURL:(NSURL * _Nonnull)url;
		[Static]
		[Export ("appInvitePromotionCodeFromURL:")]
		[return: NullAllowed]
		string AppInvitePromotionCodeFromURL (NSURL url);

		// +(BOOL)isMatchURLScheme:(NSString * _Nonnull)scheme;
		[Static]
		[Export ("isMatchURLScheme:")]
		bool IsMatchURLScheme (string scheme);

		// +(void)configureWithGraphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory infoDictionaryProvider:(id<FBSDKInfoDictionaryProviding> _Nonnull)infoDictionaryProvider settings:(id<FBSDKSettings> _Nonnull)settings appEventsConfigurationProvider:(id<FBSDKAppEventsConfigurationProviding> _Nonnull)appEventsConfigurationProvider advertiserIDProvider:(id<FBSDKAdvertiserIDProviding> _Nonnull)advertiserIDProvider appEventsDropDeterminer:(id<FBSDKAppEventDropDetermining> _Nonnull)appEventsDropDeterminer appEventParametersExtractor:(id<FBSDKAppEventParametersExtracting> _Nonnull)appEventParametersExtractor appLinkURLFactory:(id<FBSDKAppLinkURLCreating> _Nonnull)appLinkURLFactory userIDProvider:(id<FBSDKUserIDProviding> _Nonnull)userIDProvider userDataStore:(id<FBSDKUserDataPersisting> _Nonnull)userDataStore __attribute__((swift_name("configure(graphRequestFactory:infoDictionaryProvider:settings:appEventsConfigurationProvider:advertiserIDProvider:appEventsDropDeterminer:appEventParametersExtractor:appLinkURLFactory:userIDProvider:userDataStore:)")));
		[Static]
		[Export ("configureWithGraphRequestFactory:infoDictionaryProvider:settings:appEventsConfigurationProvider:advertiserIDProvider:appEventsDropDeterminer:appEventParametersExtractor:appLinkURLFactory:userIDProvider:userDataStore:")]
		void ConfigureWithGraphRequestFactory (FBSDKGraphRequestFactory graphRequestFactory, FBSDKInfoDictionaryProviding infoDictionaryProvider, FBSDKSettings settings, FBSDKAppEventsConfigurationProviding appEventsConfigurationProvider, FBSDKAdvertiserIDProviding advertiserIDProvider, FBSDKAppEventDropDetermining appEventsDropDeterminer, FBSDKAppEventParametersExtracting appEventParametersExtractor, FBSDKAppLinkURLCreating appLinkURLFactory, FBSDKUserIDProviding userIDProvider, FBSDKUserDataPersisting userDataStore);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const FBSDKAppLinkVersion __attribute__((swift_name("AppLinkVersion")));
		[Field ("FBSDKAppLinkVersion", "__Internal")]
		NSString FBSDKAppLinkVersion { get; }
	}

	// @protocol FBSDKAppStoreReceiptProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppStoreReceiptProviding
	{
		// @required @property (readonly, copy) NSURL * _Nullable appStoreReceiptURL;
		[Abstract]
		[NullAllowed, Export ("appStoreReceiptURL", ArgumentSemantic.Copy)]
		NSURL AppStoreReceiptURL { get; }
	}

	// @interface  (NSBundle) <FBSDKAppStoreReceiptProviding>
	[Category]
	[BaseType (typeof(NSBundle))]
	interface NSBundle_ : IFBSDKAppStoreReceiptProviding
	{
	}

	// @protocol FBSDKAppURLSchemeProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAppURLSchemeProviding
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull appURLScheme;
		[Abstract]
		[Export ("appURLScheme")]
		string AppURLScheme { get; }

		// @required -(void)validateURLSchemes;
		[Abstract]
		[Export ("validateURLSchemes")]
		void ValidateURLSchemes ();
	}

	// @protocol FBSDKATEPublisherCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKATEPublisherCreating
	{
		// @required -(id<FBSDKATEPublishing> _Nullable)createPublisherWithAppID:(NSString * _Nonnull)appID __attribute__((swift_name("createPublisher(appID:)")));
		[Abstract]
		[Export ("createPublisherWithAppID:")]
		[return: NullAllowed]
		FBSDKATEPublishing CreatePublisherWithAppID (string appID);
	}

	// @interface FBSDKATEPublisherFactory : NSObject <FBSDKATEPublisherCreating>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKATEPublisherFactory : IFBSDKATEPublisherCreating
	{
		// @property (nonatomic) id<FBSDKDataPersisting> _Nonnull dataStore;
		[Export ("dataStore", ArgumentSemantic.Assign)]
		FBSDKDataPersisting DataStore { get; set; }

		// @property (nonatomic) id<FBSDKGraphRequestFactory> _Nonnull graphRequestFactory;
		[Export ("graphRequestFactory", ArgumentSemantic.Assign)]
		FBSDKGraphRequestFactory GraphRequestFactory { get; set; }

		// @property (nonatomic) id<FBSDKSettings> _Nonnull settings;
		[Export ("settings", ArgumentSemantic.Assign)]
		FBSDKSettings Settings { get; set; }

		// @property (nonatomic) id<FBSDKDeviceInformationProviding> _Nonnull deviceInformationProvider;
		[Export ("deviceInformationProvider", ArgumentSemantic.Assign)]
		FBSDKDeviceInformationProviding DeviceInformationProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataStore:(id<FBSDKDataPersisting> _Nonnull)dataStore graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory settings:(id<FBSDKSettings> _Nonnull)settings deviceInformationProvider:(id<FBSDKDeviceInformationProviding> _Nonnull)deviceInformationProvider;
		[Export ("initWithDataStore:graphRequestFactory:settings:deviceInformationProvider:")]
		NativeHandle Constructor (FBSDKDataPersisting dataStore, FBSDKGraphRequestFactory graphRequestFactory, FBSDKSettings settings, FBSDKDeviceInformationProviding deviceInformationProvider);
	}

	// @protocol FBSDKAuthenticationTokenProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKAuthenticationTokenProviding
	{
		// @required @property (copy, nonatomic, class) NS_SWIFT_NAME(current) FBSDKAuthenticationToken * currentAuthenticationToken __attribute__((swift_name("current")));
		[Static, Abstract]
		[Export ("currentAuthenticationToken", ArgumentSemantic.Copy)]
		FBSDKAuthenticationToken CurrentAuthenticationToken { get; set; }

		// @required @property (copy, nonatomic, class) id<FBSDKTokenCaching> _Nullable tokenCache;
		[Static, Abstract]
		[NullAllowed, Export ("tokenCache", ArgumentSemantic.Copy)]
		FBSDKTokenCaching TokenCache { get; set; }
	}

	// @interface FBSDKAuthenticationStatusUtility : NSObject
	[BaseType (typeof(NSObject))]
	interface FBSDKAuthenticationStatusUtility
	{
		// @property (nonatomic, class) Class<FBSDKProfileProviding> _Nullable profileSetter;
		[Static]
		[NullAllowed, Export ("profileSetter", ArgumentSemantic.Assign)]
		FBSDKProfileProviding ProfileSetter { get; set; }

		// @property (nonatomic, class) id _Nullable sessionDataTaskProvider;
		[Static]
		[NullAllowed, Export ("sessionDataTaskProvider", ArgumentSemantic.Assign)]
		NSObject SessionDataTaskProvider { get; set; }

		// @property (nonatomic, class) Class<FBSDKAccessTokenProviding> _Nullable accessTokenWallet;
		[Static]
		[NullAllowed, Export ("accessTokenWallet", ArgumentSemantic.Assign)]
		FBSDKAccessTokenProviding AccessTokenWallet { get; set; }

		// @property (nonatomic, class) Class<FBSDKAuthenticationTokenProviding> _Nullable authenticationTokenWallet;
		[Static]
		[NullAllowed, Export ("authenticationTokenWallet", ArgumentSemantic.Assign)]
		FBSDKAuthenticationTokenProviding AuthenticationTokenWallet { get; set; }

		// +(void)configureWithProfileSetter:(Class<FBSDKProfileProviding> _Nonnull)profileSetter sessionDataTaskProvider:(id _Nonnull)sessionDataTaskProvider accessTokenWallet:(Class<FBSDKAccessTokenProviding> _Nonnull)accessTokenWallet authenticationTokenWallet:(Class<FBSDKAuthenticationTokenProviding> _Nonnull)authenticationWallet __attribute__((swift_name("configure(profileSetter:sessionDataTaskProvider:accessTokenWallet:authenticationTokenWallet:)")));
		[Static]
		[Export ("configureWithProfileSetter:sessionDataTaskProvider:accessTokenWallet:authenticationTokenWallet:")]
		void ConfigureWithProfileSetter (FBSDKProfileProviding profileSetter, NSObject sessionDataTaskProvider, FBSDKAccessTokenProviding accessTokenWallet, FBSDKAuthenticationTokenProviding authenticationWallet);

		// +(void)checkAuthenticationStatus;
		[Static]
		[Export ("checkAuthenticationStatus")]
		void CheckAuthenticationStatus ();
	}

	// @interface FBSDKAuthenticationToken : NSObject <NSCopying, NSObject, NSSecureCoding, FBSDKAuthenticationTokenProviding>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKAuthenticationToken : INSCopying, INSSecureCoding, IFBSDKAuthenticationTokenProviding
	{
		// -(instancetype _Nonnull)initWithTokenString:(NSString * _Nonnull)tokenString nonce:(NSString * _Nonnull)nonce graphDomain:(NSString * _Nonnull)graphDomain;
		[Export ("initWithTokenString:nonce:graphDomain:")]
		NativeHandle Constructor (string tokenString, string nonce, string graphDomain);

		// @property (copy, nonatomic, class) NS_SWIFT_NAME(current) FBSDKAuthenticationToken * currentAuthenticationToken __attribute__((swift_name("current")));
		[Static]
		[Export ("currentAuthenticationToken", ArgumentSemantic.Copy)]
		FBSDKAuthenticationToken CurrentAuthenticationToken { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull tokenString;
		[Export ("tokenString")]
		string TokenString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull nonce;
		[Export ("nonce")]
		string Nonce { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull graphDomain;
		[Export ("graphDomain")]
		string GraphDomain { get; }

		// -(FBSDKAuthenticationTokenClaims * _Nullable)claims;
		[NullAllowed, Export ("claims")]
		[Verify (MethodToProperty)]
		FBSDKAuthenticationTokenClaims Claims { get; }

		// @property (copy, nonatomic, class) id<FBSDKTokenCaching> _Nullable tokenCache;
		[Static]
		[NullAllowed, Export ("tokenCache", ArgumentSemantic.Copy)]
		FBSDKTokenCaching TokenCache { get; set; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull FBSDKBridgeAPIAppIDKey;
		[Field ("FBSDKBridgeAPIAppIDKey", "__Internal")]
		NSString FBSDKBridgeAPIAppIDKey { get; }

		// extern NSString *const _Nonnull FBSDKBridgeAPISchemeSuffixKey;
		[Field ("FBSDKBridgeAPISchemeSuffixKey", "__Internal")]
		NSString FBSDKBridgeAPISchemeSuffixKey { get; }

		// extern NSString *const _Nonnull FBSDKBridgeAPIVersionKey;
		[Field ("FBSDKBridgeAPIVersionKey", "__Internal")]
		NSString FBSDKBridgeAPIVersionKey { get; }
	}

	// @protocol FBSDKBridgeAPIProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKBridgeAPIProtocol
	{
		// @required -(NSURL * _Nullable)requestURLWithActionID:(NSString * _Nonnull)actionID scheme:(NSString * _Nonnull)scheme methodName:(NSString * _Nonnull)methodName parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters error:(NSError * _Nullable * _Nullable)errorRef __attribute__((swift_name("requestURL(actionID:scheme:methodName:parameters:)")));
		[Abstract]
		[Export ("requestURLWithActionID:scheme:methodName:parameters:error:")]
		[return: NullAllowed]
		NSURL RequestURLWithActionID (string actionID, string scheme, string methodName, NSDictionary<NSString, NSObject> parameters, [NullAllowed] out NSError errorRef);

		// @required -(NSDictionary<NSString *,id> * _Nullable)responseParametersForActionID:(NSString * _Nonnull)actionID queryParameters:(NSDictionary<NSString *,id> * _Nonnull)queryParameters cancelled:(BOOL * _Nullable)cancelledRef error:(NSError * _Nullable * _Nullable)errorRef __attribute__((swift_name("responseParameters(actionID:queryParameters:cancelled:)")));
		[Abstract]
		[Export ("responseParametersForActionID:queryParameters:cancelled:error:")]
		[return: NullAllowed]
		unsafe NSDictionary<NSString, NSObject> ResponseParametersForActionID (string actionID, NSDictionary<NSString, NSObject> queryParameters, [NullAllowed] bool* cancelledRef, [NullAllowed] out NSError errorRef);
	}

	// @protocol FBSDKBridgeAPIRequest <NSObject, NSCopying>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKBridgeAPIRequest : INSCopying
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull scheme;
		[Abstract]
		[Export ("scheme")]
		string Scheme { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull actionID;
		[Abstract]
		[Export ("actionID")]
		string ActionID { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable methodName;
		[Abstract]
		[NullAllowed, Export ("methodName")]
		string MethodName { get; }

		// @required @property (readonly, assign, nonatomic) FBSDKBridgeAPIProtocolType protocolType;
		[Abstract]
		[Export ("protocolType", ArgumentSemantic.Assign)]
		FBSDKBridgeAPIProtocolType ProtocolType { get; }

		// @required @property (readonly, nonatomic, strong) id<FBSDKBridgeAPIProtocol> _Nullable protocol;
		[Abstract]
		[NullAllowed, Export ("protocol", ArgumentSemantic.Strong)]
		FBSDKBridgeAPIProtocol Protocol { get; }

		// @required -(NSURL * _Nullable)requestURL:(NSError * _Nullable * _Nullable)errorRef;
		[Abstract]
		[Export ("requestURL:")]
		[return: NullAllowed]
		NSURL RequestURL ([NullAllowed] out NSError errorRef);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const FBSDKURLScheme FBSDKURLSchemeFacebookAPI __attribute__((swift_name("facebookAPI")));
		[Field ("FBSDKURLSchemeFacebookAPI", "__Internal")]
		NSString FBSDKURLSchemeFacebookAPI { get; }

		// extern const FBSDKURLScheme FBSDKURLSchemeMessengerApp __attribute__((swift_name("messengerApp")));
		[Field ("FBSDKURLSchemeMessengerApp", "__Internal")]
		NSString FBSDKURLSchemeMessengerApp { get; }

		// extern const FBSDKURLScheme FBSDKURLSchemeFacebookAuth __attribute__((swift_name("facebookAuth")));
		[Field ("FBSDKURLSchemeFacebookAuth", "__Internal")]
		NSString FBSDKURLSchemeFacebookAuth { get; }

		// extern const FBSDKURLScheme FBSDKURLSchemeHTTPS __attribute__((swift_name("https")));
		[Field ("FBSDKURLSchemeHTTPS", "__Internal")]
		NSString FBSDKURLSchemeHTTPS { get; }

		// extern const FBSDKURLScheme FBSDKURLSchemeHTTP __attribute__((swift_name("http")));
		[Field ("FBSDKURLSchemeHTTP", "__Internal")]
		NSString FBSDKURLSchemeHTTP { get; }

		// extern const FBSDKURLScheme FBSDKURLSchemeWeb __attribute__((swift_name("web")));
		[Field ("FBSDKURLSchemeWeb", "__Internal")]
		NSString FBSDKURLSchemeWeb { get; }
	}

	// @interface FBSDKBridgeAPIRequest : NSObject <NSCopying, FBSDKBridgeAPIRequest>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKBridgeAPIRequest : INSCopying, IFBSDKBridgeAPIRequest
	{
		// +(instancetype _Nullable)bridgeAPIRequestWithProtocolType:(FBSDKBridgeAPIProtocolType)protocolType scheme:(FBSDKURLScheme _Nonnull)scheme methodName:(NSString * _Nullable)methodName parameters:(NSDictionary<NSString *,id> * _Nullable)parameters userInfo:(NSDictionary<NSString *,id> * _Nullable)userInfo;
		[Static]
		[Export ("bridgeAPIRequestWithProtocolType:scheme:methodName:parameters:userInfo:")]
		[return: NullAllowed]
		FBSDKBridgeAPIRequest BridgeAPIRequestWithProtocolType (FBSDKBridgeAPIProtocolType protocolType, string scheme, [NullAllowed] string methodName, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] NSDictionary<NSString, NSObject> userInfo);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull actionID;
		[Export ("actionID")]
		string ActionID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable methodName;
		[NullAllowed, Export ("methodName")]
		string MethodName { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable parameters;
		[NullAllowed, Export ("parameters", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Parameters { get; }

		// @property (readonly, assign, nonatomic) FBSDKBridgeAPIProtocolType protocolType;
		[Export ("protocolType", ArgumentSemantic.Assign)]
		FBSDKBridgeAPIProtocolType ProtocolType { get; }

		// @property (readonly, copy, nonatomic) FBSDKURLScheme _Nonnull scheme;
		[Export ("scheme")]
		string Scheme { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable userInfo;
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> UserInfo { get; }

		// -(NSURL * _Nullable)requestURL:(NSError * _Nullable * _Nullable)errorRef;
		[Export ("requestURL:")]
		[return: NullAllowed]
		NSURL RequestURL ([NullAllowed] out NSError errorRef);

		// +(void)configureWithInternalURLOpener:(id<FBSDKInternalURLOpener> _Nonnull)internalURLOpener internalUtility:(id<FBSDKInternalUtility> _Nonnull)internalUtility settings:(id<FBSDKSettings> _Nonnull)settings __attribute__((swift_name("configure(internalURLOpener:internalUtility:settings:)")));
		[Static]
		[Export ("configureWithInternalURLOpener:internalUtility:settings:")]
		void ConfigureWithInternalURLOpener (FBSDKInternalURLOpener internalURLOpener, FBSDKInternalUtility internalUtility, FBSDKSettings settings);
	}

	// @protocol FBSDKBridgeAPIRequestCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKBridgeAPIRequestCreating
	{
		// @required -(id<FBSDKBridgeAPIRequest> _Nullable)bridgeAPIRequestWithProtocolType:(FBSDKBridgeAPIProtocolType)protocolType scheme:(NSString * _Nonnull)scheme methodName:(NSString * _Nullable)methodName parameters:(NSDictionary<NSString *,id> * _Nullable)parameters userInfo:(NSDictionary<NSString *,id> * _Nullable)userInfo;
		[Abstract]
		[Export ("bridgeAPIRequestWithProtocolType:scheme:methodName:parameters:userInfo:")]
		[return: NullAllowed]
		FBSDKBridgeAPIRequest Scheme (FBSDKBridgeAPIProtocolType protocolType, string scheme, [NullAllowed] string methodName, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] NSDictionary<NSString, NSObject> userInfo);
	}

	// typedef void (^FBSDKBridgeAPIResponseBlock)(FBSDKBridgeAPIResponse * _Nonnull);
	delegate void FBSDKBridgeAPIResponseBlock (FBSDKBridgeAPIResponse arg0);

	// @interface FBSDKBridgeAPIResponse : NSObject <NSCopying, NSObject>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKBridgeAPIResponse : INSCopying
	{
		// +(instancetype _Nonnull)bridgeAPIResponseWithRequest:(NSObject<FBSDKBridgeAPIRequest> * _Nonnull)request error:(NSError * _Nullable)error;
		[Static]
		[Export ("bridgeAPIResponseWithRequest:error:")]
		FBSDKBridgeAPIResponse BridgeAPIResponseWithRequest (FBSDKBridgeAPIRequest request, [NullAllowed] NSError error);

		// +(instancetype _Nullable)bridgeAPIResponseWithRequest:(NSObject<FBSDKBridgeAPIRequest> * _Nonnull)request responseURL:(NSURL * _Nonnull)responseURL sourceApplication:(NSString * _Nullable)sourceApplication error:(NSError * _Nullable * _Nullable)errorRef;
		[Static]
		[Export ("bridgeAPIResponseWithRequest:responseURL:sourceApplication:error:")]
		[return: NullAllowed]
		FBSDKBridgeAPIResponse BridgeAPIResponseWithRequest (FBSDKBridgeAPIRequest request, NSURL responseURL, [NullAllowed] string sourceApplication, [NullAllowed] out NSError errorRef);

		// +(instancetype _Nonnull)bridgeAPIResponseCancelledWithRequest:(NSObject<FBSDKBridgeAPIRequest> * _Nonnull)request;
		[Static]
		[Export ("bridgeAPIResponseCancelledWithRequest:")]
		FBSDKBridgeAPIResponse BridgeAPIResponseCancelledWithRequest (FBSDKBridgeAPIRequest request);

		// @property (readonly, getter = isCancelled, assign, nonatomic) BOOL cancelled;
		[Export ("cancelled")]
		bool Cancelled { [Bind ("isCancelled")] get; }

		// @property (readonly, copy, nonatomic) NSError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Copy)]
		NSError Error { get; }

		// @property (readonly, copy, nonatomic) NSObject<FBSDKBridgeAPIRequest> * _Nonnull request;
		[Export ("request", ArgumentSemantic.Copy)]
		FBSDKBridgeAPIRequest Request { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable responseParameters;
		[NullAllowed, Export ("responseParameters", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> ResponseParameters { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NS_SWIFT_NAME(ErrorDomain) const NSErrorDomain FBSDKErrorDomain __attribute__((swift_name("ErrorDomain")));
		[Field ("FBSDKErrorDomain", "__Internal")]
		NSString FBSDKErrorDomain { get; }

		// extern NS_SWIFT_NAME(ErrorArgumentCollectionKey) const NSErrorUserInfoKey FBSDKErrorArgumentCollectionKey __attribute__((swift_name("ErrorArgumentCollectionKey")));
		[Field ("FBSDKErrorArgumentCollectionKey", "__Internal")]
		NSString FBSDKErrorArgumentCollectionKey { get; }

		// extern NS_SWIFT_NAME(ErrorArgumentNameKey) const NSErrorUserInfoKey FBSDKErrorArgumentNameKey __attribute__((swift_name("ErrorArgumentNameKey")));
		[Field ("FBSDKErrorArgumentNameKey", "__Internal")]
		NSString FBSDKErrorArgumentNameKey { get; }

		// extern NS_SWIFT_NAME(ErrorArgumentValueKey) const NSErrorUserInfoKey FBSDKErrorArgumentValueKey __attribute__((swift_name("ErrorArgumentValueKey")));
		[Field ("FBSDKErrorArgumentValueKey", "__Internal")]
		NSString FBSDKErrorArgumentValueKey { get; }

		// extern NS_SWIFT_NAME(ErrorDeveloperMessageKey) const NSErrorUserInfoKey FBSDKErrorDeveloperMessageKey __attribute__((swift_name("ErrorDeveloperMessageKey")));
		[Field ("FBSDKErrorDeveloperMessageKey", "__Internal")]
		NSString FBSDKErrorDeveloperMessageKey { get; }

		// extern NS_SWIFT_NAME(ErrorLocalizedDescriptionKey) const NSErrorUserInfoKey FBSDKErrorLocalizedDescriptionKey __attribute__((swift_name("ErrorLocalizedDescriptionKey")));
		[Field ("FBSDKErrorLocalizedDescriptionKey", "__Internal")]
		NSString FBSDKErrorLocalizedDescriptionKey { get; }

		// extern NS_SWIFT_NAME(ErrorLocalizedTitleKey) const NSErrorUserInfoKey FBSDKErrorLocalizedTitleKey __attribute__((swift_name("ErrorLocalizedTitleKey")));
		[Field ("FBSDKErrorLocalizedTitleKey", "__Internal")]
		NSString FBSDKErrorLocalizedTitleKey { get; }

		// extern NS_SWIFT_NAME(GraphRequestErrorKey) const NSErrorUserInfoKey FBSDKGraphRequestErrorKey __attribute__((swift_name("GraphRequestErrorKey")));
		[Field ("FBSDKGraphRequestErrorKey", "__Internal")]
		NSString FBSDKGraphRequestErrorKey { get; }

		// extern NS_SWIFT_NAME(GraphRequestErrorGraphErrorCodeKey) const NSErrorUserInfoKey FBSDKGraphRequestErrorGraphErrorCodeKey __attribute__((swift_name("GraphRequestErrorGraphErrorCodeKey")));
		[Field ("FBSDKGraphRequestErrorGraphErrorCodeKey", "__Internal")]
		NSString FBSDKGraphRequestErrorGraphErrorCodeKey { get; }

		// extern NS_SWIFT_NAME(GraphRequestErrorGraphErrorSubcodeKey) const NSErrorUserInfoKey FBSDKGraphRequestErrorGraphErrorSubcodeKey __attribute__((swift_name("GraphRequestErrorGraphErrorSubcodeKey")));
		[Field ("FBSDKGraphRequestErrorGraphErrorSubcodeKey", "__Internal")]
		NSString FBSDKGraphRequestErrorGraphErrorSubcodeKey { get; }

		// extern NS_SWIFT_NAME(GraphRequestErrorHTTPStatusCodeKey) const NSErrorUserInfoKey FBSDKGraphRequestErrorHTTPStatusCodeKey __attribute__((swift_name("GraphRequestErrorHTTPStatusCodeKey")));
		[Field ("FBSDKGraphRequestErrorHTTPStatusCodeKey", "__Internal")]
		NSString FBSDKGraphRequestErrorHTTPStatusCodeKey { get; }

		// extern NS_SWIFT_NAME(GraphRequestErrorParsedJSONResponseKey) const NSErrorUserInfoKey FBSDKGraphRequestErrorParsedJSONResponseKey __attribute__((swift_name("GraphRequestErrorParsedJSONResponseKey")));
		[Field ("FBSDKGraphRequestErrorParsedJSONResponseKey", "__Internal")]
		NSString FBSDKGraphRequestErrorParsedJSONResponseKey { get; }
	}

	// typedef void (^FBSDKCodeBlock)();
	delegate void FBSDKCodeBlock ();

	// typedef void (^FBSDKErrorBlock)(NSError * _Nullable);
	delegate void FBSDKErrorBlock ([NullAllowed] NSError arg0);

	// typedef void (^FBSDKSuccessBlock)(BOOL, NSError * _Nullable);
	delegate void FBSDKSuccessBlock (bool arg0, [NullAllowed] NSError arg1);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull DefaultKeychainServicePrefix;
		[Field ("DefaultKeychainServicePrefix", "__Internal")]
		NSString DefaultKeychainServicePrefix { get; }
	}

	// @protocol FBSDKBridgeAPIRequestOpening
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKBridgeAPIRequestOpening
	{
		// @required -(void)openBridgeAPIRequest:(NSObject<FBSDKBridgeAPIRequest> * _Nonnull)request useSafariViewController:(BOOL)useSafariViewController fromViewController:(UIViewController * _Nullable)fromViewController completionBlock:(FBSDKBridgeAPIResponseBlock _Nonnull)completionBlock;
		[Abstract]
		[Export ("openBridgeAPIRequest:useSafariViewController:fromViewController:completionBlock:")]
		void OpenBridgeAPIRequest (FBSDKBridgeAPIRequest request, bool useSafariViewController, [NullAllowed] UIViewController fromViewController, FBSDKBridgeAPIResponseBlock completionBlock);

		// @required -(void)openURLWithSafariViewController:(NSURL * _Nonnull)url sender:(id<FBSDKURLOpening> _Nullable)sender fromViewController:(UIViewController * _Nullable)fromViewController handler:(FBSDKSuccessBlock _Nonnull)handler __attribute__((swift_name("openURLWithSafariViewController(url:sender:from:handler:)")));
		[Abstract]
		[Export ("openURLWithSafariViewController:sender:fromViewController:handler:")]
		void OpenURLWithSafariViewController (NSURL url, [NullAllowed] FBSDKURLOpening sender, [NullAllowed] UIViewController fromViewController, FBSDKSuccessBlock handler);

		// @required -(void)openURL:(NSURL * _Nonnull)url sender:(id<FBSDKURLOpening> _Nullable)sender handler:(FBSDKSuccessBlock _Nonnull)handler;
		[Abstract]
		[Export ("openURL:sender:handler:")]
		void OpenURL (NSURL url, [NullAllowed] FBSDKURLOpening sender, FBSDKSuccessBlock handler);
	}

	// @interface FBSDKImpressionLoggingButton : UIButton
	[BaseType (typeof(UIButton))]
	interface FBSDKImpressionLoggingButton
	{
		// +(void)configureWithImpressionLoggerFactory:(id<FBSDKImpressionLoggerFactory> _Nonnull)impressionLoggerFactory __attribute__((swift_name("configure(impressionLoggerFactory:)")));
		[Static]
		[Export ("configureWithImpressionLoggerFactory:")]
		void ConfigureWithImpressionLoggerFactory (FBSDKImpressionLoggerFactory impressionLoggerFactory);
	}

	// @interface FBSDKButton : FBSDKImpressionLoggingButton
	[BaseType (typeof(FBSDKImpressionLoggingButton))]
	interface FBSDKButton
	{
		// @property (readonly, getter = isImplicitlyDisabled, nonatomic) BOOL implicitlyDisabled;
		[Export ("implicitlyDisabled")]
		bool ImplicitlyDisabled { [Bind ("isImplicitlyDisabled")] get; }

		// -(void)checkImplicitlyDisabled;
		[Export ("checkImplicitlyDisabled")]
		void CheckImplicitlyDisabled ();

		// -(void)configureWithIcon:(FBSDKIcon * _Nullable)icon title:(NSString * _Nullable)title backgroundColor:(UIColor * _Nullable)backgroundColor highlightedColor:(UIColor * _Nullable)highlightedColor;
		[Export ("configureWithIcon:title:backgroundColor:highlightedColor:")]
		void ConfigureWithIcon ([NullAllowed] FBSDKIcon icon, [NullAllowed] string title, [NullAllowed] UIColor backgroundColor, [NullAllowed] UIColor highlightedColor);

		// -(void)configureWithIcon:(FBSDKIcon * _Nullable)icon title:(NSString * _Nullable)title backgroundColor:(UIColor * _Nullable)backgroundColor highlightedColor:(UIColor * _Nullable)highlightedColor selectedTitle:(NSString * _Nullable)selectedTitle selectedIcon:(FBSDKIcon * _Nullable)selectedIcon selectedColor:(UIColor * _Nullable)selectedColor selectedHighlightedColor:(UIColor * _Nullable)selectedHighlightedColor;
		[Export ("configureWithIcon:title:backgroundColor:highlightedColor:selectedTitle:selectedIcon:selectedColor:selectedHighlightedColor:")]
		void ConfigureWithIcon ([NullAllowed] FBSDKIcon icon, [NullAllowed] string title, [NullAllowed] UIColor backgroundColor, [NullAllowed] UIColor highlightedColor, [NullAllowed] string selectedTitle, [NullAllowed] FBSDKIcon selectedIcon, [NullAllowed] UIColor selectedColor, [NullAllowed] UIColor selectedHighlightedColor);

		// -(UIColor * _Nonnull)defaultBackgroundColor;
		[Export ("defaultBackgroundColor")]
		[Verify (MethodToProperty)]
		UIColor DefaultBackgroundColor { get; }

		// -(CGSize)sizeThatFits:(CGSize)size title:(NSString * _Nonnull)title;
		[Export ("sizeThatFits:title:")]
		CGSize SizeThatFits (CGSize size, string title);

		// -(CGSize)textSizeForText:(NSString * _Nonnull)text font:(UIFont * _Nonnull)font constrainedSize:(CGSize)constrainedSize lineBreakMode:(NSLineBreakMode)lineBreakMode;
		[Export ("textSizeForText:font:constrainedSize:lineBreakMode:")]
		CGSize TextSizeForText (string text, UIFont font, CGSize constrainedSize, NSLineBreakMode lineBreakMode);

		// -(void)logTapEventWithEventName:(FBSDKAppEventName _Nonnull)eventName parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters;
		[Export ("logTapEventWithEventName:parameters:")]
		void LogTapEventWithEventName (string eventName, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// +(void)configureWithApplicationActivationNotifier:(id _Nonnull)applicationActivationNotifier eventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger accessTokenProvider:(Class<FBSDKAccessTokenProviding> _Nonnull)accessTokenProvider __attribute__((swift_name("configure(applicationActivationNotifier:eventLogger:accessTokenProvider:)")));
		[Static]
		[Export ("configureWithApplicationActivationNotifier:eventLogger:accessTokenProvider:")]
		void ConfigureWithApplicationActivationNotifier (NSObject applicationActivationNotifier, FBSDKEventLogging eventLogger, FBSDKAccessTokenProviding accessTokenProvider);
	}

	// @protocol FBSDKButtonImpressionLogging <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKButtonImpressionLogging
	{
		// @required @property (readonly, copy, nonatomic) NSDictionary<FBSDKAppEventParameterName,id> * _Nullable analyticsParameters;
		[Abstract]
		[NullAllowed, Export ("analyticsParameters", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> AnalyticsParameters { get; }

		// @required @property (readonly, copy, nonatomic) FBSDKAppEventName _Nonnull impressionTrackingEventName;
		[Abstract]
		[Export ("impressionTrackingEventName")]
		string ImpressionTrackingEventName { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull impressionTrackingIdentifier;
		[Abstract]
		[Export ("impressionTrackingIdentifier")]
		string ImpressionTrackingIdentifier { get; }
	}

	// @protocol FBSDKClientTokenProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKClientTokenProviding
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nullable clientToken;
		[Abstract]
		[NullAllowed, Export ("clientToken")]
		string ClientToken { get; }
	}

	// @protocol FBSDKCodelessIndexing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKCodelessIndexing
	{
		// @required +(void)enable;
		[Static, Abstract]
		[Export ("enable")]
		void Enable ();
	}

	// typedef void (^FBSDKCodelessSettingLoadBlock)(BOOL, NSError * _Nullable);
	delegate void FBSDKCodelessSettingLoadBlock (bool arg0, [NullAllowed] NSError arg1);

	// @interface FBSDKCodelessIndexer : NSObject <FBSDKCodelessIndexing>
	[BaseType (typeof(NSObject))]
	interface FBSDKCodelessIndexer : IFBSDKCodelessIndexing
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull extInfo;
		[Static]
		[Export ("extInfo")]
		string ExtInfo { get; }

		// +(void)enable;
		[Static]
		[Export ("enable")]
		void Enable ();

		// +(void)configureWithGraphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory serverConfigurationProvider:(id<FBSDKServerConfigurationProviding> _Nonnull)serverConfigurationProvider dataStore:(id<FBSDKDataPersisting> _Nonnull)dataStore graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)graphRequestConnectionFactory swizzler:(Class<FBSDKSwizzling> _Nonnull)swizzler settings:(id<FBSDKSettings> _Nonnull)settings advertiserIDProvider:(id<FBSDKAdvertiserIDProviding> _Nonnull)advertisingIDProvider __attribute__((swift_name("configure(graphRequestFactory:serverConfigurationProvider:dataStore:graphRequestConnectionFactory:swizzler:settings:advertiserIDProvider:)")));
		[Static]
		[Export ("configureWithGraphRequestFactory:serverConfigurationProvider:dataStore:graphRequestConnectionFactory:swizzler:settings:advertiserIDProvider:")]
		void ConfigureWithGraphRequestFactory (FBSDKGraphRequestFactory graphRequestFactory, FBSDKServerConfigurationProviding serverConfigurationProvider, FBSDKDataPersisting dataStore, FBSDKGraphRequestConnectionFactory graphRequestConnectionFactory, FBSDKSwizzling swizzler, FBSDKSettings settings, FBSDKAdvertiserIDProviding advertisingIDProvider);
	}

	// @protocol FBSDKContainerViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FBSDKContainerViewControllerDelegate
	{
		// @required -(void)viewControllerDidDisappear:(FBSDKContainerViewController * _Nonnull)viewController animated:(BOOL)animated;
		[Abstract]
		[Export ("viewControllerDidDisappear:animated:")]
		void Animated (FBSDKContainerViewController viewController, bool animated);
	}

	// @interface FBSDKContainerViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface FBSDKContainerViewController
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKContainerViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKContainerViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)displayChildController:(UIViewController * _Nonnull)childController;
		[Export ("displayChildController:")]
		void DisplayChildController (UIViewController childController);
	}

	// @protocol FBSDKConversionValueUpdating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKConversionValueUpdating
	{
		// @required +(void)updateConversionValue:(NSInteger)conversionValue;
		[Static, Abstract]
		[Export ("updateConversionValue:")]
		void UpdateConversionValue (nint conversionValue);

		// @required +(void)updateCoarseConversionValue:(NSString * _Nonnull)coarseConversionValue;
		[Static, Abstract]
		[Export ("updateCoarseConversionValue:")]
		void UpdateCoarseConversionValue (string coarseConversionValue);

		// @required +(void)updatePostbackConversionValue:(NSInteger)conversionValue completionHandler:(void (^ _Nullable)(NSError * _Nullable))completion __attribute__((availability(ios, introduced=15.4)));
		[iOS (15,4)]
		[Static, Abstract]
		[Export ("updatePostbackConversionValue:completionHandler:")]
		void UpdatePostbackConversionValue (nint conversionValue, [NullAllowed] Action<NSError> completion);

		// @required +(void)updatePostbackConversionValue:(NSInteger)fineValue coarseValue:(SKAdNetworkCoarseConversionValue _Nonnull)coarseValue completionHandler:(void (^ _Nullable)(NSError * _Nullable))completion __attribute__((availability(ios, introduced=16.1)));
		[iOS (16,1)]
		[Static, Abstract]
		[Export ("updatePostbackConversionValue:coarseValue:completionHandler:")]
		void UpdatePostbackConversionValue (nint fineValue, string coarseValue, [NullAllowed] Action<NSError> completion);

		// @required +(void)updatePostbackConversionValue:(NSInteger)fineValue coarseValue:(SKAdNetworkCoarseConversionValue _Nonnull)coarseValue lockWindow:(BOOL)lockWindow completionHandler:(void (^ _Nullable)(NSError * _Nullable))completion __attribute__((availability(ios, introduced=16.1)));
		[iOS (16,1)]
		[Static, Abstract]
		[Export ("updatePostbackConversionValue:coarseValue:lockWindow:completionHandler:")]
		void UpdatePostbackConversionValue (nint fineValue, string coarseValue, bool lockWindow, [NullAllowed] Action<NSError> completion);
	}

	// @interface ConversionValueUpdating (SKAdNetwork) <FBSDKConversionValueUpdating>
	[Category]
	[BaseType (typeof(SKAdNetwork))]
	interface SKAdNetwork_ConversionValueUpdating : IFBSDKConversionValueUpdating
	{
	}

	// @interface FBSDKCrashObserver : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKCrashObserver
	{
		// -(instancetype _Nonnull)initWithFeatureChecker:(id<FBSDKFeatureChecking> _Nonnull)featureChecker graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory settings:(id<FBSDKSettings> _Nonnull)settings crashHandler:(id<FBSDKCrashHandler> _Nonnull)crashHandler __attribute__((swift_name("init(featureChecker:graphRequestFactory:settings:crashHandler:)")));
		[Export ("initWithFeatureChecker:graphRequestFactory:settings:crashHandler:")]
		NativeHandle Constructor (FBSDKFeatureChecking featureChecker, FBSDKGraphRequestFactory graphRequestFactory, FBSDKSettings settings, FBSDKCrashHandler crashHandler);
	}

	// @interface FBSDKCrashShield : NSObject
	[BaseType (typeof(NSObject))]
	interface FBSDKCrashShield
	{
		// +(void)analyze:(NSArray<NSDictionary<NSString *,id> *> * _Nonnull)crashLogs;
		[Static]
		[Export ("analyze:")]
		void Analyze (NSDictionary<NSString, NSObject>[] crashLogs);

		// +(void)configureWithSettings:(id<FBSDKSettings> _Nonnull)settings graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory featureChecking:(id<FBSDKFeatureChecking,FBSDKFeatureDisabling> _Nonnull)featureChecking __attribute__((swift_name("configure(settings:graphRequestFactory:featureChecking:)")));
		[Static]
		[Export ("configureWithSettings:graphRequestFactory:featureChecking:")]
		void ConfigureWithSettings (FBSDKSettings settings, FBSDKGraphRequestFactory graphRequestFactory, NSObject<FBSDKFeatureChecking, FBSDKFeatureDisabling> featureChecking);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const FBSDKDataProcessingOptionKey FBSDKDataProcessingOptionKeyOptions;
		[Field ("FBSDKDataProcessingOptionKeyOptions", "__Internal")]
		NSString FBSDKDataProcessingOptionKeyOptions { get; }

		// extern const FBSDKDataProcessingOptionKey FBSDKDataProcessingOptionKeyCountry;
		[Field ("FBSDKDataProcessingOptionKeyCountry", "__Internal")]
		NSString FBSDKDataProcessingOptionKeyCountry { get; }

		// extern const FBSDKDataProcessingOptionKey FBSDKDataProcessingOptionKeyState;
		[Field ("FBSDKDataProcessingOptionKeyState", "__Internal")]
		NSString FBSDKDataProcessingOptionKeyState { get; }
	}

	// @interface FBSDKDialogConfiguration : NSObject <NSCopying, NSObject, NSSecureCoding>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKDialogConfiguration : INSCopying, INSSecureCoding
	{
		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name URL:(NSURL * _Nonnull)URL appVersions:(NSArray<id> * _Nonnull)appVersions __attribute__((objc_designated_initializer));
		[Export ("initWithName:URL:appVersions:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, NSURL URL, NSObject[] appVersions);

		// @property (readonly, copy, nonatomic) NSArray<id> * _Nonnull appVersions;
		[Export ("appVersions", ArgumentSemantic.Copy)]
		NSObject[] AppVersions { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull URL;
		[Export ("URL", ArgumentSemantic.Copy)]
		NSURL URL { get; }
	}

	// @protocol FBSDKDialogConfigurationMapBuilding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKDialogConfigurationMapBuilding
	{
		// @required -(NSDictionary<NSString *,FBSDKDialogConfiguration *> * _Nonnull)buildDialogConfigurationMapWithRawConfigurations:(NSArray<NSDictionary<NSString *,id> *> * _Nonnull)rawConfigurations __attribute__((swift_name("buildDialogConfigurationMap(from:)")));
		[Abstract]
		[Export ("buildDialogConfigurationMapWithRawConfigurations:")]
		NSDictionary<NSString, FBSDKDialogConfiguration> BuildDialogConfigurationMapWithRawConfigurations (NSDictionary<NSString, NSObject>[] rawConfigurations);
	}

	// @interface FBSDKDomainConfiguration : NSObject <NSCopying, NSObject, NSSecureCoding>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKDomainConfiguration : INSCopying, INSSecureCoding
	{
		// -(instancetype _Nonnull)initWithTimestamp:(NSDate * _Nullable)timestamp domainInfo:(NSDictionary<NSString *,NSDictionary<NSString *,id> *> * _Nullable)domainInfo __attribute__((objc_designated_initializer));
		[Export ("initWithTimestamp:domainInfo:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSDate timestamp, [NullAllowed] NSDictionary<NSString, NSDictionary<NSString, NSObject>> domainInfo);

		// @property (readonly, copy, nonatomic) NSDate * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Copy)]
		NSDate Timestamp { get; }

		// @property (readonly, nonatomic) NSInteger version;
		[Export ("version")]
		nint Version { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSDictionary<NSString *,id> *> * _Nullable domainInfo;
		[NullAllowed, Export ("domainInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSDictionary<NSString, NSObject>> DomainInfo { get; }

		// +(void)setDefaultDomainInfo;
		[Static]
		[Export ("setDefaultDomainInfo")]
		void SetDefaultDomainInfo ();
	}

	// typedef void (^FBSDKDomainConfigurationBlock)();
	delegate void FBSDKDomainConfigurationBlock ();

	// @protocol FBSDKDomainConfigurationProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKDomainConfigurationProviding
	{
		// @required -(FBSDKDomainConfiguration * _Nonnull)cachedDomainConfiguration;
		[Abstract]
		[Export ("cachedDomainConfiguration")]
		[Verify (MethodToProperty)]
		FBSDKDomainConfiguration CachedDomainConfiguration { get; }

		// @required -(void)configureWithSettings:(id<FBSDKSettings> _Nonnull)settings dataStore:(id<FBSDKDataPersisting> _Nonnull)dataStore graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)graphRequestConnectionFactory __attribute__((swift_name("configure(settings:dataStore:graphRequestFactory:graphRequestConnectionFactory:)")));
		[Abstract]
		[Export ("configureWithSettings:dataStore:graphRequestFactory:graphRequestConnectionFactory:")]
		void ConfigureWithSettings (FBSDKSettings settings, FBSDKDataPersisting dataStore, FBSDKGraphRequestFactory graphRequestFactory, FBSDKGraphRequestConnectionFactory graphRequestConnectionFactory);

		// @required -(void)loadDomainConfigurationWithCompletionBlock:(FBSDKDomainConfigurationBlock _Nullable)completionBlock;
		[Abstract]
		[Export ("loadDomainConfigurationWithCompletionBlock:")]
		void LoadDomainConfigurationWithCompletionBlock ([NullAllowed] FBSDKDomainConfigurationBlock completionBlock);

		// @required -(void)processInvalidDomainsIfNeeded:(NSSet<NSString *> * _Nonnull)domainSet;
		[Abstract]
		[Export ("processInvalidDomainsIfNeeded:")]
		void ProcessInvalidDomainsIfNeeded (NSSet<NSString> domainSet);
	}

	// @interface FBSDKDomainConfigurationManager : NSObject <FBSDKDomainConfigurationProviding>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKDomainConfigurationManager : IFBSDKDomainConfigurationProviding
	{
		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		FBSDKDomainConfigurationManager SharedInstance ();

		// @property (nonatomic) id<FBSDKGraphRequestFactory> _Nullable graphRequestFactory;
		[NullAllowed, Export ("graphRequestFactory", ArgumentSemantic.Assign)]
		FBSDKGraphRequestFactory GraphRequestFactory { get; set; }

		// @property (nonatomic) id<FBSDKGraphRequestConnectionFactory> _Nullable graphRequestConnectionFactory;
		[NullAllowed, Export ("graphRequestConnectionFactory", ArgumentSemantic.Assign)]
		FBSDKGraphRequestConnectionFactory GraphRequestConnectionFactory { get; set; }

		// @property (nonatomic) id<FBSDKSettings> _Nullable settings;
		[NullAllowed, Export ("settings", ArgumentSemantic.Assign)]
		FBSDKSettings Settings { get; set; }

		// @property (nonatomic) id<FBSDKDataPersisting> _Nullable dataStore;
		[NullAllowed, Export ("dataStore", ArgumentSemantic.Assign)]
		FBSDKDataPersisting DataStore { get; set; }
	}

	// @interface FBSDKGraphRequestMetadata : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGraphRequestMetadata
	{
		// @property (retain, nonatomic) id<FBSDKGraphRequest> _Nonnull request;
		[Export ("request", ArgumentSemantic.Retain)]
		FBSDKGraphRequest Request { get; set; }

		// @property (copy, nonatomic) FBSDKGraphRequestCompletion _Nonnull completionHandler;
		[Export ("completionHandler", ArgumentSemantic.Copy)]
		FBSDKGraphRequestCompletion CompletionHandler { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull batchParameters;
		[Export ("batchParameters", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> BatchParameters { get; set; }

		// -(instancetype _Nonnull)initWithRequest:(id<FBSDKGraphRequest> _Nonnull)request completionHandler:(FBSDKGraphRequestCompletion _Nullable)handler batchParameters:(NSDictionary<NSString *,id> * _Nullable)batchParameters __attribute__((objc_designated_initializer));
		[Export ("initWithRequest:completionHandler:batchParameters:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKGraphRequest request, [NullAllowed] FBSDKGraphRequestCompletion handler, [NullAllowed] NSDictionary<NSString, NSObject> batchParameters);

		// -(void)invokeCompletionHandlerForConnection:(id<FBSDKGraphRequestConnecting> _Nonnull)connection withResults:(id _Nullable)results error:(NSError * _Nullable)error;
		[Export ("invokeCompletionHandlerForConnection:withResults:error:")]
		void InvokeCompletionHandlerForConnection (FBSDKGraphRequestConnecting connection, [NullAllowed] NSObject results, [NullAllowed] NSError error);
	}

	// @interface FBSDKDomainHandler : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKDomainHandler
	{
		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		FBSDKDomainHandler SharedInstance ();

		// -(void)configureWithGraphRequestFactory:(id<FBSDKDomainConfigurationProviding> _Nonnull)domainConfigurationProvider settings:(id<FBSDKSettings> _Nonnull)settings dataStore:(id<FBSDKDataPersisting> _Nonnull)dataStore graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)graphRequestConnectionFactory __attribute__((swift_name("configure(domainConfigurationProvider:settings:dataStore:graphRequestFactory:graphRequestConnectionFactory:)")));
		[Export ("configureWithGraphRequestFactory:settings:dataStore:graphRequestFactory:graphRequestConnectionFactory:")]
		void ConfigureWithGraphRequestFactory (FBSDKDomainConfigurationProviding domainConfigurationProvider, FBSDKSettings settings, FBSDKDataPersisting dataStore, FBSDKGraphRequestFactory graphRequestFactory, FBSDKGraphRequestConnectionFactory graphRequestConnectionFactory);

		// -(void)loadDomainConfigurationWithCompletionBlock:(FBSDKDomainConfigurationBlock _Nullable)completionBlock;
		[Export ("loadDomainConfigurationWithCompletionBlock:")]
		void LoadDomainConfigurationWithCompletionBlock ([NullAllowed] FBSDKDomainConfigurationBlock completionBlock);

		// -(NSString * _Nonnull)getURLPrefixForSingleRequest:(id<FBSDKGraphRequest> _Nonnull)request isAdvertiserTrackingEnabled:(BOOL)isATTOptIn;
		[Export ("getURLPrefixForSingleRequest:isAdvertiserTrackingEnabled:")]
		string GetURLPrefixForSingleRequest (FBSDKGraphRequest request, bool isATTOptIn);

		// -(NSString * _Nonnull)getURLPrefixForBatchRequest:(NSArray<FBSDKGraphRequestMetadata *> * _Nonnull)requestsMetaData isAdvertiserTrackingEnabled:(BOOL)isATTOptIn;
		[Export ("getURLPrefixForBatchRequest:isAdvertiserTrackingEnabled:")]
		string GetURLPrefixForBatchRequest (FBSDKGraphRequestMetadata[] requestsMetaData, bool isATTOptIn);

		// +(BOOL)isAuthenticatedForGamingDomain;
		[Static]
		[Export ("isAuthenticatedForGamingDomain")]
		[Verify (MethodToProperty)]
		bool IsAuthenticatedForGamingDomain { get; }

		// +(NSString * _Nonnull)getCleanedGraphPathFromRequest:(id<FBSDKGraphRequest> _Nonnull)request;
		[Static]
		[Export ("getCleanedGraphPathFromRequest:")]
		string GetCleanedGraphPathFromRequest (FBSDKGraphRequest request);

		// -(NSString * _Nullable)getATTScopeEndpointForGraphPath:(NSString * _Nonnull)graphPath;
		[Export ("getATTScopeEndpointForGraphPath:")]
		[return: NullAllowed]
		string GetATTScopeEndpointForGraphPath (string graphPath);

		// -(BOOL)isDomainHandlingEnabled;
		[Export ("isDomainHandlingEnabled")]
		[Verify (MethodToProperty)]
		bool IsDomainHandlingEnabled { get; }

		// -(void)processInvalidDomainsIfNeeded:(NSSet<NSString *> * _Nonnull)domainSet;
		[Export ("processInvalidDomainsIfNeeded:")]
		void ProcessInvalidDomainsIfNeeded (NSSet<NSString> domainSet);
	}

	// @interface FBSDKDynamicFrameworkLoaderProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface FBSDKDynamicFrameworkLoaderProxy
	{
		// +(CFTypeRef _Nonnull)loadkSecAttrAccessibleAfterFirstUnlockThisDeviceOnly;
		[Static]
		[Export ("loadkSecAttrAccessibleAfterFirstUnlockThisDeviceOnly")]
		[Verify (MethodToProperty)]
		unsafe void* LoadkSecAttrAccessibleAfterFirstUnlockThisDeviceOnly { get; }
	}

	// @protocol FBSDKErrorConfiguration
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKErrorConfiguration
	{
		// @required -(FBSDKErrorRecoveryConfiguration * _Nullable)recoveryConfigurationForCode:(NSString * _Nullable)code subcode:(NSString * _Nullable)subcode request:(id<FBSDKGraphRequest> _Nonnull)request;
		[Abstract]
		[Export ("recoveryConfigurationForCode:subcode:request:")]
		[return: NullAllowed]
		FBSDKErrorRecoveryConfiguration Subcode ([NullAllowed] string code, [NullAllowed] string subcode, FBSDKGraphRequest request);
	}

	// @protocol FBSDKDecodableErrorConfiguration <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKDecodableErrorConfiguration
	{
		// @required -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Abstract]
		[Export ("initWithDictionary:")]
		NativeHandle Constructor (NSDictionary<NSString, NSObject> dictionary);

		// @required -(void)updateWithArray:(NSArray<NSDictionary<NSString *,id> *> * _Nonnull)array;
		[Abstract]
		[Export ("updateWithArray:")]
		void UpdateWithArray (NSDictionary<NSString, NSObject>[] array);
	}

	// @interface FBSDKErrorConfiguration : NSObject <NSSecureCoding, NSCopying, FBSDKErrorConfiguration, FBSDKDecodableErrorConfiguration>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKErrorConfiguration : INSSecureCoding, INSCopying, IFBSDKErrorConfiguration, IFBSDKDecodableErrorConfiguration
	{
		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nullable)dictionary __attribute__((objc_designated_initializer));
		[Export ("initWithDictionary:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSDictionary<NSString, NSObject> dictionary);

		// -(void)updateWithArray:(NSArray<NSDictionary<NSString *,id> *> * _Nonnull)array;
		[Export ("updateWithArray:")]
		void UpdateWithArray (NSDictionary<NSString, NSObject>[] array);

		// -(FBSDKErrorRecoveryConfiguration * _Nullable)recoveryConfigurationForCode:(NSString * _Nullable)code subcode:(NSString * _Nullable)subcode request:(id<FBSDKGraphRequest> _Nonnull)request;
		[Export ("recoveryConfigurationForCode:subcode:request:")]
		[return: NullAllowed]
		FBSDKErrorRecoveryConfiguration RecoveryConfigurationForCode ([NullAllowed] string code, [NullAllowed] string subcode, FBSDKGraphRequest request);
	}

	// @protocol FBSDKErrorConfigurationProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKErrorConfigurationProviding
	{
		// @required -(id<FBSDKErrorConfiguration> _Nullable)errorConfiguration;
		[Abstract]
		[NullAllowed, Export ("errorConfiguration")]
		[Verify (MethodToProperty)]
		FBSDKErrorConfiguration ErrorConfiguration { get; }
	}

	// @interface FBSDKErrorConfigurationProvider : NSObject <FBSDKErrorConfigurationProviding>
	[BaseType (typeof(NSObject))]
	interface FBSDKErrorConfigurationProvider : IFBSDKErrorConfigurationProviding
	{
	}

	// @protocol FBSDKErrorCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKErrorCreating
	{
		// @required -(NSError * _Nonnull)errorWithCode:(NSInteger)code userInfo:(NSDictionary<NSErrorUserInfoKey,id> * _Nullable)userInfo message:(NSString * _Nullable)message underlyingError:(NSError * _Nullable)underlyingError __attribute__((swift_name("error(code:userInfo:message:underlyingError:)")));
		[Abstract]
		[Export ("errorWithCode:userInfo:message:underlyingError:")]
		NSError ErrorWithCode (nint code, [NullAllowed] NSDictionary<NSString, NSObject> userInfo, [NullAllowed] string message, [NullAllowed] NSError underlyingError);

		// @required -(NSError * _Nonnull)errorWithDomain:(NSErrorDomain _Nonnull)domain code:(NSInteger)code userInfo:(NSDictionary<NSErrorUserInfoKey,id> * _Nullable)userInfo message:(NSString * _Nullable)message underlyingError:(NSError * _Nullable)underlyingError __attribute__((swift_name("error(domain:code:userInfo:message:underlyingError:)")));
		[Abstract]
		[Export ("errorWithDomain:code:userInfo:message:underlyingError:")]
		NSError ErrorWithDomain (string domain, nint code, [NullAllowed] NSDictionary<NSString, NSObject> userInfo, [NullAllowed] string message, [NullAllowed] NSError underlyingError);

		// @required -(NSError * _Nonnull)invalidArgumentErrorWithName:(NSString * _Nonnull)name value:(id _Nullable)value message:(NSString * _Nullable)message underlyingError:(NSError * _Nullable)underlyingError __attribute__((swift_name("invalidArgumentError(name:value:message:underlyingError:)")));
		[Abstract]
		[Export ("invalidArgumentErrorWithName:value:message:underlyingError:")]
		NSError InvalidArgumentErrorWithName (string name, [NullAllowed] NSObject value, [NullAllowed] string message, [NullAllowed] NSError underlyingError);

		// @required -(NSError * _Nonnull)invalidArgumentErrorWithDomain:(NSErrorDomain _Nonnull)domain name:(NSString * _Nonnull)name value:(id _Nullable)value message:(NSString * _Nullable)message underlyingError:(NSError * _Nullable)underlyingError __attribute__((swift_name("invalidArgumentError(domain:name:value:message:underlyingError:)")));
		[Abstract]
		[Export ("invalidArgumentErrorWithDomain:name:value:message:underlyingError:")]
		NSError InvalidArgumentErrorWithDomain (string domain, string name, [NullAllowed] NSObject value, [NullAllowed] string message, [NullAllowed] NSError underlyingError);

		// @required -(NSError * _Nonnull)requiredArgumentErrorWithName:(NSString * _Nonnull)name message:(NSString * _Nullable)message underlyingError:(NSError * _Nullable)underlyingError __attribute__((swift_name("requiredArgumentError(name:message:underlyingError:)")));
		[Abstract]
		[Export ("requiredArgumentErrorWithName:message:underlyingError:")]
		NSError RequiredArgumentErrorWithName (string name, [NullAllowed] string message, [NullAllowed] NSError underlyingError);

		// @required -(NSError * _Nonnull)requiredArgumentErrorWithDomain:(NSErrorDomain _Nonnull)domain name:(NSString * _Nonnull)name message:(NSString * _Nullable)message underlyingError:(NSError * _Nullable)underlyingError __attribute__((swift_name("requiredArgumentError(domain:name:message:underlyingError:)")));
		[Abstract]
		[Export ("requiredArgumentErrorWithDomain:name:message:underlyingError:")]
		NSError RequiredArgumentErrorWithDomain (string domain, string name, [NullAllowed] string message, [NullAllowed] NSError underlyingError);

		// @required -(NSError * _Nonnull)unknownErrorWithMessage:(NSString * _Nullable)message userInfo:(NSDictionary<NSErrorUserInfoKey,id> * _Nullable)userInfo __attribute__((swift_name("unknownError(message:userInfo:)")));
		[Abstract]
		[Export ("unknownErrorWithMessage:userInfo:")]
		NSError UnknownErrorWithMessage ([NullAllowed] string message, [NullAllowed] NSDictionary<NSString, NSObject> userInfo);
	}

	// @protocol FBSDKErrorRecoveryAttempting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKErrorRecoveryAttempting
	{
		// @required -(void)attemptRecoveryFromError:(NSError * _Nonnull)error completionHandler:(void (^ _Nonnull)(BOOL))completionHandler __attribute__((swift_name("attemptRecovery(from:completion:)")));
		[Abstract]
		[Export ("attemptRecoveryFromError:completionHandler:")]
		void CompletionHandler (NSError error, Action<bool> completionHandler);
	}

	// @interface FBSDKErrorRecoveryConfiguration : NSObject <NSCopying, NSSecureCoding>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKErrorRecoveryConfiguration : INSCopying, INSSecureCoding
	{
		// @property (readonly, nonatomic) NSString * _Nonnull localizedRecoveryDescription;
		[Export ("localizedRecoveryDescription")]
		string LocalizedRecoveryDescription { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull localizedRecoveryOptionDescriptions;
		[Export ("localizedRecoveryOptionDescriptions")]
		string[] LocalizedRecoveryOptionDescriptions { get; }

		// @property (readonly, nonatomic) FBSDKGraphRequestError errorCategory;
		[Export ("errorCategory")]
		FBSDKGraphRequestError ErrorCategory { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull recoveryActionName;
		[Export ("recoveryActionName")]
		string RecoveryActionName { get; }

		// -(instancetype _Nonnull)initWithRecoveryDescription:(NSString * _Nonnull)description optionDescriptions:(NSArray<NSString *> * _Nonnull)optionDescriptions category:(FBSDKGraphRequestError)category recoveryActionName:(NSString * _Nonnull)recoveryActionName __attribute__((objc_designated_initializer));
		[Export ("initWithRecoveryDescription:optionDescriptions:category:recoveryActionName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string description, string[] optionDescriptions, FBSDKGraphRequestError category, string recoveryActionName);
	}

	// @protocol FBSDKErrorReporting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKErrorReporting
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(void)saveError:(NSInteger)errorCode errorDomain:(NSErrorDomain _Nonnull)errorDomain message:(NSString * _Nullable)message;
		[Abstract]
		[Export ("saveError:errorDomain:message:")]
		void SaveError (nint errorCode, string errorDomain, [NullAllowed] string message);
	}

	// @interface FBSDKErrorReporter : NSObject <FBSDKErrorReporting>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKErrorReporter : IFBSDKErrorReporting
	{
		// @property (readonly, nonatomic, class) FBSDKErrorReporter * _Nonnull shared;
		[Static]
		[Export ("shared")]
		FBSDKErrorReporter Shared { get; }

		// @property (nonatomic, strong) id<FBSDKGraphRequestFactory> _Nonnull graphRequestFactory;
		[Export ("graphRequestFactory", ArgumentSemantic.Strong)]
		FBSDKGraphRequestFactory GraphRequestFactory { get; set; }

		// @property (nonatomic, strong) id<FBSDKFileManaging> _Nonnull fileManager;
		[Export ("fileManager", ArgumentSemantic.Strong)]
		FBSDKFileManaging FileManager { get; set; }

		// @property (nonatomic, strong) id<FBSDKSettings> _Nonnull settings;
		[Export ("settings", ArgumentSemantic.Strong)]
		FBSDKSettings Settings { get; set; }

		// @property (nonatomic, strong) Class<FBSDKFileDataExtracting> _Nonnull dataExtractor;
		[Export ("dataExtractor", ArgumentSemantic.Strong)]
		FBSDKFileDataExtracting DataExtractor { get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull directoryPath;
		[Export ("directoryPath", ArgumentSemantic.Strong)]
		string DirectoryPath { get; }

		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// -(void)saveError:(NSInteger)errorCode errorDomain:(NSErrorDomain _Nonnull)errorDomain message:(NSString * _Nullable)message;
		[Export ("saveError:errorDomain:message:")]
		void SaveError (nint errorCode, string errorDomain, [NullAllowed] string message);

		// -(instancetype _Nonnull)initWithGraphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory fileManager:(id<FBSDKFileManaging> _Nonnull)fileManager settings:(id<FBSDKSettings> _Nonnull)settings fileDataExtractor:(Class<FBSDKFileDataExtracting> _Nonnull)dataExtractor;
		[Export ("initWithGraphRequestFactory:fileManager:settings:fileDataExtractor:")]
		NativeHandle Constructor (FBSDKGraphRequestFactory graphRequestFactory, FBSDKFileManaging fileManager, FBSDKSettings settings, FBSDKFileDataExtracting dataExtractor);

		// -(void)enable;
		[Export ("enable")]
		void Enable ();
	}

	// @protocol FBSDKEventProcessing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKEventProcessing
	{
		// @required -(NSString * _Nonnull)processSuggestedEvents:(NSString * _Nonnull)textFeature denseData:(float * _Nullable)denseData;
		[Abstract]
		[Export ("processSuggestedEvents:denseData:")]
		unsafe string ProcessSuggestedEvents (string textFeature, [NullAllowed] float* denseData);

		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();
	}

	// typedef void (^FBSDKFeatureManagerBlock)(BOOL);
	delegate void FBSDKFeatureManagerBlock (bool arg0);

	// @protocol FBSDKFeatureChecking
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKFeatureChecking
	{
		// @required -(BOOL)isEnabled:(FBSDKFeature)feature;
		[Abstract]
		[Export ("isEnabled:")]
		bool IsEnabled (FBSDKFeature feature);

		// @required -(void)checkFeature:(FBSDKFeature)feature completionBlock:(FBSDKFeatureManagerBlock _Nonnull)completionBlock;
		[Abstract]
		[Export ("checkFeature:completionBlock:")]
		void CheckFeature (FBSDKFeature feature, FBSDKFeatureManagerBlock completionBlock);
	}

	// @protocol FBSDKFeatureDisabling
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKFeatureDisabling
	{
		// @required -(void)disableFeature:(FBSDKFeature)feature;
		[Abstract]
		[Export ("disableFeature:")]
		void DisableFeature (FBSDKFeature feature);
	}

	// @protocol FBSDKFeatureExtracting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKFeatureExtracting
	{
		// @required +(float * _Nullable)getDenseFeatures:(NSDictionary<NSString *,id> * _Nonnull)viewHierarchy;
		[Static, Abstract]
		[Export ("getDenseFeatures:")]
		[return: NullAllowed]
		unsafe float* GetDenseFeatures (NSDictionary<NSString, NSObject> viewHierarchy);

		// @required +(NSString * _Nonnull)getTextFeature:(NSString * _Nonnull)text withScreenName:(NSString * _Nonnull)screenName;
		[Static, Abstract]
		[Export ("getTextFeature:withScreenName:")]
		string GetTextFeature (string text, string screenName);

		// @required +(void)loadRulesForKey:(NSString * _Nonnull)useCaseKey;
		[Static, Abstract]
		[Export ("loadRulesForKey:")]
		void LoadRulesForKey (string useCaseKey);
	}

	// @protocol FBSDKRulesFromKeyProvider
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKRulesFromKeyProvider
	{
		// @required -(NSDictionary<NSString *,id> * _Nullable)getRulesForKey:(NSString * _Nonnull)useCase;
		[Abstract]
		[Export ("getRulesForKey:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSObject> GetRulesForKey (string useCase);
	}

	// @interface FBSDKFeatureExtractor : NSObject <FBSDKFeatureExtracting>
	[BaseType (typeof(NSObject))]
	interface FBSDKFeatureExtractor : IFBSDKFeatureExtracting
	{
		// @property (nonatomic, class) id<FBSDKRulesFromKeyProvider> _Nullable rulesFromKeyProvider;
		[Static]
		[NullAllowed, Export ("rulesFromKeyProvider", ArgumentSemantic.Assign)]
		FBSDKRulesFromKeyProvider RulesFromKeyProvider { get; set; }

		// +(void)configureWithRulesFromKeyProvider:(id<FBSDKRulesFromKeyProvider> _Nonnull)rulesFromKeyProvider __attribute__((swift_name("configure(rulesFromKeyProvider:)")));
		[Static]
		[Export ("configureWithRulesFromKeyProvider:")]
		void ConfigureWithRulesFromKeyProvider (FBSDKRulesFromKeyProvider rulesFromKeyProvider);

		// +(void)loadRulesForKey:(NSString * _Nonnull)useCaseKey;
		[Static]
		[Export ("loadRulesForKey:")]
		void LoadRulesForKey (string useCaseKey);

		// +(NSString * _Nonnull)getTextFeature:(NSString * _Nonnull)text withScreenName:(NSString * _Nonnull)screenName;
		[Static]
		[Export ("getTextFeature:withScreenName:")]
		string GetTextFeature (string text, string screenName);

		// +(float * _Nullable)getDenseFeatures:(NSDictionary<NSString *,id> * _Nonnull)viewHierarchy;
		[Static]
		[Export ("getDenseFeatures:")]
		[return: NullAllowed]
		unsafe float* GetDenseFeatures (NSDictionary<NSString, NSObject> viewHierarchy);
	}

	// typedef void (^FBSDKGKManagerBlock)(NSError * _Nullable);
	delegate void FBSDKGKManagerBlock ([NullAllowed] NSError arg0);

	// @protocol FBSDKGateKeeperManaging
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKGateKeeperManaging
	{
		// @required +(BOOL)boolForKey:(NSString * _Nonnull)key defaultValue:(BOOL)defaultValue;
		[Static, Abstract]
		[Export ("boolForKey:defaultValue:")]
		bool BoolForKey (string key, bool defaultValue);

		// @required +(void)loadGateKeepers:(FBSDKGKManagerBlock _Nonnull)completionBlock;
		[Static, Abstract]
		[Export ("loadGateKeepers:")]
		void LoadGateKeepers (FBSDKGKManagerBlock completionBlock);
	}

	// typedef void (^FBSDKGKManagerBlock)(NSError * _Nullable);
	delegate void FBSDKGKManagerBlock ([NullAllowed] NSError arg0);

	// @interface FBSDKGateKeeperManager : NSObject <FBSDKGateKeeperManaging>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGateKeeperManager : IFBSDKGateKeeperManaging
	{
		// +(void)configureWithSettings:(id<FBSDKSettings> _Nonnull)settings graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)graphRequestConnectionFactory store:(id<FBSDKDataPersisting> _Nonnull)store __attribute__((swift_name("configure(settings:graphRequestFactory:graphRequestConnectionFactory:store:)")));
		[Static]
		[Export ("configureWithSettings:graphRequestFactory:graphRequestConnectionFactory:store:")]
		void ConfigureWithSettings (FBSDKSettings settings, FBSDKGraphRequestFactory graphRequestFactory, FBSDKGraphRequestConnectionFactory graphRequestConnectionFactory, FBSDKDataPersisting store);

		// +(BOOL)boolForKey:(NSString * _Nonnull)key defaultValue:(BOOL)defaultValue;
		[Static]
		[Export ("boolForKey:defaultValue:")]
		bool BoolForKey (string key, bool defaultValue);

		// +(void)loadGateKeepers:(FBSDKGKManagerBlock _Nullable)completionBlock;
		[Static]
		[Export ("loadGateKeepers:")]
		void LoadGateKeepers ([NullAllowed] FBSDKGKManagerBlock completionBlock);
	}

	// @protocol FBSDKGraphErrorRecoveryProcessorDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FBSDKGraphErrorRecoveryProcessorDelegate
	{
		// @required -(void)processorDidAttemptRecovery:(FBSDKGraphErrorRecoveryProcessor * _Nonnull)processor didRecover:(BOOL)didRecover error:(NSError * _Nullable)error;
		[Abstract]
		[Export ("processorDidAttemptRecovery:didRecover:error:")]
		void ProcessorDidAttemptRecovery (FBSDKGraphErrorRecoveryProcessor processor, bool didRecover, [NullAllowed] NSError error);

		// @optional -(BOOL)processorWillProcessError:(FBSDKGraphErrorRecoveryProcessor * _Nonnull)processor error:(NSError * _Nullable)error;
		[Export ("processorWillProcessError:error:")]
		bool ProcessorWillProcessError (FBSDKGraphErrorRecoveryProcessor processor, [NullAllowed] NSError error);
	}

	// @interface FBSDKGraphErrorRecoveryProcessor : NSObject
	[BaseType (typeof(NSObject))]
	interface FBSDKGraphErrorRecoveryProcessor
	{
		// -(instancetype _Nonnull)initWithAccessTokenString:(NSString * _Nonnull)accessTokenString;
		[Export ("initWithAccessTokenString:")]
		NativeHandle Constructor (string accessTokenString);

		// -(BOOL)processError:(NSError * _Nonnull)error request:(id<FBSDKGraphRequest> _Nonnull)request delegate:(id<FBSDKGraphErrorRecoveryProcessorDelegate> _Nullable)delegate;
		[Export ("processError:request:delegate:")]
		bool ProcessError (NSError error, FBSDKGraphRequest request, [NullAllowed] FBSDKGraphErrorRecoveryProcessorDelegate @delegate);
	}

	// @interface FBSDKGraphRequestConnectionFactory : NSObject <FBSDKGraphRequestConnectionFactory>
	[BaseType (typeof(NSObject))]
	interface FBSDKGraphRequestConnectionFactory : IFBSDKGraphRequestConnectionFactory
	{
	}

	// @interface FBSDKGraphRequestDataAttachment : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGraphRequestDataAttachment
	{
		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data filename:(NSString * _Nonnull)filename contentType:(NSString * _Nonnull)contentType __attribute__((objc_designated_initializer));
		[Export ("initWithData:filename:contentType:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSData data, string filename, string contentType);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull contentType;
		[Export ("contentType")]
		string ContentType { get; }

		// @property (readonly, nonatomic, strong) NSData * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		NSData Data { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull filename;
		[Export ("filename")]
		string Filename { get; }
	}

	// @protocol FBSDKGraphRequestFactory
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKGraphRequestFactory
	{
		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(FBSDKHTTPMethod _Nullable)method flags:(FBSDKGraphRequestFlags)flags forAppEvents:(BOOL)forAppEvents;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:tokenString:HTTPMethod:flags:forAppEvents:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string method, FBSDKGraphRequestFlags flags, bool forAppEvents);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(FBSDKHTTPMethod _Nullable)method flags:(FBSDKGraphRequestFlags)flags forAppEvents:(BOOL)forAppEvents useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:tokenString:HTTPMethod:flags:forAppEvents:useAlternativeDefaultDomainPrefix:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string method, FBSDKGraphRequestFlags flags, bool forAppEvents, bool useAlternativeDefaultDomainPrefix);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(FBSDKHTTPMethod _Nullable)method flags:(FBSDKGraphRequestFlags)flags;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:tokenString:HTTPMethod:flags:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string method, FBSDKGraphRequestFlags flags);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(FBSDKHTTPMethod _Nullable)method flags:(FBSDKGraphRequestFlags)flags useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:tokenString:HTTPMethod:flags:useAlternativeDefaultDomainPrefix:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string method, FBSDKGraphRequestFlags flags, bool useAlternativeDefaultDomainPrefix);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:useAlternativeDefaultDomainPrefix:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, bool useAlternativeDefaultDomainPrefix);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:")]
		FBSDKGraphRequest CreateGraphRequestWithGraphPath (string graphPath);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:useAlternativeDefaultDomainPrefix:")]
		FBSDKGraphRequest UseAlternativeDefaultDomainPrefix (string graphPath, bool useAlternativeDefaultDomainPrefix);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters HTTPMethod:(FBSDKHTTPMethod _Nonnull)method;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:HTTPMethod:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, string method);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters HTTPMethod:(FBSDKHTTPMethod _Nonnull)method useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:HTTPMethod:useAlternativeDefaultDomainPrefix:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, string method, bool useAlternativeDefaultDomainPrefix);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString version:(NSString * _Nullable)version HTTPMethod:(FBSDKHTTPMethod _Nonnull)method;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:tokenString:version:HTTPMethod:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string version, string method);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString version:(NSString * _Nullable)version HTTPMethod:(FBSDKHTTPMethod _Nonnull)method forAppEvents:(BOOL)forAppEvents;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:tokenString:version:HTTPMethod:forAppEvents:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string version, string method, bool forAppEvents);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters tokenString:(NSString * _Nullable)tokenString version:(NSString * _Nullable)version HTTPMethod:(FBSDKHTTPMethod _Nonnull)method forAppEvents:(BOOL)forAppEvents useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:tokenString:version:HTTPMethod:forAppEvents:useAlternativeDefaultDomainPrefix:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, [NullAllowed] string tokenString, [NullAllowed] string version, string method, bool forAppEvents, bool useAlternativeDefaultDomainPrefix);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters flags:(FBSDKGraphRequestFlags)flags;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:flags:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, FBSDKGraphRequestFlags flags);

		// @required -(id<FBSDKGraphRequest> _Nonnull)createGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters flags:(FBSDKGraphRequestFlags)flags useAlternativeDefaultDomainPrefix:(BOOL)useAlternativeDefaultDomainPrefix;
		[Abstract]
		[Export ("createGraphRequestWithGraphPath:parameters:flags:useAlternativeDefaultDomainPrefix:")]
		FBSDKGraphRequest Parameters (string graphPath, NSDictionary<NSString, NSObject> parameters, FBSDKGraphRequestFlags flags, bool useAlternativeDefaultDomainPrefix);
	}

	// @interface FBSDKGraphRequestFactory : NSObject <FBSDKGraphRequestFactory>
	[BaseType (typeof(NSObject))]
	interface FBSDKGraphRequestFactory : IFBSDKGraphRequestFactory
	{
	}

	// @protocol FBSDKGraphRequestPiggybackManaging
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKGraphRequestPiggybackManaging
	{
		// @required -(void)addPiggybackRequests:(id<FBSDKGraphRequestConnecting> _Nonnull)connection;
		[Abstract]
		[Export ("addPiggybackRequests:")]
		void AddPiggybackRequests (FBSDKGraphRequestConnecting connection);

		// @required -(void)addRefreshPiggyback:(id<FBSDKGraphRequestConnecting> _Nonnull)connection permissionHandler:(FBSDKGraphRequestCompletion _Nullable)permissionHandler;
		[Abstract]
		[Export ("addRefreshPiggyback:permissionHandler:")]
		void AddRefreshPiggyback (FBSDKGraphRequestConnecting connection, [NullAllowed] FBSDKGraphRequestCompletion permissionHandler);
	}

	// @protocol FBSDKImpressionLogging
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKImpressionLogging
	{
		// @required -(void)logImpressionWithIdentifier:(NSString * _Nonnull)identifier parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters;
		[Abstract]
		[Export ("logImpressionWithIdentifier:parameters:")]
		void Parameters (string identifier, [NullAllowed] NSDictionary<NSString, NSObject> parameters);
	}

	// @protocol FBSDKImpressionLoggerFactory
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKImpressionLoggerFactory
	{
		// @required -(id<FBSDKImpressionLogging> _Nonnull)makeImpressionLoggerWithEventName:(FBSDKAppEventName _Nonnull)eventName;
		[Abstract]
		[Export ("makeImpressionLoggerWithEventName:")]
		FBSDKImpressionLogging MakeImpressionLoggerWithEventName (string eventName);
	}

	// @interface FBSDKImpressionLoggerFactory : NSObject <FBSDKImpressionLoggerFactory>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKImpressionLoggerFactory : IFBSDKImpressionLoggerFactory
	{
		// @property (readonly, nonatomic) id<FBSDKGraphRequestFactory> _Nonnull graphRequestFactory;
		[Export ("graphRequestFactory")]
		FBSDKGraphRequestFactory GraphRequestFactory { get; }

		// @property (readonly, nonatomic) id<FBSDKEventLogging> _Nonnull eventLogger;
		[Export ("eventLogger")]
		FBSDKEventLogging EventLogger { get; }

		// @property (readonly, nonatomic) id<FBSDKNotificationDelivering> _Nonnull notificationCenter;
		[Export ("notificationCenter")]
		FBSDKNotificationDelivering NotificationCenter { get; }

		// @property (readonly, nonatomic) Class<FBSDKAccessTokenProviding> _Nonnull accessTokenWallet;
		[Export ("accessTokenWallet")]
		FBSDKAccessTokenProviding AccessTokenWallet { get; }

		// -(instancetype _Nonnull)initWithGraphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory eventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger notificationCenter:(id<FBSDKNotificationDelivering> _Nonnull)notificationCenter accessTokenWallet:(Class<FBSDKAccessTokenProviding> _Nonnull)accessTokenWallet __attribute__((objc_designated_initializer)) __attribute__((swift_name("init(graphRequestFactory:eventLogger:notificationCenter:accessTokenWallet:)")));
		[Export ("initWithGraphRequestFactory:eventLogger:notificationCenter:accessTokenWallet:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKGraphRequestFactory graphRequestFactory, FBSDKEventLogging eventLogger, FBSDKNotificationDelivering notificationCenter, FBSDKAccessTokenProviding accessTokenWallet);
	}

	// @protocol FBSDKIntegrityParametersProcessorProvider
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKIntegrityParametersProcessorProvider
	{
		// @required @property (nonatomic) id<FBSDKAppEventsParameterProcessing> _Nullable integrityParametersProcessor;
		[Abstract]
		[NullAllowed, Export ("integrityParametersProcessor", ArgumentSemantic.Assign)]
		FBSDKAppEventsParameterProcessing IntegrityParametersProcessor { get; set; }
	}

	// @protocol FBSDKIntegrityProcessing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKIntegrityProcessing
	{
		// @required -(BOOL)processIntegrity:(NSString * _Nullable)parameter;
		[Abstract]
		[Export ("processIntegrity:")]
		bool ProcessIntegrity ([NullAllowed] string parameter);
	}

	// @protocol FBSDKInternalURLOpener
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKInternalURLOpener
	{
		// @required -(BOOL)canOpenURL:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("canOpenURL:")]
		bool CanOpenURL (NSURL url);

		// @required -(void)openURL:(NSURL * _Nonnull)url options:(NSDictionary<UIApplicationOpenExternalURLOptionsKey,id> * _Nonnull)options completionHandler:(void (^ _Nullable)(BOOL))completion;
		[Abstract]
		[Export ("openURL:options:completionHandler:")]
		void OpenURL (NSURL url, NSDictionary<NSString, NSObject> options, [NullAllowed] Action<bool> completion);
	}

	// @protocol FBSDKInternalUtility
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKInternalUtility
	{
		// @required @property (readonly, nonatomic) BOOL isFacebookAppInstalled;
		[Abstract]
		[Export ("isFacebookAppInstalled")]
		bool IsFacebookAppInstalled { get; }

		// @required @property (readonly, nonatomic) BOOL isUnity;
		[Abstract]
		[Export ("isUnity")]
		bool IsUnity { get; }

		// @required -(NSURL * _Nullable)URLWithScheme:(NSString * _Nonnull)scheme host:(NSString * _Nonnull)host path:(NSString * _Nonnull)path queryParameters:(NSDictionary<NSString *,NSString *> * _Nonnull)queryParameters error:(NSError * _Nullable * _Nullable)errorRef;
		[Abstract]
		[Export ("URLWithScheme:host:path:queryParameters:error:")]
		[return: NullAllowed]
		NSURL URLWithScheme (string scheme, string host, string path, NSDictionary<NSString, NSString> queryParameters, [NullAllowed] out NSError errorRef);

		// @required -(NSURL * _Nullable)appURLWithHost:(NSString * _Nonnull)host path:(NSString * _Nonnull)path queryParameters:(NSDictionary<NSString *,NSString *> * _Nonnull)queryParameters error:(NSError * _Nullable * _Nullable)errorRef;
		[Abstract]
		[Export ("appURLWithHost:path:queryParameters:error:")]
		[return: NullAllowed]
		NSURL AppURLWithHost (string host, string path, NSDictionary<NSString, NSString> queryParameters, [NullAllowed] out NSError errorRef);

		// @required -(NSURL * _Nullable)facebookURLWithHostPrefix:(NSString * _Nonnull)hostPrefix path:(NSString * _Nonnull)path queryParameters:(NSDictionary<NSString *,NSString *> * _Nonnull)queryParameters error:(NSError * _Nullable * _Nullable)errorRef __attribute__((swift_name("facebookURL(hostPrefix:path:queryParameters:)")));
		[Abstract]
		[Export ("facebookURLWithHostPrefix:path:queryParameters:error:")]
		[return: NullAllowed]
		NSURL FacebookURLWithHostPrefix (string hostPrefix, string path, NSDictionary<NSString, NSString> queryParameters, [NullAllowed] out NSError errorRef);

		// @required -(void)registerTransientObject:(id _Nonnull)object;
		[Abstract]
		[Export ("registerTransientObject:")]
		void RegisterTransientObject (NSObject @object);

		// @required -(void)unregisterTransientObject:(__weak id _Nonnull)object;
		[Abstract]
		[Export ("unregisterTransientObject:")]
		void UnregisterTransientObject (NSObject @object);

		// @required -(void)checkRegisteredCanOpenURLScheme:(NSString * _Nonnull)urlScheme;
		[Abstract]
		[Export ("checkRegisteredCanOpenURLScheme:")]
		void CheckRegisteredCanOpenURLScheme (string urlScheme);

		// @required -(void)validateURLSchemes;
		[Abstract]
		[Export ("validateURLSchemes")]
		void ValidateURLSchemes ();

		// @required -(void)extendDictionaryWithDataProcessingOptions:(NSMutableDictionary<NSString *,NSString *> * _Nonnull)parameters;
		[Abstract]
		[Export ("extendDictionaryWithDataProcessingOptions:")]
		void ExtendDictionaryWithDataProcessingOptions (NSMutableDictionary<NSString, NSString> parameters);

		// @required -(NSString * _Nullable)hexadecimalStringFromData:(NSData * _Nonnull)data;
		[Abstract]
		[Export ("hexadecimalStringFromData:")]
		[return: NullAllowed]
		string HexadecimalStringFromData (NSData data);

		// @required -(void)validateAppID;
		[Abstract]
		[Export ("validateAppID")]
		void ValidateAppID ();

		// @required -(NSString * _Nonnull)validateRequiredClientAccessToken;
		[Abstract]
		[Export ("validateRequiredClientAccessToken")]
		[Verify (MethodToProperty)]
		string ValidateRequiredClientAccessToken { get; }

		// @required -(void)extractPermissionsFromResponse:(NSDictionary<NSString *,id> * _Nonnull)responseObject grantedPermissions:(NSMutableSet<NSString *> * _Nonnull)grantedPermissions declinedPermissions:(NSMutableSet<NSString *> * _Nonnull)declinedPermissions expiredPermissions:(NSMutableSet<NSString *> * _Nonnull)expiredPermissions;
		[Abstract]
		[Export ("extractPermissionsFromResponse:grantedPermissions:declinedPermissions:expiredPermissions:")]
		void ExtractPermissionsFromResponse (NSDictionary<NSString, NSObject> responseObject, NSMutableSet<NSString> grantedPermissions, NSMutableSet<NSString> declinedPermissions, NSMutableSet<NSString> expiredPermissions);

		// @required -(void)validateFacebookReservedURLSchemes;
		[Abstract]
		[Export ("validateFacebookReservedURLSchemes")]
		void ValidateFacebookReservedURLSchemes ();

		// @required -(void)validateDomainConfiguration;
		[Abstract]
		[Export ("validateDomainConfiguration")]
		void ValidateDomainConfiguration ();

		// @required -(NSDictionary<NSString *,id> * _Nonnull)parametersFromFBURL:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("parametersFromFBURL:")]
		NSDictionary<NSString, NSObject> ParametersFromFBURL (NSURL url);

		// @required @property (readonly, nonatomic, strong) NSBundle * _Nonnull bundleForStrings;
		[Abstract]
		[Export ("bundleForStrings", ArgumentSemantic.Strong)]
		NSBundle BundleForStrings { get; }

		// @required -(UIViewController * _Nullable)topMostViewController;
		[Abstract]
		[NullAllowed, Export ("topMostViewController")]
		[Verify (MethodToProperty)]
		UIViewController TopMostViewController { get; }
	}

	// @protocol FBSDKURLHosting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKURLHosting
	{
		// @required -(NSURL * _Nullable)appURLWithHost:(NSString * _Nonnull)host path:(NSString * _Nonnull)path queryParameters:(NSDictionary<NSString *,NSString *> * _Nonnull)queryParameters error:(NSError * _Nullable * _Nullable)errorRef;
		[Abstract]
		[Export ("appURLWithHost:path:queryParameters:error:")]
		[return: NullAllowed]
		NSURL AppURLWithHost (string host, string path, NSDictionary<NSString, NSString> queryParameters, [NullAllowed] out NSError errorRef);

		// @required -(NSURL * _Nullable)facebookURLWithHostPrefix:(NSString * _Nonnull)hostPrefix path:(NSString * _Nonnull)path queryParameters:(NSDictionary<NSString *,NSString *> * _Nonnull)queryParameters error:(NSError * _Nullable * _Nullable)errorRef __attribute__((swift_name("facebookURL(hostPrefix:path:queryParameters:)")));
		[Abstract]
		[Export ("facebookURLWithHostPrefix:path:queryParameters:error:")]
		[return: NullAllowed]
		NSURL FacebookURLWithHostPrefix (string hostPrefix, string path, NSDictionary<NSString, NSString> queryParameters, [NullAllowed] out NSError errorRef);
	}

	// @interface FBSDKInternalUtility : NSObject <FBSDKAppAvailabilityChecker, FBSDKAppURLSchemeProviding, FBSDKInternalUtility, FBSDKURLHosting, _FBSDKWindowFinding>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKInternalUtility : IFBSDKAppAvailabilityChecker, IFBSDKAppURLSchemeProviding, IFBSDKInternalUtility, IFBSDKURLHosting, I_FBSDKWindowFinding
	{
		// @property (readonly, class) FBSDKInternalUtility * _Nonnull sharedUtility;
		[Static]
		[Export ("sharedUtility")]
		FBSDKInternalUtility SharedUtility { get; }

		// @property (readonly, nonatomic, strong) NSBundle * _Nonnull bundleForStrings;
		[Export ("bundleForStrings", ArgumentSemantic.Strong)]
		NSBundle BundleForStrings { get; }

		// -(BOOL)isBrowserURL:(NSURL * _Nonnull)URL;
		[Export ("isBrowserURL:")]
		bool IsBrowserURL (NSURL URL);

		// -(BOOL)object:(id _Nonnull)object isEqualToObject:(id _Nonnull)other;
		[Export ("object:isEqualToObject:")]
		bool Object (NSObject @object, NSObject other);

		// -(UIViewController * _Nullable)viewControllerForView:(UIView * _Nonnull)view;
		[Export ("viewControllerForView:")]
		[return: NullAllowed]
		UIViewController ViewControllerForView (UIView view);

		// -(BOOL)isRegisteredURLScheme:(NSString * _Nonnull)urlScheme;
		[Export ("isRegisteredURLScheme:")]
		bool IsRegisteredURLScheme (string urlScheme);

		// -(UIViewController * _Nullable)topMostViewController;
		[NullAllowed, Export ("topMostViewController")]
		[Verify (MethodToProperty)]
		UIViewController TopMostViewController { get; }

		// -(UIWindow * _Nullable)findWindow;
		[NullAllowed, Export ("findWindow")]
		[Verify (MethodToProperty)]
		UIWindow FindWindow { get; }

		// @property (readonly, assign, nonatomic) BOOL isMessengerAppInstalled;
		[Export ("isMessengerAppInstalled")]
		bool IsMessengerAppInstalled { get; }

		// -(BOOL)isRegisteredCanOpenURLScheme:(NSString * _Nonnull)urlScheme;
		[Export ("isRegisteredCanOpenURLScheme:")]
		bool IsRegisteredCanOpenURLScheme (string urlScheme);

		// -(void)configureWithInfoDictionaryProvider:(id<FBSDKInfoDictionaryProviding> _Nonnull)infoDictionaryProvider loggerFactory:(id<__FBSDKLoggerCreating> _Nonnull)loggerFactory settings:(id<FBSDKSettings> _Nonnull)settings errorFactory:(id<FBSDKErrorCreating> _Nonnull)errorFactory __attribute__((swift_name("configure(infoDictionaryProvider:loggerFactory:settings:errorFactory:)")));
		[Export ("configureWithInfoDictionaryProvider:loggerFactory:settings:errorFactory:")]
		void ConfigureWithInfoDictionaryProvider (FBSDKInfoDictionaryProviding infoDictionaryProvider, __FBSDKLoggerCreating loggerFactory, FBSDKSettings settings, FBSDKErrorCreating errorFactory);
	}

	// @interface FBSDKInstrumentManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKInstrumentManager
	{
		// @property (readonly, nonatomic, class) FBSDKInstrumentManager * _Nonnull shared;
		[Static]
		[Export ("shared")]
		FBSDKInstrumentManager Shared { get; }

		// -(void)configureWithFeatureChecker:(id<FBSDKFeatureChecking> _Nonnull)featureChecker settings:(id<FBSDKSettings> _Nonnull)settings crashObserver:(id<FBSDKCrashObserving> _Nonnull)crashObserver errorReporter:(id<FBSDKErrorReporting> _Nonnull)errorReporter crashHandler:(id<FBSDKCrashHandler> _Nonnull)crashHandler __attribute__((swift_name("configure(featureChecker:settings:crashObserver:errorReporter:crashHandler:)")));
		[Export ("configureWithFeatureChecker:settings:crashObserver:errorReporter:crashHandler:")]
		void ConfigureWithFeatureChecker (FBSDKFeatureChecking featureChecker, FBSDKSettings settings, FBSDKCrashObserving crashObserver, FBSDKErrorReporting errorReporter, FBSDKCrashHandler crashHandler);

		// -(void)enable;
		[Export ("enable")]
		void Enable ();
	}

	// @protocol FBSDKKeychainStore
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKKeychainStore
	{
		// @required -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("stringForKey:")]
		[return: NullAllowed]
		string StringForKey (string key);

		// @required -(NSDictionary<NSString *,id> * _Nullable)dictionaryForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("dictionaryForKey:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSObject> DictionaryForKey (string key);

		// @required -(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key accessibility:(CFTypeRef _Nullable)accessibility;
		[Abstract]
		[Export ("setString:forKey:accessibility:")]
		unsafe bool SetString ([NullAllowed] string value, string key, [NullAllowed] void* accessibility);

		// @required -(BOOL)setDictionary:(NSDictionary<NSString *,id> * _Nullable)value forKey:(NSString * _Nonnull)key accessibility:(CFTypeRef _Nullable)accessibility;
		[Abstract]
		[Export ("setDictionary:forKey:accessibility:")]
		unsafe bool SetDictionary ([NullAllowed] NSDictionary<NSString, NSObject> value, string key, [NullAllowed] void* accessibility);
	}

	// @interface FBSDKKeychainStore : NSObject <FBSDKKeychainStore>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKKeychainStore : IFBSDKKeychainStore
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull service;
		[Export ("service")]
		string Service { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable accessGroup;
		[NullAllowed, Export ("accessGroup")]
		string AccessGroup { get; }

		// -(instancetype _Nonnull)initWithService:(NSString * _Nonnull)service accessGroup:(NSString * _Nullable)accessGroup __attribute__((objc_designated_initializer));
		[Export ("initWithService:accessGroup:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string service, [NullAllowed] string accessGroup);

		// -(BOOL)setData:(NSData * _Nullable)value forKey:(NSString * _Nonnull)key accessibility:(CFTypeRef _Nonnull)accessibility;
		[Export ("setData:forKey:accessibility:")]
		unsafe bool SetData ([NullAllowed] NSData value, string key, void* accessibility);

		// -(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key;
		[Export ("dataForKey:")]
		[return: NullAllowed]
		NSData DataForKey (string key);

		// -(NSMutableDictionary<NSString *,id> * _Nonnull)queryForKey:(NSString * _Nonnull)key;
		[Export ("queryForKey:")]
		NSMutableDictionary<NSString, NSObject> QueryForKey (string key);
	}

	// @protocol FBSDKKeychainStoreProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKKeychainStoreProviding
	{
		// @required -(id<FBSDKKeychainStore> _Nonnull)createKeychainStoreWithService:(NSString * _Nonnull)service accessGroup:(NSString * _Nullable)accessGroup __attribute__((swift_name("createKeychainStore(service:accessGroup:)")));
		[Abstract]
		[Export ("createKeychainStoreWithService:accessGroup:")]
		FBSDKKeychainStore AccessGroup (string service, [NullAllowed] string accessGroup);
	}

	// @interface FBSDKLocation : NSObject <NSCopying, NSObject, NSSecureCoding>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKLocation : INSCopying, INSSecureCoding
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull id;
		[Export ("id", ArgumentSemantic.Strong)]
		string Id { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// +(instancetype _Nullable)locationFromDictionary:(NSDictionary<NSString *,NSString *> * _Nonnull)dictionary;
		[Static]
		[Export ("locationFromDictionary:")]
		[return: NullAllowed]
		FBSDKLocation LocationFromDictionary (NSDictionary<NSString, NSString> dictionary);
	}

	// @interface FBSDKLogger : NSObject <FBSDKLogging>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKLogger : IFBSDKLogging
	{
		// +(void)singleShotLogEntry:(FBSDKLoggingBehavior _Nonnull)loggingBehavior logEntry:(NSString * _Nonnull)logEntry;
		[Static]
		[Export ("singleShotLogEntry:logEntry:")]
		void SingleShotLogEntry (string loggingBehavior, string logEntry);
	}

	// @interface FBSDKLoggerFactory : NSObject <__FBSDKLoggerCreating>
	[BaseType (typeof(NSObject))]
	interface FBSDKLoggerFactory : I__FBSDKLoggerCreating
	{
	}

	// @interface FBSDKLoginTooltip : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKLoginTooltip
	{
		// @property (readonly, getter = isEnabled, assign, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text enabled:(BOOL)enabled __attribute__((objc_designated_initializer));
		[Export ("initWithText:enabled:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string text, bool enabled);
	}

	// @protocol FBSDKMacCatalystDetermining
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKMacCatalystDetermining
	{
		// @required @property (readonly) BOOL fb_isMacCatalystApp;
		[Abstract]
		[Export ("fb_isMacCatalystApp")]
		bool Fb_isMacCatalystApp { get; }
	}

	// @interface FBSDKMath : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKMath
	{
		// +(CGSize)ceilForSize:(CGSize)value;
		[Static]
		[Export ("ceilForSize:")]
		CGSize CeilForSize (CGSize value);

		// +(CGSize)floorForSize:(CGSize)value;
		[Static]
		[Export ("floorForSize:")]
		CGSize FloorForSize (CGSize value);

		// +(NSUInteger)hashWithInteger:(NSUInteger)value;
		[Static]
		[Export ("hashWithInteger:")]
		nuint HashWithInteger (nuint value);

		// +(NSUInteger)hashWithIntegerArray:(NSUInteger * _Nonnull)values count:(NSUInteger)count;
		[Static]
		[Export ("hashWithIntegerArray:count:")]
		unsafe nuint HashWithIntegerArray (nuint* values, nuint count);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NS_SWIFT_NAME(MeasurementEvent) const NSNotificationName FBSDKMeasurementEventNotification __attribute__((swift_name("MeasurementEvent")));
		[Field ("FBSDKMeasurementEventNotification", "__Internal")]
		NSString FBSDKMeasurementEventNotification { get; }

		// extern NS_SWIFT_NAME(AppLinkParseEventName) NSString *const FBSDKAppLinkParseEventName __attribute__((swift_name("AppLinkParseEventName")));
		[Field ("FBSDKAppLinkParseEventName", "__Internal")]
		NSString FBSDKAppLinkParseEventName { get; }

		// extern NS_SWIFT_NAME(AppLinkNavigateInEventName) NSString *const FBSDKAppLinkNavigateInEventName __attribute__((swift_name("AppLinkNavigateInEventName")));
		[Field ("FBSDKAppLinkNavigateInEventName", "__Internal")]
		NSString FBSDKAppLinkNavigateInEventName { get; }

		// extern NS_SWIFT_NAME(AppLinkNavigateOutEventName) NSString *const FBSDKAppLinkNavigateOutEventName __attribute__((swift_name("AppLinkNavigateOutEventName")));
		[Field ("FBSDKAppLinkNavigateOutEventName", "__Internal")]
		NSString FBSDKAppLinkNavigateOutEventName { get; }

		// extern NS_SWIFT_NAME(AppLinkNavigateBackToReferrerEventName) NSString *const FBSDKAppLinkNavigateBackToReferrerEventName __attribute__((swift_name("AppLinkNavigateBackToReferrerEventName")));
		[Field ("FBSDKAppLinkNavigateBackToReferrerEventName", "__Internal")]
		NSString FBSDKAppLinkNavigateBackToReferrerEventName { get; }
	}

	// @interface FBSDKMeasurementEventListener : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKMeasurementEventListener
	{
		// -(instancetype _Nonnull)initWithEventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger sourceApplicationTracker:(id<FBSDKSourceApplicationTracking> _Nonnull)sourceApplicationTracker;
		[Export ("initWithEventLogger:sourceApplicationTracker:")]
		NativeHandle Constructor (FBSDKEventLogging eventLogger, FBSDKSourceApplicationTracking sourceApplicationTracker);

		// -(void)registerForAppLinkMeasurementEvents;
		[Export ("registerForAppLinkMeasurementEvents")]
		void RegisterForAppLinkMeasurementEvents ();
	}

	// @protocol FBSDKMetadataIndexing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKMetadataIndexing
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();
	}

	// @interface FBSDKMetadataIndexer : NSObject <FBSDKMetadataIndexing>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKMetadataIndexer : IFBSDKMetadataIndexing
	{
		// -(instancetype _Nonnull)initWithUserDataStore:(id<FBSDKUserDataPersisting> _Nonnull)userDataStore swizzler:(Class<FBSDKSwizzling> _Nonnull)swizzler __attribute__((objc_designated_initializer));
		[Export ("initWithUserDataStore:swizzler:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKUserDataPersisting userDataStore, FBSDKSwizzling swizzler);

		// -(void)enable;
		[Export ("enable")]
		void Enable ();
	}

	// @interface FBSDKModelManager : NSObject <FBSDKEventProcessing, FBSDKIntegrityParametersProcessorProvider, FBSDKIntegrityProcessing, FBSDKRulesFromKeyProvider>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKModelManager : IFBSDKEventProcessing, IFBSDKIntegrityParametersProcessorProvider, IFBSDKIntegrityProcessing, IFBSDKRulesFromKeyProvider
	{
		// @property (readonly, class) FBSDKModelManager * _Nonnull shared;
		[Static]
		[Export ("shared")]
		FBSDKModelManager Shared { get; }

		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(NSData * _Nullable)getWeightsForKey:(NSString * _Nonnull)useCase;
		[Export ("getWeightsForKey:")]
		[return: NullAllowed]
		NSData GetWeightsForKey (string useCase);

		// -(NSArray<NSNumber *> * _Nullable)getThresholdsForKey:(NSString * _Nonnull)useCase;
		[Export ("getThresholdsForKey:")]
		[return: NullAllowed]
		NSNumber[] GetThresholdsForKey (string useCase);

		// -(BOOL)processIntegrity:(NSString * _Nullable)param;
		[Export ("processIntegrity:")]
		bool ProcessIntegrity ([NullAllowed] string param);

		// -(NSString * _Nonnull)processSuggestedEvents:(NSString * _Nonnull)textFeature denseData:(float * _Nullable)denseData;
		[Export ("processSuggestedEvents:denseData:")]
		unsafe string ProcessSuggestedEvents (string textFeature, [NullAllowed] float* denseData);

		// -(void)configureWithFeatureChecker:(id<FBSDKFeatureChecking> _Nonnull)featureChecker graphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory fileManager:(id<FBSDKFileManaging> _Nonnull)fileManager store:(id<FBSDKDataPersisting> _Nonnull)store getAppID:(NSString * _Nonnull (^ _Nonnull)(void))getAppID dataExtractor:(Class<FBSDKFileDataExtracting> _Nonnull)dataExtractor gateKeeperManager:(Class<FBSDKGateKeeperManaging> _Nonnull)gateKeeperManager suggestedEventsIndexer:(id<FBSDKSuggestedEventsIndexer> _Nonnull)suggestedEventsIndexer featureExtractor:(Class<FBSDKFeatureExtracting> _Nonnull)featureExtractor __attribute__((swift_name("configure(featureChecker:graphRequestFactory:fileManager:store:getAppID:dataExtractor:gateKeeperManager:suggestedEventsIndexer:featureExtractor:)")));
		[Export ("configureWithFeatureChecker:graphRequestFactory:fileManager:store:getAppID:dataExtractor:gateKeeperManager:suggestedEventsIndexer:featureExtractor:")]
		void ConfigureWithFeatureChecker (FBSDKFeatureChecking featureChecker, FBSDKGraphRequestFactory graphRequestFactory, FBSDKFileManaging fileManager, FBSDKDataPersisting store, Func<NSString> getAppID, FBSDKFileDataExtracting dataExtractor, FBSDKGateKeeperManaging gateKeeperManager, FBSDKSuggestedEventsIndexer suggestedEventsIndexer, FBSDKFeatureExtracting featureExtractor);
	}

	// @protocol FBSDKMutableCopying <NSCopying, NSObject, NSMutableCopying>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKMutableCopying : INSCopying, INSMutableCopying
	{
		// @required -(id _Nonnull)mutableCopy;
		[Abstract]
		[Export ("mutableCopy")]
		[Verify (MethodToProperty)]
		NSObject MutableCopy { get; }
	}

	// @protocol FBSDKNetworkErrorChecking
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKNetworkErrorChecking
	{
		// @required -(BOOL)isNetworkError:(NSError *)error;
		[Abstract]
		[Export ("isNetworkError:")]
		bool IsNetworkError (NSError error);
	}

	// @interface FBSDKNetworkErrorChecker : NSObject <FBSDKNetworkErrorChecking>
	[BaseType (typeof(NSObject))]
	interface FBSDKNetworkErrorChecker : IFBSDKNetworkErrorChecking
	{
	}

	// @protocol FBSDKObjectDecoding <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKObjectDecoding
	{
		// @required -(id _Nullable)decodeObjectOfClass:(Class _Nonnull)aClass forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("decodeObjectOfClass:forKey:")]
		[return: NullAllowed]
		NSObject DecodeObjectOfClass (Class aClass, string key);

		// @required -(id _Nullable)decodeObjectOfClasses:(NSSet<Class> * _Nonnull)classes forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("decodeObjectOfClasses:forKey:")]
		[return: NullAllowed]
		NSObject DecodeObjectOfClasses (NSSet<Class> classes, string key);
	}

	// @protocol FBSDKOperatingSystemVersionComparing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKOperatingSystemVersionComparing
	{
		// @required -(BOOL)fb_isOperatingSystemAtLeastVersion:(NSOperatingSystemVersion)version __attribute__((swift_name("fb_isOperatingSystemAtLeast(_:)")));
		[Abstract]
		[Export ("fb_isOperatingSystemAtLeastVersion:")]
		bool Fb_isOperatingSystemAtLeastVersion (NSOperatingSystemVersion version);
	}

	// @protocol FBSDKPasteboard
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKPasteboard
	{
		// @required @property (readonly, nonatomic) NSString * _Nonnull name;
		[Abstract]
		[Export ("name")]
		string Name { get; }

		// @required @property (readonly, nonatomic) BOOL _isGeneralPasteboard;
		[Abstract]
		[Export ("_isGeneralPasteboard")]
		bool _isGeneralPasteboard { get; }

		// @required -(NSData * _Nullable)dataForPasteboardType:(NSString * _Nonnull)pasteboardType;
		[Abstract]
		[Export ("dataForPasteboardType:")]
		[return: NullAllowed]
		NSData DataForPasteboardType (string pasteboardType);

		// @required -(void)setData:(NSData * _Nonnull)data forPasteboardType:(NSString * _Nonnull)pasteboardType;
		[Abstract]
		[Export ("setData:forPasteboardType:")]
		void SetData (NSData data, string pasteboardType);
	}

	// @protocol FBSDKPaymentObserving
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKPaymentObserving
	{
		// @required -(void)startObservingTransactions __attribute__((swift_name("startObservingTransactions()")));
		[Abstract]
		[Export ("startObservingTransactions")]
		void StartObservingTransactions ();

		// @required -(void)stopObservingTransactions __attribute__((swift_name("stopObservingTransactions()")));
		[Abstract]
		[Export ("stopObservingTransactions")]
		void StopObservingTransactions ();
	}

	// @interface FBSDKPaymentProductRequestor : NSObject <SKProductsRequestDelegate>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKPaymentProductRequestor : ISKProductsRequestDelegate
	{
		// -(instancetype _Nonnull)initWithTransaction:(SKPaymentTransaction * _Nonnull)transaction settings:(id<FBSDKSettings> _Nonnull)settings eventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger gateKeeperManager:(Class<FBSDKGateKeeperManaging> _Nonnull)gateKeeperManager store:(id<FBSDKDataPersisting> _Nonnull)store loggerFactory:(id<__FBSDKLoggerCreating> _Nonnull)loggerFactory productsRequestFactory:(id<FBSDKProductsRequestCreating> _Nonnull)productRequestFactory appStoreReceiptProvider:(id<FBSDKAppStoreReceiptProviding> _Nonnull)receiptProvider;
		[Export ("initWithTransaction:settings:eventLogger:gateKeeperManager:store:loggerFactory:productsRequestFactory:appStoreReceiptProvider:")]
		NativeHandle Constructor (SKPaymentTransaction transaction, FBSDKSettings settings, FBSDKEventLogging eventLogger, FBSDKGateKeeperManaging gateKeeperManager, FBSDKDataPersisting store, __FBSDKLoggerCreating loggerFactory, FBSDKProductsRequestCreating productRequestFactory, FBSDKAppStoreReceiptProviding receiptProvider);

		// -(void)resolveProducts;
		[Export ("resolveProducts")]
		void ResolveProducts ();
	}

	// @protocol FBSDKPaymentProductRequestorCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKPaymentProductRequestorCreating
	{
		// @required -(FBSDKPaymentProductRequestor * _Nonnull)createRequestorWithTransaction:(SKPaymentTransaction * _Nonnull)transaction __attribute__((swift_name("createRequestor(transaction:)")));
		[Abstract]
		[Export ("createRequestorWithTransaction:")]
		FBSDKPaymentProductRequestor CreateRequestorWithTransaction (SKPaymentTransaction transaction);
	}

	// @protocol FBSDKProductsRequest
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKProductsRequest
	{
		[Wrap ("WeakDelegate"), Abstract]
		[NullAllowed]
		SKProductsRequestDelegate Delegate { get; set; }

		// @required @property (nonatomic, weak) id<SKProductsRequestDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @required -(void)cancel;
		[Abstract]
		[Export ("cancel")]
		void Cancel ();

		// @required -(void)start;
		[Abstract]
		[Export ("start")]
		void Start ();
	}

	// @protocol FBSDKProductsRequestCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKProductsRequestCreating
	{
		// @required -(id<FBSDKProductsRequest> _Nonnull)createWithProductIdentifiers:(NSSet<NSString *> * _Nonnull)identifiers;
		[Abstract]
		[Export ("createWithProductIdentifiers:")]
		FBSDKProductsRequest CreateWithProductIdentifiers (NSSet<NSString> identifiers);
	}

	// @interface FBSDKProductRequestFactory : NSObject <FBSDKProductsRequestCreating>
	[BaseType (typeof(NSObject))]
	interface FBSDKProductRequestFactory : IFBSDKProductsRequestCreating
	{
	}

	// typedef void (^FBSDKProfileBlock)(FBSDKProfile * _Nullable, NSError * _Nullable);
	delegate void FBSDKProfileBlock ([NullAllowed] FBSDKProfile arg0, [NullAllowed] NSError arg1);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NS_SWIFT_NAME(ProfileDidChange) const NSNotificationName FBSDKProfileDidChangeNotification __attribute__((swift_name("ProfileDidChange")));
		[Field ("FBSDKProfileDidChangeNotification", "__Internal")]
		NSString FBSDKProfileDidChangeNotification { get; }

		// extern NS_SWIFT_NAME(ProfileChangeOldKey) NSString *const FBSDKProfileChangeOldKey __attribute__((swift_name("ProfileChangeOldKey")));
		[Field ("FBSDKProfileChangeOldKey", "__Internal")]
		NSString FBSDKProfileChangeOldKey { get; }

		// extern NS_SWIFT_NAME(ProfileChangeNewKey) NSString *const FBSDKProfileChangeNewKey __attribute__((swift_name("ProfileChangeNewKey")));
		[Field ("FBSDKProfileChangeNewKey", "__Internal")]
		NSString FBSDKProfileChangeNewKey { get; }
	}

	// @interface FBSDKRestrictiveDataFilterManager : NSObject <FBSDKAppEventsParameterProcessing, FBSDKEventsProcessing>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKRestrictiveDataFilterManager : IFBSDKAppEventsParameterProcessing, IFBSDKEventsProcessing
	{
		// -(instancetype _Nonnull)initWithServerConfigurationProvider:(id<FBSDKServerConfigurationProviding> _Nonnull)serverConfigurationProvider __attribute__((objc_designated_initializer));
		[Export ("initWithServerConfigurationProvider:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKServerConfigurationProviding serverConfigurationProvider);

		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(void)processEvents:(NSArray<NSDictionary<NSString *,id> *> * _Nonnull)events;
		[Export ("processEvents:")]
		void ProcessEvents (NSDictionary<NSString, NSObject>[] events);

		// -(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)processParameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters eventName:(FBSDKAppEventName _Nullable)eventName;
		[Export ("processParameters:eventName:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSObject> ProcessParameters ([NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] string eventName);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull FBSDKDialogConfigurationNameLogin;
		[Field ("FBSDKDialogConfigurationNameLogin", "__Internal")]
		NSString FBSDKDialogConfigurationNameLogin { get; }

		// extern NSString *const _Nonnull FBSDKDialogConfigurationNameAppInvite;
		[Field ("FBSDKDialogConfigurationNameAppInvite", "__Internal")]
		NSString FBSDKDialogConfigurationNameAppInvite { get; }

		// extern NSString *const _Nonnull FBSDKDialogConfigurationNameGameRequest;
		[Field ("FBSDKDialogConfigurationNameGameRequest", "__Internal")]
		NSString FBSDKDialogConfigurationNameGameRequest { get; }

		// extern NSString *const _Nonnull FBSDKDialogConfigurationNameGroup;
		[Field ("FBSDKDialogConfigurationNameGroup", "__Internal")]
		NSString FBSDKDialogConfigurationNameGroup { get; }

		// extern const NSInteger FBSDKServerConfigurationVersion;
		[Field ("FBSDKServerConfigurationVersion", "__Internal")]
		nint FBSDKServerConfigurationVersion { get; }
	}

	// @interface FBSDKServerConfiguration : NSObject <NSCopying, NSObject, NSSecureCoding>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKServerConfiguration : INSCopying, INSSecureCoding
	{
		// -(instancetype _Nonnull)initWithAppID:(NSString * _Nonnull)appID appName:(NSString * _Nullable)appName loginTooltipEnabled:(BOOL)loginTooltipEnabled loginTooltipText:(NSString * _Nullable)loginTooltipText defaultShareMode:(NSString * _Nullable)defaultShareMode advertisingIDEnabled:(BOOL)advertisingIDEnabled implicitLoggingEnabled:(BOOL)implicitLoggingEnabled implicitPurchaseLoggingEnabled:(BOOL)implicitPurchaseLoggingEnabled codelessEventsEnabled:(BOOL)codelessEventsEnabled uninstallTrackingEnabled:(BOOL)uninstallTrackingEnabled dialogConfigurations:(NSDictionary<NSString *,id> * _Nullable)dialogConfigurations dialogFlows:(NSDictionary<NSString *,id> * _Nullable)dialogFlows timestamp:(NSDate * _Nullable)timestamp errorConfiguration:(FBSDKErrorConfiguration * _Nullable)errorConfiguration sessionTimeoutInterval:(NSTimeInterval)sessionTimeoutInterval defaults:(BOOL)defaults loggingToken:(NSString * _Nullable)loggingToken smartLoginOptions:(FBSDKServerConfigurationSmartLoginOptions)smartLoginOptions smartLoginBookmarkIconURL:(NSURL * _Nullable)smartLoginBookmarkIconURL smartLoginMenuIconURL:(NSURL * _Nullable)smartLoginMenuIconURL updateMessage:(NSString * _Nullable)updateMessage eventBindings:(NSArray<NSDictionary<NSString *,id> *> * _Nullable)eventBindings restrictiveParams:(NSDictionary<NSString *,id> * _Nullable)restrictiveParams AAMRules:(NSDictionary<NSString *,id> * _Nullable)AAMRules suggestedEventsSetting:(NSDictionary<NSString *,id> * _Nullable)suggestedEventsSetting protectedModeRules:(NSDictionary<NSString *,id> * _Nullable)protectedModeRules migratedAutoLogValues:(NSDictionary<NSString *,id> * _Nullable)migratedAutoLogValues __attribute__((objc_designated_initializer));
		[Export ("initWithAppID:appName:loginTooltipEnabled:loginTooltipText:defaultShareMode:advertisingIDEnabled:implicitLoggingEnabled:implicitPurchaseLoggingEnabled:codelessEventsEnabled:uninstallTrackingEnabled:dialogConfigurations:dialogFlows:timestamp:errorConfiguration:sessionTimeoutInterval:defaults:loggingToken:smartLoginOptions:smartLoginBookmarkIconURL:smartLoginMenuIconURL:updateMessage:eventBindings:restrictiveParams:AAMRules:suggestedEventsSetting:protectedModeRules:migratedAutoLogValues:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string appID, [NullAllowed] string appName, bool loginTooltipEnabled, [NullAllowed] string loginTooltipText, [NullAllowed] string defaultShareMode, bool advertisingIDEnabled, bool implicitLoggingEnabled, bool implicitPurchaseLoggingEnabled, bool codelessEventsEnabled, bool uninstallTrackingEnabled, [NullAllowed] NSDictionary<NSString, NSObject> dialogConfigurations, [NullAllowed] NSDictionary<NSString, NSObject> dialogFlows, [NullAllowed] NSDate timestamp, [NullAllowed] FBSDKErrorConfiguration errorConfiguration, double sessionTimeoutInterval, bool defaults, [NullAllowed] string loggingToken, FBSDKServerConfigurationSmartLoginOptions smartLoginOptions, [NullAllowed] NSURL smartLoginBookmarkIconURL, [NullAllowed] NSURL smartLoginMenuIconURL, [NullAllowed] string updateMessage, [NullAllowed] NSDictionary<NSString, NSObject>[] eventBindings, [NullAllowed] NSDictionary<NSString, NSObject> restrictiveParams, [NullAllowed] NSDictionary<NSString, NSObject> AAMRules, [NullAllowed] NSDictionary<NSString, NSObject> suggestedEventsSetting, [NullAllowed] NSDictionary<NSString, NSObject> protectedModeRules, [NullAllowed] NSDictionary<NSString, NSObject> migratedAutoLogValues);

		// @property (readonly, getter = isAdvertisingIDEnabled, assign, nonatomic) BOOL advertisingIDEnabled;
		[Export ("advertisingIDEnabled")]
		bool AdvertisingIDEnabled { [Bind ("isAdvertisingIDEnabled")] get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appID;
		[Export ("appID")]
		string AppID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable appName;
		[NullAllowed, Export ("appName")]
		string AppName { get; }

		// @property (readonly, getter = isDefaults, assign, nonatomic) BOOL defaults;
		[Export ("defaults")]
		bool Defaults { [Bind ("isDefaults")] get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable defaultShareMode;
		[NullAllowed, Export ("defaultShareMode")]
		string DefaultShareMode { get; }

		// @property (readonly, nonatomic, strong) FBSDKErrorConfiguration * _Nullable errorConfiguration;
		[NullAllowed, Export ("errorConfiguration", ArgumentSemantic.Strong)]
		FBSDKErrorConfiguration ErrorConfiguration { get; }

		// @property (readonly, getter = isImplicitLoggingSupported, assign, nonatomic) BOOL implicitLoggingEnabled;
		[Export ("implicitLoggingEnabled")]
		bool ImplicitLoggingEnabled { [Bind ("isImplicitLoggingSupported")] get; }

		// @property (readonly, getter = isImplicitPurchaseLoggingSupported, assign, nonatomic) BOOL implicitPurchaseLoggingEnabled;
		[Export ("implicitPurchaseLoggingEnabled")]
		bool ImplicitPurchaseLoggingEnabled { [Bind ("isImplicitPurchaseLoggingSupported")] get; }

		// @property (readonly, getter = isCodelessEventsEnabled, assign, nonatomic) BOOL codelessEventsEnabled;
		[Export ("codelessEventsEnabled")]
		bool CodelessEventsEnabled { [Bind ("isCodelessEventsEnabled")] get; }

		// @property (readonly, getter = isLoginTooltipEnabled, assign, nonatomic) BOOL loginTooltipEnabled;
		[Export ("loginTooltipEnabled")]
		bool LoginTooltipEnabled { [Bind ("isLoginTooltipEnabled")] get; }

		// @property (readonly, getter = isUninstallTrackingEnabled, assign, nonatomic) BOOL uninstallTrackingEnabled;
		[Export ("uninstallTrackingEnabled")]
		bool UninstallTrackingEnabled { [Bind ("isUninstallTrackingEnabled")] get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable loginTooltipText;
		[NullAllowed, Export ("loginTooltipText")]
		string LoginTooltipText { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Copy)]
		NSDate Timestamp { get; }

		// @property (assign, nonatomic) NSTimeInterval sessionTimeoutInterval;
		[Export ("sessionTimeoutInterval")]
		double SessionTimeoutInterval { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable loggingToken;
		[NullAllowed, Export ("loggingToken")]
		string LoggingToken { get; }

		// @property (readonly, assign, nonatomic) FBSDKServerConfigurationSmartLoginOptions smartLoginOptions;
		[Export ("smartLoginOptions", ArgumentSemantic.Assign)]
		FBSDKServerConfigurationSmartLoginOptions SmartLoginOptions { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable smartLoginBookmarkIconURL;
		[NullAllowed, Export ("smartLoginBookmarkIconURL", ArgumentSemantic.Copy)]
		NSURL SmartLoginBookmarkIconURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable smartLoginMenuIconURL;
		[NullAllowed, Export ("smartLoginMenuIconURL", ArgumentSemantic.Copy)]
		NSURL SmartLoginMenuIconURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable updateMessage;
		[NullAllowed, Export ("updateMessage")]
		string UpdateMessage { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSDictionary<NSString *,id> *> * _Nullable eventBindings;
		[NullAllowed, Export ("eventBindings", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject>[] EventBindings { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable restrictiveParams;
		[NullAllowed, Export ("restrictiveParams", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> RestrictiveParams { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable AAMRules;
		[NullAllowed, Export ("AAMRules", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> AAMRules { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable suggestedEventsSetting;
		[NullAllowed, Export ("suggestedEventsSetting", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> SuggestedEventsSetting { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable protectedModeRules;
		[NullAllowed, Export ("protectedModeRules", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> ProtectedModeRules { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable migratedAutoLogValues;
		[NullAllowed, Export ("migratedAutoLogValues", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> MigratedAutoLogValues { get; }

		// @property (readonly, nonatomic) NSInteger version;
		[Export ("version")]
		nint Version { get; }

		// -(FBSDKDialogConfiguration * _Nullable)dialogConfigurationForDialogName:(NSString * _Nonnull)dialogName;
		[Export ("dialogConfigurationForDialogName:")]
		[return: NullAllowed]
		FBSDKDialogConfiguration DialogConfigurationForDialogName (string dialogName);

		// -(BOOL)useNativeDialogForDialogName:(NSString * _Nonnull)dialogName;
		[Export ("useNativeDialogForDialogName:")]
		bool UseNativeDialogForDialogName (string dialogName);

		// -(BOOL)useSafariViewControllerForDialogName:(NSString * _Nonnull)dialogName;
		[Export ("useSafariViewControllerForDialogName:")]
		bool UseSafariViewControllerForDialogName (string dialogName);
	}

	// typedef void (^FBSDKServerConfigurationBlock)(FBSDKServerConfiguration * _Nullable, NSError * _Nullable);
	delegate void FBSDKServerConfigurationBlock ([NullAllowed] FBSDKServerConfiguration arg0, [NullAllowed] NSError arg1);

	// @protocol FBSDKServerConfigurationProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKServerConfigurationProviding
	{
		// @required -(FBSDKServerConfiguration * _Nonnull)cachedServerConfiguration;
		[Abstract]
		[Export ("cachedServerConfiguration")]
		[Verify (MethodToProperty)]
		FBSDKServerConfiguration CachedServerConfiguration { get; }

		// @required -(void)loadServerConfigurationWithCompletionBlock:(FBSDKServerConfigurationBlock _Nullable)completionBlock;
		[Abstract]
		[Export ("loadServerConfigurationWithCompletionBlock:")]
		void LoadServerConfigurationWithCompletionBlock ([NullAllowed] FBSDKServerConfigurationBlock completionBlock);

		// @required -(void)processLoadRequestResponse:(id _Nonnull)result error:(NSError * _Nullable)error appID:(NSString * _Nonnull)appID;
		[Abstract]
		[Export ("processLoadRequestResponse:error:appID:")]
		void ProcessLoadRequestResponse (NSObject result, [NullAllowed] NSError error, string appID);

		// @required -(FBSDKGraphRequest * _Nullable)requestToLoadServerConfiguration:(NSString * _Nonnull)appID;
		[Abstract]
		[Export ("requestToLoadServerConfiguration:")]
		[return: NullAllowed]
		FBSDKGraphRequest RequestToLoadServerConfiguration (string appID);
	}

	// @interface FBSDKServerConfigurationManager : NSObject <FBSDKServerConfigurationProviding>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKServerConfigurationManager : IFBSDKServerConfigurationProviding
	{
		// @property (readonly, class) FBSDKServerConfigurationManager * _Nonnull shared;
		[Static]
		[Export ("shared")]
		FBSDKServerConfigurationManager Shared { get; }

		// @property (nonatomic) id<FBSDKGraphRequestFactory> _Nullable graphRequestFactory;
		[NullAllowed, Export ("graphRequestFactory", ArgumentSemantic.Assign)]
		FBSDKGraphRequestFactory GraphRequestFactory { get; set; }

		// @property (nonatomic) id<FBSDKGraphRequestConnectionFactory> _Nullable graphRequestConnectionFactory;
		[NullAllowed, Export ("graphRequestConnectionFactory", ArgumentSemantic.Assign)]
		FBSDKGraphRequestConnectionFactory GraphRequestConnectionFactory { get; set; }

		// @property (nonatomic) id<FBSDKDialogConfigurationMapBuilding> _Nullable dialogConfigurationMapBuilder;
		[NullAllowed, Export ("dialogConfigurationMapBuilder", ArgumentSemantic.Assign)]
		FBSDKDialogConfigurationMapBuilding DialogConfigurationMapBuilder { get; set; }

		// -(void)configureWithGraphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory graphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)graphRequestConnectionFactory dialogConfigurationMapBuilder:(id<FBSDKDialogConfigurationMapBuilding> _Nonnull)dialogConfigurationMapBuilder __attribute__((swift_name("configure(graphRequestFactory:graphRequestConnectionFactory:dialogConfigurationMapBuilder:)")));
		[Export ("configureWithGraphRequestFactory:graphRequestConnectionFactory:dialogConfigurationMapBuilder:")]
		void ConfigureWithGraphRequestFactory (FBSDKGraphRequestFactory graphRequestFactory, FBSDKGraphRequestConnectionFactory graphRequestConnectionFactory, FBSDKDialogConfigurationMapBuilding dialogConfigurationMapBuilder);

		// -(void)clearCache;
		[Export ("clearCache")]
		void ClearCache ();
	}

	// @protocol FBSDKSettingsLogging
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSettingsLogging
	{
		// @required -(void)logIfSDKSettingsChanged;
		[Abstract]
		[Export ("logIfSDKSettingsChanged")]
		void LogIfSDKSettingsChanged ();

		// @required -(void)recordInstall;
		[Abstract]
		[Export ("recordInstall")]
		void RecordInstall ();
	}

	// @interface FBSDKSKAdNetworkReporter : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKSKAdNetworkReporter
	{
		// @property (nonatomic) id<FBSDKGraphRequestFactory> _Nonnull graphRequestFactory;
		[Export ("graphRequestFactory", ArgumentSemantic.Assign)]
		FBSDKGraphRequestFactory GraphRequestFactory { get; set; }

		// @property (nonatomic) id<FBSDKDataPersisting> _Nonnull dataStore;
		[Export ("dataStore", ArgumentSemantic.Assign)]
		FBSDKDataPersisting DataStore { get; set; }

		// @property (nonatomic) Class<FBSDKConversionValueUpdating> _Nonnull conversionValueUpdater;
		[Export ("conversionValueUpdater", ArgumentSemantic.Assign)]
		FBSDKConversionValueUpdating ConversionValueUpdater { get; set; }

		// -(instancetype _Nonnull)initWithGraphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory dataStore:(id<FBSDKDataPersisting> _Nonnull)dataStore conversionValueUpdater:(Class<FBSDKConversionValueUpdating> _Nonnull)conversionValueUpdater __attribute__((swift_name("init(graphRequestFactory:dataStore:conversionValueUpdater:)")));
		[Export ("initWithGraphRequestFactory:dataStore:conversionValueUpdater:")]
		NativeHandle Constructor (FBSDKGraphRequestFactory graphRequestFactory, FBSDKDataPersisting dataStore, FBSDKConversionValueUpdating conversionValueUpdater);

		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(void)recordAndUpdateEvent:(NSString * _Nonnull)event currency:(NSString * _Nullable)currency value:(NSNumber * _Nullable)value;
		[Export ("recordAndUpdateEvent:currency:value:")]
		void RecordAndUpdateEvent (string @event, [NullAllowed] string currency, [NullAllowed] NSNumber value);

		// -(BOOL)shouldCutoff;
		[Export ("shouldCutoff")]
		[Verify (MethodToProperty)]
		bool ShouldCutoff { get; }

		// -(BOOL)isReportingEvent:(NSString * _Nonnull)event;
		[Export ("isReportingEvent:")]
		bool IsReportingEvent (string @event);

		// -(void)checkAndRevokeTimer;
		[Export ("checkAndRevokeTimer")]
		void CheckAndRevokeTimer ();
	}

	// @interface FBSDKSKAdNetworkReporterV2 : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKSKAdNetworkReporterV2
	{
		// @property (nonatomic) id<FBSDKGraphRequestFactory> _Nonnull graphRequestFactory;
		[Export ("graphRequestFactory", ArgumentSemantic.Assign)]
		FBSDKGraphRequestFactory GraphRequestFactory { get; set; }

		// @property (nonatomic) id<FBSDKDataPersisting> _Nonnull dataStore;
		[Export ("dataStore", ArgumentSemantic.Assign)]
		FBSDKDataPersisting DataStore { get; set; }

		// @property (nonatomic) Class<FBSDKConversionValueUpdating> _Nonnull conversionValueUpdater;
		[Export ("conversionValueUpdater", ArgumentSemantic.Assign)]
		FBSDKConversionValueUpdating ConversionValueUpdater { get; set; }

		// -(instancetype _Nonnull)initWithGraphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory dataStore:(id<FBSDKDataPersisting> _Nonnull)dataStore conversionValueUpdater:(Class<FBSDKConversionValueUpdating> _Nonnull)conversionValueUpdater __attribute__((swift_name("init(graphRequestFactory:dataStore:conversionValueUpdater:)")));
		[Export ("initWithGraphRequestFactory:dataStore:conversionValueUpdater:")]
		NativeHandle Constructor (FBSDKGraphRequestFactory graphRequestFactory, FBSDKDataPersisting dataStore, FBSDKConversionValueUpdating conversionValueUpdater);

		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(void)recordAndUpdateEvent:(NSString * _Nonnull)event currency:(NSString * _Nullable)currency value:(NSNumber * _Nullable)value;
		[Export ("recordAndUpdateEvent:currency:value:")]
		void RecordAndUpdateEvent (string @event, [NullAllowed] string currency, [NullAllowed] NSNumber value);

		// -(BOOL)shouldCutoff;
		[Export ("shouldCutoff")]
		[Verify (MethodToProperty)]
		bool ShouldCutoff { get; }

		// -(BOOL)isReportingEvent:(NSString * _Nonnull)event;
		[Export ("isReportingEvent:")]
		bool IsReportingEvent (string @event);

		// -(void)checkAndRevokeTimer;
		[Export ("checkAndRevokeTimer")]
		void CheckAndRevokeTimer ();
	}

	// @protocol FBSDKSuggestedEventsIndexer
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSuggestedEventsIndexer
	{
		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();
	}

	// @interface FBSDKSuggestedEventsIndexer : NSObject <FBSDKSuggestedEventsIndexer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKSuggestedEventsIndexer : IFBSDKSuggestedEventsIndexer
	{
		// -(instancetype _Nonnull)initWithGraphRequestFactory:(id<FBSDKGraphRequestFactory> _Nonnull)graphRequestFactory serverConfigurationProvider:(id<FBSDKServerConfigurationProviding> _Nonnull)serverConfigurationProvider swizzler:(Class<FBSDKSwizzling> _Nonnull)swizzler settings:(id<FBSDKSettings> _Nonnull)settings eventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger featureExtractor:(Class<FBSDKFeatureExtracting> _Nonnull)featureExtractor eventProcessor:(id<FBSDKEventProcessing> _Nonnull)eventProcessor __attribute__((objc_designated_initializer));
		[Export ("initWithGraphRequestFactory:serverConfigurationProvider:swizzler:settings:eventLogger:featureExtractor:eventProcessor:")]
		[DesignatedInitializer]
		NativeHandle Constructor (FBSDKGraphRequestFactory graphRequestFactory, FBSDKServerConfigurationProviding serverConfigurationProvider, FBSDKSwizzling swizzler, FBSDKSettings settings, FBSDKEventLogging eventLogger, FBSDKFeatureExtracting featureExtractor, FBSDKEventProcessing eventProcessor);

		// -(void)enable;
		[Export ("enable")]
		void Enable ();
	}

	// typedef void (^_swizzleBlock)();
	delegate void _swizzleBlock ();

	// @protocol FBSDKSwizzling
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKSwizzling
	{
		// @required +(void)swizzleSelector:(SEL _Nonnull)aSelector onClass:(Class _Nonnull)aClass withBlock:(_swizzleBlock _Nonnull)block named:(NSString * _Nonnull)aName;
		[Static, Abstract]
		[Export ("swizzleSelector:onClass:withBlock:named:")]
		void OnClass (Selector aSelector, Class aClass, _swizzleBlock block, string aName);
	}

	// typedef void (^_swizzleBlock)();
	delegate void _swizzleBlock ();

	// @interface FBSDKSwizzler : NSObject <FBSDKSwizzling>
	[BaseType (typeof(NSObject))]
	interface FBSDKSwizzler : IFBSDKSwizzling
	{
		// +(void)swizzleSelector:(SEL _Nonnull)aSelector onClass:(Class _Nonnull)aClass withBlock:(_swizzleBlock _Nonnull)block named:(NSString * _Nonnull)aName;
		[Static]
		[Export ("swizzleSelector:onClass:withBlock:named:")]
		void SwizzleSelector (Selector aSelector, Class aClass, _swizzleBlock block, string aName);

		// +(void)unswizzleSelector:(SEL _Nonnull)aSelector onClass:(Class _Nonnull)aClass named:(NSString * _Nonnull)aName;
		[Static]
		[Export ("unswizzleSelector:onClass:named:")]
		void UnswizzleSelector (Selector aSelector, Class aClass, string aName);

		// +(void)printSwizzles;
		[Static]
		[Export ("printSwizzles")]
		void PrintSwizzles ();
	}

	// @protocol FBSDKTimeSpentRecording
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKTimeSpentRecording
	{
		// @required -(void)suspend;
		[Abstract]
		[Export ("suspend")]
		void Suspend ();

		// @required -(void)restore:(BOOL)calledFromActivateApp;
		[Abstract]
		[Export ("restore:")]
		void Restore (bool calledFromActivateApp);
	}

	// @interface FBSDKTimeSpentData : NSObject <FBSDKSourceApplicationTracking, FBSDKTimeSpentRecording>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKTimeSpentData : IFBSDKSourceApplicationTracking, IFBSDKTimeSpentRecording
	{
		// -(instancetype _Nonnull)initWithEventLogger:(id<FBSDKEventLogging> _Nonnull)eventLogger serverConfigurationProvider:(id<FBSDKServerConfigurationProviding> _Nonnull)serverConfigurationProvider;
		[Export ("initWithEventLogger:serverConfigurationProvider:")]
		NativeHandle Constructor (FBSDKEventLogging eventLogger, FBSDKServerConfigurationProviding serverConfigurationProvider);

		// -(void)setSourceApplication:(NSString * _Nullable)sourceApplication openURL:(NSURL * _Nullable)url;
		[Export ("setSourceApplication:openURL:")]
		void SetSourceApplication ([NullAllowed] string sourceApplication, [NullAllowed] NSURL url);

		// -(void)setSourceApplication:(NSString * _Nullable)sourceApplication isFromAppLink:(BOOL)isFromAppLink;
		[Export ("setSourceApplication:isFromAppLink:")]
		void SetSourceApplication ([NullAllowed] string sourceApplication, bool isFromAppLink);

		// -(void)registerAutoResetSourceApplication;
		[Export ("registerAutoResetSourceApplication")]
		void RegisterAutoResetSourceApplication ();

		// -(void)suspend;
		[Export ("suspend")]
		void Suspend ();

		// -(void)restore:(BOOL)calledFromActivateApp;
		[Export ("restore:")]
		void Restore (bool calledFromActivateApp);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CATransform3D FBSDKCATransform3DIdentity;
		[Field ("FBSDKCATransform3DIdentity", "__Internal")]
		CATransform3D FBSDKCATransform3DIdentity { get; }
	}

	// @interface FBSDKTransformer : NSObject
	[BaseType (typeof(NSObject))]
	interface FBSDKTransformer
	{
		// -(CATransform3D)CATransform3DMakeScale:(CGFloat)sx sy:(CGFloat)sy sz:(CGFloat)sz;
		[Export ("CATransform3DMakeScale:sy:sz:")]
		CATransform3D CATransform3DMakeScale (nfloat sx, nfloat sy, nfloat sz);

		// -(CATransform3D)CATransform3DMakeTranslation:(CGFloat)tx ty:(CGFloat)ty tz:(CGFloat)tz;
		[Export ("CATransform3DMakeTranslation:ty:tz:")]
		CATransform3D CATransform3DMakeTranslation (nfloat tx, nfloat ty, nfloat tz);

		// -(CATransform3D)CATransform3DConcat:(CATransform3D)a b:(CATransform3D)b;
		[Export ("CATransform3DConcat:b:")]
		CATransform3D CATransform3DConcat (CATransform3D a, CATransform3D b);
	}

	// @interface FBSDKURL : NSObject <FBSDKAppLinkURL>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKURL : IFBSDKAppLinkURL
	{
		// +(instancetype _Nonnull)URLWithURL:(NSURL * _Nonnull)url __attribute__((swift_name("init(url:)")));
		[Static]
		[Export ("URLWithURL:")]
		FBSDKURL URLWithURL (NSURL url);

		// +(instancetype _Nonnull)URLWithInboundURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nonnull)sourceApplication __attribute__((swift_name("init(inboundURL:sourceApplication:)")));
		[Static]
		[Export ("URLWithInboundURL:sourceApplication:")]
		FBSDKURL URLWithInboundURL (NSURL url, string sourceApplication);

		// @property (readonly, nonatomic, strong) NSURL * _Nonnull targetURL;
		[Export ("targetURL", ArgumentSemantic.Strong)]
		NSURL TargetURL { get; }

		// @property (readonly, nonatomic, strong) NSDictionary<NSString *,id> * _Nonnull targetQueryParameters;
		[Export ("targetQueryParameters", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSObject> TargetQueryParameters { get; }

		// @property (readonly, nonatomic, strong) NSDictionary<NSString *,id> * _Nullable appLinkData;
		[NullAllowed, Export ("appLinkData", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSObject> AppLinkData { get; }

		// @property (readonly, nonatomic, strong) NSDictionary<NSString *,id> * _Nullable appLinkExtras;
		[NullAllowed, Export ("appLinkExtras", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSObject> AppLinkExtras { get; }

		// @property (readonly, nonatomic, strong) id<FBSDKAppLink> _Nullable appLinkReferer;
		[NullAllowed, Export ("appLinkReferer", ArgumentSemantic.Strong)]
		FBSDKAppLink AppLinkReferer { get; }

		// @property (readonly, nonatomic, strong) NSURL * _Nonnull inputURL;
		[Export ("inputURL", ArgumentSemantic.Strong)]
		NSURL InputURL { get; }

		// @property (readonly, nonatomic, strong) NSDictionary<NSString *,id> * _Nonnull inputQueryParameters;
		[Export ("inputQueryParameters", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSObject> InputQueryParameters { get; }

		// @property (readonly, getter = isAutoAppLink, nonatomic) BOOL isAutoAppLink;
		[Export ("isAutoAppLink")]
		bool IsAutoAppLink { [Bind ("isAutoAppLink")] get; }

		// +(void)configureWithSettings:(id<FBSDKSettings> _Nonnull)settings appLinkFactory:(id<FBSDKAppLinkCreating> _Nonnull)appLinkFactory appLinkTargetFactory:(id<FBSDKAppLinkTargetCreating> _Nonnull)appLinkTargetFactory appLinkEventPoster:(id<FBSDKAppLinkEventPosting> _Nonnull)appLinkEventPoster __attribute__((swift_name("configure(settings:appLinkFactory:appLinkTargetFactory:appLinkEventPoster:)")));
		[Static]
		[Export ("configureWithSettings:appLinkFactory:appLinkTargetFactory:appLinkEventPoster:")]
		void ConfigureWithSettings (FBSDKSettings settings, FBSDKAppLinkCreating appLinkFactory, FBSDKAppLinkTargetCreating appLinkTargetFactory, FBSDKAppLinkEventPosting appLinkEventPoster);
	}

	// @protocol FBSDKURLOpener
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKURLOpener
	{
		// @required -(void)openURL:(NSURL * _Nonnull)url sender:(id<FBSDKURLOpening> _Nullable)sender handler:(FBSDKSuccessBlock _Nonnull)handler;
		[Abstract]
		[Export ("openURL:sender:handler:")]
		void OpenURL (NSURL url, [NullAllowed] FBSDKURLOpening sender, FBSDKSuccessBlock handler);

		// @required -(void)openURLWithSafariViewController:(NSURL * _Nonnull)url sender:(id<FBSDKURLOpening> _Nullable)sender fromViewController:(UIViewController * _Nullable)fromViewController handler:(FBSDKSuccessBlock _Nonnull)handler __attribute__((swift_name("openURLWithSafariViewController(url:sender:from:handler:)")));
		[Abstract]
		[Export ("openURLWithSafariViewController:sender:fromViewController:handler:")]
		void OpenURLWithSafariViewController (NSURL url, [NullAllowed] FBSDKURLOpening sender, [NullAllowed] UIViewController fromViewController, FBSDKSuccessBlock handler);
	}

	// @protocol FBSDKURLOpening <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKURLOpening
	{
		// @required -(BOOL)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation;
		[Abstract]
		[Export ("application:openURL:sourceApplication:annotation:")]
		bool Application ([NullAllowed] UIApplication application, [NullAllowed] NSURL url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// @required -(BOOL)canOpenURL:(NSURL * _Nonnull)url forApplication:(UIApplication * _Nullable)application sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation;
		[Abstract]
		[Export ("canOpenURL:forApplication:sourceApplication:annotation:")]
		bool CanOpenURL (NSURL url, [NullAllowed] UIApplication application, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

		// @required -(void)applicationDidBecomeActive:(UIApplication * _Nonnull)application;
		[Abstract]
		[Export ("applicationDidBecomeActive:")]
		void ApplicationDidBecomeActive (UIApplication application);

		// @required -(BOOL)isAuthenticationURL:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("isAuthenticationURL:")]
		bool IsAuthenticationURL (NSURL url);

		// @optional +(instancetype _Nonnull)makeOpener;
		[Static]
		[Export ("makeOpener")]
		FBSDKURLOpening MakeOpener ();

		// @optional -(BOOL)shouldStopPropagationOfURL:(NSURL * _Nonnull)url;
		[Export ("shouldStopPropagationOfURL:")]
		bool ShouldStopPropagationOfURL (NSURL url);
	}

	// @protocol FBSDKURLSessionProxying
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKURLSessionProxying
	{
		// @required @property (retain, nonatomic) NSOperationQueue * _Nullable delegateQueue;
		[Abstract]
		[NullAllowed, Export ("delegateQueue", ArgumentSemantic.Retain)]
		NSOperationQueue DelegateQueue { get; set; }

		// @required -(void)executeURLRequest:(NSURLRequest * _Nonnull)request completionHandler:(id)handler;
		[Abstract]
		[Export ("executeURLRequest:completionHandler:")]
		void ExecuteURLRequest (NSURLRequest request, NSObject handler);

		// @required -(void)invalidateAndCancel;
		[Abstract]
		[Export ("invalidateAndCancel")]
		void InvalidateAndCancel ();
	}

	// @protocol FBSDKURLSessionProxyProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKURLSessionProxyProviding
	{
		// @required -(id<FBSDKURLSessionProxying> _Nonnull)createSessionProxyWithDelegate:(id<NSURLSessionDataDelegate> _Nullable)delegate queue:(NSOperationQueue * _Nullable)queue;
		[Abstract]
		[Export ("createSessionProxyWithDelegate:queue:")]
		FBSDKURLSessionProxying Queue ([NullAllowed] NSURLSessionDataDelegate @delegate, [NullAllowed] NSOperationQueue queue);
	}

	// @interface FBSDKURLSessionProxyFactory : NSObject <FBSDKURLSessionProxyProviding>
	[BaseType (typeof(NSObject))]
	interface FBSDKURLSessionProxyFactory : IFBSDKURLSessionProxyProviding
	{
	}

	// @protocol FBSDKUnarchiverProviding <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKUnarchiverProviding
	{
		// @required +(id<FBSDKObjectDecoding> _Nonnull)createSecureUnarchiverFor:(NSData * _Nonnull)data;
		[Static, Abstract]
		[Export ("createSecureUnarchiverFor:")]
		FBSDKObjectDecoding CreateSecureUnarchiverFor (NSData data);

		// @required +(id<FBSDKObjectDecoding> _Nonnull)createInsecureUnarchiverFor:(NSData * _Nonnull)data;
		[Static, Abstract]
		[Export ("createInsecureUnarchiverFor:")]
		FBSDKObjectDecoding CreateInsecureUnarchiverFor (NSData data);
	}

	// @interface FBSDKUnarchiverProvider : NSObject <FBSDKUnarchiverProviding>
	[BaseType (typeof(NSObject))]
	interface FBSDKUnarchiverProvider : IFBSDKUnarchiverProviding
	{
	}

	// @interface FBSDKUserAgeRange : NSObject <NSCopying, NSObject, NSSecureCoding>
	[BaseType (typeof(NSObject)), BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKUserAgeRange : INSCopying, INSSecureCoding
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable min;
		[NullAllowed, Export ("min", ArgumentSemantic.Strong)]
		NSNumber Min { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable max;
		[NullAllowed, Export ("max", ArgumentSemantic.Strong)]
		NSNumber Max { get; }

		// +(instancetype _Nullable)ageRangeFromDictionary:(NSDictionary<NSString *,NSNumber *> * _Nonnull)dictionary;
		[Static]
		[Export ("ageRangeFromDictionary:")]
		[return: NullAllowed]
		FBSDKUserAgeRange AgeRangeFromDictionary (NSDictionary<NSString, NSNumber> dictionary);
	}

	// @protocol FBSDKUserDataPersisting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKUserDataPersisting
	{
		// @required -(void)setUserEmail:(NSString * _Nullable)email firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName phone:(NSString * _Nullable)phone dateOfBirth:(NSString * _Nullable)dateOfBirth gender:(NSString * _Nullable)gender city:(NSString * _Nullable)city state:(NSString * _Nullable)state zip:(NSString * _Nullable)zip country:(NSString * _Nullable)country __attribute__((swift_name("setUser(email:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:)")));
		[Abstract]
		[Export ("setUserEmail:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:")]
		void SetUserEmail ([NullAllowed] string email, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string phone, [NullAllowed] string dateOfBirth, [NullAllowed] string gender, [NullAllowed] string city, [NullAllowed] string state, [NullAllowed] string zip, [NullAllowed] string country);

		// @required -(void)setUserEmail:(NSString * _Nullable)email firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName phone:(NSString * _Nullable)phone dateOfBirth:(NSString * _Nullable)dateOfBirth gender:(NSString * _Nullable)gender city:(NSString * _Nullable)city state:(NSString * _Nullable)state zip:(NSString * _Nullable)zip country:(NSString * _Nullable)country externalId:(NSString * _Nullable)externalId __attribute__((swift_name("setUser(email:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:externalId:)")));
		[Abstract]
		[Export ("setUserEmail:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:externalId:")]
		void SetUserEmail ([NullAllowed] string email, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string phone, [NullAllowed] string dateOfBirth, [NullAllowed] string gender, [NullAllowed] string city, [NullAllowed] string state, [NullAllowed] string zip, [NullAllowed] string country, [NullAllowed] string externalId);

		// @required -(NSString * _Nullable)getUserData;
		[Abstract]
		[NullAllowed, Export ("getUserData")]
		[Verify (MethodToProperty)]
		string UserData { get; }

		// @required -(void)clearUserData;
		[Abstract]
		[Export ("clearUserData")]
		void ClearUserData ();

		// @required -(void)setUserData:(NSString * _Nullable)data forType:(FBSDKAppEventUserDataType _Nonnull)type;
		[Abstract]
		[Export ("setUserData:forType:")]
		void SetUserData ([NullAllowed] string data, string type);

		// @required -(void)clearUserDataForType:(FBSDKAppEventUserDataType _Nonnull)type;
		[Abstract]
		[Export ("clearUserDataForType:")]
		void ClearUserDataForType (string type);

		// @required -(void)setEnabledRules:(NSArray<NSString *> * _Nonnull)rules;
		[Abstract]
		[Export ("setEnabledRules:")]
		void SetEnabledRules (string[] rules);

		// @required -(NSString * _Nullable)getInternalHashedDataForType:(FBSDKAppEventUserDataType _Nonnull)type;
		[Abstract]
		[Export ("getInternalHashedDataForType:")]
		[return: NullAllowed]
		string GetInternalHashedDataForType (string type);

		// @required -(void)setInternalHashData:(NSString * _Nullable)hashData forType:(FBSDKAppEventUserDataType _Nonnull)type;
		[Abstract]
		[Export ("setInternalHashData:forType:")]
		void SetInternalHashData ([NullAllowed] string hashData, string type);
	}

	// @interface FBSDKUserDataStore : NSObject <FBSDKUserDataPersisting>
	[BaseType (typeof(NSObject))]
	interface FBSDKUserDataStore : IFBSDKUserDataPersisting
	{
		// -(void)setUserEmail:(NSString * _Nullable)email firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName phone:(NSString * _Nullable)phone dateOfBirth:(NSString * _Nullable)dateOfBirth gender:(NSString * _Nullable)gender city:(NSString * _Nullable)city state:(NSString * _Nullable)state zip:(NSString * _Nullable)zip country:(NSString * _Nullable)country __attribute__((swift_name("setUser(email:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:)")));
		[Export ("setUserEmail:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:")]
		void SetUserEmail ([NullAllowed] string email, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string phone, [NullAllowed] string dateOfBirth, [NullAllowed] string gender, [NullAllowed] string city, [NullAllowed] string state, [NullAllowed] string zip, [NullAllowed] string country);

		// -(void)setUserEmail:(NSString * _Nullable)email firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName phone:(NSString * _Nullable)phone dateOfBirth:(NSString * _Nullable)dateOfBirth gender:(NSString * _Nullable)gender city:(NSString * _Nullable)city state:(NSString * _Nullable)state zip:(NSString * _Nullable)zip country:(NSString * _Nullable)country externalId:(NSString * _Nullable)externalId __attribute__((swift_name("setUser(email:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:externalId:)")));
		[Export ("setUserEmail:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:externalId:")]
		void SetUserEmail ([NullAllowed] string email, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string phone, [NullAllowed] string dateOfBirth, [NullAllowed] string gender, [NullAllowed] string city, [NullAllowed] string state, [NullAllowed] string zip, [NullAllowed] string country, [NullAllowed] string externalId);

		// -(NSString * _Nullable)getUserData;
		[NullAllowed, Export ("getUserData")]
		[Verify (MethodToProperty)]
		string UserData { get; }

		// -(void)clearUserData;
		[Export ("clearUserData")]
		void ClearUserData ();

		// -(void)setUserData:(NSString * _Nullable)data forType:(FBSDKAppEventUserDataType _Nonnull)type;
		[Export ("setUserData:forType:")]
		void SetUserData ([NullAllowed] string data, string type);

		// -(void)clearUserDataForType:(FBSDKAppEventUserDataType _Nonnull)type;
		[Export ("clearUserDataForType:")]
		void ClearUserDataForType (string type);
	}

	// @interface FBSDKUtility : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKUtility
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)dictionaryWithQueryString:(NSString * _Nonnull)queryString __attribute__((swift_name("dictionary(withQuery:)")));
		[Static]
		[Export ("dictionaryWithQueryString:")]
		NSDictionary<NSString, NSString> DictionaryWithQueryString (string queryString);

		// +(NSString * _Nonnull)queryStringWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary error:(NSError * _Nullable * _Nullable)errorRef __attribute__((swift_name("query(from:)"))) __attribute__((swift_error("nonnull_error")));
		[Static]
		[Export ("queryStringWithDictionary:error:")]
		string QueryStringWithDictionary (NSDictionary<NSString, NSObject> dictionary, [NullAllowed] out NSError errorRef);

		// +(NSString * _Nonnull)URLDecode:(NSString * _Nonnull)value __attribute__((swift_name("decode(urlString:)")));
		[Static]
		[Export ("URLDecode:")]
		string URLDecode (string value);

		// +(NSString * _Nonnull)URLEncode:(NSString * _Nonnull)value __attribute__((swift_name("encode(urlString:)")));
		[Static]
		[Export ("URLEncode:")]
		string URLEncode (string value);

		// +(dispatch_source_t _Nonnull)startGCDTimerWithInterval:(double)interval block:(dispatch_block_t _Nonnull)block;
		[Static]
		[Export ("startGCDTimerWithInterval:block:")]
		OS_dispatch_source StartGCDTimerWithInterval (double interval, dispatch_block_t block);

		// +(void)stopGCDTimer:(dispatch_source_t _Nonnull)timer;
		[Static]
		[Export ("stopGCDTimer:")]
		void StopGCDTimer (OS_dispatch_source timer);

		// +(NSString * _Nullable)SHA256Hash:(NSObject * _Nonnull)input __attribute__((swift_name("sha256Hash(_:)")));
		[Static]
		[Export ("SHA256Hash:")]
		[return: NullAllowed]
		string SHA256Hash (NSObject input);

		// +(NSString * _Nullable)getGraphDomainFromToken;
		[Static]
		[NullAllowed, Export ("getGraphDomainFromToken")]
		[Verify (MethodToProperty)]
		string GraphDomainFromToken { get; }

		// +(NSURL * _Nonnull)unversionedFacebookURLWithHostPrefix:(NSString * _Nonnull)hostPrefix path:(NSString * _Nonnull)path queryParameters:(NSDictionary<NSString *,id> * _Nonnull)queryParameters error:(NSError * _Nullable * _Nullable)errorRef;
		[Static]
		[Export ("unversionedFacebookURLWithHostPrefix:path:queryParameters:error:")]
		NSURL UnversionedFacebookURLWithHostPrefix (string hostPrefix, string path, NSDictionary<NSString, NSObject> queryParameters, [NullAllowed] out NSError errorRef);
	}

	// @protocol FBSDKWebDialogDelegate
	[Protocol, Model]
	interface FBSDKWebDialogDelegate
	{
		// @required -(void)webDialog:(FBSDKWebDialog * _Nonnull)webDialog didCompleteWithResults:(NSDictionary<NSString *,id> * _Nonnull)results;
		[Abstract]
		[Export ("webDialog:didCompleteWithResults:")]
		void WebDialog (FBSDKWebDialog webDialog, NSDictionary<NSString, NSObject> results);

		// @required -(void)webDialog:(FBSDKWebDialog * _Nonnull)webDialog didFailWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("webDialog:didFailWithError:")]
		void WebDialog (FBSDKWebDialog webDialog, NSError error);

		// @required -(void)webDialogDidCancel:(FBSDKWebDialog * _Nonnull)webDialog;
		[Abstract]
		[Export ("webDialogDidCancel:")]
		void WebDialogDidCancel (FBSDKWebDialog webDialog);
	}

	// @interface FBSDKWebDialogView : UIView
	[BaseType (typeof(UIView))]
	interface FBSDKWebDialogView
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FBSDKWebDialogViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FBSDKWebDialogViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)loadURL:(NSURL * _Nonnull)URL;
		[Export ("loadURL:")]
		void LoadURL (NSURL URL);

		// -(void)stopLoading;
		[Export ("stopLoading")]
		void StopLoading ();

		// +(void)configureWithWebViewProvider:(id<FBSDKWebViewProviding> _Nonnull)webViewProvider urlOpener:(id<FBSDKInternalURLOpener> _Nonnull)urlOpener errorFactory:(id<FBSDKErrorCreating> _Nonnull)errorFactory __attribute__((swift_name("configure(webViewProvider:urlOpener:errorFactory:)")));
		[Static]
		[Export ("configureWithWebViewProvider:urlOpener:errorFactory:")]
		void ConfigureWithWebViewProvider (FBSDKWebViewProviding webViewProvider, FBSDKInternalURLOpener urlOpener, FBSDKErrorCreating errorFactory);
	}

	// @protocol FBSDKWebDialogViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FBSDKWebDialogViewDelegate
	{
		// @required -(void)webDialogView:(FBSDKWebDialogView * _Nonnull)webDialogView didCompleteWithResults:(NSDictionary<NSString *,id> * _Nonnull)results;
		[Abstract]
		[Export ("webDialogView:didCompleteWithResults:")]
		void WebDialogView (FBSDKWebDialogView webDialogView, NSDictionary<NSString, NSObject> results);

		// @required -(void)webDialogView:(FBSDKWebDialogView * _Nonnull)webDialogView didFailWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("webDialogView:didFailWithError:")]
		void WebDialogView (FBSDKWebDialogView webDialogView, NSError error);

		// @required -(void)webDialogViewDidCancel:(FBSDKWebDialogView * _Nonnull)webDialogView;
		[Abstract]
		[Export ("webDialogViewDidCancel:")]
		void WebDialogViewDidCancel (FBSDKWebDialogView webDialogView);

		// @required -(void)webDialogViewDidFinishLoad:(FBSDKWebDialogView * _Nonnull)webDialogView;
		[Abstract]
		[Export ("webDialogViewDidFinishLoad:")]
		void WebDialogViewDidFinishLoad (FBSDKWebDialogView webDialogView);
	}

	// @protocol FBSDKWebView
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKWebView
	{
		[Wrap ("WeakNavigationDelegate"), Abstract]
		[NullAllowed]
		WKNavigationDelegate NavigationDelegate { get; set; }

		// @required @property (nonatomic, weak) id<WKNavigationDelegate> _Nullable navigationDelegate;
		[Abstract]
		[NullAllowed, Export ("navigationDelegate", ArgumentSemantic.Weak)]
		NSObject WeakNavigationDelegate { get; set; }

		// @required @property (nonatomic) CGRect frame;
		[Abstract]
		[Export ("frame", ArgumentSemantic.Assign)]
		CGRect Frame { get; set; }

		// @required @property (nonatomic) CGRect bounds;
		[Abstract]
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// @required -(WKNavigation * _Nullable)loadRequest:(NSURLRequest * _Nonnull)request;
		[Abstract]
		[Export ("loadRequest:")]
		[return: NullAllowed]
		WKNavigation LoadRequest (NSURLRequest request);

		// @required -(void)stopLoading;
		[Abstract]
		[Export ("stopLoading")]
		void StopLoading ();
	}

	// @interface FBSDKWebViewAppLinkResolver : NSObject <FBSDKAppLinkResolving>
	[BaseType (typeof(NSObject))]
	interface FBSDKWebViewAppLinkResolver : IFBSDKAppLinkResolving
	{
		// @property (readonly, nonatomic, strong, class) NS_SWIFT_NAME(shared) FBSDKWebViewAppLinkResolver * sharedInstance __attribute__((swift_name("shared")));
		[Static]
		[Export ("sharedInstance", ArgumentSemantic.Strong)]
		FBSDKWebViewAppLinkResolver SharedInstance { get; }
	}

	// @protocol FBSDKWebViewProviding
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKWebViewProviding
	{
		// @required -(id<FBSDKWebView> _Nonnull)createWebViewWithFrame:(CGRect)frame __attribute__((swift_name("createWebView(frame:)")));
		[Abstract]
		[Export ("createWebViewWithFrame:")]
		FBSDKWebView CreateWebViewWithFrame (CGRect frame);
	}

	// @interface FBSDKWebView (WKWebView) <FBSDKWebView>
	[Category]
	[BaseType (typeof(WKWebView))]
	interface WKWebView_FBSDKWebView : IFBSDKWebView
	{
	}

	// @interface FBSDKGraphRequestQueue : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKGraphRequestQueue
	{
		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		FBSDKGraphRequestQueue SharedInstance ();

		// -(void)configureWithGraphRequestConnectionFactory:(id<FBSDKGraphRequestConnectionFactory> _Nonnull)graphRequestConnectionFactory __attribute__((swift_name("configure(graphRequestConnectionFactory:)")));
		[Export ("configureWithGraphRequestConnectionFactory:")]
		void ConfigureWithGraphRequestConnectionFactory (FBSDKGraphRequestConnectionFactory graphRequestConnectionFactory);

		// -(void)enqueueRequest:(id<FBSDKGraphRequest> _Nonnull)request completion:(FBSDKGraphRequestCompletion _Nonnull)completion;
		[Export ("enqueueRequest:completion:")]
		void EnqueueRequest (FBSDKGraphRequest request, FBSDKGraphRequestCompletion completion);

		// -(void)enqueueRequests:(NSArray<FBSDKGraphRequestMetadata *> * _Nonnull)requests;
		[Export ("enqueueRequests:")]
		void EnqueueRequests (FBSDKGraphRequestMetadata[] requests);

		// -(void)enqueueRequestMetadata:(FBSDKGraphRequestMetadata * _Nonnull)requestMetadata;
		[Export ("enqueueRequestMetadata:")]
		void EnqueueRequestMetadata (FBSDKGraphRequestMetadata requestMetadata);

		// -(void)flush;
		[Export ("flush")]
		void Flush ();
	}

	// @protocol FBSDKTransactionObserving
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKTransactionObserving
	{
		// @required -(void)startObserving __attribute__((swift_name("startObserving()")));
		[Abstract]
		[Export ("startObserving")]
		void StartObserving ();

		// @required -(void)stopObserving __attribute__((swift_name("stopObserving()")));
		[Abstract]
		[Export ("stopObserving")]
		void StopObserving ();
	}

	// @protocol FBSDKIAPFailedTransactionLogging
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKIAPFailedTransactionLogging
	{
		// @required -(void)logFailedStoreKit2Purchase:(NSString * _Nonnull)productID __attribute__((swift_name("logFailedStoreKit2Purchase(productID:)"))) __attribute__((availability(ios, introduced=15)));
		[iOS (15,0)]
		[Abstract]
		[Export ("logFailedStoreKit2Purchase:")]
		void LogFailedStoreKit2Purchase (string productID);
	}

	// @protocol FBSDKIAPFailedTransactionLoggingCreating
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKIAPFailedTransactionLoggingCreating
	{
		// @required -(id<FBSDKIAPFailedTransactionLogging> _Nonnull)createIAPFailedTransactionLogging __attribute__((availability(ios, introduced=15)));
		[iOS (15, 0)]
		[Abstract]
		[Export ("createIAPFailedTransactionLogging")]
		[Verify (MethodToProperty)]
		FBSDKIAPFailedTransactionLogging CreateIAPFailedTransactionLogging { get; }
	}

	// @protocol FBSDKIAPDedupeProcessing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKIAPDedupeProcessing
	{
		// @required @property (readonly, assign) BOOL isEnabled;
		[Abstract]
		[Export ("isEnabled")]
		bool IsEnabled { get; }

		// @required -(void)enable;
		[Abstract]
		[Export ("enable")]
		void Enable ();

		// @required -(void)disable;
		[Abstract]
		[Export ("disable")]
		void Disable ();

		// @required -(void)saveNonProcessedEvents;
		[Abstract]
		[Export ("saveNonProcessedEvents")]
		void SaveNonProcessedEvents ();

		// @required -(void)processSavedEvents;
		[Abstract]
		[Export ("processSavedEvents")]
		void ProcessSavedEvents ();

		// @required -(void)processManualEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(NSNumber * _Nullable)valueToSum parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters accessToken:(FBSDKAccessToken * _Nullable)accessToken operationalParameters:(NSDictionary<FBSDKAppOperationalDataType,NSDictionary<NSString *,id> *> * _Nullable)operationalParameters;
		[Abstract]
		[Export ("processManualEvent:valueToSum:parameters:accessToken:operationalParameters:")]
		void ProcessManualEvent (string eventName, [NullAllowed] NSNumber valueToSum, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] FBSDKAccessToken accessToken, [NullAllowed] NSDictionary<NSString, NSDictionary<NSString, NSObject>> operationalParameters);

		// @required -(void)processImplicitEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(NSNumber * _Nullable)valueToSum parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters accessToken:(FBSDKAccessToken * _Nullable)accessToken operationalParameters:(NSDictionary<FBSDKAppOperationalDataType,NSDictionary<NSString *,id> *> * _Nullable)operationalParameters;
		[Abstract]
		[Export ("processImplicitEvent:valueToSum:parameters:accessToken:operationalParameters:")]
		void ProcessImplicitEvent (string eventName, [NullAllowed] NSNumber valueToSum, [NullAllowed] NSDictionary<NSString, NSObject> parameters, [NullAllowed] FBSDKAccessToken accessToken, [NullAllowed] NSDictionary<NSString, NSDictionary<NSString, NSObject>> operationalParameters);

		// @required -(BOOL)shouldDedupeEvent:(FBSDKAppEventName _Nonnull)eventName valueToSum:(NSNumber * _Nullable)valueToSum parameters:(NSDictionary<FBSDKAppEventParameterName,id> * _Nullable)parameters;
		[Abstract]
		[Export ("shouldDedupeEvent:valueToSum:parameters:")]
		bool ShouldDedupeEvent (string eventName, [NullAllowed] NSNumber valueToSum, [NullAllowed] NSDictionary<NSString, NSObject> parameters);
	}

	// @protocol FBSDKIAPTransactionCaching
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSDKIAPTransactionCaching
	{
		// @required @property (nonatomic, strong) NSDate * _Nullable newCandidatesDate;
		[Abstract]
		[NullAllowed, Export ("newCandidatesDate", ArgumentSemantic.Strong)]
		NSDate NewCandidatesDate { get; set; }

		// @required @property (assign, nonatomic) BOOL hasRestoredPurchases;
		[Abstract]
		[Export ("hasRestoredPurchases")]
		bool HasRestoredPurchases { get; set; }

		// @required -(void)addTransaction:(NSString * _Nullable)transactionID eventName:(FBSDKAppEventName _Nonnull)eventName productID:(NSString * _Nonnull)productID __attribute__((swift_name("addTransaction(transactionID:eventName:productID:)")));
		[Abstract]
		[Export ("addTransaction:eventName:productID:")]
		void AddTransaction ([NullAllowed] string transactionID, string eventName, string productID);

		// @required -(void)removeTransaction:(NSString * _Nullable)transactionID eventName:(FBSDKAppEventName _Nonnull)eventName productID:(NSString * _Nonnull)productID __attribute__((swift_name("removeTransaction(transactionID:eventName:productID:)")));
		[Abstract]
		[Export ("removeTransaction:eventName:productID:")]
		void RemoveTransaction ([NullAllowed] string transactionID, string eventName, string productID);

		// @required -(BOOL)contains:(NSString * _Nullable)transactionID eventName:(FBSDKAppEventName _Nonnull)eventName productID:(NSString * _Nonnull)productID __attribute__((swift_name("contains(transactionID:eventName:productID:)")));
		[Abstract]
		[Export ("contains:eventName:productID:")]
		bool Contains ([NullAllowed] string transactionID, string eventName, string productID);

		// @required -(BOOL)contains:(NSString * _Nullable)transactionID productID:(NSString * _Nonnull)productID __attribute__((swift_name("contains(transactionID:productID:)")));
		[Abstract]
		[Export ("contains:productID:")]
		bool Contains ([NullAllowed] string transactionID, string productID);

		// @required -(void)trimIfNeeded:(BOOL)hasLowMemory __attribute__((swift_name("trimIfNeeded(hasLowMemory:)")));
		[Abstract]
		[Export ("trimIfNeeded:")]
		void TrimIfNeeded (bool hasLowMemory);
	}
}