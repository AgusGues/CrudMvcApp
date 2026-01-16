using Microsoft.EntityFrameworkCore;
using CrudMvcApp.Models;

namespace CrudMvcApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
