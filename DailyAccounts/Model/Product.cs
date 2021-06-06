using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccounts.Model
{
    class Product
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public string productName { get; set; }
        public int availableStock { get; set; }
        public int saleprice { get; set; }

    }
}
