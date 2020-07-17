using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class LecturaConfiguration : IEntityTypeConfiguration<LecturaEntity>
    {
        public void Configure(EntityTypeBuilder<LecturaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
