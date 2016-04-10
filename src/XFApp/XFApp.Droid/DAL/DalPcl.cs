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

namespace XFApp.Droid.DAL
{
    class DalPcl
    {
        public void DatabaseTest()
        {
            var db = new SQLitePCL.SQLite3Provider_sqlcipher();
        }
    }
}