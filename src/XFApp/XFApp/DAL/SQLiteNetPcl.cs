using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using XFApp.DomainModel;

namespace XFApp.DAL
{
    /// <summary>
    /// Using SQLite-net PCL library.
    /// </summary>
    public class SQLiteNetPcl
    {
        public void TestDatabase()
        {
            string path = "";
            var db = new SQLiteConnection(path);

            var result = db.Query<AccountTransaction>("select * from checkingtransaction_v1");

            Debug.WriteLine(result.Count);
        }
    }
}
