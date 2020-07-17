using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class TipoIncidenciaLecturaConfiguration : IEntityTypeConfiguration<TipoIncidenciaLecturaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoIncidenciaLecturaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
