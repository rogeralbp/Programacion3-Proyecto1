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
            //string claveAnthonny = "1414250816ma";
            string claveRoger = "Saborio17";

            string baseDatos = "gestion_vuelos";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + claveRoger+ ";" + "Database=" + baseDatos;
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
            cmd = new NpgsqlCommand("INSERT INTO usuarios (cedula, nombre, contraseña , tipo_usuario) VALUES ('" + cedula + "', '" + nombre + "', '" + contraseña + "', '" + tipo_usuario + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public String TipoDeUsuario(String cedula)
        {

            String tipoUsuario = String.Empty;

            Conexion();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT cedula,tipo_usuario FROM usuarios WHERE cedula='" + cedula + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    tipoUsuario = lectorConsulta.GetString(1);
                }
            }
            conexion.Close();


            return tipoUsuario;
        }

        public String ValidarContraseña(String cedula)
        {

            String contraseña = String.Empty;

            Conexion();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT cedula,contraseña FROM usuarios WHERE cedula='" + cedula + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    contraseña = lectorConsulta.GetString(1);
                }
            }
            conexion.Close();


            return contraseña;
        }
    }


    public void InsertarDatosVehiculos(int placa, string marca, string modelo, string tipo_vehiculo, double precio, int cantidad_personas)
    {
        Conexion();
        conexion.Open();
        cmd = new NpgsqlCommand("INSERT INTO vehiculos (placa, marca, modelo , tipo_vehiculo, precio , cantidad_personas) VALUES ('" + placa + "', '" + marca + "', '" + modelo + "', '" + tipo_vehiculo + "', '" + precio + "', '" + cantidad_personas + "')", conexion);
        cmd.ExecuteNonQuery();
        conexion.Close();
    }

    public void ModificarDatosVehiculo(int placa, string marca, string modelo, string tipo_vehiculo, double precio, int cantidad_personas)
    {
        Conexion();
        conexion.Open();
        NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vehiculos SET marca = '" + marca + "', modelo = '" + modelo + "', tipo_vehiculo = '" + tipo_vehiculo + "', precio ='" + precio + "', cantidad_personas = '" + cantidad_personas + "' WHERE placa = '" + placa + "'", conexion);
        cmd.ExecuteNonQuery();
        conexion.Close();
    }


}

