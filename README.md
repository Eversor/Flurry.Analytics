The Flurry Analytics Agent allows you to track the usage and behavior of your Android, iOS or Windows Phone application on users' phones for viewing in the Flurry Analytics system. It is designed to be as easy as possible with a basic setup complete in few minutes.

## Features

There are many features available in the Flurry Analytics API, such as:

* Session tracking
* Event logging, with optional parameters
* Page View tracking
* Demographics tracking, such as age, gender and user id
* Location tracking
* App version tracking
* And much more...

## Getting Started
The setup for all the platforms is very easy with only a few steps:

### Android
1. Add the `INTERNET` permission to `AndroidManifest.xml`.
2. Add `FlurryAgent.Init(this, "YOUR_API_KEY");` to the `OnCreate` method of your `Application`.
3. Only if you are targeting Android versions below 4.0, are two extra steps required:
  1. Add `FlurryAgent.OnStartSession(this);` to the `OnStart` method of the Activity or Service.
  2. Add `FlurryAgent.OnEndSession(this);` to the `OnStop` method of the Activity or Service.

If you are only targeting Android 4.0 or greater, Flurry Analytics will automatically be registered with the activity lifecycle events.  
This is done through the `Application.IActivityLifecycleCallbacks` interface.

### iOS
1. Add `FlurryAgent.StartSession("YOUR_API_KEY");` to the `FinishedLaunching` method of the application delegate, such as `UIApplicationDelegate`

### Windows Phone
1. Add `ID_CAP_NETWORKING` and `ID_CAP_IDENTITY_DEVICE` capabilities to `WMAppManifest.xml`.
2. Add `FlurryWP8SDK.Api.StartSession("YOUR_API_KEY");` to `Launching` and `Activated` events of the `Application`.

And that's it, your mobile app will start sending activity usage statistics to the Flurry servers!


## Advanced

Flurry Analytics SDK supported versions:

* SDK for iOS supports **iOS 5** and above
* SDK for Android supports **Android API level 10** (Gingerbread) and above
* SDK for Windows Phone supports **Windows Phone 8 (Silverlight)** and above
* 