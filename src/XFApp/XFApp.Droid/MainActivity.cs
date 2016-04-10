using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SQLitePCL;

namespace XFApp.Droid
{
    [Activity(Label = "XFApp.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // initialize database engine with encryption support
            SQLite3Plugin.Init();
            var sqlcipher = new SQLite3Provider_sqlcipher();
            SQLitePCL.raw.SetProvider(sqlcipher);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

