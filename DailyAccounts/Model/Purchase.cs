using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccounts.Model
{
    class Purchase
    {
        public int id { get; set; }
        public int productId { get; set; }
        public DateTime dateTime { get; set; }
        public int quantity { get; set; }
        public int paidAmount { get; set; }

    }
}
