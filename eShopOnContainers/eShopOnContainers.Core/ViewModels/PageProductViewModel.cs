using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Models.Models;
using eShopOnContainers.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    class PageProductViewModel
    {
        public ObservableCollection<Urun> Products { get; set; }
        private ObservableCollection<Urun> AllProducts { get; set; } = new ObservableCollection<Urun>() {
            new Urun { urun = "Softy Wellsoft Tv Battaniye 120x170 Cm Çikolata", fiyat = 149.99, image = "https://cdn-eh.akinon.net/products/2021/10/05/189290/a3dbd199-bf0d-4f02-9921-d552b60eca6c_size768x575_cropCenter.jpg", renk = "Çikolata", rating = 0.0, CategoryID = 1, SubCategoryID = 1 },
            new Urun { urun = "Liberty Bloom Pamuklu Çift Kişilik Nevresim Seti 200x220 Cm Tarçın", fiyat = 499.99, image = "https://cdn-eh.akinon.net/products/2022/02/25/205114/462482ba-4a25-4fa4-9937-7bb5fa5efce5_size768x575_cropCenter.jpg", renk = "Pembe", rating = 0.0, CategoryID = 1, SubCategoryID = 2 },
            new Urun { urun = "Silikonlu Yastık 50X70 Cm Ekru", fiyat = 99.99, image = "https://cdn-eh.akinon.net/products/2019/02/12/48498/3c437f1f-03d6-46f0-bec6-481e9d41c202_size768x575_cropCenter.jpg", renk = "Beyaz", rating = 0.0, CategoryID = 1, SubCategoryID = 3 },
            new Urun { urun = "Siesta Mikrofiber Çift Kişilik Yorgan 195x215 Cm Beyaz", fiyat = 499.99, image = "https://cdn-eh.akinon.net/products/2020/05/07/64997/b7f1464b-c40b-4ac0-8eb7-3d7842f0ae81_size768x575_cropCenter.jpg", renk = "Beyaz", rating = 0.0, CategoryID = 1, SubCategoryID = 4 },

            new Urun { urun = "Icy Alüminyum Döküm Tencere Seti 7 Parça Siyah", fiyat = 2449.99, image = "https://cdn-eh.akinon.net/products/2022/01/14/206695/4480a9c1-6fab-449b-923d-eb397607dfe7_size768x575_cropCenter.jpg", renk = "Siyah", rating = 0.0, CategoryID = 2, SubCategoryID = 5 },
            new Urun { urun = "Cassidy Cam Kavanoz 1100 Ml Şeffaf", fiyat = 109.99, image = "https://cdn-eh.akinon.net/products/2021/12/24/197796/ec1814ce-fae1-4850-83ae-025f0b505fd3_size768x575_cropCenter.jpg", renk = "Kahverengi", rating = 0.0, CategoryID = 2, SubCategoryID = 6 },
            new Urun { urun = "Pamira Porselen 6 Kişilik Kahve Fincan Takımı 80 Ml Mavi", fiyat = 249.99, image = "https://cdn-eh.akinon.net/products/2022/02/09/196669/bb0d9486-8962-4b22-82a0-73481aec8033_size768x575_cropCenter.jpg", renk = "Mavi", rating = 0.0, CategoryID = 2, SubCategoryID = 7 },
            new Urun { urun = "Galia Butterfly Bone Porselen 12 Parça Yemek Takımı 25 - 20 - 15 Cm Pembe", fiyat = 1199.99, image = "https://cdn-eh.akinon.net/products/2021/11/29/195330/a7459148-84bc-499d-8320-a24ccc7da6c3_size768x575_cropCenter.jpg", renk = "Beyaz-Altın", rating = 0.0, CategoryID = 2, SubCategoryID = 8 },

            new Urun { urun = "Quadro Pamuklu 4'lü Set Havlu Seti 30x40 Cm Beyaz - Bordo", fiyat = 119.99, image = "https://cdn-eh.akinon.net/products/2022/03/10/204593/4e3902ba-7b1b-46fb-ad47-b8fa438c09a3_size768x575_cropCenter.jpg", renk = "Beyaz", rating = 0.0, CategoryID = 3, SubCategoryID = 9 },
            new Urun { urun = "Casa Cam Banyo Sıvı Sabunluk 8x14 Cm Gold", fiyat = 29.99, image = "https://cdn-eh.akinon.net/products/2020/09/17/167357/c43642db-f0fa-405a-88e1-e43181c97838_size768x575_cropCenter.jpg", renk = "Beyaz", rating = 0.0, CategoryID = 3, SubCategoryID = 10 },
            new Urun { urun = "Plain Pamuklu Bornoz L-xl Kiremit", fiyat = 349.99, image = "https://cdn-eh.akinon.net/products/2022/04/19/210709/06c27a52-ab7c-4073-81ee-493f4acb79e8_size768x575_cropCenter.jpg", renk = "Kiremit", rating = 0.0, CategoryID = 3, SubCategoryID = 11 },
            new Urun { urun = "Evelyn 3'lü Banyo Seti Bej", fiyat = 299.99, image = "https://cdn-eh.akinon.net/products/2022/04/19/206923/8f568c3c-3064-4430-9ed8-ccdfd1d10567_size768x575_cropCenter.jpg", renk = "Bej", rating = 0.0, CategoryID = 3, SubCategoryID = 12 },

            new Urun { urun = "Vera Şönil Halı Gri", fiyat = 999.99, image = "https://cdn-eh.akinon.net/products/2021/06/22/180419/759d29d4-55cd-45cb-a235-3a63f2dc3482_size768x575_cropCenter.jpg", renk = "Gri", rating = 0.0, CategoryID = 4, SubCategoryID = 13 },
            new Urun { urun = "Fluffy Peluş Kırlent Kılıfı 45x45 cm Mürdüm", fiyat = 119.99, image = "https://cdn-eh.akinon.net/products/2021/11/29/192494/2bb51d63-c5cd-449e-83e7-7f4fee5ca2f2_size768x575_cropCenter.jpg", renk = "Mürdüm", rating = 0.0, CategoryID = 4, SubCategoryID = 14 },
            new Urun { urun = "Mace Polyester Masa Örtüsü 150x200 Cm Antrasit", fiyat = 149.99, image = "https://cdn-eh.akinon.net/products/2021/11/22/200593/d5f45304-77be-4e51-8133-26639b95c3d6_size768x575_cropCenter.jpg", renk = "Mavi", rating = 0.0, CategoryID = 4, SubCategoryID = 15 },
            new Urun { urun = "Marcel Sehpa 30x30x30 Cm Krem", fiyat = 249.99, image = "https://cdn-eh.akinon.net/products/2021/04/20/177084/ba615c13-ba1c-429a-a8e8-f01cbd393f97_size768x575_cropCenter.jpg", renk = "Krem", rating = 0.0, CategoryID = 4, SubCategoryID = 16 }
        };

        public PageProductViewModel()
        {
            Products = AllProducts;
        }
        public PageProductViewModel(int categoryID, int subCategoryID)
        {
            Products = new ObservableCollection<Urun>(AllProducts.Where(item => item.SubCategoryID == subCategoryID && item.CategoryID == categoryID));
            AddToCartCommand = new Command(() => AddToCart());
            ViewCartCommand = new Command(() => ViewCart());
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

        private Urun _SelectedProduct;
        public Urun SelectedProduct;


        public Command AddToCartCommand { get; set; }
        public Command ViewCartCommand { get; set; }
    }

}

