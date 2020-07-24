using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Conexion
{
    public static class ConexionBD
    {

        private const string Usuario = "";
        private const string Password = "";
        private const string BaseDeDatos = "";
        private const string Servidor = "";


        public static string ConexionWin = $"Data Source={Servidor};" +
                                           $"Initial Catalog={BaseDeDatos};" +
                                           $"User Id={Usuario};" +
                                           $"Password={Password}";

        public static string ConexionSql = $"Data Source={Servidor};" +
                                           $"Initial Catalog={BaseDeDatos};" +
                                           $"Integrated Security=true";



    }
}
