# AR Foundation Checker

Check AR Foundation support status and AR session status on iOS/Android devices.

## Description

Check the AR Foundation support status, AR software installation status, and AR session status on ARKit-compatible iOS devices or ARCore-compatible Android devices.  
After checking the status of the AR session, displays the following message.

- The AR System has not been initialized and availability is unknown.
- AR is not supported on the current device.
- The system is checking the availability of AR on the current device.
- AR is supported on the current device, but requires an additional install.
- AR software is being installed
- AR is supported and ready
- An AR session is initializing (i.e., starting up). This usually means AR is working but has not gathered enough information about the environment
- An AR session is running and is tracking (i.e., the device is able to determine its position and orientation in the world).

## Screenshot

![ARFoundationChecker](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker.jpg)

## Usage

### iOS

1. Clone or download this repository
2. Open the Unity project
3. Build Settings
4. Switch Platform (iOS)
5. Build
6. Open the generated Xcode project  
7. Connect iOS device to Mac
8. Run

- Set proper signature information in Unity or Xcode
- ARKit-incompatible devices fail to install apps when running Xcode

### Android

1. Clone or download this repository
2. Open the Unity project
3. Build Settings
4. Switch Platform (Android)
5. Connect Android device to Mac/PC
6. Build And Run

## Requirement

- Unity 2019.2.17f1
- AR Foundation 2.0.2
- ARKit XR Plugin 2.0.1
- ARCore XR Plugin 2.0.2

## Author

[@_shinjism](https://twitter.com/_shinjism)

## References

[AR Foundation](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@2.0/manual/index.html)

## License

MIT
