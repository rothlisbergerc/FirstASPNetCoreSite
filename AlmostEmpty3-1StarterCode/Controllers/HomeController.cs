using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Title = "Home";
            ViewData["Title"] = "Home";
            return View();
        }

        // Create an About page. (Right click About() and add view.)
        public IActionResult About()
        {
            return View();
        }
    }
}
