using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public  class ListaDePrecios : EntityBase
    {
        public string Descripcion { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Recargo { get; set; }

        public long PrecioListaPrecioId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual PrecioListaPrecio PrecioListaPrecio { get; set; }
    }
}
