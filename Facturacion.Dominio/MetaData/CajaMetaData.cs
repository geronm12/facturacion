using Facturacion.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facturacion.Dominio.MetaData
{
    public class CajaMetaData : IEntityTypeConfiguration<Caja>
    {
        public void Configure(EntityTypeBuilder<Caja> builder)
        {
            builder.Property(x => x.MontoApertura).IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.FechaApertura).IsRequired();
           
        }
    }
}
