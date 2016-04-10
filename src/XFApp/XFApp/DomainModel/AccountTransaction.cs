using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace XFApp.DomainModel
{
    class AccountTransaction
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime TransactionDate { get; set; }

        [MaxLength(255)]
        public string Notes { get; set; }
    }
}
