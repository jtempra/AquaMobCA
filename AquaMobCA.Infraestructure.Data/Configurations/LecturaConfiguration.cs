using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class LecturaConfiguration : IEntityTypeConfiguration<LecturaEntity>
    {
        public void Configure(EntityTypeBuilder<LecturaEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NumeroContrato).IsRequired();
            builder.Property(e => e.NombreAbonado).IsRequired( ).HasMaxLength(100);
            builder.Property(e => e.MovilAbonado).HasMaxLength(15);
            builder.Property(e => e.EmailAbonado).HasMaxLength(100);
            builder.Property(e => e.DireccionSuministro).IsRequired().HasMaxLength(100);
            builder.Property(e => e.PoblacionSuministro).IsRequired().HasMaxLength(25);
            builder.Property(e => e.OrdenRutaLectura).HasMaxLength(10);
            builder.Property(e => e.UbicacionContador).HasMaxLength(100);
            builder.Property(e => e.NumeroContador).IsRequired().HasMaxLength(25);
            builder.Property(e => e.NumeroContadorNuevo).HasMaxLength(25);
            builder.Property(e => e.FechaLecturaAnterior).IsRequired().HasColumnType("DateTime");
            builder.Property(e => e.FechaLecturaActual).HasColumnType("DateTime");
            builder.Property(e => e.FechaLecturaNuevo).HasColumnType("DateTime");
            builder.Property(e => e.SituacionLectura).IsRequired();
            builder.Property(e => e.IncidenciaContador).IsRequired();
            builder.Property(e => e.ObservacionesLectura ).HasMaxLength(100);
            builder.Property(e => e.ObservacionesSuministro).HasMaxLength(100);
            builder.Property(e => e.Codigo1).HasMaxLength(100);
            builder.Property(e => e.Codigo2).HasMaxLength(100);
            builder.Property(e => e.Codigo3).HasMaxLength(100);

        }
    }
}
