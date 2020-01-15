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

1. Clone or download repository  
![ARFoundationChecker-01](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-01.jpg)
2. Open cloned or downloaded Unity project  
![ARFoundationChecker-02](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-02.jpg)
3. Open Build Settings panel  
![ARFoundationChecker-03](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-03.jpg)
4. Select iOS as build platform, check Development Build and click Switch Platform button  
![ARFoundationChecker-04](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-04_iOS.jpg)
5. Click Build button  
![ARFoundationChecker-05](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-05_iOS.jpg)
6. Open generated Xcode project  
![ARFoundationChecker-06](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-06_iOS.jpg)
7. Select a development team in Project Editor  
![ARFoundationChecker-07](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-07_iOS.jpg)
8. Connect iOS device to Mac, select connected iOS device and click Run button (Notice: ARKit-incompatible devices fail to install apps when running Xcode)  
![ARFoundationChecker-08](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-08_iOS.jpg)

### Android

1. Clone or download repository  
![ARFoundationChecker-01](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-01.jpg)
2. Open cloned or downloaded Unity project  
![ARFoundationChecker-02](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-02.jpg)
3. Open Build Settings panel  
![ARFoundationChecker-03](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-03.jpg)
4. Select Android as build platform, check Development Build and click Switch Platform button  
![ARFoundationChecker-04](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-04_Android.jpg)
5. Connect Android device to Mac/PC and click Build And Run button  
![ARFoundationChecker-05](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker-05_Android.jpg)

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
