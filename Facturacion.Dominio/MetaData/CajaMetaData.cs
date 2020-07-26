using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facturacion.Dominio.MetaData
{
    public class CajaMetaData : IEntityTypeConfiguration<Caja>
    {
        public void Configure(EntityTypeBuilder<Caja> builder)
        {
            builder.Property(x => x.MontoApertura)
                .IsRequired()
                .HasColumnType("numeric(18,2)"); 

            builder.Property(x => x.Total)
                .IsRequired()
                .HasColumnType("numeric(18,2)");

            builder.Property(x => x.MontoCierre)
                .HasColumnType("numeric(18,2)");

            builder.Property(x => x.FechaCierre)
                .HasColumnType("Date");

            builder.Property(x => x.FechaApertura)
                .IsRequired()
                .HasColumnType("Date"); 

            builder.Property(x => x.EstaBorrado)
                .HasDefaultValue(false);
           
        }
    }
}
