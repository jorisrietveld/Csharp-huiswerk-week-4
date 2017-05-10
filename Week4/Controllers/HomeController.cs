using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Week4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Senario41()
        {
            return View();
        }

        public IActionResult Senario42( string name, string email )
        {
            ViewData["Name"] = name;
            ViewData["Email"] = email;
            return View();
        }

        public IActionResult Senario43()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
