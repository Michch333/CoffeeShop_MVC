using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class RegisterViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DrinkType FavoriteDrink { get; set; }
    }

    public enum DrinkType
    {
        Latte,
        Coffee,
        Espresso
    }
}
