using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class TipoIncidenciaLecturaConfiguration : IEntityTypeConfiguration<TipoIncidenciaLecturaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoIncidenciaLecturaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
