using Entities;
using Facturacion.Dominio.MetaData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class Usuario : EntityBase
    {
        public string Nombre { get; set; }

        public string PasswordHash { get; set; }

        public string Mail { get; set; }

        public bool EsBloqueable { get; set; }

        public bool EstaBloqueado { get; set; }

        public virtual ICollection<Carrito> Carritos { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Emplead Empleado { get; set; }
    }
}
