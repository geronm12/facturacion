﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class Categoria : EntityBase
    {
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
