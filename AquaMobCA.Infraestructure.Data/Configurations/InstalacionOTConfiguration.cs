using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class InstalacionOTConfiguration : IEntityTypeConfiguration<InstalacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<InstalacionOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
