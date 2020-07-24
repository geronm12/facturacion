using Constantes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public  class Movimiento : EntityBase
    {
        public DateTime Fecha { get; set; }

        public TipoMovimiento Tipo { get; set; }

        public decimal Monto { get; set; }
    }
}
