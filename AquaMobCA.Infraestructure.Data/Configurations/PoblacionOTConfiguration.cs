using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class PoblacionOTConfiguration : IEntityTypeConfiguration<PoblacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<PoblacionOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Codigo).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Poblacion).IsRequired().HasMaxLength(50);
        }
    }
}
