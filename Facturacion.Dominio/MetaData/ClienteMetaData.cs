using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class ClienteMetaData : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(x => x.UsuarioId).IsRequired();
            builder.Property(x => x.Nombre).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Telefono).HasMaxLength(100);
            builder.Property(x => x.Email).HasMaxLength(150);
            builder.Property(x => x.Direccion).HasMaxLength(150);
            builder.Property(x => x.Apellidos).HasMaxLength(300);
            
        }
    }
}
