using LotsOfFood.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace LotsOfFood.Views
{
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            //InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}