using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            try
            {

                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO usuarios (cedula, nombre, contraseña , tipo_usuario) VALUES ('" + cedula + "', '" + nombre + "', '" + contraseña + "', '" + tipo_usuario + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show("Error--- \n" + error);
            }

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
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO vehiculos (placa, marca, modelo , tipo_vehiculo, precio , cantidad_personas) VALUES ('" + placa + "', '" + marca + "', '" + modelo + "', '" + tipo_vehiculo + "', '" + precio + "', '" + cantidad_personas + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show("Error--- \n" + error);
            }


        }

        public void ModificarDatosVehiculo(int placa, string marca, string modelo, string tipo_vehiculo, double precio, int cantidad_personas)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vehiculos SET marca = '" + marca + "', modelo = '" + modelo + "', tipo_vehiculo ='" + tipo_vehiculo + "', precio = '" + precio + "', cantidad_personas = '" + cantidad_personas + "' WHERE placa = '" + placa + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }


        }

        public void EliminarDatosVehiculos(int placa)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM vehiculos WHERE placa = '" + placa + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }


        public void InsertarDatosAeropuerto(int identificador_aeropuerto, string nombre_aerpuerto, string lugar_aeropuerto, int codigo_aeropuerto)
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO aeropuerto (identificador_aeropuerto, nombre_aeropuerto, lugar_aeropuerto , codigo_aeropuerto) VALUES ('" + identificador_aeropuerto + "', '" + nombre_aerpuerto + "', '" + lugar_aeropuerto + "', '" + codigo_aeropuerto + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se agrego con exito en la DB");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public void ModificarDatosAeropuerto(int identificador_aeropuerto, string nombre_aerpuerto, string lugar_aeropuerto, int codigo_aeropuerto)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aeropuerto SET nombre_aeropuerto = '" + nombre_aerpuerto + "', lugar_aeropuerto = '" + lugar_aeropuerto + "', codigo_aeropuerto ='" + codigo_aeropuerto + "' WHERE identificador_aeropuerto = '" + identificador_aeropuerto + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }


        public void EliminarDatosAeropuerto(int identificador_aeropuerto)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM aeropuerto WHERE identificador_aeropuerto = '" + identificador_aeropuerto + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public void InsertarDatosLugares(int idPais, int identificador, string nombre)
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO lugares (id_pais,identificador_lugar, nombre_lugar) VALUES ('" + idPais + "','" + identificador + "', '" + nombre + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public void ModificarDatosLugar(int identificador, string nombre, int pais_id)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE lugares SET id_pais ='" + pais_id + "', nombre_lugar = '" + nombre + "' WHERE identificador_lugar = '" + identificador + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public void EliminarDatosLugares(int identificador)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM lugares WHERE identificador_lugar = '" + identificador + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }
        }

        public void InsertarDatosRutas(int identificador, string pais_origen, string pais_destino, int duracion)
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO rutas (identificador_ruta, pais_origen , pais_destino , duracion) VALUES ('" + identificador + "', '" + pais_origen + "', '" + pais_destino + "' ,'" + duracion + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }


        }

        public void ModificarDatosRuta(int identificador, string pais_origen, string pais_destino, int duracion)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE rutas SET pais_origen = '" + pais_origen + "', pais_destino = '" + pais_destino + "', duracion ='" + duracion + "' WHERE identificador_ruta = '" + identificador + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public void EliminarDatosRuta(int identificador_ruta)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM rutas WHERE identificador_ruta = '" + identificador_ruta + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }


        }

        public void InsertaTarifaHotel(int identificador_tarifa, double precio_tarifa)
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO tarifas_hoteles (identificador_tarifa, precio_tarifa) VALUES ('" + identificador_tarifa + "', '" + precio_tarifa + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }


        }

        public void ModificarTarifaHotel(int identificador, double precio_tarifa)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE  tarifas_hoteles SET precio_tarifa = '" + precio_tarifa + "' WHERE identificador_tarifa = '" + identificador + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }


        }

        public void EliminarDatosTarifa(int identificador)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM  tarifas_hoteles WHERE identificador_tarifa  = '" + identificador + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }
        public void InsertarDatosVuelos(int identificador_tarifa, int ruta, double precio)
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO tarifas_vuelos (identificador_tarifa, ruta, precio) VALUES ('" + identificador_tarifa + "', '" + ruta + "', '" + precio + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }


        public void ModificarTarifaVuelo(int identificador_tarifa, int ruta, double precio)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE tarifas_vuelos SET ruta = '" + ruta + "', precio = '" + precio + "' WHERE identificador_tarifa = '" + identificador_tarifa + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public void EliminarDatosTarifaVuelos(int identificador)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM  tarifas_vuelos WHERE identificador_tarifa = '" + identificador + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }


        public void InsertarDatosPaises(int identificador, string nombre, string direccion)
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO paises (identificador, nombre , direccion) VALUES ('" + identificador + "', '" + nombre + "', '" + direccion + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }


        public void EliminarDatosPaises(int identificador)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM  paises WHERE identificador = '" + identificador + "'", conexion); cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }



        public void ModificarDatosPaises(int identificador, string nombre, string direccion)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE paises SET identificador = '" + identificador + "', nombre = '" + nombre + "', direccion = '" + direccion + "' WHERE nombre = '" + nombre + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }


        public void InsertarHotel(int identificador, string nombre_hotel, string foto_hotel, string pais, string lugar, int habitaciones, double tarifa_hotel)
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO hotel (identificador , nombre, foto , pais, lugar, habitaciones , tarifa_hotel) VALUES ('" + identificador + "', '" + nombre_hotel + "', '" + foto_hotel + "', '" + pais + "', '" + lugar + "', '" + habitaciones + "', '" + tarifa_hotel + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }


        public void ModificarHotel(int identificador, string nombre_hotel, string pais, string lugar, int habitaciones, double tarifa_hotel)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE hotel SET nombre = '" + nombre_hotel + "', pais = '" + pais + "', lugar ='" + lugar + "', habitaciones = '" + habitaciones + "', tarifa_hotel = '" + tarifa_hotel + "' WHERE identificador = '" + identificador + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public void EliminarHotel(int identificador)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM hotel WHERE identificador = '" + identificador + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
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
        public int ConsultarCedulaUsuario(String nombre)
        {
            int cedulaUsurio = 0;

            Conexion();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT * FROM usuarios WHERE nombre='" + nombre + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    //cedula, nombre y tipo de usuario
                    //informacionUsuario = lectorConsulta.GetString(0) + ";" + lectorConsulta.GetString(1)  + ";"+ lectorConsulta.GetString(3);
                    cedulaUsurio = int.Parse(lectorConsulta.GetString(0));

                }
            }
            conexion.Close();

            return cedulaUsurio;
        }

        public void InsertarDatosAerolineas(string identificador, string nombre)
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO aerolineas(identificador, nombre) VALUES ('" + identificador + "', '" + nombre + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }


        public void LlenarComboIdentificadorAerolineas(ComboBox IDSA)
        {
            try
            {
                Conexion();
                conexion.Open();
                List<String> lista = new List<String>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador FROM aerolineas", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        IDSA.Items.Add(dr.GetInt64(0));
                    }
                }
                conexion.Close();

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }

        public void MostrarInformacionAerolineas(ComboBox id_aerolineas, TextBox idActual, TextBox nombre)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT identificador,nombre FROM aerolineas WHERE identificador = '" + id_aerolineas.SelectedItem.ToString() + "'", conexion);
                NpgsqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        idActual.Text = leer.GetString(0);
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

        public void ModificarDatosAerolineas(string identificadorAer, string nombreAer)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aerolineas SET nombre ='" + nombreAer + "' WHERE identificador='" + identificadorAer + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public void EliminarDatosAerolineas(string idAer)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM  aerolineas WHERE identificador = '" + idAer + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error--- \n" + error);
            }

        }

        public String ConsultarIDPais(String nombrePais)
        {

            String idPais = String.Empty;

            Conexion();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT identificador FROM pais WHERE nombre='" + nombrePais + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    //cedula, nombre y tipo de usuario
                    idPais = lectorConsulta.GetString(0);

                }
            }
            conexion.Close();

            return idPais;
        }



        /// <summary>
        /// REPORTE 1
        /// </summary>
        /// <returns></returns>

        public List<string> Cantidad_Hoteles()
        {
            List<string> cantidad = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(r.id_hotel) AS reservaciones, h.nombre FROM informacion_reservaciones_hoteles AS r JOIN hotel AS h on r.id_hotel = h.identificador  WHERE r.id_hotel = h.identificador GROUP BY h.nombre ORDER BY reservaciones DESC", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    cantidad.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();

            }


            return cantidad;
        }
        public List<string> Metodo_Nombres()
        {

            List<string> nombres = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(r.id_hotel) AS reservaciones, h.nombre FROM informacion_reservaciones_hoteles AS r JOIN hotel AS h on r.id_hotel = h.identificador  WHERE r.id_hotel = h.identificador GROUP BY h.nombre ORDER BY reservaciones DESC", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(1));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }


            return nombres;
        }


        /// <summary>
        /// REPORTE 2
        /// </summary>
        /// <returns></returns>


        public List<int> Cantidad_Persona()
        {

            List<int> nombres = new List<int>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(r.cantidad_personas) AS personas,h.nombre FROM informacion_reservaciones_hoteles AS r JOIN hotel AS h on r.id_hotel = h.identificador  WHERE r.id_hotel = h.identificador GROUP BY h.nombre  ORDER BY personas DESC", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetInt32(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }


            return nombres;
        }



        public List<string> Hoteles()
        {

            List<String> nombres = new List<String>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(r.cantidad_personas) AS personas,h.nombre FROM informacion_reservaciones_hoteles AS r JOIN hotel AS h on r.id_hotel = h.identificador  WHERE r.id_hotel = h.identificador GROUP BY h.nombre  ORDER BY personas DESC", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(1));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }


            return nombres;
        }

        /// <summary>
        /// REPORTE 3
        /// </summary>
        /// <returns></returns>
        public List<string> Cantidad_Porcentaje()
        {
            List<string> cantidad = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) as porcentaje_visitas,pais_destino FROM informacion_reservaciones_vuelos GROUP BY pais_destino", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    cantidad.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();

            }


            return cantidad;
        }
        public List<string> Metodo_Porcentaje()
        {

            List<string> nombres = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) as porcentaje_visitas,pais_destino FROM informacion_reservaciones_vuelos GROUP BY pais_destino", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(1));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }


            return nombres;
        }



        /// <summary>
        /// REPORTE 4
        /// </summary>
        /// <returns></returns>
        /// 


        public List<string> Cantidad_Adultos(string fechainicio, string fechafin)
        {
            List<string> cantidad = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) as porcentaje_visitas,pais_destino FROM informacion_reservaciones_vuelos GROUP BY pais_destino", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    cantidad.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();

            }


            return cantidad;
        }
       
        /// <summary>
        /// REPORTE 5
        /// </summary>
        /// <returns></returns>
        /// 

        public List<string> Cantidad_Niños(string fechainicio, string fechafin)
        {
            List<string> cantidad = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(c.pasajeros_niños) FROM informacion_reservaciones_vuelos as c WHERE to_date(c.fecha_inicio,'DD/MM/YY')  >= '" + fechainicio + "' AND to_date(c.fecha_fin,'DD/MM/YY')  <= '" + fechafin + "'", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    cantidad.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();

            }


            return cantidad;
        }
        /// <summary>
        /// REPORTE 6
        /// </summary>
        /// <returns></returns>
        /// 
        public List<string> Cantidad_Vehiculos()
        {
            List<string> cantidad = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT v.marca  as marca FROM informacion_reservaciones_vuelos AS r JOIN vehiculos AS v ON r.placa_vehiculo = v.placa GROUP BY marca ORDER BY marca DESC", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    cantidad.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }
            for (int i = 0; i < cantidad.Count; i++)
            {
                string carros = (string)cantidad[i];
                carros = carros.Replace(",", "");
                cantidad[i] = carros;
            }



            return cantidad;
        }
        public List<string> Metodo_Vehiculos()
        {

            List<string> nombres = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT v.marca  as marca FROM informacion_reservaciones_vuelos AS r JOIN vehiculos AS v ON r.placa_vehiculo = v.placa GROUP BY marca ORDER BY marca DESC", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(1));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }

            for (int i = 0; i < nombres.Count; i++)
            {
                string user = (string)nombres[i];
                user = user.Replace(",", "");
                nombres[i] = user;
            }
            return nombres;
        }



        /// <summary>
        /// REPORTE 7
        /// </summary>
        /// <returns></returns>
        /// 

        public List<string> Cantidad_Escala()
        {
            List<string> cantidad = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT vuelo_escala pais_escla FROM informacion_reservaciones_vuelos WHERE vuelo_escala !='Vuelo Directo'", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    cantidad.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }
            for (int i = 0; i < cantidad.Count; i++)
            {
                string carros = (string)cantidad[i];
                carros = carros.Replace(",", "");
                cantidad[i] = carros;
            }



            return cantidad;
        }
        public List<string> Metodo_Escala()
        {

            List<string> nombres = new List<string>();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT vuelo_escala pais_escla FROM informacion_reservaciones_vuelos WHERE vuelo_escala !='Vuelo Directo'", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(1));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }

            for (int i = 0; i < nombres.Count; i++)
            {
                string user = (string)nombres[i];
                user = user.Replace(",", "");
                nombres[i] = user;
            }
            return nombres;
        }
    }

}



