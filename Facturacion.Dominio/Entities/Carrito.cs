using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public  class Carrito : EntityBase
    {
        public DateTime? FechaExpiracion { get; set; }

        public decimal Total { get; set; }

        public long UsuarioId { get; set; }

        public bool Expira { get; set; } 
        
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Orden Orden { get; set; }
    }
}
