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
            string claveAnthonny = "1414250816ma";
            //string claveRoger = "Saborio17";

            string baseDatos = "gestion_vuelos";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + claveAnthonny + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);

            if (conexion != null)
            {

                Console.WriteLine("Conexion con la DB nombre : " + baseDatos + " , Exitosa!!");
            }
            else
            {

                Console.WriteLine("Error en la conexion con la DB");
            }
        }

        public void InsertarDatosUsuarios(int cedula, string nombre, string contraseña, string tipo_usuario)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT usuarios (cedula, nombre, contraseña , tipo_usuario) VALUES ('" + cedula + "', '" + nombre + "', '" + contraseña + "', '" + tipo_usuario + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public String TipoDeUsuario() {

            String tipoUsuario="";

            return tipoUsuario;
        }
    }
}
