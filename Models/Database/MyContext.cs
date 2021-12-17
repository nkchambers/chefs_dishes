using Microsoft.EntityFrameworkCore;

namespace chefs_dishes.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<Chef> chefs { get; set; }
        public DbSet<Dish> dishes { get; set; }
        
    }
}