using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using XFApp.DomainModel;

namespace XFApp
{
    public partial class FirstPage : ContentPage
    {
        private const string EncryptedPath = "/mnt/sdcard/Download/UnEncrypted.db";
        private const string UnencryptedPath = "";

        public FirstPage()
        {
            InitializeComponent();

            
        }

        public void OpenDatabase()
        {
            
        }

        void OnCreateClicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Message", "this should create a database", "close");

            var db = new SQLiteConnection(UnencryptedPath);

            db.CreateTable<AccountTransaction>();

            db.Insert(new AccountTransaction()
            {
                TransactionDate = DateTime.Now,
                Notes = "first record"
            });

            var query = db.Table<AccountTransaction>();
            foreach (var record in query)
            {
                Debug.WriteLine("Test: {0}, {1}", record.Id, record.Notes);
            }

            db.Close();
            db.Dispose();
        }

        void OnEncryptClicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Message", "this should encrypt a database", "close");


        }

        void OnEncryptReadClicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Message", "this should open an encrypted database", "close");

            var db = new SQLiteConnection(EncryptedPath);
            db.Execute("PRAGMA key = 'testkey';");
            var query = db.Table<AccountTransaction>();
            foreach (var test in query)
            {
                Debug.WriteLine("Test: {0}, {1}, {2}", test.Id, test.TransactionDate, test.Notes);
            }

            db.Close();
            db.Dispose();
        }
    }
}
