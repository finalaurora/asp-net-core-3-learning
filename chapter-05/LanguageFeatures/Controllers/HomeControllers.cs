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

            return View("Index", new string[] { "Bob", "Joe", "Alice" });
        }
    }
}