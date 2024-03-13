using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccesLayer
{
    public class SklepDbContext : DbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Product> Orders { get; set; }
        DbSet<Product> Users { get; set; }
        DbSet<Product> OrderPositions { get; set; }
        DbSet<Product> BasketPositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sklepior;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}