
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

namespace Facebook.GamingServices
{
	[Native]
	public enum FBSDKChooseContextFilter : long
	{
		None = 0,
		ExistingChallenges = 1,
		NewPlayersOnly = 2,
		NewContextOnly = 3
	}

	[Native]
	public enum FBSDKGameRequestActionType : long
	{
		None = 0,
		Send = 1,
		AskFor = 2,
		Turn = 3,
		Invite = 4
	}

	[Native]
	public enum FBSDKGameRequestFilter : long
	{
		None = 0,
		AppUsers = 1,
		AppNonUsers = 2,
		Everybody = 3
	}
}
