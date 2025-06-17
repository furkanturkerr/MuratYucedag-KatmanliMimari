using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MuratYucedag_KatmanliMimari.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MuratYucedag; Integrated Security = True; TrustServerCertificate = True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
