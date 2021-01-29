using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.DALModels;
using CoffeeShop.Models;
using CoffeeShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class CoffeeShop : Controller
    {
        private readonly CoffeeShopContext _coffeeShopContext;

        public CoffeeShop(CoffeeShopContext coffeeShopContext)
        {
            _coffeeShopContext = coffeeShopContext;

        }
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
            var newUser = new CoffeeUsersDAL();
            newUser.Email = model.Email;
            newUser.Password = model.Password;
            newUser.UserName = model.UserName;
            newUser.FavoriteDrink = model.FavoriteDrink;

            _coffeeShopContext.Add(newUser);
            _coffeeShopContext.SaveChanges();

            return View(model);
        }

        public IActionResult UpdateUserInfo(int id)
        {
            var userToUpdate = new UpdateUserViewModel();

            return View();
        }
    }
}
