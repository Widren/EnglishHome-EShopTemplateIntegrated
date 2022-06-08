
using eShopOnContainers.Core.Models.Catalog;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.Products
{
    public interface IProductsService
    {
        Task<ObservableCollection<CatalogItem>> GetCatalogAsync();
    }
}
