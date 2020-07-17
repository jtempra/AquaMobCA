using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class DetalleOTConfiguration: IEntityTypeConfiguration<DetalleOTEntity>
    {
        public void Configure(EntityTypeBuilder<DetalleOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
