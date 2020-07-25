using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class CarritoMetaData : IEntityTypeConfiguration<Carrito>
    {
        public void Configure(EntityTypeBuilder<Carrito> builder)
        {
            builder.Property(x => x.Expira).IsRequired();
            builder.Property(x => x.FechaExpiracion).IsRequired();
            builder.Property(x => x.UsuarioId).IsRequired();
            builder.Property(x => x.Total).IsRequired();
        }
    }
}
