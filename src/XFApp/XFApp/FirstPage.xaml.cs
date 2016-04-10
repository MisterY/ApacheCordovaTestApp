using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;
using Xamarin.Forms;
using XFApp.DomainModel;

namespace XFApp
{
    public partial class FirstPage : ContentPage
    {
        private const string EncryptedPath = "/mnt/sdcard/Download/Encrypted.db";
        private const string UnencryptedPath = "/mnt/sdcard/Download/UnEncrypted.db";

        public FirstPage()
        {
            InitializeComponent();
        }

        void OnCreateClicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Message", "this will create a database", "close");

            var db = new SQLiteConnection(UnencryptedPath);

            db.CreateTable<Test>();

            db.Insert(new Test()
            {
                TestText = "blah blah"
                //TransactionDate = DateTime.Now,
                //Notes = "first record"
            });

            var query = db.Table<Test>();
            foreach (var record in query)
            {
                Debug.WriteLine("Test: {0}, {1}", record.Id, record.TestText);
            }

            db.Close();
            db.Dispose();
        }

        void OnEncryptClicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Message", "this will encrypt the database", "close");

            /**
             * Encryption using .raw works.
             */
            //sqlite3 db;
            //raw.sqlite3_open(UnencryptedPath, out db);
            //raw.sqlite3_exec(db, "ATTACH DATABASE '" + EncryptedPath + "' AS encrypted KEY 'testkey';");
            //raw.sqlite3_exec(db, "SELECT sqlcipher_export('encrypted');");
            //raw.sqlite3_exec(db, "DETACH DATABASE encrypted;");

            // This does not work.
            //var db = new SQLiteConnection(UnencryptedPath);
            //db.Execute("ATTACH DATABASE '" + EncryptedPath + "' AS encrypted KEY 'testkey';");
            //db.Execute("SELECT sqlcipher_export('encrypted');");
            //db.Execute("DETACH DATABASE encrypted;");

            //db.Dispose();
        }

        void OnReadUnencryptedClicked(object sender, EventArgs eventArgs)
        {
            try
            {
                var db = new SQLiteConnection(UnencryptedPath);
                var query = db.Table<Test>();
                foreach (var test in query)
                {
                    Debug.WriteLine("Test: {0}, {1}", test.Id, test.TestText);
                }

                db.Close();
                db.Dispose();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "close");
                //Debug.WriteLine(ex.Message);
            }
        }

        void OnEncryptReadClicked(object sender, EventArgs eventArgs)
        {
            try
            {
                var db = new SQLiteConnection(EncryptedPath);
                db.Execute("PRAGMA key = 'testkey';");
                var query = db.Table<Test>();
                foreach (var test in query)
                {
                    Debug.WriteLine("Test: {0}, {1}", test.Id, test.TestText);
                }

                db.Close();
                db.Dispose();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "close");
                //Debug.WriteLine(ex.Message);
            }
        }
    }
}
