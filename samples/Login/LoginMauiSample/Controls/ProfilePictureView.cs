
namespace LoginMauiSample.Controls;

/// <summary>
/// A view to display a profile picture. 
/// </summary>
/// <remarks>
/// <para>
/// NOTE: With Facebook SDK 18.1.0 and newer, ios defaults to limited login mode.
/// Limited login mode does not have a valid access token so Graph API calls will fail. ProfilePicureView
/// depends on these Graph API calls succeeding when setting the <see cref="Profile"/> property.
/// The profile picture can still be loaded by using <see cref="ImageSource.FromUri(Uri)"/> 
/// and using <see cref="CrossFacebookLogin.CurrentProfile"/> and inputing <see cref="IProfile.ImageURL"/>.
/// </para>
/// <para>
/// NOTE: When using the facebook sdk <see cref="LoginButton"/>, <see cref="LoginTracking"/> must be set to <see cref="LoginTracking.Limited"/>
/// for manual image loading to work.
/// </para>
/// </remarks>
public class ProfilePictureView : ContentView
{
    /// <summary>
    /// Identifies the <see cref="Profile"/> bindable property.
    /// </summary>
    public static readonly BindableProperty ProfileProperty = BindableProperty.Create(nameof(Profile), typeof(IProfile), typeof(ProfilePictureView), null, BindingMode.OneWay);

    /// <summary>
    /// The profile to contruce the picture view from.
    /// </summary>
    public IProfile? Profile
    {
        get => (IProfile?)GetValue(ProfileProperty);
        set => SetValue(ProfileProperty, value);
    }

    /// <summary>
    /// Identifies the <see cref="PictureMode"/> bindable property.
    /// </summary>
    public static readonly BindableProperty PictureModeProperty = BindableProperty.Create(nameof(PictureMode), typeof(ProfilePictureMode), typeof(ProfilePictureView), ProfilePictureMode.Square, BindingMode.OneWay);

    /// <summary>
    /// The mode for the receiver to determine the aspect ratio of the source image.
    /// </summary>
    public ProfilePictureMode PictureMode
    {
        get => (ProfilePictureMode)GetValue(PictureModeProperty);
        set => SetValue(PictureModeProperty, value);
    }

    /// <summary>
    /// Gets the profile identifier associated with the current <see cref="Profile"/>.
    /// </summary>
    public string? ProfileId => Profile?.UserId;
}
