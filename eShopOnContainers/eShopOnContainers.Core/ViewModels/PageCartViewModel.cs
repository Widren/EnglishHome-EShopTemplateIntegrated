using eShopOnContainers.Core.Models.PageCart;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    class PageCartViewModel : PageBaseViewModel
    {
        public ObservableCollection<PageUserCartItem> CartItems { get; set; }
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
    }
}
