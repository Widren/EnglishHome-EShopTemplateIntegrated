using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.PageCategory
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryIcon { get; set; }
    }
}