using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.Entities
{
    public class UsuarioMetaData : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.EsBloqueable)
                .IsRequired();

            builder.Property(x => x.EstaBloqueado)
                .IsRequired();

            builder.Property(x => x.Mail)
                .IsRequired();

            builder.Property(x => x.Nombre)
                .IsRequired();

            builder.Property(x => x.PasswordHash)
                .IsRequired();

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);
        }
    }
}
