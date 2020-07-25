using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class DetalleFacturaMetaData : IEntityTypeConfiguration<DetalleFactura>
    {
        public void Configure(EntityTypeBuilder<DetalleFactura> builder)
        {
            builder.Property(x => x.Cantidad)
                .IsRequired();

            builder.Property(x => x.FacturaId)
                .IsRequired();

            builder.Property(x => x.ProductoId)
                .IsRequired();

            builder.Property(x => x.SubTotal)
                .IsRequired()
                .HasColumnType("numeric(18,2)");

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);
        }
    }
}
