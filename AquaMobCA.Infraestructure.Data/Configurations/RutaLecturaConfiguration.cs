using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class RutaLecturaConfiguration : IEntityTypeConfiguration<RutaLecturaEntity>
    {
        public void Configure(EntityTypeBuilder<RutaLecturaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
