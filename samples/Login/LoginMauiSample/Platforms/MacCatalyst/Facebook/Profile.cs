
using CoreGraphics;
using Facebook.Core;

namespace LoginMauiSample;

/// <inheritdoc />
public sealed partial class Profile : IProfile
{
    internal readonly FBSDKProfile nativeProfile;
    internal Profile(FBSDKProfile nativeProfile)
    {
        this.nativeProfile = nativeProfile;        
        UserId = nativeProfile.UserID;
        FirstName = nativeProfile.FirstName;
        MiddleName = nativeProfile.MiddleName;
        LastName = nativeProfile.LastName;
        Name = nativeProfile.Name;
        LinkURL = nativeProfile.LinkURL;
        RefreshDate = nativeProfile.RefreshDate.ToDateTimeOffset();
        ImageURL = nativeProfile.ImageURL;
        Email = nativeProfile.Email;
        FriendIds = nativeProfile.FriendIDs?.ToHashSet<string>();
        Birthday = nativeProfile.Birthday?.ToDateTimeOffset();
        AgeRange = nativeProfile.AgeRange?.ToAgeRange();
        Hometown = nativeProfile.Hometown?.ToLocation();
        Location = nativeProfile.Location?.ToLocation();
        Gender = nativeProfile.Gender;
        GrantedPermissions = nativeProfile.Permissions?.ToRawPermissions();
        IsLimited = nativeProfile.IsLimited;
    }
    
    /// <inheritdoc />
    public Uri? GetProfilePictureUri(ProfilePictureMode mode) => nativeProfile.GetImageURL(mode.ToNativePictureMode(), CGSize.Empty).ToUri();
}