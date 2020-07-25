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
            builder.Property(x => x.Fecha).IsRequired();
            builder.Property(x => x.Monto).IsRequired();
            builder.Property(x => x.NumeroFactura).IsRequired();
            builder.Property(x => x.UsuarioId).IsRequired();
            builder.Property(x => x.ClienteId).IsRequired();
        }
    }
}
