using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class FotoConfiguration: IEntityTypeConfiguration<FotoEntity>
    {
        public void Configure(EntityTypeBuilder<FotoEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.RutaFoto).IsRequired().HasMaxLength(250);
        }
    }
}
