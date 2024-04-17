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


    }
}