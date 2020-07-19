using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class HistoricoLecturasConfiguration: IEntityTypeConfiguration<HistoricoLecturasEntity>
    {
        public void Configure(EntityTypeBuilder<HistoricoLecturasEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NumeroContrato).IsRequired();
            builder.Property(e => e.Periodo).IsRequired();
            builder.Property(e => e.FechaLectura).IsRequired();
        }
    }
}
