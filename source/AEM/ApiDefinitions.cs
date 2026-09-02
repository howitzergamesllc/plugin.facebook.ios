
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

using Facebook.CoreBasics;

namespace Facebook.AEM
{
	delegate void FBAEMGraphRequestCompletion([NullAllowed] NSObject result, IntPtr error);

	// @protocol FBAEMNetworking
	interface IFBAEMNetworking {}
	
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBAEMNetworking
	{
		// @required -(void)startGraphRequestWithGraphPath:(NSString * _Nonnull)graphPath parameters:(id)parameters tokenString:(NSString * _Nullable)tokenString HTTPMethod:(NSString * _Nullable)method completion:(void (^ _Nonnull)(id _Nullable, int * _Nullable))completion;
		[Abstract]
		[Export ("startGraphRequestWithGraphPath:parameters:tokenString:HTTPMethod:completion:")]
		void StartGraphRequest (string graphPath, NSObject parameters, [NullAllowed] string tokenString, [NullAllowed] string method, FBAEMGraphRequestCompletion completion);
	}

	// @interface FBAEMReporter
	[BaseType (typeof(NSObject))]
	interface FBAEMReporter
	{
		// +(void)configureWithNetworker:(id<FBAEMNetworking> _Nullable)networker appID:(NSString * _Nullable)appID reporter:(id<FBSKAdNetworkReporting> _Nullable)reporter;
		[Static]
		[Export ("configureWithNetworker:appID:reporter:")]
		void Configure ([NullAllowed] IFBAEMNetworking networker, [NullAllowed] string appID, [NullAllowed] IFBSKAdNetworkReporting reporter);

		// +(void)configureWithNetworker:(id<FBAEMNetworking> _Nullable)networker appID:(NSString * _Nullable)appID reporter:(id<FBSKAdNetworkReporting> _Nullable)reporter analyticsAppID:(NSString * _Nullable)analyticsAppID store:(id<FBSDKDataPersisting> _Nullable)store;
		[Static]
		[Export ("configureWithNetworker:appID:reporter:analyticsAppID:store:")]
		void Configure ([NullAllowed] IFBAEMNetworking networker, [NullAllowed] string appID, [NullAllowed] IFBSKAdNetworkReporting reporter, [NullAllowed] string analyticsAppID, [NullAllowed] IFBSDKDataPersisting store);

		// +(void)enable;
		[Static]
		[Export ("enable")]
		void Enable ();

		// +(void)setConversionFilteringEnabled:(id)enabled;
		[Static]
		[Export ("setConversionFilteringEnabled:")]
		void SetConversionFilteringEnabled (bool enabled);

		// +(void)setCatalogMatchingEnabled:(id)enabled;
		[Static]
		[Export ("setCatalogMatchingEnabled:")]
		void SetCatalogMatchingEnabled (bool enabled);

		// +(void)setAdvertiserRuleMatchInServerEnabled:(id)enabled;
		[Static]
		[Export ("setAdvertiserRuleMatchInServerEnabled:")]
		void SetAdvertiserRuleMatchInServerEnabled (bool enabled);

		// +(void)handle:(NSURL * _Nullable)url;
		[Static]
		[Export ("handle:")]
		void HandleUrl ([NullAllowed] NSUrl url);

		// +(void)recordAndUpdateEvent:(NSString * _Nonnull)event currency:(NSString * _Nullable)currency value:(NSNumber * _Nullable)value parameters:(id)parameters;
		[Static]
		[Export ("recordAndUpdateEvent:currency:value:parameters:")]
		void RecordAndUpdateEvent (string @event, [NullAllowed] string currency, [NullAllowed] NSNumber value, NSObject parameters);
	}

	// @protocol FBSKAdNetworkReporting
	interface IFBSKAdNetworkReporting {}
	
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSKAdNetworkReporting
	{
		// @required -(id)shouldCutoff __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("shouldCutoff")]
		bool ShouldCutoff { get; }

		// @required -(id)isReportingEvent:(NSString * _Nonnull)event __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("isReportingEvent:")]
		bool IsReportingEvent (string @event);

		// @required -(void)checkAndRevokeTimer;
		[Abstract]
		[Export ("checkAndRevokeTimer")]
		void CheckAndRevokeTimer ();
	}
}
