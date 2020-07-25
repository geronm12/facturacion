using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class Cliente: Persona
    {
        public long ListaPrecioId { get; set; }

        public virtual ListaDePrecios ListaDePrecios { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<FacturaVenta> FacturaVentas { get; set; }
    }
}
