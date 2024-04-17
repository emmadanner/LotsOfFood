using LotsOfFood.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static System.Net.WebRequestMethods;

namespace LotsOfFood.ViewModels
{
    public class MenuPageViewModel: BaseViewModel
    {
        public MenuPageViewModel()
        {

            Title = "Menu";
            LoadFoodItems();
            PlaceOrderCommand = new Command(PlaceOrderAsync);
            FoodItemTappedCommand = new Command(OnFoodItemTapped);

        }

        public string Title { get; set; }
        public ObservableCollection<FoodItem> FoodItem { get; set; }
        public ICommand PlaceOrderCommand { get; }

        public ICommand FoodItemTappedCommand { get; }


        //You can connect the database with LoadFoodItems, I am using it in MenuPage as a UI testing
        private void LoadFoodItems()
        {
            FoodItem = new ObservableCollection<FoodItem>
            {
                new FoodItem { Name = "Pizza", Price = 9.99, ItemID = 1, ImageUrl =  "https://www.foodandwine.com/thmb/Wd4lBRZz3X_8qBr69UOu2m7I2iw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/classic-cheese-pizza-FT-RECIPE0422-31a2c938fc2546c9a07b7011658cfd05.jpg", Quantity = 0 },
                new FoodItem { Name = "Burger", Price = 5.99, ItemID = 2, ImageUrl = "https://cdn2.cincinnatimagazine.com/wp-content/uploads/sites/5/2015/07/Gaslight_Cafe-078-Hero-Ak-CMYK_web-e1435846819296.jpg", Quantity = 0 },
                new FoodItem { Name = "Chicken Wings", Price = 5.99, ItemID = 3, ImageUrl = "https://www.allrecipes.com/thmb/SoBuPU73KcbYHl3Kp3j8Xx4A3fc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/8805-CrispyFriedChicken-mfs-3x2-072-d55b8406d4ae45709fcdeb58a04143c2.jpg", Quantity = 0 },
                new FoodItem { Name = "Ramen", Price = 5.99, ItemID = 4, ImageUrl = "https://www.justonecookbook.com/wp-content/uploads/2023/04/Spicy-Shoyu-Ramen-8055-I.jpg", Quantity = 0 },

            };
        }


        private async void OnFoodItemTapped()
        {
            await Application.Current.MainPage.DisplayAlert("Item Added", $"Adding this item into Order", "OK");
        }
        private async void PlaceOrderAsync()
        {
            await Application.Current.MainPage.DisplayAlert("Order Placed", "Your order has been placed!", "OK");
        }
    }
}
