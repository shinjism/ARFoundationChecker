# AR Foundation Checker

iOS/Androidデバイス上でAR Foundationのサポート状況やARセッションの状況などをチェックします。

## Description

ARKit対応のiOSデバイス、または、ARCore対応のAndroidデバイス上で、AR Foundationのサポート状況、ARソフトウェアのインストール状況、ARセッションの状況をチェックします。  

検出した状況により次のメッセージを表示します(日本語訳はほぼ機械翻訳のままなのでご注意を)。

1. The AR System has not been initialized and availability is unknown.  
(ARシステムは初期化されておらず、使用できるかどうか不明です。)
2. AR is not supported on the current device.  
(ARはこのデバイスではサポートされていません。)
3. The system is checking the availability of AR on the current device.  
(このデバイスでARが使用できるかどうか確認しています。)
4. AR is supported on the current device, but requires an additional install.  
(ARはこのデバイスでサポートされていますが、追加のインストールが必要です。)
5. AR software is being installed  
(ARソフトウェアをインストールしています)
6. AR is supported and ready  
(ARはサポートされており、使用できる状態です)
7. An AR session is initializing (i.e., starting up). This usually means AR is working but has not gathered enough information about the environment  
(ARセッションは初期化中です(つまり、起動中)。これは通常、ARは機能しているものの、環境に関する十分な情報が収集されていないことを意味します)
8. An AR session is running and is tracking (i.e., the device is able to determine its position and orientation in the world).  
(ARセッションが実行されており、トラッキング中です(つまり、デバイスは空間での位置と方向を決定できます)。)

## Screenshot

![ARFoundationChecker](https://raw.githubusercontent.com/shinjism/Screenshot/master/ARFoundationChecker.jpg)

## Usage

- iOSの場合
   - Unityプロジェクトを開く ->  
Build Settings ->  
Switch Platform (iOS) ->  
Build ->  
生成されたXcodeプロジェクトを開く ->  
Run
   - Signing情報はUnity、または、Xcodeで適宜設定する
   - ARKit非対応デバイスは、XcodeでRunした時点でエラーとなる
- Androidの場合
   - Unityプロジェクトを開く ->  
Build Settings ->  
Switch Platform (Android) ->  
Build And Run

## Requirement

- Unity 2019.2.17f1
- AR Foundation 2.0.2
- ARKit XR Plugin 2.0.1
- ARCore XR Plugin 2.0.2

## Author

[@_shinjism](https://twitter.com/_shinjism)

## References

[AR Foundation 公式ドキュメント](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@2.0/manual/index.html)

## License

MIT
