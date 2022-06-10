using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.Product;
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
        public Product Product;
        public override async Task InitializeAsync(IDictionary<string, string> query)
        {
            Product = JsonConvert.DeserializeObject<Product>(query["Product"]);
        }

        public ICommand AddToCartCommand => new Command(async () => await AddToCart());

        private Task AddToCart()
        {
            throw new NotImplementedException();
        }
    }
}
