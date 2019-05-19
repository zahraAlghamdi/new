using ShoppApp.Models;
using ShoppApp.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace ShoppApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailedPageView : ContentPage
	{
        string email;
        string phone;
        string mapURL;
        item product;
        DetailedPageVM vm;

        public DetailedPageView (item selectedItem )
		{
			InitializeComponent ();
            //create VM obj 
            vm = new DetailedPageVM();
            this.BindingContext = vm;
            //set UI values to view selected item inf 
            Title = selectedItem.title;
            image.Source = selectedItem.image;
            title.Text = selectedItem.title;
            Price.Text = selectedItem.price;
            description.Text = selectedItem.description;
            product = selectedItem;

        }

        private void callButton_Clicked(object sender, EventArgs e)
        {
            // open the phone dialer with item's phone number 
            PhoneDialer.Open(product.phoneNumber);

        }
        private async void emailButton_Clicked(object sender, EventArgs e)
        {
            // open email app to send email 
            try
            {
                await vm.SendEmail("order product" + product.title,
                "I want to order the product " + product.title + "  ",
                new List<string> { "khaalghamdi@kau.edu.sa" });
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                DisplayAlert("Alert", fbsEx.Message , "Ok"); 
            }
            catch (Exception ex)
            {
                // Some other exception occurred handling 
            }
        }

        private void mapButton_Clicked(object sender, EventArgs e)
        {
            //open Map app to diplay spesific location 
            try
            {
                Map.OpenAsync(product.MapLat, product.MapLang, new MapLaunchOptions { Name = "Shopp App" });
            }
            catch (Exception ex) {
                DisplayAlert("Alert", ex.Message, "Ok");
            }
        }
    }
}