using Microsoft.EntityFrameworkCore;
using MinhaLoja.Models;

namespace MinhaLoja.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> tabUsers { get; set; }
        public DbSet<Product> tabProducts { get; set; }
        public DbSet<Category> tabCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("DataSource=app.db; Cache=Shared");
        }
    }
}