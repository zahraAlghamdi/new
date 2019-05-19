using ShoppApp.Models;
using ShoppApp.ViewModels;
using ShoppApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        HomePageVM homepageVM; 
       public HomePage ()
		{
            InitializeComponent ();
            homepageVM = new HomePageVM(); 
            //set page Title 
            Title = "Home Page";
            // set the binding context 
            this.BindingContext = homepageVM;
            

        }

        private async void Itemlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // get selected item
            var selectedItem = e.SelectedItem as item;
            //Navigate to details page with selected item info 
            await Navigation.PushAsync(new DetailedPageView(selectedItem));
        }
    }
}