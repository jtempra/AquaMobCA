using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class UserEntityConfiguration: IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NIF).IsRequired().HasMaxLength(15);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Apellidos).IsRequired( ).HasMaxLength(100);


            builder.HasMany<OTEntity>(p => p.OrdenesTrabajoCreadas)
                .WithOne(b => b.Creador).HasForeignKey(x => x.Id);

            builder.HasMany<OTEntity>(p => p.OrdenesTrabajoGestionadas)
                .WithOne(b => b.Responsable).HasForeignKey(x => x.Id);
        }
    }
}
