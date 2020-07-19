using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class EquipoOTConfiguration: IEntityTypeConfiguration<EquipoOTEntity>
    {
        public void Configure(EntityTypeBuilder<EquipoOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Equipo).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Observaciones).HasMaxLength(250);
        }
    }
}
