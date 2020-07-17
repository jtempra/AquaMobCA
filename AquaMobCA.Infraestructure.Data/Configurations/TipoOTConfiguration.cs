using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class TipoOTConfiguration: IEntityTypeConfiguration<TipoOTEntity>
    {
        public void Configure(EntityTypeBuilder<TipoOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
