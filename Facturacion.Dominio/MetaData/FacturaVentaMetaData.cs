using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class FacturaVentaMetaData : IEntityTypeConfiguration<FacturaVenta>
    {
        public void Configure(EntityTypeBuilder<FacturaVenta> builder)
        {
            builder.Property(x => x.Fecha)
                .IsRequired()
                .HasColumnType("Date");

            builder.Property(x => x.Monto)
                .IsRequired()
                .HasColumnType("numeric(18,2)");

            builder.Property(x => x.NumeroFactura)
                .IsRequired();

           

            builder.Property(x => x.UsuarioId)
                .IsRequired();

            builder.Property(x => x.ClienteId)
                .IsRequired();

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);
        }
    }
}
