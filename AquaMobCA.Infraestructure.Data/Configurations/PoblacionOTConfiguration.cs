using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class PoblacionOTConfiguration : IEntityTypeConfiguration<PoblacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<PoblacionOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
