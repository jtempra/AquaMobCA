using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class EquipoOTConfiguration: IEntityTypeConfiguration<EquipoOTEntity>
    {
        public void Configure(EntityTypeBuilder<EquipoOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
