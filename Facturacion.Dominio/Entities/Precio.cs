using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class Precio : EntityBase
    {
        public decimal PrecioPublico { get; set; }

        public DateTime FechaActualizacion { get; set; }

        public decimal PrecioCosto { get; set; }

        public long PrecioListaPrecioId { get; set; }

        public virtual PrecioListaPrecio PrecioListaPrecio { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
