using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class EmpleadoMetaData : IEntityTypeConfiguration<Emplead>
    {
        public void Configure(EntityTypeBuilder<Emplead> builder)
        {
            builder.Property(x => x.Nombre)
                .HasMaxLength(150)
                .IsRequired();


            builder.Property(x => x.Telefono)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.UsuarioId)
                .IsRequired();

            builder.Property(x => x.FechaNacimiento)
                .IsRequired();

            builder.Property(x => x.Email)
               .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.DNI)
                .HasMaxLength(12)
                .IsRequired();

            builder.Property(x => x.Direccion)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Codigo)
                .IsRequired();

            builder.Property(x => x.Celular)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Apellidos)
                .HasMaxLength(300)
                .IsRequired();


        }
    }
}
