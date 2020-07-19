using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class TipoOTConfiguration: IEntityTypeConfiguration<TipoOTEntity>
    {
        public void Configure(EntityTypeBuilder<TipoOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Tipo).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Descripcion).HasMaxLength(100);

        }
    }
}
