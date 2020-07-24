using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Dominio.Entities
{
    public class Empleado : Persona
    {
        public string DNI { get; set; }

        public string Codigo { get; set; }

        public string Celular { get; set; }

        public DateTime FechaNacimiento { get; set; }


    }
}
