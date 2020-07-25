using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class ListaDePreciosMetaData : IEntityTypeConfiguration<ListaDePrecios>
    {
        public void Configure(EntityTypeBuilder<ListaDePrecios> builder)
        {

            builder.Property(x => x.Descripcion)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.EstaBorrado)
              .HasDefaultValue(false);
        }
    }
}
