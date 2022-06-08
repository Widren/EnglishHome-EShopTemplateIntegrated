using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace eShopOnContainers.Core.Models.Models
{
     public interface ISQlite
    {
        SQLiteConnection GetConnection();
    }
}
