using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;

namespace WebApplication1.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2QRUQ1N\\MSSQLSERVER01;Database=MuratYucedag; Integrated Security = True; TrustServerCertificate = True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
