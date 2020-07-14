using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class AnotacionOTConfiguration : IEntityTypeConfiguration<AnotacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<AnotacionOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Anotacion).IsRequired().HasMaxLength(250);
            builder.Property(e => e.Fecha).IsRequired().HasColumnType("DateTime");
        }
    }
}
