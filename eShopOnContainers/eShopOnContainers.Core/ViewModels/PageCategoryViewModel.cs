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
        public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();
        public ObservableCollection<Category> AllCategories { get; set; } = new ObservableCollection<Category>();
        public List<Category> Cat { get; set; }
        private IPageCategoryService _service;
        private ISettingsService _settingsService;
        public PageCategoryViewModel()
        {
            _service = DependencyService.Get<IPageCategoryService>();
            _settingsService = DependencyService.Get<ISettingsService>();
            this.MultipleInitialization = true;
        }
        public override async Task InitializeAsync(IDictionary<string, string> query)
        {
            IsBusy = true;
            AllCategories = await _service.GetCategoriesAsync();
            Categories = AllCategories.Where(x => x.ParentID == 0).ToObservableCollection();
            RaisePropertyChanged(() => Categories);
            Console.WriteLine("test");

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
