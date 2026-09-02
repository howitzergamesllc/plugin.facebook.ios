# plugin.facebook.ios

## Todo:

## Bugs:

## Setup:

## Note: Gaming Services SDK Not Built for Now.

### Build the Project folders

- Navigate to your Visual Studio Projects folder
```zsh
cd "Path/to/your/projects```

- Make a directory to manage all the repos
```zsh
mkdir -p Plugin.FacebookKit
```

- Download/fork/pull the repo to a shortpath folder and document the base project repo filepath.
```zsh
git clone https://github.com/howitzergamesllc/plugin.facebook.ios.git
```

- Navigate to the root
```zsh
cd plugin.facebook.ios
```

- Adding the remote origin
```zsh
git remote add origin https://github.com/youraccount/plugin.facebook.ios.git
```

#### Build and extract the xcframeworks to the project "externals" folder:

- Navigate and make swift folder, and clone the firebase-ios-sdk repo again.
```zsh
mkdir -p swift
cd swift
git clone https://github.com/facebook/facebook-ios-sdk.git
```

#### (If already build once) Update the facebook-ios-sdk repo in the ./swift folder
- Navigate to the repo
```zsh
cd "facebook-ios-sdk"
```
- Update the repo
```zsh
git fetch
git pull
```

### Extract the xcframeworks(FBSDKCoreKit, FBSDKCoreBasicsKit, FBSDKLoginKit, FBSDKShareKit, FBAEMKit, FBSDKGamingServicesKit).

## All steps from the temporary "facebook-ios-sdk" repo.

- First expose the framework Schemes
```zsh
mkdir -p FacebookSDK.xcworkspace/xcshareddata/xcschemes
cp .swiftpm/xcode/xcshareddata/xcschemes/*.xcscheme \
   FacebookSDK.xcworkspace/xcshareddata/xcschemes/
```
- Verify the all schemes are available
```zsh
xcodebuild -workspace FacebookSDK.xcworkspace -list
```
- It should print:
```zsh
Information about workspace "FacebookSDK":
    Schemes:
        BuildAllKits-Dynamic
        BuildAllKits-Static
        Facebook-Package
        FacebookAEM
        FacebookBasics
        FacebookCore
        FacebookGamingServices
        FacebookLogin
        FacebookShare
```

- Build a xcode project to pull frameworks in from the cache
```zsh
swift package generate-xcodeproj
```

- Get the xcframeworks from the cache and put them in the externals folder
```zsh
mkdir -p "../../externals"

cp -R ~/Library/Developer/Xcode/DerivedData/facebook-ios-sdk-*/SourcePackages/artifacts/facebook-ios-sdk/*/*.xcframework \
"../../externals/"
```

- Navigate back to the root
```zsh
cd ../..
```

### Flatten the xcframework:

- Make all scripts executable
```zsh
cd "$HOME/Path/to/your/projects/Plugin.FacebookKit/plugin.facebook.ios"
chmod +x flatten_facebook.sh
chmod +x clean.sh
chmod +x cleansamples.sh
```

- Flatten the xcframeworks for dSYM removal
```zsh
./flatten_facebook.sh
```

- Clean
```zsh
./clean.sh
```

- Build the source code nuget packages first for use in the .Nuget.sln and Nuget.Local.Config
```zsh
dotnet build plugin.facebook.ios.slnx --configfile Nuget.Config
```

- Now build the nuget solution to inject the local nuget packages into the roslyn compiler.
```zsh
dotnet build plugin.facebook.ios.Nuget.slnx --configfile Nuget.Local.Config
```


## (SDK UPDATES) Use objectivesharpie to generate new ApiDefinitions, Enums, Structs

### Firebase
- FBAEMKit
```zsh
sharpie bind \
    ./externals/FBAEMKit.xcframework/ios-arm64_arm64e/FBAEMKit.framework/Headers/FBAEMKit-swift.h \
    --output=source/AEM/sharpie \
    --namespace=Facebook.AEM \
    --sdk=iphoneos26.5 \
    -c -F ./externals/FBAEMKit.xcframework/ios-arm64_arm64e
```
- FBSDKCoreKit_Basics
```zsh
sharpie bind \
    ./externals/FBSDKCoreKit_Basics.xcframework/ios-arm64_arm64e/FBSDKCoreKit_Basics.framework/Headers/FBSDKCoreKit_Basics.h \
    --output=source/CoreBasics/sharpie \
    --namespace=Facebook.CoreBasics \
    --sdk=iphoneos26.5 \
    -c -F ./externals/FBSDKCoreKit_Basics.xcframework/ios-arm64_arm64e
```
- FBSDKCoreKit
```zsh
sharpie bind \
    ./externals/FBSDKCoreKit.xcframework/ios-arm64_arm64e/FBSDKCoreKit.framework/Headers/FBSDKCoreKit.h \
    --output=source/Core/sharpie \
    --namespace=Facebook.Core \
    --sdk=iphoneos26.5 \
    -c -F ./externals/FBSDKCoreKit.xcframework/ios-arm64_arm64e
sharpie bind \
    ./externals/FBSDKCoreKit.xcframework/ios-arm64_arm64e/FBSDKCoreKit.framework/Headers/FBSDKCoreKit-Swift.h \
    --output=source/Core/sharpie \
    --namespace=Facebook.Core \
    --sdk=iphoneos26.5 \
    -c -F ./externals/FBSDKCoreKit.xcframework/ios-arm64_arm64e
```
- FBSDKLoginKit
```zsh
sharpie bind \
    ./externals/FBSDKLoginKit.xcframework/ios-arm64_arm64e/FBSDKLoginKit.framework/Headers/FBSDKLoginKit.h \
    --output=source/Login/sharpie \
    --namespace=Facebook.Login \
    --sdk=iphoneos26.5 \
    -c -F ./externals/FBSDKLoginKit.xcframework/ios-arm64_arm64e
sharpie bind \
    ./externals/FBSDKLoginKit.xcframework/ios-arm64_arm64e/FBSDKLoginKit.framework/Headers/FBSDKLoginKit-Swift.h \
    --output=source/Login/sharpie \
    --namespace=Facebook.Login \
    --sdk=iphoneos26.5 \
    -c -F ./externals/FBSDKLoginKit.xcframework/ios-arm64_arm64e
```
- FBSDKShareKit
```zsh
sharpie bind \
    ./externals/FBSDKShareKit.xcframework/ios-arm64_arm64e/FBSDKShareKit.framework/Headers/FBSDKShareKit.h \
    --output=source/Share/sharpie \
    --namespace=Facebook.Share \
    --sdk=iphoneos26.5 \
    -c -F ./externals/FBSDKShareKit.xcframework/ios-arm64_arm64e
sharpie bind \
    ./externals/FBSDKShareKit.xcframework/ios-arm64_arm64e/FBSDKShareKit.framework/Headers/FBSDKShareKit-Swift.h \
    --output=source/Share/sharpie \
    --namespace=Facebook.Share \
    --sdk=iphoneos26.5 \
    -c -F./externals/FBSDKShareKit.xcframework/ios-arm64_arm64e
```
- FBSDKGamingServicesKit
```zsh
sharpie bind \
    ./externals/FBSDKGamingServicesKit.xcframework/ios-arm64_arm64e/FBSDKGamingServicesKit.framework/Headers/FBSDKGamingServicesKit-swift.h \
    --output=source/GamingServices/sharpie \
    --namespace=Facebook.GamingServices \
    --sdk=iphoneos26.5 \
    -c -F ./externals/FBSDKGamingServicesKit.xcframework/ios-arm64_arm64e
sharpie bind \
    ./externals/FBSDKGamingServicesKit.xcframework/ios-arm64_arm64e/FBSDKGamingServicesKit.framework/Headers/FBSDKGamingServicesKit-swift.h \
    --output=source/GamingServices/sharpie \
    --namespace=Facebook.GamingServices \
    --sdk=iphoneos26.5 \
    -c -F./externals/FBSDKGamingServicesKit.xcframework/ios-arm64_arm64e
```


## Test Build the Samples:

### Facebook

```zsh
//Build without Nuget
dotnet build samples/Login/LoginMauiSample/LoginMauiSample.csproj
dotnet build samples/Share/ShareMauiSample/ShareMauiSample.csproj

//Before Publishing
dotnet build samples/Login/LoginMauiSample/LoginMauiSample.Nuget.csproj --configfile Nuget.Local.Config
dotnet build samples/Share/ShareMauiSample/ShareMauiSample.Nuget.csproj --configfile Nuget.Local.Config

//After Publishing
dotnet build samples/Login/LoginMauiSample/LoginMauiSample.Nuget.csproj
dotnet build samples/Share/ShareMauiSample/ShareMauiSample.Nuget.csproj
```

## Build Nuget Packages for Debugging and Pushing:

### Facebook
```zsh
dotnet build source/AEM/AEM.csproj
dotnet build source/Core/Core.csproj
dotnet build source/CoreBasics/CoreBasics.csproj
dotnet build source/GamingServices/GamingServices.csproj
dotnet build source/Login/Login.csproj
dotnet build source/Share/Share.csproj
```
```zsh
dotnet build source/AEM/AEM.csproj -c Release
dotnet build source/Core/Core.csproj -c Release
dotnet build source/CoreBasics/CoreBasics.csproj -c Release
dotnet build source/GamingServices/GamingServices.csproj -c Release
dotnet build source/Login/Login.csproj -c Release
dotnet build source/Share/Share.csproj -c Release
```

## GitHub Publishing Commands
- Selecting the repo
```zsh
cd "$HOME/Path/to/your/projects/Plugin.FacebookKit/plugin.facebook.ios"
```
- Adding the remote origin
```zsh
git remote add origin https://github.com/youraccount/plugin.facebook.ios.git
```
- Ensure the right branch is selected
```zsh
git branch -m main
```
- Adding recent changes to the branch
```zsh
git add .
```
- Checking the status of the local repo
```zsh
git status
```
- Fetching recent commits to compare with the local repo   
```zsh
git fetch
```
- Pulling recent changes to the local repo
```zsh
git pull
```
- Committing new changes to the local repo
```zsh
git commit -m "Initial commit with project files"
```
- Pushing new commits to remote origin
```zsh
git push -u origin main
```

## Push package for private publishing.
- Set api key you use for publishing to git hub
```zsh
GITHUBTOKEN=ghp_yoursuperlonguniqueapikeyhere
```

### Publishing
```zsh
dotnet nuget push "$HOME/Path/to/your/projects/Plugin.FacebookKit/plugin.facebook.ios/source/AEM/bin/Release/plugin.Facebook.iOS.AEM.10.0.80.nupkg" --source "https://nuget.pkg.github.com/youraccount/index.json" --api-key $GITHUBTOKEN
dotnet nuget push "$HOME/Path/to/your/projects/Plugin.FacebookKit/plugin.facebook.ios/source/CoreBasics/bin/Release/plugin.Facebook.iOS.CoreBasics.10.0.80.nupkg" --source "https://nuget.pkg.github.com/youraccount/index.json" --api-key $GITHUBTOKEN
dotnet nuget push "$HOME/Path/to/your/projects/Plugin.FacebookKit/plugin.facebook.ios/source/Core/bin/Release/plugin.Facebook.iOS.Core.10.0.80.nupkg" --source "https://nuget.pkg.github.com/youraccount/index.json" --api-key $GITHUBTOKEN
dotnet nuget push "$HOME/Path/to/your/projects/Plugin.FacebookKit/plugin.facebook.ios/source/GamingServices/bin/Release/plugin.Facebook.iOS.GamingServices.10.0.80.nupkg" --source "https://nuget.pkg.github.com/youraccount/index.json" --api-key $GITHUBTOKEN
dotnet nuget push "$HOME/Path/to/your/projects/Plugin.FacebookKit/plugin.facebook.ios/source/Login/bin/Release/plugin.Facebook.iOS.Login.10.0.80.nupkg" --source "https://nuget.pkg.github.com/youraccount/index.json" --api-key $GITHUBTOKEN
dotnet nuget push "$HOME/Path/to/your/projects/Plugin.FacebookKit/plugin.facebook.ios/source/Share/bin/Release/plugin.Facebook.iOS.Share.10.0.80.nupkg" --source "https://nuget.pkg.github.com/youraccount/index.json" --api-key $GITHUBTOKEN
```

### Setup the sample projects
Updating sample projects to dotnet maui (Example: Facebook.Core)
1. Create and add the project to the solution

dotnet new maui -n CoreMauiSample.Nuget -o samples/Core/CoreMauiSample

dotnet new maui -n CoreMauiSample -o samples/Core/CoreMauiSample --force

2. Modify the projects to match the old examples and improve if desired.
3. Update the solution files

dotnet sln plugin.facebook.ios.slnx add samples/Core/CoreMauiSample/CoreMauiSample.csproj

dotnet sln plugin.facebook.ios.Nuget.slnx add samples/Core/CoreMauiSample/CoreMauiSample.Nuget.csproj

8. Too remove the old samples from the solution.

dotnet sln plugin.facebook.ios.slnx remove samples/Core/CoreMauiSample/CoreMauiSample.csproj

dotnet sln plugin.facebook.ios.Nuget.slnx remove samples/Core/CoreMauiSample/CoreMauiSample.Nuget.csproj

9. Verify new projects build correctly.
10. Commit changes.
