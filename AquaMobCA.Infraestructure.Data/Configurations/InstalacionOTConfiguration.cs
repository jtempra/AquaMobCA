using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class InstalacionOTConfiguration : IEntityTypeConfiguration<InstalacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<InstalacionOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Instalacion).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Observaciones).IsRequired().HasMaxLength(250);
        }
    }
}
