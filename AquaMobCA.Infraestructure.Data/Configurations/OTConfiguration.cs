using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class OTConfiguration: IEntityTypeConfiguration<OTEntity>
    {
        public void Configure(EntityTypeBuilder<OTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
