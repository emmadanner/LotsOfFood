using LotsOfFood.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
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
            PlaceOrderCommand = new Command(PlaceOrderAsync);
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
                new FoodItem { Name = "Pizza", Price = 9.99, ItemID = 1, ImageUrl = "Pizza.png", Quantity = 0 },
                new FoodItem { Name = "Burger", Price = 5.99, ItemID = 2, ImageUrl = "Burger.png", Quantity = 0 },
                new FoodItem { Name = "Chicken Wings", Price = 5.99, ItemID = 2, ImageUrl = "Chicken.png", Quantity = 0 },
                new FoodItem { Name = "Ramen", Price = 5.99, ItemID = 2, ImageUrl = "Ramen.png", Quantity = 0 },

            };
        }

        private async void PlaceOrderAsync()
        {
            await Application.Current.MainPage.DisplayAlert("Order Placed", "Your order has been placed!", "OK");
        }
    }
}
