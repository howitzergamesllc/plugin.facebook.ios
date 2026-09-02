namespace Facebook.Share
{
	public enum FBSDKAppInviteDestination
	{
		Facebook = 0,
		Messenger = 1
	}

	public enum FBSDKShareDialogMode
	{
		Automatic = 0,
		Native = 1,
		ShareSheet = 2,
		Browser = 3,
		Web = 4,
		FeedBrowser = 5,
		FeedWeb = 6
	}

	public enum FBSDKShareError
	{
		Reserved = 200,
		OpenGraph = 201,
		DialogNotAvailable = 202,
		Unknown = 203
	}
}
