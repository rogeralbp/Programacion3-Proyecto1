using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class Guardar_Imagen

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


        public void Cargar(OpenFileDialog op)
        {
            
        }

        public void InsertarHotelFoto( int indentificador , string nombre , string filefoto , string pais , string lugar , int habitaciones)
        {

            try
            {
                Conexion();
                conexion.Open();
                MemoryStream imagen = new MemoryStream();
                FileStream fs = new FileStream( filefoto , FileMode.Open , FileAccess.Read , FileShare.ReadWrite);
                imagen.SetLength(fs.Length);
                fs.Read(imagen.GetBuffer(), 0, (int)fs.Length);
                byte[] arrImg = imagen.GetBuffer();
                imagen.Flush();
                fs.Close();

                using (cmd = conexion.CreateCommand()) ;
                {
                    conexion.Open();
                    cmd.CommandText = "INSERT INTO usuarios VALUES( " + " identificador_hotel" + "nombre_hotel" + "foto_hotel" + "pais" + "lugar" + "habitaciones" + ")";
                   // cmd.Parameters.Add("identificador_hotel" , 


                }

            }
            catch(Exception error)
            
            {
                
                

            }

        }
    }



   
    
    }
    

    

