using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class LecturaConfiguration : IEntityTypeConfiguration<LecturaEntity>
    {
        public void Configure(EntityTypeBuilder<LecturaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
