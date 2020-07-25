using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class OrdenMetaData : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.Property(x => x.CarritoId).IsRequired();
            builder.Property(x => x.CodigOrden).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Estado).IsRequired();
            builder.Property(x => x.Total).IsRequired();
        }
    }
}
