using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public abstract class Factura : EntityBase
    {
        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public int NumeroFactura { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }

        public virtual Orden Orden { get; set; }

    }
}
