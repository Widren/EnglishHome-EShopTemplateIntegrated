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
    public partial class PageGiris : ContentPage
    {
        public PageGiris()
        {
            InitializeComponent();
        }
        async void OnClicked(object o, EventArgs args)
        {
            await Navigation.PushAsync(new PageKayit());
        }



        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMain");
        }
    }
}