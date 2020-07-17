using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class InstalacionOTConfiguration : IEntityTypeConfiguration<InstalacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<InstalacionOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
