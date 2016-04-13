using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ksamarin
{
    /// <summary>
    /// Used only to generate an entry in AndroidManifest.xml
    /// </summary>
    [Activity(Name = "com.dropbox.client2.android.AuthActivity")]
#if DEBUG
    [IntentFilter(new[] { Intent.ActionView }, DataScheme = "db-myBetaApp")]
#else
    [IntentFilter(new[] { Intent.ActionView }, DataScheme = "db-myReleaseApp")]
#endif
    public class DropboxRegistration : Activity
    {
    }
}