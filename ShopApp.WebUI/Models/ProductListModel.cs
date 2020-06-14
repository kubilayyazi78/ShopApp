using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{

    public class PageInfo
    {
        public int TotalItems { get; set; }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public string CurrentCategory { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal) TotalItems / ItemsPerPage);
        }



        // örnek 10 item var bir sayfada 3 ürün gösteriliyor 10/3 =3.3 ü 4 e yuvarlamak gerekir.
    }
    public class ProductListModel
    {

        public PageInfo  PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}
