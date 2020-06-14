﻿using System;
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
            return View(new ProductListModel()
            {
                Products = _productService.GetAll()
            });
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

            return RedirectToAction("Index");
        }


        public IActionResult Edit (int? id)
        {

            if (id==null)
            {
                return NotFound();
            }

            var entity = _productService.GetById((int)id);

            if (entity==null)
            {
                return NotFound();
            }

            var model = new ProductModel()
            {
                Name = entity.Name,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                Price = entity.Price,
                 Id=entity.Id 

            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {

            var entity = _productService.GetById(model.Id);

            if (entity==null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            entity.Price = model.Price;

            _productService.Update(entity);

            return RedirectToAction("Index");
        }

    }
}
