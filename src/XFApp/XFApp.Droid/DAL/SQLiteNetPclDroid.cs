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
using XFApp.DAL;

namespace XFApp.Droid.DAL
{
    /// <summary>
    /// SQLite-net PCL version. 
    /// </summary>
    public class SQLiteNetPclDroid
    {
        public void TestDatabase()
        {
            SQLite3Plugin.Init();

            // After this it should be possible to read encrypted db?
            var access = new SQLiteNetPcl();
            access.TestDatabase();
        }
    }
}