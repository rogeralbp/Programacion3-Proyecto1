using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CapaNegocios
{
    class Metodos_Usuarios
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




        //Este metodo llena el comboBox de nombres de paises en la seccion de alojamiento
        public void LlenarNombresPaises(ComboBox nombre_pais)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM paises", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        nombre_pais.Items.Add(dr.GetString(0));

                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }



        //Este metodo llena el comboBox de nombres de lugares en la seccion de alojamiento
        public void LlenarNombresLugares(ComboBox nombre_lugar)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM lugares", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        nombre_lugar.Items.Add(dr.GetString(0));

                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }


        //Este metodo llena el comboBox de nombres de paises de origen en la seccion de vuelos
        public void LlenarNombresPaisOrigen(ComboBox nombre_pais)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM rutas", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        nombre_pais.Items.Add(dr.GetString(0));

                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }

        //Este metodo llena el comboBox de nombres de paises de destino en la seccion de vuelos
        public void LlenarNombresPaisDestino(ComboBox nombre_pais)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_destino FROM rutas", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        nombre_pais.Items.Add(dr.GetString(0));

                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }




        //Este metodo llena el comboBox de nombres de hoteles en la seccion de vuelos
        public void LlenarNombresHoteles(ComboBox hoteles)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM hotel", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        hoteles.Items.Add(dr.GetString(0));

                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }

        //Metodo que llena el combo de identificadores de vehiculos , en la ventana de seccion de vuelo
        public void LlenarVehiculos(ComboBox placa)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT placa FROM vehiculos", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        placa.Items.Add(dr.GetInt64(0));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }

   
        //Este metodo muestra la informacion del vehiculo seleccionado en el combobox por el usuario
        public void Combo2Vehiculos(ComboBox placa, TextBox marca, TextBox modelo, TextBox tipo_vehiculo, TextBox precio)
        {

            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT marca, modelo , tipo_vehiculo , precio FROM vehiculos WHERE placa = '" + placa.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        marca.Text = leer.GetString(0);
                        modelo.Text = leer.GetString(1);
                        tipo_vehiculo.Text = leer.GetString(2);
                        precio.Text = leer.GetDouble(3).ToString();
                       
                    }
                    conexion.Close();

                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }


    }


}