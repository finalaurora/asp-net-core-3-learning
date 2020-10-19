using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            List<string> output = new List<string>();
            await foreach (long? len in MyAsyncMethods.GetPageLengths(output,
            "apress.com", "microsoft.com", "amazon.com"))
            {
                output.Add($"Page length: { len}");
            }
            return View(output);
        }
    }


}