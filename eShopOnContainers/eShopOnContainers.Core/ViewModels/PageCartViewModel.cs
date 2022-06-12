using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Models.PageCart;
using eShopOnContainers.Core.Models.Product;
using eShopOnContainers.Core.Services.Cart;
using eShopOnContainers.Core.Services.PageCategory;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class PageCartViewModel : ViewModelBase
    {
        public ObservableCollection<CartItem> CartItems { get; set; } = new ObservableCollection<CartItem>();
        private ICartService _service;
        private ISettingsService _settingsService;
        public PageCartViewModel()
        {
            _service = DependencyService.Get<ICartService>();
            _settingsService = DependencyService.Get<ISettingsService>();
            this.MultipleInitialization = true;
        }
        public override async Task InitializeAsync(IDictionary<string, string> query)
        {
            IsBusy = true;
            CartItems = _service.GetCarts();
            RaisePropertyChanged(() => CartItems);
            Console.WriteLine("test");
            IsBusy = false;
        }
        private async Task ItemClicked(CartItem item)
        {
            if (item != null)
            {
                IsBusy = true;
                await NavigationService.NavigateToAsync("ProductDetail", new Dictionary<string, string> { { "Product", item.ProductID.ToString() } });
                IsBusy = false;
            }
        }
        public ICommand NavigateCommand => new Command<CartItem>(async (item) => await ItemClicked(item));

        public ICommand NavigateHome => new Command(async () =>
        {
            IsBusy = true;
            await NavigationService.NavigateToAsync("Home");
            IsBusy = false;
        });

        //private double _TotalCost;

        //public double TotalCost
        //{
        //    set
        //    {
        //        _TotalCost = value;
        //        OnPropertyChanged();
        //    }
        //    get { return _TotalCost; }

        //}

        //public Command PlaceOrderCommand { get; set; }
        //public CartViewModel()
        //{
        //    CartItems = new ObservableCollection<UserCartItem>();
        //    LoadItems();

        //}

        //private void LoadItems()
        //{
        //    var cn = DependencyService.Get<ISQlite>().GetConnection();
        //    var items = cn.Table<CartItem>().ToList();
        //    CartItems.Clear();
        //    foreach (var item in items)
        //    {
        //        CartItems.Add(new UserCartItem()
        //        {
        //            CartItemId = item.CartItemID,
        //            ProductId = item.ProductID,
        //            ProductName = item.ProductName,
        //            Price = item.Price,




        //        });

        //    }
        //}



        private void RemoveItemsFromCart()
        {
            //var cis = new CartItemService();
            //cis.RemoveItemsFromCart();
        }

        private Command clearAll;

        public ICommand ClearAll
        {
            get
            {
                if (clearAll == null)
                {
                    clearAll = new Command(PerformClearAll);
                }

                return clearAll;
            }
        }

        private void PerformClearAll()
        {
            _service.ClearAll();
            CartItems = new ObservableCollection<CartItem>();
            RaisePropertyChanged(() => CartItems);
        }
    }
}
