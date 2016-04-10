using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFApp.DomainModel
{
    class AccountTransaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Notes { get; set; }
    }
}
