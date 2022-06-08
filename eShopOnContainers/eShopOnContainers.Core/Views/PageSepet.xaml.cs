using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSepet : ContentPage
    {
        public PageSepet()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            PageCartViewModel scv = new PageCartViewModel();
            MyListView.ItemsSource = scv.CartItems;
        }
        private void SepetSil(object sender, EventArgs e)
        {
            PageCartViewModel cis = new PageCartViewModel();
            //cis.RemoveItemsFromCart();
            PageCartViewModel scv = new PageCartViewModel();
            scv.CartItems.Clear();
            Navigation.PushAsync(new PageSepet());

        }
        private void HemenAl(object sender, EventArgs e)
        {
            ////Ödeme ekranına gönder
            //if (MyListView.SelectedItem == null)
            //{
            //    Application.Current.MainPage.DisplayAlert("Sepet Boş", "Sepet Boş olduğu için işlem yapılamıyor", "Tamam");
            //}
            //else
            //    Navigation.PushModalAsync(new PageOdeme());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMain");

        }
    }
}