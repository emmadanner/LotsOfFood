using System;
using LotsOfFood.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using LotsOfFood.Views;



namespace LotsOfFood
{
    // one for each database (food and orders) I'm pretty sure this would be how they would be stored
    public partial class App : Application
    {
        private static FoodItemDatabase foodDatabase;
        internal static FoodItemDatabase FoodDatabase
        {
            get
            {
                if (foodDatabase == null)
                {
                    foodDatabase = new FoodItemDatabase(Path.Combine(Environment.GetFolderPath
                    (Environment.SpecialFolder.LocalApplicationData), "MenuItems.db3"));
                }
                return foodDatabase;
            }
        }

        private static OrderDatabase orderDatabase;
        internal static OrderDatabase OrderDatabase
        {
            get
            {
                if (orderDatabase == null)
                {
                    orderDatabase = new OrderDatabase(Path.Combine(Environment.GetFolderPath
                    (Environment.SpecialFolder.LocalApplicationData), "Orders.db3"));
                }
                return orderDatabase;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            //MainPage = new NavigationPage(new HomePage());

        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}