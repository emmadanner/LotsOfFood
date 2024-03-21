using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotsOfFood.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LotsOfFood.Models;
using LotsOfFood;

namespace LotsOfFood.Views
{
    public partial class FoodItemPage : ContentPage
    {
        public FoodItemPage()
        {
            InitializeComponent();
        }
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var foodItem = (FoodItem)BindingContext;
            // FoodItemDatabase database = await FoodItemDatabase.Instance;
            await App.FoodDatabase.SaveItemAsync(foodItem);
            await Navigation.PopAsync();
        }
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var foodItem = (FoodItem)BindingContext;
            //FoodItemDatabase database = await FoodItemDatabase.Instance;
            await App.FoodDatabase.DeleteItemAsync(foodItem);
            await Navigation.PopAsync();
        }
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}