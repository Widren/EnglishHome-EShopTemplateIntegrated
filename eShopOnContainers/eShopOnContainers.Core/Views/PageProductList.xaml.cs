using eShopOnContainers.Core.Models.Product;
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
    public partial class PageProductList : ContentPage
    {
        public int CategoryID, SubCategoryID;
        public PageProductList(int categoryID, int subCategoryID)
        {
            InitializeComponent();
            CategoryID = categoryID;
            SubCategoryID = subCategoryID;
        }


        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new PageProductDetail
                {
                    BindingContext = e.SelectedItem as Urun
                });
            }
        }

        private async void MyListView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new PageProductDetail
                {
                    BindingContext = e.SelectedItem as Urun
                });
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            PageProductViewModel plv = new PageProductViewModel(CategoryID, SubCategoryID);
            MyListView.ItemsSource = plv.Products;
        }
    }
}