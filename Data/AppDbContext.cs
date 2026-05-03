using Inventory.Model;
using Microsoft.EntityFrameworkCore;
using static Inventory.Model.Category;

namespace Inventory.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Supplier>Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }      
        public DbSet<SubCategory> SubCategories { get; set; }

    }
}
