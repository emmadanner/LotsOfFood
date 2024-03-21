using LotsOfFood.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LotsOfFood.Views
{
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}