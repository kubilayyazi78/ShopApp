using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
   public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }

         

        }

        private static Category[] Categories =
        {
            new Category()
            {
                 Name="Telefon"
            },
             new Category()
            {
                 Name="Pc"
            }
        };

        private static Product[] Products =
        {
            new Product()
            {
                 Name="Samsung5" , Price=1000, ImageUrl="1.jpg" 
            },
                        new Product()
            {
                 Name="Samsung6" , Price=2000, ImageUrl="3.jpg"
            },
                                    new Product()
            {
                 Name="Samsung7" , Price=3330, ImageUrl="5.jpg"
            },
                                                new Product()
            {
                 Name="Iphone6" , Price=8880, ImageUrl="6.jpg"
            },
                                                            new Product()
            {
                 Name="Iphone7" , Price=9990, ImageUrl="9.jpg"
            },
        };
    }
}
