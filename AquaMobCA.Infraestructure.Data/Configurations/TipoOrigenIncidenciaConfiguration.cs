using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class TipoOrigenIncidenciaConfiguration: IEntityTypeConfiguration<TipoOrigenIncidenciaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoOrigenIncidenciaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
