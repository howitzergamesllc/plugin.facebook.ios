
namespace ShareMauiSample;

/// <summary>
/// Manages the global FacebookShare state, provides methods to create
/// <see cref="IShareDialog"/> and <see cref="IMessageDialog"/>.
/// </summary>
public interface IFacebookShare : IDisposable
{
	/// <summary>
	/// Creates a new <see cref="IShareDialog"/> for sharing content to facebook. A base interface for content to be shared.
	/// </summary>
	/// <param name="sharingContent">The content to be shared.</param>
	/// <returns>A new <see cref="IShareDialog"/> with an empty source.</returns>
	IShareDialog CreateShareDialog(ISharingContent sharingContent);

	/// <summary>
	/// Creates a new <see cref="IMessageDialog"/>. A dialog for sharing content through Messenger.
	/// </summary>
	/// <remarks>
	/// SUPPORTED SHARE TYPES
	/// <list type="bullet">
	/// <item>FBSDKShareLinkContent</item>
	/// </list>
	/// UNSUPPORTED SHARE TYPES (DEPRECATED AUGUST 2018)
	/// <list type="bullet">
	/// <item>FBSDKShareOpenGraphContent</item>
	/// <item>FBSDKSharePhotoContent</item>
	/// <item>FBSDKShareVideoContent</item>
	/// <item>FBSDKShareMessengerOpenGraphMusicTemplateContent</item>
	/// <item>FBSDKShareMessengerMediaTemplateContent</item>
	/// <item>FBSDKShareMessengerGenericTemplateContent</item>
	/// <item>Any other types that are not one of the four supported types listed above</item>
	/// </list>
	/// </remarks>
	/// <param name="sharingContent">The facebook permissions to request for the device login. Defaults to requesting no permissions.</param>
	/// <returns>A new <see cref="IMessageDialog"/>.</returns>
	IMessageDialog CreateMessageDialog(ISharingContent sharingContent);
}
