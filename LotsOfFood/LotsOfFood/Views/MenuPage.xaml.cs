using LotsOfFood.Models;
using LotsOfFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotsOfFood.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LotsOfFood.ViewModels;


namespace LotsOfFood.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = new MenuPageViewModel(); 
        }

        private void OnFoodItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is FoodItem tappedFoodItem)
            {
                if (BindingContext is MenuPageViewModel viewModel && viewModel.NavigateToDetailCommand != null)
                {
                    viewModel.NavigateToDetailCommand.Execute(tappedFoodItem);
                }
            }

     
     ((ListView)sender).SelectedItem = null;
        }
    }
}