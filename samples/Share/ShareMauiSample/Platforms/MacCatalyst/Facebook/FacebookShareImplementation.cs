
using Foundation;

namespace ShareMauiSample;

[Preserve(AllMembers = true)]
internal sealed class FacebookShareImplementation : NSObject, IFacebookShare
{
	public IShareDialog CreateShareDialog(ISharingContent sharingContent) =>
		new ShareDialog(sharingContent);

	public IMessageDialog CreateMessageDialog(ISharingContent sharingContent) =>
		new MessageDialog(sharingContent);
}