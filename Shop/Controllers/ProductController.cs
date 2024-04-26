using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Data;
using Shop.Models;
using Shop.ViewModel;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int? id, string q)
        {

            var products = ProductRepository.Products;

            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(p => p.Name.ToLower().Contains(q.ToLower())).ToList();
            }


            var prd = new ProductViewModel()
            {
                Products = products,
                Categories = CategoryRepository.Categories
            };

            return View(prd);
        }
        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            ProductRepository.AddProduct(product);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.EditProduct(product);
            return RedirectToAction("List");
        }





    }
}