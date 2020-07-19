using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace Infraestructure.Persistence.Configurations
{
    public class OTConfiguration: IEntityTypeConfiguration<OTEntity>
    {
        public void Configure(EntityTypeBuilder<OTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Fecha).IsRequired().HasColumnType("DateTime");
            builder.Property(e => e.Situacion).IsRequired();
            builder.Property(e => e.FechaSituacion).IsRequired().HasColumnType("DateTime");
            builder.Property(e => e.Descripcion).IsRequired().HasMaxLength(1000);
            builder.Property(e => e.Trabajos).HasMaxLength(1000);
            builder.Property(e => e.Direccion).IsRequired().HasMaxLength(250);
            builder.Property(e => e.DireccionAdicional).HasMaxLength(250);
            builder.Property(e => e.NumeroContrato).HasMaxLength(20);
            builder.Property(e => e.NombreAbonado).HasMaxLength(50);
            builder.Property(e => e.MovilCliente).HasMaxLength(20);
            builder.Property(e => e.EMailCliente).HasMaxLength(100);
            builder.Property(e => e.Prioridad).IsRequired();
        }
    }
}
