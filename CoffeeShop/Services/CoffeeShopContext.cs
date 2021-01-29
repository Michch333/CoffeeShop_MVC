using CoffeeShop.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Services
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CoffeeUsersDAL> CoffeeUsers { get; set; }
    }
}
