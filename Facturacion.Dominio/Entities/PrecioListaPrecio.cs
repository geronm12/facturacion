using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class PrecioListaPrecio : EntityBase
    {

        public long PrecioId { get; set; }

        public long ListaPrecioId { get; set; }

        public virtual PrecioMetaData Precio { get; set; }

        public virtual ListaDePrecios ListaDePrecio { get; set; }
    
    }
}
