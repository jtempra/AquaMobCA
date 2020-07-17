using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class TipoOrigenIncidenciaConfiguration: IEntityTypeConfiguration<TipoOrigenIncidenciaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoOrigenIncidenciaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
