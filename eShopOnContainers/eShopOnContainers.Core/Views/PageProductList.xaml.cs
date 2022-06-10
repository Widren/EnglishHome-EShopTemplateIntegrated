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
    public partial class PageProductList : ContentPageBase
    {
        public int CategoryID;
        public PageProductList(int categoryID)
        {
            InitializeComponent();
            CategoryID = categoryID;
            PageProductViewModel plv = new PageProductViewModel(CategoryID);
            MyListView.ItemsSource = plv.Products;
        }
    }
}