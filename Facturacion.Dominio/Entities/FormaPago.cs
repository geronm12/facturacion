using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class FormaPago : EntityBase
    {
        public FormaPago Tipo { get; set; }

        public long DetalleCajaId { get; set; }

        public virtual DetalleDeCaja  DetalleDeCaja { get; set; }
    }
}
