using Microsoft.EntityFrameworkCore;
using NumberAPI.Models;

namespace NumberAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<NumItem> NumItems => Set<NumItem>();
    }
}
