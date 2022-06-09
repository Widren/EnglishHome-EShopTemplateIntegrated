﻿
using eShopOnContainers.Core.Models.Catalog;
using eShopOnContainers.Core.Models.Product;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.Products
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}