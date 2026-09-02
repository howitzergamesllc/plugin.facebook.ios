
using System;
using System.Collections.Generic;

using Foundation;
using CoreFoundation;
using ObjCRuntime;
using Security;

namespace Facebook.Share
{
	[Static]
	partial interface Constants
	{
		// extern const NSErrorDomain _Nonnull FBSDKShareErrorDomain;
		[Field ("FBSDKShareErrorDomain", "__Internal")]
		NSString ShareErrorDomain { get; }
	}
}