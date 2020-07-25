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
            builder.Property(x => x.Expira).
                IsRequired();

            builder.Property(x => x.FechaExpiracion)
                .HasColumnType("Date");

            builder.Property(x => x.UsuarioId)
                .IsRequired();

            builder.Property(x => x.Total)
                .IsRequired()
                .HasColumnType("numeric(18,2)");
            
            
            
            builder.Property(x => x.Expira)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);
        }
    }
}
