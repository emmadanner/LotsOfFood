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

namespace LotsOfFood.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //FoodItemDatabase database = await FoodItemDatabase.Instance;
            listView.ItemsSource = await App.FoodDatabase.GetItemsAsync();
        }
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodItemPage
            {
                BindingContext = new FoodItem()
            });
        }
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new FoodItemPage
                {
                    BindingContext = e.SelectedItem as FoodItem
                });
            }
        }
    }
}