using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class DetalleFactura: EntityBase
    {

        public decimal SubTotal { get; set; }

        public decimal Cantidad { get; set; }

        public long ProductoId { get; set; }

        public long FacturaId { get; set; }

        public long CarritoId { get; set; }
        public virtual Producto Producto { get; set; }

        public virtual Factura Factura { get; set; }

        public virtual Carrito Carrito { get; set; }

    }
}
