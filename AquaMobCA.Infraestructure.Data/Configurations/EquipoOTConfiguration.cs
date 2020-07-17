using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class EquipoOTConfiguration: IEntityTypeConfiguration<EquipoOTEntity>
    {
        public void Configure(EntityTypeBuilder<EquipoOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
