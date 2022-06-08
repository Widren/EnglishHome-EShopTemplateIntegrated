using eShopOnContainers.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Services.Products
{
    public class ProductService : IProductsService
    {
        public ProductService()
        {
           
        }

        public Task<ObservableCollection<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}