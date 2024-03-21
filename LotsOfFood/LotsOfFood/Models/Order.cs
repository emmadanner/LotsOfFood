using System;
using System.Collections.Generic;
using System.Text;

namespace LotsOfFood.Models
{
    // stores user's previous orders
    internal class Order
    {
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public string Description { get; set; }
        // need something to store the order items as well
        public int OrderTotal { get; set; }
    }
}
