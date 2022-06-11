using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMain : ContentPageBase
    {
        public PageMain()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
            {
             "https://cdn-eh.akinon.net/cms/2022/04/25/4a7f6870-fa44-42fa-b904-4e7c611e8139.jpg",
             "https://cdn-eh.akinon.net/cms/2022/04/25/6d7a94dd-66f9-472f-919c-a505a55fd8fa.jpg",
             "https://cdn-eh.akinon.net/cms/2022/04/25/5b168158-4d8a-4471-a189-1d7c868c1381.jpg",
             };
            FırsatÜrünleriCarousel.ItemsSource = CarouselItems;

            List<string> CarouselItem = new List<string>()
            {
             "https://cdn-eh.akinon.net/products/2020/10/06/75616/f27e6b9b-c5e3-40f3-8e7d-d9f1473b7e47_size300x225_cropTop.jpg",
             "https://cdn-eh.akinon.net/products/2020/10/06/75632/0ed072de-d2fb-41f2-872d-d1e745984681_size300x225_cropTop.jpg",
             "https://cdn-eh.akinon.net/products/2020/08/14/172930/6d0f3d76-d2f3-4780-a1b9-2a77c5d13a0a_size300x225_cropTop.jpg",
             };
            SizinIcinSectiklerimizCarousel.ItemsSource = CarouselItem;
        }



        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageSepet");
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageGiris");
        }

        private void YatakOdası_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageYatakOdasi");
        }

        private void Salon_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageSalon");
        }

        private void Banyo_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageBanyo");
        }

        private void Mutfak_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMutfak");
        }
    }

}