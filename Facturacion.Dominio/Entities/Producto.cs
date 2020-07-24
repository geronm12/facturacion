using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public  class Producto : EntityBase
    {
        public string Descripcion { get; set; }

        public Categoria Categoria { get; set; }

        public Marca Marca { get; set; }

        public decimal Stock { get; set; }

        public string Codigo { get; set; }

        public DateTime FechaVencimiento { get; set; }
    }
}
