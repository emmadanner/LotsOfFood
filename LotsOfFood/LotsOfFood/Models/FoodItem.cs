using System;

namespace LotsOfFood.Models
{
    // stores each food item offered
    public class FoodItem
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int ItemPrice { get; set; }
        public bool InOrder { get; set; }
    }
}