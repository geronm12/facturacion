using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class FacturaCompra : Factura
    {
        public long ProveedorId { get; set; }

        public long UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
