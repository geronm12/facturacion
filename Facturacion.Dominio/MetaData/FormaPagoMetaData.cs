using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Facturacion.Dominio.MetaData
{
    public class FormaPagoMetaData : IEntityTypeConfiguration<FormaPago>
    {
        public void Configure(EntityTypeBuilder<FormaPago> builder)
        {
            builder.Property(x => x.DetalleCajaId)
                .IsRequired();


            builder.Property(x => x.Tipo)
                .HasConversion(x => x.ToString(), e => (FormaPago)Enum.Parse(typeof(FormaPago), e))
                .IsRequired();

            builder.Property(x => x.EstaBorrado)
               .HasDefaultValue(false);
        }
    }
}
