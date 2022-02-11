using Microsoft.EntityFrameworkCore;
using RestaurantApp.BL.Models;

namespace RestaurantApp.BL.EF
{
    public class RestaurantAppContext : DbContext
    {
        public RestaurantAppContext()
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<TypeDish> TypeDishes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB;database=RestaurantDb;integrated security=True;
                    MultipleActiveResultSets=True;App=EntityFramework;");
        }
    }
}
