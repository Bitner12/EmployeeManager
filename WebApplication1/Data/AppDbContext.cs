using Microsoft.EntityFrameworkCore;
using WebApplication1.Enties;

namespace WebApplication1.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Hour> Hours { get; set; }
    }
}
