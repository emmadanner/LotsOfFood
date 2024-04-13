using System;
using System.ComponentModel;

namespace LotsOfFood.Models
{
    // stores each food item offered
    public class FoodItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int ItemID { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Quantity
        {
            get; set;
        }
    }
}