using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class PrecioListaPrecio
    {

        public long PrecioId { get; set; }

        public long ListaPrecioId { get; set; }

        public virtual ICollection<Precio> Precios { get; set; }

        public virtual ICollection<ListaDePrecios> ListaDePrecios { get; set; }
    
    }
}
