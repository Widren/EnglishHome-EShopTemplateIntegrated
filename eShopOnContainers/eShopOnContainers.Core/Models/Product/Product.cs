using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double PreviousCost { get; set; }
        public int CategoryId { get; set; }
        public string Url { get; set; }
        public int NumberInStock { get; set; }
        public string Info { get; set; }
        public double KargoFiyatı { get; set; }
        public int ToplamSiparisSayisi { get; set; }
        public string imageUrl { get; set; }
    }
}
