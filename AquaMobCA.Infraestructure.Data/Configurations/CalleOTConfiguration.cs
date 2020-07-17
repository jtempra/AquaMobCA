using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class CalleOTConfiguration : IEntityTypeConfiguration<CalleOTEntity>
    {
        public void Configure(EntityTypeBuilder<CalleOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
