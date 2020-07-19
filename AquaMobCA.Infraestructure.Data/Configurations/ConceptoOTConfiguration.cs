using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class ConceptoOTConfiguration: IEntityTypeConfiguration<ConceptoOTEntity>
    {
        public void Configure(EntityTypeBuilder<ConceptoOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Codigo).IsRequired().HasMaxLength(25);
            builder.Property(e => e.Concepto).IsRequired().HasMaxLength(100);
        }
    }
}
