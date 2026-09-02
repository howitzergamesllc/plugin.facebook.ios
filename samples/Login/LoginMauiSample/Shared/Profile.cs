
namespace LoginMauiSample;

/// <inheritdoc />
public sealed partial class Profile : IProfile
{
    /// <inheritdoc />
    public string UserId { get; internal set;}

    /// <inheritdoc />
    public string? FirstName { get; internal set; }

    /// <inheritdoc />
    public string? MiddleName { get; internal set; }

    /// <inheritdoc />
    public string? LastName { get; internal set; }

    /// <inheritdoc />
    public string? Name { get; internal set; }

    /// <inheritdoc />
    public Uri? LinkURL { get; internal set; }

    /// <inheritdoc />
    public DateTimeOffset? RefreshDate { get; internal set; }

    /// <inheritdoc />
    public Uri? ImageURL { get; internal set; }

    /// <inheritdoc />
    public string? Email { get; internal set; }

    /// <inheritdoc />
    public IReadOnlySet<string>? FriendIds { get; internal set; }

    /// <inheritdoc />
    public DateTimeOffset? Birthday { get; internal set; }

    /// <inheritdoc />
    public IAgeRange? AgeRange { get; internal set; }

    /// <inheritdoc />
    public ILocation? Hometown { get; internal set; }

    /// <inheritdoc />
    public ILocation? Location { get; internal set; }

    /// <inheritdoc />
    public string? Gender { get; internal set; }

    /// <inheritdoc />
    public IReadOnlySet<string>? GrantedPermissions { get; internal set; }

    /// <inheritdoc />
    public bool IsLimited { get; internal set; }
    
    /// <inheritdoc />
    public string DebugDescription() => $"UserId={UserId}, FirstName={FirstName}, MiddleName={MiddleName}, LastName={LastName}, " +
        $"Name={Name}, LinkURL={LinkURL}, RefreshDate={RefreshDate}, ImageURL={ImageURL}, Email={Email}, " +
        $"AgeRange={AgeRange?.DebugDescription()}, HomeTown={Hometown?.DebugDescription()}, Location={Location?.DebugDescription()}, " +
        $"Gender={Gender}, GrantedPermission={string.Join(", ", GrantedPermissions is null ? [] : GrantedPermissions)}, IsLimited={IsLimited}";
}