using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();

        Product GetProductDetails(int id);
        Product GetById(int id);

        void Create(Product entity);

        List<Product> GetProductsByCategory(string category);

        void Update(Product entity);

        void Delete(Product entity);
    }
}
