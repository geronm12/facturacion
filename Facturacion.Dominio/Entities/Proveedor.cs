using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class Proveedor : EntityBase
    {
        public string CUIL { get; set; }

        public string Telefono { get; set; }

        public string RazonSocial { get; set; }

        public string NombreFantasia { get; set; }
    }
}
