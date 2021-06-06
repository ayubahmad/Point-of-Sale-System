using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccounts.Model
{
    class order
    {
        public int id { get; set; }
        public  DateTime dateTime { get; set; }
        public int items { get; set; }
        public int billAmount { get; set; }

    }
}
