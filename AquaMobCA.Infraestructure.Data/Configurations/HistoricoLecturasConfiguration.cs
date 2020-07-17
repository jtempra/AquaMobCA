using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class HistoricoLecturasConfiguration: IEntityTypeConfiguration<HistoricoLecturasEntity>
    {
        public void Configure(EntityTypeBuilder<HistoricoLecturasEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
