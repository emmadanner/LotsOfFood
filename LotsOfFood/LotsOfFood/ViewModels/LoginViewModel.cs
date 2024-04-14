using LotsOfFood.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LotsOfFood.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
           
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
}
