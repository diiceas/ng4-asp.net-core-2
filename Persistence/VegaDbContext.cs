using Microsoft.EntityFrameworkCore;
using ng4_asp.net_core_2.Models;

namespace ng4_asp.net_core_2.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}