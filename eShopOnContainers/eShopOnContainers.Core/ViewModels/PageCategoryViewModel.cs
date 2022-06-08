using eShopOnContainers.Core.Models.PageCategory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    class PageCategoryViewModel
    {
        public ObservableCollection<Category> Category { get; set; }
        public List<Category> Cat { get; set; }
        public PageCategoryViewModel()
        {

            Category = new ObservableCollection<Category>();
            Cat = new List<Category>();

            Category.Add(new Category { CategoryIcon = "bed.png", CategoryTitle = "Yatak Odası" });
            Category.Add(new Category { CategoryIcon = "kitchen.png", CategoryTitle = "Mutfak" });
            Category.Add(new Category { CategoryIcon = "bathroom.png", CategoryTitle = "Banyo" });
            Category.Add(new Category { CategoryIcon = "sofa.png", CategoryTitle = "Salon" });
        }

        public void SubCats(int Catid)
        {
            Category.Clear();
            if (Catid == 1)
            {
                Category.Add(new Category { CategoryTitle = "Yastık" });
                Category.Add(new Category { CategoryTitle = "Battaniye" });
                Category.Add(new Category { CategoryTitle = "Nevresim Seti" });
                Category.Add(new Category { CategoryTitle = "Yorgan" });
            }

            if (Catid == 2)
            {
                Category.Add(new Category { CategoryTitle = "Tencere" });
                Category.Add(new Category { CategoryTitle = "Kavanoz" });
                Category.Add(new Category { CategoryTitle = "Fincan Seti" });
                Category.Add(new Category { CategoryTitle = "Yemek Takımı" });
            }
            if (Catid == 3)
            {
                Category.Add(new Category { CategoryTitle = "Banyo Seti" });
                Category.Add(new Category { CategoryTitle = "Havlu" });
                Category.Add(new Category { CategoryTitle = "Bornoz" });
                Category.Add(new Category { CategoryTitle = "Sabunluk" });
            }
            if (Catid == 4)
            {
                Category.Add(new Category { CategoryTitle = "Halı" });
                Category.Add(new Category { CategoryTitle = "Kırlent" });
                Category.Add(new Category { CategoryTitle = "Masa Örtüsü" });
                Category.Add(new Category { CategoryTitle = "Sehpa" });

            }
        }
    }
}
