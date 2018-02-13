using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CapaDatos
{
    public class Conexiones_Base_Datos
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "1414250816ma";
            string baseDatos = "gestion_vuelos";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }
    }
}
