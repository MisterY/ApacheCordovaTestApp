# Mmex Alternatives

Here are a couple of possible alternative approaches for Money Manager Ex for Android. 

As there are several possible approaches to making the code multi-platform, it is worth trying them out and see if the benefits can be reaped.

Some issues and findings are [here](https://github.com/moneymanagerex/android-money-manager-ex/issues/777).

Possible improvements:

- Same code base for multiple mobile platforms (Android, iOS, Windows Mobile) and possible desktop (Windows Unified Apps, etc.).
- Database encryption support

## Apache Cordova

A test app using Apache Cordova.

To run, use Visual Studio 2015 or manually configure all the required tools.

## Xamarin

Xamarin test area. Includes a Xamarin.Android app, Xamarin.Forms suite of apps covering all the supported platforms.

Hints:

To set the custom aapt version, see [this](https://forums.xamarin.com/discussion/28181/android-build-tools-21-0-1-aapt-exe-exited-with-code-1073741819-on-windows).