using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class IncidenciaConfiguration: IEntityTypeConfiguration<IncidenciaEntity>
    {
        public void Configure(EntityTypeBuilder<IncidenciaEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Prioridad).IsRequired();
            builder.Property(e => e.Fecha).IsRequired();
            builder.Property(e => e.FechaSituacion).IsRequired();
            builder.Property(e => e.Direccion).IsRequired().HasMaxLength(250);
            builder.Property(e => e.Descripcion).IsRequired().HasMaxLength(500);
            builder.Property(e => e.Localizacion).IsRequired().HasMaxLength(250);
            builder.Property(e => e.Solucion).IsRequired().HasMaxLength(500);
            builder.Property(e => e.Observaciones).IsRequired().HasMaxLength(500);
            builder.Property(e => e.NombreAbonado).IsRequired().HasMaxLength(100);
            builder.Property(e => e.MovilAbonado).IsRequired().HasMaxLength(15);
            builder.Property(e => e.EMailAbonado).IsRequired().HasMaxLength(100);
        }
    }
}
