using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurentAPI.Models
{
    public class RestaurentDbContext:DbContext  
    {
        public RestaurentDbContext(DbContextOptions<RestaurentDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }

        public DbSet<OrderMaster> OrderMasters { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

    }

}
