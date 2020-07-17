using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class TipoIncidenciaConfiguration : IEntityTypeConfiguration<TipoIncidenciaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoIncidenciaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
