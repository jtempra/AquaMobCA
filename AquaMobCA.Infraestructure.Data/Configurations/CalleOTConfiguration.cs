using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class CalleOTConfiguration : IEntityTypeConfiguration<CalleOTEntity>
    {
        public void Configure(EntityTypeBuilder<CalleOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
