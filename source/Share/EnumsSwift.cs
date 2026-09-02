
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

namespace Facebook.Share
{
	[Native]
	public enum FBSDKAppInviteDestination : long
	{
		Facebook = 0,
		Messenger = 1
	}

	[Native]
	public enum FBSDKShareDialogMode : long
	{
		Automatic = 0,
		NativeMode = 1,
		ShareSheet = 2,
		Browser = 3,
		Web = 4,
		FeedBrowser = 5,
		FeedWeb = 6
	}

	[Native]
	public enum FBSDKShareError : long
	{
		Reserved = 200,
		OpenGraph = 201,
		DialogNotAvailable = 202,
		Unknown = 203
	}
}
