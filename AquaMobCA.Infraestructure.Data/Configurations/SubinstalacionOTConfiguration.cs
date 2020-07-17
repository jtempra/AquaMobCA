using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class SubinstalacionOTConfiguration : IEntityTypeConfiguration<SubinstalacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<SubinstalacionOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
