using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class RutaLecturaConfiguration : IEntityTypeConfiguration<RutaLecturaEntity>
    {
        public void Configure(EntityTypeBuilder<RutaLecturaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
