using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Models.Models;
using eShopOnContainers.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProductDetail : ContentPage
    {
        public PageProductDetail()
        {
            InitializeComponent();

        }
        public ObservableCollection<Urun> SepeteEklenen { get; set; }
        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQlite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    ProductName = urunAd.Text,
                    Price = Convert.ToDouble(urunFiyat.Text),




                };
                var item = cn.Table<CartItem>().ToList()
                    .FirstOrDefault();
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Cart", "Selected Item Added to Cart", "OK");
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            AddToCart();
            Navigation.PushAsync(new PageSepet());
        }
    }
}
