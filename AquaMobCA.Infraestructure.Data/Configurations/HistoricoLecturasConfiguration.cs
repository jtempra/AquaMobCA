using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class HistoricoLecturasConfiguration: IEntityTypeConfiguration<HistoricoLecturasEntity>
    {
        public void Configure(EntityTypeBuilder<HistoricoLecturasEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
