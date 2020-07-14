using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using AquaMobCA.Infraestructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AquaMobCA.Infraestructure.Data.DataContext
{
    class AppDbContext : DbContext
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
