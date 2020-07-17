using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class SubinstalacionOTConfiguration : IEntityTypeConfiguration<SubinstalacionOTEntity>
    {
        public void Configure(EntityTypeBuilder<SubinstalacionOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
