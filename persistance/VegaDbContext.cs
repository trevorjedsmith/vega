using vega.models;

using Microsoft.EntityFrameworkCore;

namespace vega.persistance
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options):base(options)
        { }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }
    }
}