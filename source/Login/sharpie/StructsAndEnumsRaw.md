namespace Facebook.Login
{
	public enum FBSDKAppSwitch
	{
		Disabled = 0,
		Enabled = 1
	}

	public enum FBSDKDefaultAudience
	{
		Friends = 0,
		OnlyMe = 1,
		Everyone = 2
	}

	public enum FBSDKDeviceLoginError
	{
		ExcessivePolling = 1349172,
		AuthorizationDeclined = 1349173,
		AuthorizationPending = 1349174,
		CodeExpired = 1349152
	}

	public enum FBSDKLoginButtonTooltipBehavior
	{
		Automatic = 0,
		ForceDisplay = 1,
		Disable = 2
	}

	public enum FBSDKTooltipViewArrowDirection
	{
		Down = 0,
		Up = 1
	}

	public enum FBSDKTooltipColorStyle
	{
		FriendlyBlue = 0,
		NeutralGray = 1
	}

	public enum FBSDKLimitedLoginRefreshError
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

	public enum FBSDKLoginError
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

	public enum FBSDKLoginTracking
	{
		Enabled = 0,
		Limited = 1
	}

	public enum FBSDKRefreshFallbackPolicy
	{
		Automatic = 0,
		SilentOnly = 1,
		ExplicitOnly = 2,
		DirectOnly = 3
	}
}
