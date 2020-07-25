using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Facturacion.Dominio.MetaData
{
    public class CategoriaMetaData : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.Property(x => x.Descripcion).HasMaxLength(200).IsRequired();
        }
    }
}
