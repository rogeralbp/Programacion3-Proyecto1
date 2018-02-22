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
            string claveRoger = "Saborio17";

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


            return Seguridad.DesEncriptarContraseña(contraseña);
        }



        public void InsertarDatosVehiculos(int placa, string marca, string modelo, string tipo_vehiculo, double precio, int cantidad_personas)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO vehiculos (placa, marca, modelo , tipo_vehiculo, precio , cantidad_personas) VALUES ('" + placa + "', '" + marca + "', '" + modelo + "', '" + tipo_vehiculo + "', '" + precio + "', '" + cantidad_personas + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDatosVehiculo(string marca, string modelo, string tipo_vehiculo, double precio, int cantidad_personas)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vehiculos SET marca = '" + marca + "', modelo = '" + modelo + "', tipo_vehiculo = '" + tipo_vehiculo + "', precio ='" + precio + "', cantidad_personas = '" + cantidad_personas  + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDatosVehiculos(string marca)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM vehiculos WHERE marca = '" + marca + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void InsertarDatosAeropuerto(int identificador_aeropuerto, string nombre_aerpuerto, string lugar_aeropuerto, int codigo_aeropuerto)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO aeropuerto (identificador_aeropuerto, nombre_aeropuerto, lugar_aeropuerto , codigo_aeropuerto) VALUES ('" + identificador_aeropuerto + "', '" + nombre_aerpuerto + "', '" + lugar_aeropuerto + "', '" + codigo_aeropuerto +"')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDatosAeropuerto(int identificador_aeropuerto, string nombre_aerpuerto, string lugar_aeropuerto, int codigo_aeropuerto)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aeropuerto SET nombre_aeropuerto = '" + nombre_aerpuerto  + "', lugar_aeropuerto = '" + lugar_aeropuerto + "', codigo_aeropuerto ='" + codigo_aeropuerto + "' WHERE identificador_aeropuerto = '" + identificador_aeropuerto + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void EliminarDatosAeropuerto(int identificador_aeropuerto)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM aeropuerto WHERE identificador_aeropuerto = '" + identificador_aeropuerto + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void InsertarDatosLugares(int identificador, string nombre)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO lugares (idenficador_lugar, nombre) VALUES ('" + identificador + "', '" + nombre +  "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDatosLugar( string nombre )
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE lugares SET nombre = '" + nombre + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
                

        }

        public void EliminarDatosLugares( string nombre)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM lugares WHERE nombre = '" + nombre+ "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void InsertarDatosRutas( int identificador , string pais_origen ,  string pais_destino , int duracion)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO rutas (identificador_ruta, pais_origen , pais_destino , duracion) VALUES ('" + identificador + "', '" + pais_origen +  "', '" + pais_destino + "' ,'" + duracion +  "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void ModificarDatosRuta(int identificador, string pais_origen, string pais_destino, int duracion)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE rutas SET pais_origen = '" + pais_origen + "', pais_destino = '" + pais_destino + "', duracion ='" + duracion + "' WHERE identificador_ruta = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDatosRuta(int identificador)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM rutas WHERE identificador_ruta = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void InsertaTarifaHotel(int identificador_tarifa , double precio_tarifa)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO tarifas_hoteles (identificador_tarifa, precio_tarifa) VALUES ('" + identificador_tarifa + "', '" + precio_tarifa + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void ModificarTarifaHotel(int identificador,  double precio_tarifa)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE  tarifas_hoteles SET precio_tarifa = '" + precio_tarifa +"' WHERE identificador_tarifa = '" + identificador +  "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarDatosTarifa(double precio)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM  tarifas_hoteles WHERE precio_tarifa = '" + precio + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void InsertarDatosVuelos(int identificador_tarifa, string ruta  , double precio)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO tarifas_vuelos (identificador_tarifa, ruta, precio) VALUES ('" + identificador_tarifa + "', '" + ruta + "', '" + precio +  "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void ModificarTarifaVuelo(int identificador_tarifa, string ruta, double precio)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE tarifas_vuelos SET ruta = '" + ruta + "', precio = '" + precio + "' WHERE identificador_tarifa = '" + identificador_tarifa + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        public void EliminarDatosTarifaVuelos(int identificador)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM  tarifas_vuelos WHERE identificador_tarifa = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void InsertarDatosPaises(int identificador , string nombre , string direccion)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO pais (identificador, nombre , direccion) VALUES ('" + identificador + "', '" + nombre + "', '" + direccion + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public void EliminarDatosPaises(string nombre)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM  pais WHERE nombre = '" + nombre + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        public void ModificarDatosPaises(int identificador, string nombre, string direccion)
        {
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE pais SET identificador = '" + identificador + "', nombre = '" + nombre + "', direccion = '" + direccion + "' WHERE nombre = '" + nombre + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }

        }
        /// <summary>
        /// Este metodo funciona para saber quien esta logeado
        /// en linea mejor dicho y a si saber la informacion
        /// del usuario a la hora de realizar procesos
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns> el nombre del usuario en Linea </returns>
        public String ConsultarInformacionUsuarioCedula(String cedula)
        {

            String informacionUsuario = String.Empty;

            Conexion();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT * FROM usuarios WHERE cedula='" + cedula + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    //cedula, nombre, contraseña y tipo de usuario
                    //informacionUsuario = lectorConsulta.GetString(0) + ";" + lectorConsulta.GetString(1) + ";" + lectorConsulta.GetString(2) + ";"+ lectorConsulta.GetString(3);
                    informacionUsuario = lectorConsulta.GetString(1);
                }
            }
            conexion.Close();

            return informacionUsuario;
        }

        /// <summary>
        /// Retorna la informacion completa de un usuario 
        /// mediante el nombre dado por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns> los datos completos cedula[0], nombre[1] y tipo de usuario[3] </returns>
        public String ConsultarInformacionUsuarioNombre(String nombre)
        {

            String informacionUsuario = String.Empty;

            Conexion();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT * FROM usuarios WHERE nombre='" + nombre + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    //cedula, nombre y tipo de usuario
                    informacionUsuario = lectorConsulta.GetString(0) + ";" + lectorConsulta.GetString(1)  + ";"+ lectorConsulta.GetString(3);
                
                }
            }
            conexion.Close();

            return informacionUsuario;
        }

    } 

}






