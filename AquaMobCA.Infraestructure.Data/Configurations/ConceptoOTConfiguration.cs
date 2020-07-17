using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class ConceptoOTConfiguration: IEntityTypeConfiguration<ConceptoOTEntity>
    {
        public void Configure(EntityTypeBuilder<ConceptoOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
