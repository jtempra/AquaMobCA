using System;
using System.Collections.Generic;
using System.Text;
using AquaMobCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AquaMobCA.Infraestructure.Data.Configurations
{
    public class InfoAdicionalConfiguration: IEntityTypeConfiguration<InfoAdicionalOTEntity>
    {
        public void Configure(EntityTypeBuilder<InfoAdicionalOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }

}
