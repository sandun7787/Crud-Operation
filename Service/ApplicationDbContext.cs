using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)

        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
