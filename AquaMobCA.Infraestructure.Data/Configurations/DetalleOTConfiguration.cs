using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class DetalleOTConfiguration: IEntityTypeConfiguration<DetalleOTEntity>
    {
        public void Configure(EntityTypeBuilder<DetalleOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Cantidad).IsRequired();
            builder.Property(e => e.Fecha).IsRequired();
        }
    }
}
