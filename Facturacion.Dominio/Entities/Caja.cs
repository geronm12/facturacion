using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{ 
    public class Caja : EntityBase
    {
        public decimal Total { get; set; }

        public DateTime FechaApertura { get; set; }

        public DateTime FechaCierre { get; set; }

        public decimal MontoApertura { get; set; }

        public decimal MontoCierre { get; set; }


        public virtual ICollection<DetalleDeCaja> DetalleDeCajas { get; set; }

        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}
