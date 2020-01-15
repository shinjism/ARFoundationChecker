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
![Clone or download repository](https://raw.githubusercontent.com/shinjism/Screenshot/blob/master/Clone%20or%20download%20repository.jpg)
2. Open cloned or downloaded Unity project  
![Open cloned or downloaded Unity project](https://raw.githubusercontent.com/shinjism/Screenshot/blob/master/Open%20cloned%20or%20downloaded%20Unity%20project.jpg)
3. Open Build Settings panel  
![Open Build Settings panel](https://raw.githubusercontent.com/shinjism/Screenshot/blob/master/Open%20Build%20Settings%20panel.jpg)
4. Select iOS as build platform and click Switch Platform button  
![Select iOS as build platform and click Switch Platform button](https://raw.githubusercontent.com/shinjism/Screenshot/blob/master/Select%20iOS%20as%20build%20platform%20and%20click%20Switch%20Platform%20button.jpg)
5. Check Development Build and click Build button  
![Check Development Build and click Build button](https://raw.githubusercontent.com/shinjism/Screenshot/blob/master/Check%20Development%20Build%20and%20click%20Build%20button.jpg)
6. Open generated Xcode project  
![Open generated Xcode project](https://raw.githubusercontent.com/shinjism/Screenshot/blob/master/Open%20generated%20Xcode%20project.jpg)
7. Select a development team in Project Editor  
![Select a development team in Project Editor](https://raw.githubusercontent.com/shinjism/Screenshot/blob/master/Select%20a%20development%20team%20in%20Project%20Editor.jpg)
8. Connect iOS device to Mac, select connected iOS device and click Run button  
![Connect iOS device to Mac, select connected iOS device and click Run button](https://raw.githubusercontent.com/shinjism/Screenshot/blob/master/Connect%20iOS%20device%20to%20Mac%2C%20select%20connected%20iOS%20device%20and%20click%20Run%20button.jpg)

ARKit-incompatible devices fail to install apps when running Xcode

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
