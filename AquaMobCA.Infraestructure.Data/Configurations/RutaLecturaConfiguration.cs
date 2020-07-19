using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class RutaLecturaConfiguration : IEntityTypeConfiguration<RutaLecturaEntity>
    {
        public void Configure(EntityTypeBuilder<RutaLecturaEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Codigo).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(50);
            builder.Property(e => e.FechaInicio).HasColumnType("DateTime");
            builder.Property(e => e.FechaFin).HasColumnType("DateTime");
        }
    }
}
