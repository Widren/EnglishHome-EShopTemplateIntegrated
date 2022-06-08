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
    public partial class PageKayit : ContentPage
    {
        public PageKayit()
        {
            InitializeComponent();

        }


        private void Geri_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}