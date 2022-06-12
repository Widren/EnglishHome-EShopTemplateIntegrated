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