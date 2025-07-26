using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-2QRUQ1N\\MSSQLSERVER01;Database=DbNewOopCore;Integrated Security=True;TrustServerCertificate=True");
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Job> Jobs { get; set; }
}