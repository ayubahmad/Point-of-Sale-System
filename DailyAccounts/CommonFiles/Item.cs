using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccounts.CommonFiles
{
    class Item
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public int amount { get; set; }
        public Item(int productId, string name, int quantity, int amount)
        {
            this.productId = productId;
            this.productName = name;
            this.quantity = quantity;
            this.amount = amount;
        }
    }
}
