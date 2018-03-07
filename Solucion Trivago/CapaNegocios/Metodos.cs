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

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + claveRoger + ";" + "Database=" + baseDatos;
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
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_aeropuerto , nombre_aeropuerto, lugar_aeropuerto, codigo_aeropuerto FROM aeropuerto ORDER BY nombre_aeropuerto ASC", conexion);
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
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT placa , marca , modelo , tipo_vehiculo, precio , cantidad_personas FROM vehiculos ORDER BY marca ASC", conexion);
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
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_ruta , pais_origen , pais_destino , duracion FROM rutas ORDER BY identificador_ruta ASC", conexion);
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
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id_pais,identificador_lugar , nombre_lugar  FROM lugares ORDER BY nombre ASC", conexion);
                adapter.Fill(dataset, "lugares");
                agregar_lugares.DataSource = dataset.Tables[0];
                agregar_lugares.Columns[0].HeaderCell.Value = "id_pais";
                agregar_lugares.Columns[1].HeaderCell.Value = "idenficador_lugar";
                agregar_lugares.Columns[2].HeaderCell.Value = "nombre";
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
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_tarifa , precio_tarifa  FROM tarifas_hoteles ORDER BY identificador_tarifa ASC", conexion);
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
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_tarifa , ruta ,  precio  FROM tarifas_vuelos ORDER BY ruta ASC", conexion);
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



        public void LlenarDtHoteles(DataGridView agregar_hotel)
        {
            try
            {
                Conexion();
                conexion.Open();
                DataSet dataset = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador , nombre , foto ,  pais , lugar , habitaciones , tarifa_hotel FROM hotel ORDER BY nombre ASC", conexion);
                adapter.Fill(dataset, "hotel");
                agregar_hotel.DataSource = dataset.Tables[0];
                agregar_hotel.Columns[0].HeaderCell.Value = "identificador";
                agregar_hotel.Columns[1].HeaderCell.Value = "nombre";
                agregar_hotel.Columns[2].HeaderCell.Value = "foto";
                agregar_hotel.Columns[3].HeaderCell.Value = "pais";
                agregar_hotel.Columns[4].HeaderCell.Value = "lugar";
                agregar_hotel.Columns[5].HeaderCell.Value = "habitaciones";
                agregar_hotel.Columns[6].HeaderCell.Value = "tarifa_hotel";

                conexion.Close();




            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);
            }



        }



        public void LlenarDtPaises(DataGridView agregar_tariVuelo)
        {
            try
            {
                Conexion();
                conexion.Open();
                DataSet dataset = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador , nombre ,  direccion  FROM paises ORDER BY nombre ASC", conexion);
                adapter.Fill(dataset, "paises");
                agregar_tariVuelo.DataSource = dataset.Tables[0];
                agregar_tariVuelo.Columns[0].HeaderCell.Value = "identificador";
                agregar_tariVuelo.Columns[1].HeaderCell.Value = "nombre";
                agregar_tariVuelo.Columns[2].HeaderCell.Value = "direccion";
                conexion.Close();


            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);
            }



        }


        //Metodo que llena el combobox de indentificadores de lugares
        public void ComboLugar(ComboBox identificador)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador_lugar FROM lugares", conexion);
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
        public void ComboEliminarLugar(ComboBox agregar, TextBox nombre_pais, TextBox nombre_lugar)
        {

            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre_lugar,nombre  FROM lugares JOIN paises ON lugares.id_pais=paises.identificador WHERE identificador_lugar='" + agregar.SelectedItem.ToString()+"'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        nombre_lugar.Text = leer.GetString(0);
                        nombre_pais.Text = leer.GetString(1);
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
        public void ComboNombresLugares(ComboBox id_lugares)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT  idenficador_lugar FROM lugares", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_lugares.Items.Add(dr.GetInt64(0));
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
        public void LlenarCombosModificarLugar(ComboBox id_lugar, TextBox nombre_pais, TextBox nombre_lugar)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre_lugar,nombre  FROM lugares JOIN paises ON lugares.id_pais=paises.identificador WHERE identificador_lugar='" + id_lugar.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        nombre_lugar.Text = leer.GetString(0);
                        nombre_pais.Text = leer.GetString(1);
                    }
                    conexion.Close();
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }


        //Metodo que llena el combo de identificadores de vehiculos , en la ventana de modificar vehiculos
        public void LlenarCombo1IdentificadorVehiculos(ComboBox placas)
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

        public void Combo2Vehiculos(ComboBox placa, TextBox marca, TextBox modelo, TextBox tipo_vehiculo, TextBox precio, TextBox cantidadP)
        {

            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT marca, modelo , tipo_vehiculo , precio , cantidad_personas FROM vehiculos WHERE placa = '" + placa.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        marca.Text = leer.GetString(0);
                        modelo.Text = leer.GetString(1);
                        tipo_vehiculo.Text = leer.GetString(2);
                        precio.Text = leer.GetDouble(3).ToString();
                        cantidadP.Text = leer.GetInt64(4).ToString();
                    }
                    conexion.Close();

                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }


        }



        //Metodo que llena el combobox de indentificadores de tarifas de hoteles
        public void ComboIDTarifasHoteles(ComboBox identificador_tarifa)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador_tarifa FROM tarifas_hoteles", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        identificador_tarifa.Items.Add(dr.GetInt64(0));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }




        public void MostrarInformacionTarifaHoteles(ComboBox tarifa_hoteles, TextBox precio_hotel)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT precio_tarifa FROM tarifas_hoteles WHERE identificador_tarifa = '" + tarifa_hoteles.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        precio_hotel.Text = leer.GetDouble(0).ToString();

                    }
                    conexion.Close();

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }





        //Metodo que llena el combobox de indentificadores de tarifas de hoteles
        public void ComboIDPaises(ComboBox identificador_pais)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador FROM paises", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        identificador_pais.Items.Add(dr.GetInt64(0));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }


        }




        public void MostrarInformacionPais(ComboBox pais, TextBox identificador, TextBox nombre)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador , nombre  FROM paises WHERE identificador = '" + pais.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        identificador.Text = leer.GetDouble(0).ToString();
                        nombre.Text = leer.GetString(1);

                    }
                    conexion.Close();

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }




        public void ComboNombresPaises(ComboBox nombre_pais)
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




        public void MostrarInformacionPaisModificar(ComboBox pais, TextBox identificador, TextBox nombre, PictureBox bandera)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador , nombre , direccion FROM paises WHERE nombre = '" + pais.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        identificador.Text = leer.GetDouble(0).ToString();
                        nombre.Text = leer.GetString(1);
                        //bandera.Image= leer.GetString


                    }
                    conexion.Close();

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }





        //Metodo que llena el combobox de indentificadores de rutas
        public void ComboIDRuta(ComboBox identificador)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador_ruta FROM rutas", conexion);
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



        //Metodo que llena el combobox de nombres  de rutas
        public void ComboNombreRuta(ComboBox identificador)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM pais", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        identificador.Items.Add(dr.GetString(0));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }


        }




        public void MostrarInformacionRutas(ComboBox id_rutas, TextBox pais_origen, TextBox pais_destino, TextBox cantidad)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen , pais_destino , duracion FROM rutas WHERE identificador_ruta = '" + id_rutas.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        pais_origen.Text = leer.GetString(0);
                        pais_destino.Text = leer.GetString(1);
                        cantidad.Text = leer.GetInt64(2).ToString();


                    }
                    conexion.Close();

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }

        //Metodo que llena el combobox de indentificadores de vuelos
        public void ComboIDVuelos(ComboBox identificador)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador_tarifa FROM tarifas_vuelos", conexion);
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




        public void MostrarInformacionVuelos(ComboBox id_rutas, TextBox ruta, TextBox precio)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT ruta , precio  FROM tarifas_vuelos WHERE identificador_tarifa = '" + id_rutas.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        ruta.Text = leer.GetString(0);
                        precio.Text = leer.GetDouble(1).ToString();


                    }
                    conexion.Close();

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }




        public void ComboLugares(ComboBox lugares, int id_pais)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre_lugar FROM lugares JOIN paises ON lugares.id_pais=paises.identificador WHERE id_pais='"+id_pais+"'", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lugares.Items.Add(dr.GetString(0));

                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }





        //Metodo que llena el combobox de nombres  de rutas
        public void ComboIDHoteles(ComboBox identificador)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador FROM hotel", conexion);
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




        public void MostrarInformacionHoteles(ComboBox identificador_hotel, TextBox nombre, TextBox pais, TextBox lugar, TextBox cantidad, TextBox tarifa_hotel)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre , pais , lugar , habitaciones , tarifa_hotel FROM hotel WHERE identificador = '" + identificador_hotel.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        nombre.Text = leer.GetString(0);
                        pais.Text = leer.GetString(1);
                        // foto.Image = leer.Get;
                        lugar.Text = leer.GetString(2);
                        cantidad.Text = leer.GetInt64(3).ToString();
                        tarifa_hotel.Text = leer.GetDouble(4).ToString();


                    }
                    conexion.Close();

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }

        //Metodo que llena el combo de identificadores de vehiculos , en la ventana de modificar vehiculos
        public void LlenarComboDatagridviewAeropuertos(DataGridViewComboBoxColumn nombre)
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
                        nombre.Items.Add(dr.GetString(0));
                    }
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }


        //Metodo que llena el combobox de indentificadores de vuelos
        public void ComboIDRutas(ComboBox identificador)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador_ruta FROM rutas", conexion);
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


        //Metodo que llena el combobox de indentificadores de tarifas de hoteles
        public void ComboPreciosTarifaHoteles(ComboBox precio)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT precio_tarifa FROM tarifas_hoteles", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        precio.Items.Add(dr.GetDouble(0));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }

        //Metodo que llena el combobox de indentificadores de tarifas de vuelos
        public void ComboIDSTarifasVuelos(ComboBox precio)
        {

            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador FROM tarifas_vuelos", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        precio.Items.Add(dr.GetDouble(0));
                    }
                }
                conexion.Close();


            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }

        }

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

        public int RetornarIDPais(String nombre_pais)
        {
            int id = 0;
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador FROM paises WHERE nombre='" + nombre_pais + "'", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id = Convert.ToInt16(dr.GetString(0));
                    }
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

            return id;
        }

        public int RetornarNombrePais(String nombre_pais)
        {
            int id = 0;
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM paises WHERE nombre='" + nombre_pais + "'", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id = Convert.ToInt16(dr.GetString(0));
                    }
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

            return id;
        }



    }
    }

    
