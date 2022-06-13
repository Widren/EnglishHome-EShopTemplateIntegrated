using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.PageCategory;
using eShopOnContainers.Core.Models.Product;
using eShopOnContainers.Core.Services.PageCategory;
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
    class PageCategoryViewModel:ViewModelBase
    {
        private ObservableCollection<Category> AllCategories { get; set; } = new ObservableCollection<Category>();

        private ObservableCollection<Category> _categories = new ObservableCollection<Category>();
        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set
            {
                _categories = value;
                RaisePropertyChanged(() => Categories);
            }
        }
        private IPageCategoryService _service;
        private ISettingsService _settingsService;
        private int CategoryID = -1;
        public PageCategoryViewModel()
        {
            // Eshop mimarisinde bulunan dependency servisi viewmodel locator içerisine tanımladığımız servisleri kullanabilmemize olanak sağlar.
            _service = DependencyService.Get<IPageCategoryService>();
            _settingsService = DependencyService.Get<ISettingsService>();
            this.MultipleInitialization = true;
        }
        public override async Task InitializeAsync(IDictionary<string, string> query)
        {
            IsBusy = true;

            // Categoriler Categori servisi ile çekilir.
            AllCategories = await _service.GetCategoriesAsync();
            if (query != null)
            {
                if (query.ContainsKey("CategoryID"))
                    CategoryID= query.GetValueAsInt("CategoryID").Value;
            }
            if (CategoryID < 0)
            {
                Categories = AllCategories.Where(x => x.ParentID == 0).ToObservableCollection();
                RaisePropertyChanged(() => Categories);
            }
            else SubCats(CategoryID);
            IsBusy = false;
        }

        private async Task ItemClicked(Category item)
        {
            if (item != null)
            {
                Category catgo = item;
                if (catgo.ParentID==0)
                {
                    SubCats(catgo.Id);
                }
                else
                {

                    IsBusy = true;
                    await NavigationService.NavigateToAsync("Products", new Dictionary<string, string> { { "CategoryID", item.Id.ToString() } });

                    IsBusy = false;
                }
            }
        }
        public ICommand NavigateCommand => new Command<Category>(async (item) => await ItemClicked(item));

        public void SubCats(int ParentCategoryID)
        {
            Categories.Clear();
            Categories = AllCategories.Where(x => x.ParentID == ParentCategoryID)?.ToObservableCollection();
            RaisePropertyChanged(() => Categories);
        }
    }
}
