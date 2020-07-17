using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class IncidenciaConfiguration: IEntityTypeConfiguration<TipoIncidenciaEntity>
    {
        public void Configure(EntityTypeBuilder<TipoIncidenciaEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
