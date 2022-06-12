using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Models.Models;
using eShopOnContainers.Core.Models.Product;
using eShopOnContainers.Core.Services.Products;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.ViewModels.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    class PageProductViewModel:ViewModelBase
    {
        private IProductsService _productsService;
        private ISettingsService _settingsService;
        private int categoryID=-1;
        private string searchQuery = "";
        private ObservableCollection<Product> _products = new ObservableCollection<Product>();
        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                RaisePropertyChanged(() => Products);
            }
        }
        public PageProductViewModel()
        {
            _productsService = DependencyService.Get<IProductsService>();
            _settingsService = DependencyService.Get<ISettingsService>();
            this.MultipleInitialization = true;
        }

        public override async Task InitializeAsync(IDictionary<string, string> query)
        {

            IsBusy = true;
            if (query == null) categoryID = -1;
            else { 
                categoryID = query.GetValueAsInt("CategoryID").Value;
                bool searchQueryFound = query.TryGetValue("SearchQuery", out searchQuery);
            }
            Products = await _productsService.GetProductsAsync(categoryID, searchQuery);
            IsBusy = false;
        }

        private void ViewCart()
        {
            throw new NotImplementedException();
        }
        private async Task ItemClicked(Product item)
        {
            if (item != null)
            {
                IsBusy = true;
                await NavigationService.NavigateToAsync("ProductDetail", new Dictionary<string, string> { { "Product", item.Id.ToString() } });
                IsBusy = false;
            }
        }

        public ICommand Search => new Command<string>(async (string query) =>
        {
            if (query != null)
            {
                searchQuery = query;
                IsBusy = true;
                Products = await _productsService.GetProductsAsync(categoryID, query);
                IsBusy = false;
            }
        });
        public Command ViewCartCommand => new Command(() => ViewCart());
        public ICommand NavigateCommand => new Command<Product>(async (item) => await ItemClicked(item));
    }
}