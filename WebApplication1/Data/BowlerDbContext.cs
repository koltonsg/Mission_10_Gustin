using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Data
{
    public class BowlerDbContext : DbContext
    {
        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Teams> Teams { get; set; }

        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {
        }
    }
}

