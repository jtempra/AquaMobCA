using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class TipoOrigenIncidenciaConfiguration: IEntityTypeConfiguration<TipoOrigenIncidenciaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoOrigenIncidenciaEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.OrigenIncidencia).IsRequired();
            builder.Property(e => e.Observaciones).IsRequired().HasMaxLength(250);

        }
    }
}
