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
        private ObservableCollection<Product> _products;
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
        }
        public PageProductViewModel(int categoryID)
        {
            this.categoryID = categoryID;
            AddToCartCommand = new Command(() => AddToCart());
            ViewCartCommand = new Command(() => ViewCart());
        }

        public override async Task InitializeAsync(IDictionary<string, string> query)
        {
           
            if (Products == null)
                Products = new ObservableCollection<Product>();

            // Update Basket
            Products = await _productsService.GetProductsAsync(categoryID);
        }

        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQlite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    ProductID = SelectedProduct.UrunID,
                    ProductName = SelectedProduct.urun,
                    Price = SelectedProduct.fiyat,


                };
                var item = cn.Table<CartItem>().ToList()
                    .FirstOrDefault(c => c.ProductID == SelectedProduct.UrunID);
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Sepet", "Ürün Sepete Eklendi", "OK");
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                cn.Close();
            }
        }

        private void ViewCart()
        {
            throw new NotImplementedException();
        }
        private async Task ItemClicked(Product item)
        {
            if (item != null)
            {

                var serializedProduct = JsonConvert.SerializeObject(item);
                await NavigationService.NavigateToAsync("//PageProductDetail", new Dictionary<string, string> { { "data", serializedProduct } });
                //await Navigation.PushAsync(new PageProductDetail
                //{
                //    BindingContext = e.SelectedItem as Urun
                //});
            }
        }

        private Urun _SelectedProduct;
        public Urun SelectedProduct;


        public Command AddToCartCommand { get; set; }
        public Command ViewCartCommand { get; set; }

        public ICommand NavigateCommand => new Command<Product>(async (item) => await ItemClicked(item));
    }

}

