using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class TipoIncidenciaLecturaConfiguration : IEntityTypeConfiguration<TipoIncidenciaLecturaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoIncidenciaLecturaEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Codigo).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Incidencia).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Observaciones).HasMaxLength(250);
        }
    }
}
