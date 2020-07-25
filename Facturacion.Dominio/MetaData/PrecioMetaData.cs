using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.Entities
{
    public class PrecioMetaData : IEntityTypeConfiguration<Precio>
    {
        public void Configure(EntityTypeBuilder<Precio> builder)
        {
            builder.Property(x => x.FechaActualizacion)
                .IsRequired()
                .HasColumnType("numeric(18,2)");

                 builder.Property(x => x.PrecioPublico)
                .IsRequired()
                .HasColumnType("Date");

           builder.Property(x => x.PrecioCosto)
                .IsRequired()
                .HasColumnType("Date");

            builder.Property(x => x.EstaBorrado)
                .HasDefaultValue(false);
        }
    }
}
