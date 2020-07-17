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
            throw new NotImplementedException();
        }
    }
}
