using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            // List<string> results = new List<string>();
            // foreach (Product p in Product.GetProducts())
            // {
            //     string name = p?.Name ?? "<No Name>";
            //     decimal? price = p?.Price ?? 0;
            //     string relatedName = p?.Related?.Name?? "<None>";
            //     results.Add(string.Format($"Name: {name}, Price: {price:C2}, Related {relatedName}"));
            // }
            // return View(results);
            Dictionary<string, Product> products = new Dictionary<string, Product>{
                ["Kayak"] = new Product{Name = "Kayak", Price = 275M},
                ["Life Jacket"] = new Product{Name = "Life Jacket", Price= 48.9M}
            };
            return View("Index", products.Keys);
        }
    }
}