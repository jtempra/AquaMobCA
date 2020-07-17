using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class FotoConfiguration: IEntityTypeConfiguration<FotoEntity>
    {
        public void Configure(EntityTypeBuilder<FotoEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
