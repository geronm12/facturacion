using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class DetalleDeCajaMetaData : IEntityTypeConfiguration<DetalleDeCaja>
    {
        public void Configure(EntityTypeBuilder<DetalleDeCaja> builder)
        {
            builder.Property(x => x.CajaId)
                .IsRequired();

            builder.Property(x => x.Monto)
                .IsRequired()
                .HasColumnType("numeric(18,2)");

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);
        }
    }
}
