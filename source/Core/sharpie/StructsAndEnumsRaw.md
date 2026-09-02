using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

namespace Facebook.Core
{

	[Native]
	public enum FBSDKAdvertisingTrackingStatus : ulong
	{
		Allowed,
		Disallowed,
		Unspecified
	}

	[Native]
	public enum FBSDKAppEventsFlushBehavior : ulong
	{
		Auto = 0,
		ExplicitOnly
	}

	[Native]
	public enum FBSDKAppEventsFlushReason : ulong
	{
		Explicit,
		Timer,
		SessionChange,
		PersistedEvents,
		EventThreshold,
		EagerlyFlushingEvent
	}

	[Flags]
	[Native]
	public enum FBSDKGraphRequestFlags : ulong
	{
		None = 0x0,
		SkipClientToken = 1uL << 1,
		DoNotInvalidateTokenOnError = 1uL << 2,
		DisableErrorRecovery = 1uL << 3
	}

	[Native]
	public enum FBSDKProductAvailability : ulong
	{
		InStock = 0,
		OutOfStock,
		PreOrder,
		AvailableForOrder,
		Discontinued
	}

	[Native]
	public enum FBSDKProductCondition : ulong
	{
		New = 0,
		Refurbished,
		Used
	}

	[Native]
	public enum FBSDKAppLinkNavigationType : long
	{
		Failure,
		Browser,
		App
	}

	[Native]
	public enum FBSDKBridgeAPIProtocolType : ulong
	{
		Native,
		Web
	}

	[Native]
	public enum FBSDKCoreError : long
	{
		Reserved = 0,
		Encryption,
		InvalidArgument,
		Unknown,
		Network,
		AppEventsFlush,
		GraphRequestNonTextMimeTypeReturned,
		GraphRequestProtocolMismatch,
		GraphRequestGraphAPI,
		DialogUnavailable,
		AccessTokenRequired,
		AppVersionUnsupported,
		BrowserUnavailable,
		BridgeAPIInterruption,
		BridgeAPIResponse
	}

	[Native]
	public enum FBSDKGraphRequestError : ulong
	{
		Other = 0,
		Transient = 1,
		Recoverable = 2
	}


	[Native]
	public enum FBSDKFeature : ulong
	{
		None = 0,
		Core = 16777216,
		AppEvents = 16842752,
		CodelessEvents = 16843008,
		RestrictiveDataFiltering = 16843264,
		Aam = 16843520,
		PrivacyProtection = 16843776,
		SuggestedEvents = 16843777,
		IntelligentIntegrity = 16843778,
		ModelRequest = 16843779,
		ProtectedMode = 16843780,
		MACARuleMatching = 16843781,
		BlocklistEvents = 16843782,
		FilterRedactedEvents = 16843783,
		FilterSensitiveParams = 16843784,
		StdParamEnforcement = 16843785,
		BannedParamFiltering = 16843786,
		Vvp = 16843787,
		EventDeactivation = 16844032,
		SKAdNetwork = 16844288,
		SKAdNetworkConversionValue = 16844289,
		SKAdNetworkV4 = 16844290,
		ATELogging = 16844544,
		Aem = 16844800,
		AEMConversionFiltering = 16844801,
		AEMCatalogMatching = 16844802,
		AEMAdvertiserRuleMatchInServer = 16844803,
		AEMAutoSetup = 16844804,
		AEMAutoSetupProxy = 16844805,
		AppEventsCloudbridge = 16845056,
		IAPLoggingSK2 = 16846848,
		IOSManualImplicitPurchaseDedupe = 16846849,
		Instrument = 16908288,
		CrashReport = 16908544,
		CrashShield = 16908545,
		ErrorReport = 16908800,
		Login = 33554432,
		LoginFastAppSwitch = 33619968,
		LimitedLoginRefresh = 33685504,
		LimitedLoginFastAppSwitch = 33751040,
		Share = 50331648,
		GamingServices = 67108864
	}

	[Flags]
	[Native]
	public enum FBSDKServerConfigurationSmartLoginOptions : ulong
	{
		Unknown = 0x0,
		Enabled = 1uL << 0,
		RequireConfirmation = 1uL << 1
	}
}