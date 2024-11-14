using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Service
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        
        {
            
        }
    }
}
