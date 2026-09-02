namespace Facebook.GamingServices
{
	public enum FBSDKChooseContextFilter
	{
		None = 0,
		ExistingChallenges = 1,
		NewPlayersOnly = 2,
		NewContextOnly = 3
	}

	public enum FBSDKGameRequestActionType
	{
		None = 0,
		Send = 1,
		AskFor = 2,
		Turn = 3,
		Invite = 4
	}

	public enum FBSDKGameRequestFilter
	{
		None = 0,
		AppUsers = 1,
		AppNonUsers = 2,
		Everybody = 3
	}
}
