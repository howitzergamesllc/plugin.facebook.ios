
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

namespace Facebook.Share
{

	[Flags]
	[Native]
	public enum FBSDKShareBridgeOptions : ulong
	{
		Default = 0x0,
		PhotoAsset = 1uL << 0,
		PhotoImageURL = 1uL << 1,
		VideoAsset = 1uL << 2,
		VideoData = 1uL << 3,
		WebHashtag = 1uL << 4
	}
}