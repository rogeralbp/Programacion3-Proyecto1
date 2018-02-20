using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace CapaNegocios
{
    public class Metodos
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
        public void Llenar_DtgAeropuerto(DataGridView agregar)
        {
            try
            {
                Conexion();
                conexion.Open();
                DataSet dataset = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_aeropuerto , nombre_aeropuerto, lugar_aeropuerto, codigo_aeropuerto FROM aeropuerto", conexion);
                adapter.Fill(dataset, "aeropuerto");
                agregar.DataSource = dataset.Tables[0];
                agregar.Columns[0].HeaderCell.Value = "identificador_aeropuerto";
                agregar.Columns[1].HeaderCell.Value = "nombre_aeropuerto";
                agregar.Columns[2].HeaderCell.Value = "lugar_aeropuerto";
                agregar.Columns[3].HeaderCell.Value = "codigo_aeropuerto";
                conexion.Close();
            }

            catch (Exception error)
            {
                Console.WriteLine(error);

            }
        }


        public void LlenarDtVehiculos(DataGridView Agregar_Vehiculo)
        {

            try
            {
                Conexion();
                conexion.Open();
                DataSet dataset = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT placa , marca , modelo , tipo_vehiculo, precio , cantidad_personas FROM vehiculos", conexion);
                adapter.Fill(dataset, "vehiculos");
                Agregar_Vehiculo.DataSource = dataset.Tables[0];
                Agregar_Vehiculo.Columns[0].HeaderCell.Value = "placa";
                Agregar_Vehiculo.Columns[1].HeaderCell.Value = "marca";
                Agregar_Vehiculo.Columns[2].HeaderCell.Value = "modelo";
                Agregar_Vehiculo.Columns[3].HeaderCell.Value = "tipo_vehiculo";
                Agregar_Vehiculo.Columns[4].HeaderCell.Value = "precio";
                Agregar_Vehiculo.Columns[5].HeaderCell.Value = "cantidad_personas";
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }



        public void LlenarDtRutas(DataGridView agregar_Rutas)
        {
            try
            {

                Conexion();
                conexion.Open();
                DataSet dataset = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_ruta , pais_origen , pais_destino , duracion FROM rutas", conexion);
                adapter.Fill(dataset, "rutas");
                agregar_Rutas.DataSource = dataset.Tables[0];
                agregar_Rutas.Columns[0].HeaderCell.Value = "identificador_ruta";
                agregar_Rutas.Columns[1].HeaderCell.Value = "pais_origen";
                agregar_Rutas.Columns[2].HeaderCell.Value = "pais_destino";
                agregar_Rutas.Columns[3].HeaderCell.Value = "duracion";

                conexion.Close();

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }


        public void LlenarDtLugar(DataGridView agregar_lugares)
        {

            try
            {
                Conexion();
                conexion.Open();
                DataSet dataset = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT idenficador_lugar , nombre  FROM lugares", conexion);
                adapter.Fill(dataset, "lugares");
                agregar_lugares.DataSource = dataset.Tables[0];
                agregar_lugares.Columns[0].HeaderCell.Value = "idenficador_lugar";
                agregar_lugares.Columns[1].HeaderCell.Value = "nombre";
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }
        }



        public void LlenarDtarifaHotel(DataGridView agregar_tariHotel)
        {

            try
            {
                Conexion();
                conexion.Open();
                DataSet dataset = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_tarifa , precio_tarifa  FROM tarifas_hoteles", conexion);
                adapter.Fill(dataset, "tarifas_hoteles");
                agregar_tariHotel.DataSource = dataset.Tables[0];
                agregar_tariHotel.Columns[0].HeaderCell.Value = "identificador_tarifa";
                agregar_tariHotel.Columns[1].HeaderCell.Value = "precio_tarifa";
                conexion.Close();


            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);
            }


        }

        public void LlenarDtTarifaVuelo(DataGridView agregar_tariVuelo)
        {
            try
            {
                Conexion();
                conexion.Open();
                DataSet dataset = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_tarifa , ruta ,  precio  FROM tarifas_vuelos", conexion);
                adapter.Fill(dataset, "tarifas_vuelos");
                agregar_tariVuelo.DataSource = dataset.Tables[0];
                agregar_tariVuelo.Columns[0].HeaderCell.Value = "identificador_tarifa";
                agregar_tariVuelo.Columns[1].HeaderCell.Value = "ruta";
                agregar_tariVuelo.Columns[2].HeaderCell.Value = "precio";
                conexion.Close();


            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);
            }



        }


        //Metodo que llena el combobox de indentificadores de lugares
        public void LlenarLugares(ComboBox identificador)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT idenficador_lugar FROM lugares", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        identificador.Items.Add(dr.GetInt64(0));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }
        //Metodo que selecciona un identicador e impreme su imformacion en un texbox
        public void LLenarComboLugares(ComboBox agregar, TextBox nombre_lugar)
        {

            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM lugares WHERE idenficador_lugar = '" + agregar.SelectedItem + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        nombre_lugar.Text = leer.GetString(1);


                    }
                    conexion.Close();

                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }

        //Metodo que llena el combo de lugares , en la ventana de modificar lugares
        public void LlenarComboModificarLugares(ComboBox nombres)
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
                        nombres.Items.Add(dr.GetString(1));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }



        //Metodo que llena el combo de lugares , en la ventana de modificar lugares
        public void ComboboxModificarLugares(ComboBox nombre, TextBox nombre_lugar)
        {

            {

                try
                {
                    Conexion();
                    conexion.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM lugares WHERE nombre = '" + nombre.SelectedItem + "'", conexion);
                    NpgsqlDataReader leer = cmd.ExecuteReader();
                    if (leer.HasRows)
                    {
                        while (leer.Read())
                        {
                            nombre_lugar.Text = leer.GetString(1);


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


        //Metodo que llena el combo de identificadores de vehiculos , en la ventana de modificar vehiculos
        public void LlenarComboIdentificadorVehiculos(ComboBox placas)
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
                        placas.Items.Add(dr.GetInt64(0));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }


        //Este metodo sirve para modificar y eliminar datos de los vehiculos 

        public void SeleccionarPlacaInformacion(ComboBox placa, TextBox marca, TextBox modelo, TextBox tipo_vehiculo, TextBox precio, TextBox cantidadP)
        {

            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT marca, modelo , tipo_vehiculo , precio , cantidad_personas FROM vehiculos WHERE placa = '" + placa.SelectedItem + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        marca.Text = leer.GetString(1);
                        modelo.Text = leer.GetString(2);
                        tipo_vehiculo.Text = leer.GetString(3);
                        precio.Text = leer.GetString(4);
                        cantidadP.Text = leer.GetString(5);
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



