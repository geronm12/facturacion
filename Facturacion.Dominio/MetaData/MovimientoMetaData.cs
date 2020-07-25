using Constantes;
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
            builder.Property(x => x.CajaId)
                .IsRequired();

            builder.Property(x => x.Fecha)
                .IsRequired().HasColumnType("Date");

            builder.Property(x => x.Monto)
                .IsRequired().HasColumnType("numeric(18,2)");

            builder.Property(x => x.Tipo)
                .IsRequired()
                .HasConversion(x => x.ToString(), e => (TipoMovimiento)Enum.Parse(typeof(TipoMovimiento), e));

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);

        }
    }
}
