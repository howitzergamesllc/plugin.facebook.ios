
using Facebook.Login;
using UIKit;
using Foundation;

namespace LoginMauiSample;
internal sealed class DeviceLoginManager : IDeviceLoginManager
{
    private readonly FBSDKDeviceLoginManager _native;

    public DeviceLoginManager(IEnumerable<string> permissions, bool enableSmartLogin)
    {
        _native = new FBSDKDeviceLoginManager(permissions.ToArray(), enableSmartLogin);
        Permissions = permissions.ToArray();
        _native.Started += OnLoginStarted;
        _native.Completed += OnLoginCompleted;
    }

    public IReadOnlyList<string> Permissions { get; }

    public Uri? RedirectUrl
    {
        get
        {
            var absolute = _native.RedirectURL?.AbsoluteString;
            return string.IsNullOrWhiteSpace(absolute) ? null : new Uri(absolute);
        }

        set
        {
            _native.RedirectURL = value is null ? null : new NSUrl(value.AbsoluteUri);
        }
    }

    public void Start() => _native.Start();

    public void Cancel() => _native.Cancel();
    
    public event EventHandler<DeviceLoginStartedEventArgs>? Started;

    public event EventHandler<DeviceLoginCompletedEventArgs>? Completed;

    private void OnLoginStarted(object? sender, FBSDKDeviceLoginStartedEventArgs e) => 
        Started?.Invoke(this, new DeviceLoginStartedEventArgs(e.CodeInfo.ToCodeInfo()));

    private void OnLoginCompleted(object? sender, FBSDKDeviceLoginCompletedEventArgs e) =>  
        Completed?.Invoke(this, new DeviceLoginCompletedEventArgs(e.Result?.ToDeviceLoginResult(), e.Error?.ToDeviceLoginException()));
}