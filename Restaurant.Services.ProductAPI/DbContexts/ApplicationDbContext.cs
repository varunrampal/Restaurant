using Microsoft.EntityFrameworkCore;
using Restaurant.Services.ProductAPI.Models;

namespace Restaurant.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
