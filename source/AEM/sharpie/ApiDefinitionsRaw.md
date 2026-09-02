using System;
using FBAEMKit;
using Foundation;

namespace Facebook.AEM
{
	// @protocol FBAEMNetworking
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBAEMNetworking
	{
		// @required -(void)startGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(id)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(NSString * _Nullable)method completion:(void (^ _Nonnull)(id _Nullable, int * _Nullable))completion;
		[Abstract]
		[Export ("startGraphRequestWithGraphPath:parameters:tokenString:HTTPMethod:completion:")]
		unsafe void Parameters (string graphPath, NSObject parameters, [NullAllowed] string tokenString, [NullAllowed] string method, Action<NSObject, int*> completion);
	}

	// @interface FBAEMReporter
	interface FBAEMReporter
	{
		// +(void)configureWithNetworker:(id<FBAEMNetworking> _Nullable)networker appID:(NSString * _Nullable)appID reporter:(id<FBSKAdNetworkReporting> _Nullable)reporter;
		[Static]
		[Export ("configureWithNetworker:appID:reporter:")]
		void ConfigureWithNetworker ([NullAllowed] FBAEMNetworking networker, [NullAllowed] string appID, [NullAllowed] FBSKAdNetworkReporting reporter);

		// +(void)configureWithNetworker:(id<FBAEMNetworking> _Nullable)networker appID:(NSString * _Nullable)appID reporter:(id<FBSKAdNetworkReporting> _Nullable)reporter analyticsAppID:(NSString * _Nullable)analyticsAppID store:(id<FBSDKDataPersisting> _Nullable)store;
		[Static]
		[Export ("configureWithNetworker:appID:reporter:analyticsAppID:store:")]
		void ConfigureWithNetworker ([NullAllowed] FBAEMNetworking networker, [NullAllowed] string appID, [NullAllowed] FBSKAdNetworkReporting reporter, [NullAllowed] string analyticsAppID, [NullAllowed] FBSDKDataPersisting store);

		// +(void)enable;
		[Static]
		[Export ("enable")]
		void Enable ();

		// +(void)setConversionFilteringEnabled:(id)enabled;
		[Static]
		[Export ("setConversionFilteringEnabled:")]
		void SetConversionFilteringEnabled (NSObject enabled);

		// +(void)setCatalogMatchingEnabled:(id)enabled;
		[Static]
		[Export ("setCatalogMatchingEnabled:")]
		void SetCatalogMatchingEnabled (NSObject enabled);

		// +(void)setAdvertiserRuleMatchInServerEnabled:(id)enabled;
		[Static]
		[Export ("setAdvertiserRuleMatchInServerEnabled:")]
		void SetAdvertiserRuleMatchInServerEnabled (NSObject enabled);

		// +(void)handle:(NSURL * _Nullable)url;
		[Static]
		[Export ("handle:")]
		void Handle ([NullAllowed] NSURL url);

		// +(void)recordAndUpdateEvent:(NSString * _Nonnull)event currency:(NSString * _Nullable)currency value:(NSNumber * _Nullable)value parameters:(id)parameters;
		[Static]
		[Export ("recordAndUpdateEvent:currency:value:parameters:")]
		void RecordAndUpdateEvent (string @event, [NullAllowed] string currency, [NullAllowed] NSNumber value, NSObject parameters);
	}

	// @protocol FBSKAdNetworkReporting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface FBSKAdNetworkReporting
	{
		// @required -(id)shouldCutoff __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("shouldCutoff")]
		[Verify (MethodToProperty)]
		NSObject ShouldCutoff { get; }

		// @required -(id)isReportingEvent:(NSString * _Nonnull)event __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("isReportingEvent:")]
		NSObject IsReportingEvent (string @event);

		// @required -(void)checkAndRevokeTimer;
		[Abstract]
		[Export ("checkAndRevokeTimer")]
		void CheckAndRevokeTimer ();
	}
}
