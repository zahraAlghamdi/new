using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShoppApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void logIn (object sender, EventArgs e)
        {
            if (email_label.Text == "k@k.sa" && password.Text == "123")
            {
                await Navigation.PushAsync(new HomePage());
            }
            else {
                await DisplayAlert("Error", "Wrong information", "cancel");
            }
        }
    }
}
