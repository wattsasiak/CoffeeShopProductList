using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopProductList.Models;

namespace CoffeeShopProductList.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> results = DAL.GetProducts();
            return View(results);
        }



        public IActionResult Detail(string name)
        {
          
            Product theproduct = DAL.GetAProduct(name);
            ViewData["name"] = theproduct.name;
            return View(theproduct);

          

        }
    }
}
