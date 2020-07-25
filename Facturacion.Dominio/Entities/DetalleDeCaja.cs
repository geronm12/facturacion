using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class DetalleDeCaja : EntityBase
    {
        public decimal Monto { get; set; }

        public long CajaId { get; set; }
        public virtual Caja Caja { get; set; }
        public virtual ICollection<FormaPago> FormaPagos { get; set; }
    }
}
