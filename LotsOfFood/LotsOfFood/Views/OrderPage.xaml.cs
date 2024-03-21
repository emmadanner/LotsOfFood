using LotsOfFood.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LotsOfFood.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}