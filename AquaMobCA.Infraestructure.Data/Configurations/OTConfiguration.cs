using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class OTConfiguration: IEntityTypeConfiguration<OTEntity>
    {
        public void Configure(EntityTypeBuilder<OTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
