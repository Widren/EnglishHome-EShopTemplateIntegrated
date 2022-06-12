using eShopOnContainers.Core.Models.PageCategory;
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
    class PageMainViewModel : ViewModelBase
    {

        public ObservableCollection<string> carouselFirst = new ObservableCollection<string>()
            {
             "https://cdn-eh.akinon.net/cms/2022/04/25/4a7f6870-fa44-42fa-b904-4e7c611e8139.jpg",
             "https://cdn-eh.akinon.net/cms/2022/04/25/6d7a94dd-66f9-472f-919c-a505a55fd8fa.jpg",
             "https://cdn-eh.akinon.net/cms/2022/04/25/5b168158-4d8a-4471-a189-1d7c868c1381.jpg",
            };

        public ObservableCollection<string> carouselSecond = new ObservableCollection<string>()
            {
             "https://cdn-eh.akinon.net/products/2020/10/06/75616/f27e6b9b-c5e3-40f3-8e7d-d9f1473b7e47_size300x225_cropTop.jpg",
             "https://cdn-eh.akinon.net/products/2020/10/06/75632/0ed072de-d2fb-41f2-872d-d1e745984681_size300x225_cropTop.jpg",
             "https://cdn-eh.akinon.net/products/2020/08/14/172930/6d0f3d76-d2f3-4780-a1b9-2a77c5d13a0a_size300x225_cropTop.jpg",
            };
        public PageMainViewModel()
        {

            MultipleInitialization = true;
        }

        public override async Task InitializeAsync(IDictionary<string, string> query)
        {

            IsBusy = true;

            RaisePropertyChanged(() => carouselFirst);

            RaisePropertyChanged(() => carouselSecond);

            IsBusy = false;

        }

        private Command navigateLogin;

        public ICommand NavigateLogin
        {
            get
            {
                if (navigateLogin == null)
                {
                    navigateLogin = new Command(PerformNavigateLogin);
                }

                return navigateLogin;
            }
        }

        private void PerformNavigateLogin()
        {
            Shell.Current.GoToAsync("//PageGiris");
        }

        private Command navigateCart;

        public ICommand NavigateCart
        {
            get
            {
                if (navigateCart == null)
                {
                    navigateCart = new Command(PerformNavigateCart);
                }

                return navigateCart;
            }
        }

        private void PerformNavigateCart()
        {
            Shell.Current.GoToAsync("//PageSepet");
        }




        public ICommand Search => new Command<string>(async (string query) =>
        {
            if (query != null)
            {
                IsBusy = true;
                await NavigationService.NavigateToAsync("Products", new Dictionary<string, string> { { "SearchQuery", query } });
                IsBusy = false;
            }
        });

        public ICommand CategoryPressed => new Command<string>(async (string catID) =>
        {

            await NavigationService.NavigateToAsync("Categories", new Dictionary<string, string> { { "CategoryID", catID } });
        });

    }

}
