
namespace LoginMauiSample
{
    /// <summary>
    /// Sealed shared class to lazy initialize the Facebook Login SDKs
    /// </summary>
    public sealed class CrossFacebookLogin
    {
        private static Lazy<IFacebookLogin> _implementation = new Lazy<IFacebookLogin>(CreateInstance, System.Threading.LazyThreadSafetyMode.PublicationOnly);

        private static IFacebookLogin CreateInstance()
        {
#if IOS || MACCATALYST
            return new FacebookLoginImplementation();
#else
#pragma warning disable IDE0022 // Use expression body for methods
            return null;
#pragma warning restore IDE0022 // Use expression body for methods
#endif
        }

        /// <summary>
        /// Gets if the plugin is supported on the current platform.
        /// </summary>
        public static bool IsSupported => _implementation.Value != null;

        /// <summary>
        /// Current plugin implementation to use
        /// </summary>
        public static IFacebookLogin Current {
            get {
                var ret = _implementation.Value;
                if(ret == null) {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        private static Exception NotImplementedInReferenceAssembly() =>
            new NotImplementedException("This functionality is not implemented in the portable version of this assembly. You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

#if IOS || MACCATALYST
        /// <summary>
        /// An initialization method to call for iOS implementation
        /// </summary>
        public static void Initialize(bool automaticallyUpdateProfileOnAccessTokenChange = true)
        {
            FacebookLoginImplementation.Initialize(automaticallyUpdateProfileOnAccessTokenChange);
        }

        public static IAccessToken? CurrentToken => Current.CurrentAccessToken;

        public static Task<IProfile?> LoadCurrentProfileAsync() => Current.LoadCurrentProfileAsync();

        public static IProfile? CurrentProfile => Current.CurrentProfile;
#endif

        /// <summary>
        /// Dispose of everything 
        /// </summary>
        public static void Dispose()
        {
            if(_implementation != null && _implementation.IsValueCreated) {
                _implementation.Value.Dispose();
                _implementation = new Lazy<IFacebookLogin>(CreateInstance, System.Threading.LazyThreadSafetyMode.PublicationOnly);
            }
        }
    }
}