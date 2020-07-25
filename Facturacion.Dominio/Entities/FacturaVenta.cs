using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public  class FacturaVenta : Factura
    {
        public long ? ClienteId { get; set; }

        public long UsuarioId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
