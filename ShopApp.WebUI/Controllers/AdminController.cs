using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class AdminController : Controller
    {

        IProductService _productService;
        public AdminController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(ProductModel model)
        {
            var entity = new Product()
            {
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Name = model.Name,
                Price = model.Price
            };


            _productService.Create(entity);

            return Redirect("Index");
        }
    }
}
