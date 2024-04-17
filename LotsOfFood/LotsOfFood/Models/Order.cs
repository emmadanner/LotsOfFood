using System;
using System.Collections.Generic;
using System.Text;

namespace LotsOfFood.Models
{
    // stores user's previous orders
    internal class Order
    {
        public int OrderID { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int OrderTotal { get; set; }
    }
}
