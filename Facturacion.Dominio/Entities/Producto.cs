using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public  class Producto : EntityBase
    {
        public string Descripcion { get; set; }

        public long CategoriaId { get; set; }

        public long MarcaId { get; set; }
        public decimal Stock { get; set; }

        public string Codigo { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public long PrecioId { get; set; }

        public virtual PrecioMetaData Precio { get; set; }
    }
}
