using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class DetalleOTConfiguration: IEntityTypeConfiguration<DetalleOTEntity>
    {
        public void Configure(EntityTypeBuilder<DetalleOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
