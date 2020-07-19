using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class SubinstalacionOTConfiguration : IEntityTypeConfiguration<SubinstalacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<SubinstalacionOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Subinstalacion).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Observaciones).IsRequired().HasMaxLength(250);
        }
    }
}
