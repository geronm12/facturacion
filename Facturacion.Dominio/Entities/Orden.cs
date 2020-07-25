using Constantes;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class Orden: EntityBase
    {   
        public string CodigOrden { get; set; }

        public long Total { get; set; }

        public EstadoOrden Estado { get; set; }
         
        public long CarritoId { get; set; }
        public virtual Factura Factura { get; set; }

        public virtual Carrito Carrito { get; set; }
    }
}
