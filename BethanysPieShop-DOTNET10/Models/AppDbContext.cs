using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop_DOTNET10.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pie> Pies { get; set; }
    }
}
