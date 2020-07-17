using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class ZonaOTConfiguration : IEntityTypeConfiguration<ZonaOTEntity>
    {
        public void Configure(EntityTypeBuilder<ZonaOTEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Codigo).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Zona).IsRequired().HasMaxLength(50);
        }
    }
}
