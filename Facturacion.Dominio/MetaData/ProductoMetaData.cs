using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.Entities
{
    public class ProductoMetaData : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.MarcaId).IsRequired();
            builder.Property(x => x.FechaVencimiento).IsRequired();
            builder.Property(x => x.Descripcion).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Codigo).HasMaxLength(150).IsRequired();
            builder.Property(x => x.PrecioId).IsRequired();
            builder.Property(x => x.CategoriaId).IsRequired();













        }
    }
}
