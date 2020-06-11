using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {

            var products = new List<Product>()
            { 
               new Product()
               {
                    Id=1,
                     Name="aa",
                      ImageUrl="1.jpg",
                       Price=10
               },
               new Product()
               {
                    Id=2,
                     Name="bb",
                      ImageUrl="2.jpg",
                       Price=20
               },
               new Product()
               {
                    Id=3,
                     Name="cc",
                      ImageUrl="3.jpg",
                       Price=30
               },
               new Product()
               {
                    Id=2,
                     Name="dd",
                      ImageUrl="4.jpg",
                       Price=40
               }
            };

            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }



        public Product GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
