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

            }
        }
    }
}

