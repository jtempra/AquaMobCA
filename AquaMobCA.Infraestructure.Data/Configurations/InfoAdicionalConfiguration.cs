using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class InfoAdicionalConfiguration: IEntityTypeConfiguration<InfoAdicionalOTEntity>
    {
        public void Configure(EntityTypeBuilder<InfoAdicionalOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Clave).HasMaxLength(50);
            builder.Property(e => e.Valor).HasMaxLength(250);
        }
    }

}
