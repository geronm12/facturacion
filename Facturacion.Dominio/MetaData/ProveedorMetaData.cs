using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.Entities
{
    public class ProveedorMetaData : IEntityTypeConfiguration<Proveedor>
    {  
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.Property(x => x.CUIL)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.NombreFantasia)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.RazonSocial)
                .IsRequired()
                .HasMaxLength(200);
             
            builder.Property(x => x.Telefono)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.EstaBorrado)
                 .HasDefaultValue(false);
        }
    }
}
