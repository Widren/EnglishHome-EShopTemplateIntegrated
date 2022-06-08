using eShopOnContainers.Core.Models.Product;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTumUrunler : ContentPage
    {
        public ObservableCollection<Urun> SepeteEklenen { get; set; }
        public PageTumUrunler()
        {
            InitializeComponent();
            BindingContext = new PageProductViewModel();

        }


        private void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _containter = BindingContext as PageProductViewModel;
            MyListView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                MyListView.ItemsSource = _containter.Products;
            else
                MyListView.ItemsSource = _containter.Products.Where(i => i.renk.Contains(e.NewTextValue));

            MyListView.EndRefresh();

        }

    }
}