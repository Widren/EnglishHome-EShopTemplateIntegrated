using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.Product;
using eShopOnContainers.Core.Services.Products;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.ViewModels.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    class PageProductDetailViewModel : ViewModelBase
    {
        private Product _product;
        public Product Product
        {
            get => _product;
            set
            {
                _product = value;
                RaisePropertyChanged(() => Product);
            }
        }

        private IProductsService _productsService;
        private ISettingsService _settingsService;
        public PageProductDetailViewModel()
        {
            _productsService = DependencyService.Get<IProductsService>();
            _settingsService = DependencyService.Get<ISettingsService>();
        }
        public override async Task InitializeAsync(IDictionary<string, string> query)
        {
            IsBusy = true;
            int id = query.GetValueAsInt("Product").Value;
            Product = await _productsService.GetProductWithIDAsync(id);
            IsBusy = false;
        }

        public ICommand AddToCartCommand => new Command(async () => await AddToCart());

        private async Task AddToCart()
        {
            Console.WriteLine("test");        
        }
    }
}
