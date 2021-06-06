using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccounts.Model
{
    class Order_detail
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int prductId { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
    }
}
