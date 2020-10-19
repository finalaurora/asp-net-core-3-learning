using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() =>

            View(Product.GetProducts().Select(p => p?.Name));
    }


}