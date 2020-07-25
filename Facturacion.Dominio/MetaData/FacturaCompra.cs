using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class FacturaCompraMetaData : IEntityTypeConfiguration<FacturaCompra>
    {
        public void Configure(EntityTypeBuilder<FacturaCompra> builder)
        {
            builder.Property(x => x.Fecha)
                .IsRequired()
                .HasColumnType("Date");

            builder.Property(x => x.Monto)
                .IsRequired()
                .HasColumnType("numeric(18,2)");

            builder.Property(x => x.NumeroFactura)
                .IsRequired();

            builder.Property(x => x.ProveedorId)
                .IsRequired();

            builder.Property(x => x.UsuarioId)
                .IsRequired();

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);
        }
    }
}
