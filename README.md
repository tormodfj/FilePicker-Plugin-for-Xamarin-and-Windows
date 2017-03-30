## FilePicker Plugin for Xamarin.Forms

Simple cross-platform plug-in that allows you to pick files from the filesystem (iCloud drive in case of iOS) and work with them.

--------

*Forked by [Tormod Fjeldskår](https://github.com/tormodfj) and tailored to specific needs:*
* *Eager loads file contents on pick (using [this approach](https://github.com/Studyxnet/FilePicker-Plugin-for-Xamarin-and-Windows/issues/30))*
* *Removed support for all platforms except Android and iOS*

--------

### Setup

**Platform Support**

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Yes|iOS 6+|
|Xamarin.iOS Unified|Yes|iOS 6+|
|Xamarin.Android|Yes|API 10+|
|Windows Phone Silverlight|No||
|Windows Phone RT|No||
|Windows Store RT|No||
|Windows 10 UWP|No||
|Xamarin.Mac|No||

### API Usage

Call **CrossFilePicker.Current** from any project or PCL to gain access to APIs.

### **IMPORTANT**
**Android:**
The `WRITE_EXTERNAL_STORAGE` & `READ_EXTERNAL_STORAGE` permissions are required.

**iOS:** 
Need [Configure iCloud Driver for your app](https://developer.xamarin.com/guides/ios/platform_features/intro_to_cloudkit)

#### Contributors
* [rafaelrmou](https://github.com/rafaelrmou)
* [jfversluis](https://github.com/jfversluis)
 
Thanks!

#### License
Licensed under main repo license
