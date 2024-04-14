using LotsOfFood.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LotsOfFood.ViewModels
{
    public class MenuPageViewModel: BaseViewModel
    {
        public MenuPageViewModel()
        {

            Title = "Menu";
            LoadFoodItems();
            PlaceOrderCommand = new Command(PlaceOrder);
            NavigateToDetailCommand = new Command<FoodItem>(NavigateToDetailPage);
        }

        public string Title { get; set; }
        public ObservableCollection<FoodItem> FoodItem { get; set; }
        public ICommand PlaceOrderCommand { get; }
        
        public ICommand NavigateToDetailCommand { get; }
   

        private async void NavigateToDetailPage(FoodItem selectedFoodItem)
        {
            // Navigate to ItemDetailPage and pass the selected food item
            await Shell.Current.GoToAsync($"FoodItemPage?itemId={selectedFoodItem.ItemID}");
        }
      
        //You can connect the database with LoadFoodItems, I am using it in MenuPage as a UI testing
        private void LoadFoodItems()
        {
            FoodItem = new ObservableCollection<FoodItem>
            {
                new FoodItem { Name = "Pizza", Price = 9.99, ItemID = 1, ImageUrl = ".\\LotsOfFood\\LotsOfFood\\Images\\pizza.jpg", Quantity = 0 },
                new FoodItem { Name = "Burger", Price = 5.99, ItemID = 2, ImageUrl = ".\\LotsOfFood\\LotsOfFood\\Images\\burger.jpg", Quantity = 0 },
                new FoodItem { Name = "Chicken Wings", Price = 5.99, ItemID = 2, ImageUrl = ".\\LotsOfFood\\LotsOfFood\\Images\\chicken.jpg", Quantity = 0 },
                new FoodItem { Name = "Ramen", Price = 5.99, ItemID = 2, ImageUrl = ".\\LotsOfFood\\LotsOfFood\\Images\\ramen.jpg", Quantity = 0 },

            };
        }

        private void PlaceOrder()
        {
           
        }
    }
}
