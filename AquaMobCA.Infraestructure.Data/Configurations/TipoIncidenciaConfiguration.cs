using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class TipoIncidenciaConfiguration : IEntityTypeConfiguration<TipoIncidenciaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoIncidenciaEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Codigo).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Tipo).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Observaciones).HasMaxLength(250);
        }
    }
}
