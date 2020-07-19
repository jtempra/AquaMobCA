using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class CalleOTConfiguration : IEntityTypeConfiguration<CalleOTEntity>
    {
        public void Configure(EntityTypeBuilder<CalleOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Codigo).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Calle).IsRequired().HasMaxLength(50);
        }
    }
}
