
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

namespace Facebook.Login
{
	[Native]
	public enum FBSDKAppSwitch : long
	{
		Disabled = 0,
		Enabled = 1
	}

	[Native]
	public enum FBSDKDefaultAudience : long
	{
		Friends = 0,
		OnlyMe = 1,
		Everyone = 2
	}

	[Native]
	public enum FBSDKDeviceLoginError : long
	{
		ExcessivePolling = 1349172,
		AuthorizationDeclined = 1349173,
		AuthorizationPending = 1349174,
		CodeExpired = 1349152
	}

	[Native]
	public enum FBSDKLoginButtonTooltipBehavior : long
	{
		Automatic = 0,
		ForceDisplay = 1,
		Disable = 2
	}

	[Native]
	public enum FBSDKTooltipViewArrowDirection : long
	{
		Down = 0,
		Up = 1
	}

	[Native]
	public enum FBSDKTooltipColorStyle : long
	{
		FriendlyBlue = 0,
		NeutralGray = 1
	}

	[Native]
	public enum FBSDKLimitedLoginRefreshError : long
	{
		NoCurrentToken = 0,
		NotLimitedLogin = 1,
		LoginRequired = 2,
		ConsentRequired = 3,
		UserMismatch = 4,
		NetworkError = 5,
		Timeout = 6,
		RateLimited = 7,
		InvalidResponse = 8,
		Cancelled = 9,
		FeatureDisabled = 10,
		UnsupportedPlatform = 11,
		NotDPoPBound = 12,
		DpopKeyGenerationFailed = 13,
		Unknown = 14
	}

	[Native]
	public enum FBSDKLoginError : long
	{
		Reserved = 300,
		Unknown = 301,
		PasswordChanged = 302,
		UserCheckpointed = 303,
		UserMismatch = 304,
		UnconfirmedUser = 305,
		SystemAccountAppDisabled = 306,
		SystemAccountUnavailable = 307,
		BadChallengeString = 308,
		InvalidIDToken = 309,
		MissingAccessToken = 310
	}

	[Native]
	public enum FBSDKLoginTracking : long
	{
		Enabled = 0,
		Limited = 1
	}

	[Native]
	public enum FBSDKRefreshFallbackPolicy : long
	{
		Automatic = 0,
		SilentOnly = 1,
		ExplicitOnly = 2,
		DirectOnly = 3
	}
}
