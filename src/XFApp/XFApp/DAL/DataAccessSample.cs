//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SQLite.Net;
//using SQLite.Net.Async;
//using SQLite.Net.Interop;
//using SQLitePCL;
//using XFApp.DAL;
//using XFApp.DomainModel;

//namespace XFApp
//{
//    /// <summary>
//    /// The samples using SQLite.Net.
//    /// Reference: https://components.xamarin.com/gettingstarted/sqlite-net/true
//    /// </summary>
//    internal class DataAccessSample
//    {
//        public void ConnectToDatabase()
//        {
//            /**
//             * The platform parameter has to be set in the calling shell app and passed for initialization of the connection.
//             */
//            var db = new SQLiteConnectionWithLock(new DummyPlatform(), new SQLiteConnectionString("path", false));

//            /**
//             * To use asynchronous calls, use the async connection. 
//             */
//            //var connectionFactory = new Func<SQLiteConnectionWithLock>( () => db );
//            //var db = new SQLiteAsyncConnection(connectionFactory);
            
//            // Create schema.

//            //db.CreateTable<AccountTransaction>();

//            // Insert data

//            var tx = new AccountTransaction();
//            db.Insert(tx);

//            // Query

//            var query = db.Table<AccountTransaction>().Where(x => x.TransactionDate < DateTime.Today);
//            foreach (var accountTransaction in query)
//            {
//                //Console.WriteLine(accountTransaction);
//            }
//            // or
//            var adHocQuery = db.Query<AccountTransaction>("select * from CheckingAccount_V1 where TransDate <='2016-04-10'");
//            var adHocResult = adHocQuery.FirstOrDefault();

//            // Update data.

//            db.Update(adHocResult);
//        }
//    }
//}
