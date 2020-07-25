using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class MovimientoMetaData : IEntityTypeConfiguration<Movimiento>
    {
        public void Configure(EntityTypeBuilder<Movimiento> builder)
        {
            builder.Property(x => x.CajaId).IsRequired();
            builder.Property(x => x.Fecha).IsRequired();
            builder.Property(x => x.Monto).IsRequired();
            builder.Property(x => x.Tipo).IsRequired();
        }
    }
}
