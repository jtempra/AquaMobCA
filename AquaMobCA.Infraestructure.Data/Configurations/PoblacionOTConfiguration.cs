using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class PoblacionOTConfiguration : IEntityTypeConfiguration<PoblacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<PoblacionOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
