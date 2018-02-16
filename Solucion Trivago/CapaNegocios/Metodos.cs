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
                MessageBox.Show("Error" + error);

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
                MessageBox.Show("Error" + error);
            }

        }



            public void LlenarDtRutas(DataGridView agregar_Rutas)
        {
            try{

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
            catch(Exception error)
               {
           MessageBox.Show("error" + error);
                }
        }
    }

    public void LlenarDtLugar(DataGridView agregar_lugares){

        try{
        Conexion();
        conexion.open();
        DataSet dataset = new DataSet();
        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_lugar , nombre  FROM lugares", conexion);
        adapter.Fill(dataset, "lugares");
        agregar_lugares.DataSource = dataset.Tables[0];
        agregar_lugares.Columns[0].HeaderCell.Value = "identificador_lugar";
        agregar_lugares.Columns[1].HeaderCell.Value = "nombre";
        conexion.Close();


            }
          catch(Exception error)
            {
            MessageBox.Show("" + error);
            }
        }



    public void LlenarDt(DataGridView agregar_tariHotel){

        try{
        Conexion();
        conexion.open();
        DataSet dataset = new DataSet();
        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT identificador_tarifa , precio_tarifa  FROM tarifas_hoteles", conexion);
        adapter.Fill(dataset, "tarifas_hoteles");
        agregar_tariHotel.DataSource = dataset.Tables[0];
        agregar_tariHotel.Columns[0].HeaderCell.Value = "identificador_tarifa";
        agregar_tariHotel.Columns[1].HeaderCell.Value = "precio_tarifa";
        conexion.Close();


            }
          catch(Exception error)
            {
            MessageBox.Show("" + error);
            }




        }

        }






    


