using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class CoffeeShop : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterView()
        {
            return View();
        }
        public IActionResult RegistrationConformation(RegisterViewModel model)
        {
            return View(model);
        }
    }
}
