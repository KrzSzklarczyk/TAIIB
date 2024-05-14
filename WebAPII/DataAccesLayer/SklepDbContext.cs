using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccesLayer
{
    public class SklepDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Orders { get; set; }
        public DbSet<Product> Users { get; set; }
        public DbSet<Product> OrderPositions { get; set; }
        public DbSet<Product> BasketPositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-9N0R9EE\\SQLEXPRESS;Initial Catalog=Store;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Product).Assembly);
        }
    }
}