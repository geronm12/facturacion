using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class PrecioListaPrecioMetaData : IEntityTypeConfiguration<PrecioListaPrecio>
    {
        public void Configure(EntityTypeBuilder<PrecioListaPrecio> builder)
        {
            builder.Property(x => x.ListaPrecioId)
                .IsRequired();

            builder.Property(x => x.PrecioId)
                .IsRequired();

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);
        }
    }
}
