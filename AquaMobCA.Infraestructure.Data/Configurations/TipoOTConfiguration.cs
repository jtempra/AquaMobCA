using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class TipoOTConfiguration: IEntityTypeConfiguration<TipoOTEntity>
    {
        public void Configure(EntityTypeBuilder<TipoOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
