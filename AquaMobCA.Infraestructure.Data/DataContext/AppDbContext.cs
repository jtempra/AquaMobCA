using Domain.Entities;
using Infraestructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<AnotacionOTEntity> AnotacionesOT { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnotacionOTConfiguration());
        }
    }
}
