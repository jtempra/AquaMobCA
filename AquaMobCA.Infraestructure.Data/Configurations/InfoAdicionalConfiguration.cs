using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class InfoAdicionalConfiguration: IEntityTypeConfiguration<InfoAdicionalOTEntity>
    {
        public void Configure(EntityTypeBuilder<InfoAdicionalOTEntity> builder)
        {
            throw new NotImplementedException();
        }
    }

}
