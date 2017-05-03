using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string FullName { get; set; }
        public IActionResult About()
        {
            ViewData["Message"] = $"Hello {FullName}";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = $"Hello {FullName}";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
