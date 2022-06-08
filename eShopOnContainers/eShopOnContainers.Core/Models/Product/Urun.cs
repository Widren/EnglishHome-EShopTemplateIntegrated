using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Product
{
    public class Urun
    {
        [PrimaryKey, AutoIncrement]
        public int UrunID
        {
            get;
            set;
        }
        [PrimaryKey]
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public string urun
        {
            get;
            set;
        }
        public double fiyat
        {
            get;
            set;
        }
        public string image
        {
            get;
            set;
        }
        public string renk
        {
            get;
            set;
        }
        public double rating
        {
            get; set;
        }


    }
}
