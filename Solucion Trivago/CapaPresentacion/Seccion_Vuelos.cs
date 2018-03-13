using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Seccion_Vuelos : Form
    {
        Validaciones validar = new Validaciones();
        Metodos_Usuarios metodos = new Metodos_Usuarios();
        Conexiones_Base_Datos conexion = new Conexiones_Base_Datos();
        int idHotel;
        int placaVehiculo;
        double precioHotel;
        double precioVehiculo;
        //Este objeto funciona para guardar los datos de las reservaciones y
        // pre reservaciones en la seccion de VUELOS.
        Reservaciones_Vuelos reservacionVuelo = new Reservaciones_Vuelos();
        int posicionDTGVuelos;

        public Seccion_Vuelos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Seccion_Vuelos_Load(object sender, EventArgs e)
        {
            metodos.LlenarNombresPaises(comboBoxPaisOrigen);
            metodos.LlenarNombresPaises(comboBoxPaisDestino);
            metodos.LlenarVehiculos(comboBoxVehiculos);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Usuarios v = new Menu_Principal_Usuarios();
            v.Show();
            panelAgregarHotel.Visible = false;
            panelAgregarAutomovil.Visible = false;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void spinnerCantidadPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }


        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        
        private void optTodosServicios_CheckedChanged(object sender, EventArgs e)
        {
            panelAgregarAutomovil.Visible = true;
            panelAgregarHotel.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelAgregarAutomovil.Visible = false;
            panelAgregarHotel.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelAgregarHotel.Visible = false;
            panelAgregarAutomovil.Visible = true;
        }

        private void spinnerCantidadPasajerosNiños_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void spinnerCantidadHabitacionesHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void fechaFinalizacion_ValueChanged(object sender, EventArgs e)
        {
            if (metodos.DiferenciaDiasFechas(fechaInicio.Text, fechaFinalizacion.Text) > 0)
            {
                labelCantidadDias.Text = "Cantidad de dias " + metodos.DiferenciaDiasFechas(fechaInicio.Text, fechaFinalizacion.Text).ToString();
            }
            else
            {
                MessageBox.Show("Debe de Seleccionnar Fechas Validas");
            }
        }

        private void btnGuardarCantidadPasajeros_Click(object sender, EventArgs e)
        {
            int cantidadTotalPersonasPais = Convert.ToInt16(spinnerCantidadPasajerosAdultos.Value + spinnerCantidadPasajerosNiños.Value);
            spinnerCantidadPasajerosAdultos.Enabled = false;
            spinnerCantidadPasajerosNiños.Enabled = false;
            spinnerCantidadHabitacionesHotel.Enabled = false;
            btnGuardarCantidadPasajeros.Enabled = false;

            if (cantidadTotalPersonasPais <= 4)
            {

                MessageBox.Show("Una habitacion");
                spinnerCantidadHabitacionesHotel.Value = 1;
            }
            if ((cantidadTotalPersonasPais > 4) && (cantidadTotalPersonasPais <= 8))
            {
                MessageBox.Show("Dos habitaciones");
                spinnerCantidadHabitacionesHotel.Value = 2;
            }
            if ((cantidadTotalPersonasPais > 8) && (cantidadTotalPersonasPais <= 12))
            {
                MessageBox.Show("Tres habitaciones");
                spinnerCantidadHabitacionesHotel.Value = 3;
            }
            if ((cantidadTotalPersonasPais > 12) && (cantidadTotalPersonasPais <= 16))
            {
                MessageBox.Show("Cuatro habitaciones");
                spinnerCantidadHabitacionesHotel.Value = 4;
            }
            if ((cantidadTotalPersonasPais > 16) && (cantidadTotalPersonasPais <= 20))
            {

                MessageBox.Show("Cinco habitaciones");
                spinnerCantidadHabitacionesHotel.Value = 5;
            }
            if ((cantidadTotalPersonasPais > 20) && (cantidadTotalPersonasPais <= 24))
            {

                MessageBox.Show("Seis habitaciones");
                 spinnerCantidadHabitacionesHotel.Value = 6;
            }
            if ((cantidadTotalPersonasPais > 24) && (cantidadTotalPersonasPais <= 28))
            {

                MessageBox.Show("Siete habitaciones");
                 spinnerCantidadHabitacionesHotel.Value = 7;
            }
            if ((cantidadTotalPersonasPais > 28) && (cantidadTotalPersonasPais <= 32))
            {

                MessageBox.Show("Ocho habitaciones");
                 spinnerCantidadHabitacionesHotel.Value = 8;
            }
            if ((cantidadTotalPersonasPais > 32) && (cantidadTotalPersonasPais <= 36))
            {

                MessageBox.Show("Nueve habitaciones");
                spinnerCantidadHabitacionesHotel.Value = 9;
            }
            if ((cantidadTotalPersonasPais > 36) && (cantidadTotalPersonasPais <= 40))
            {

                MessageBox.Show("Diez habitaciones");
                spinnerCantidadHabitacionesHotel.Value = 10;
            }
            if (cantidadTotalPersonasPais > 40)
            {
                MessageBox.Show("Cantidad de Personas Inexsistente");
            }
        }

        private void comboBoxPaisDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodos.LlenarHotelesPaisDestino(comboBoxHotelesPaisDestino,comboBoxPaisDestino.SelectedItem.ToString());
            //comboBoxPaisOrigen.Items.Clear();
            //comboBoxPaisDestino.Items.Clear();
            //optPrecioMayorHotel.Enabled = false;
            //optPrecioMenorHotel.Enabled = false;
            //optTiempoCorto.Enabled = false;
            //optTodosServicios.Enabled = false;
            //optAutomovil.Enabled = false;
            //optHotel.Enabled = false;
            //fechaInicio.Enabled = false;
            //fechaFinalizacion.Enabled = false;
            //btnGuardarCantidadPasajeros.Enabled = false;
            //spinnerCantidadPasajerosAdultos.Enabled = false;
            //spinnerCantidadPasajerosNiños.Enabled = false;
            //btnGuardarReservacion.Enabled = false;
            //btnCofirmarReservacion.Enabled = false;
            //dtgVistaPreliminarVHA.Enabled = false;
            //panelAgregarAutomovil.Visible = false;
            //panelAgregarHotel.Visible = false;

           
        }

        private void comboBoxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodos.MostrarInformacionVehiculos(comboBoxVehiculos, textBoxMarcaVehiculo, textBoxModeloVehiculo, textBoxTipoVehiculo, txtPrecioVehiculo);
        }

        private void btnVerListaPreeliminarHotelesVuelos_Click(object sender, EventArgs e)
        {
            if (metodos.BanderaRutaSinEscala(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString()))
            {

                MessageBox.Show("SI existe en Vuelo DIRECTO");

                metodos.LlenarHotelesPaisDestino(comboBoxHotelesPaisDestino, comboBoxPaisDestino.SelectedItem.ToString());
                reservacionVuelo.vuelo_escala ="Vuelo Directo";
                optPrecioMayorHotel.Enabled = true;
                optPrecioMenorHotel.Enabled = true;
                optTiempoCorto.Enabled = true;
                optTodosServicios.Enabled = true;
                optAutomovil.Enabled = true;
                optHotel.Enabled = true;
                fechaInicio.Enabled = true;
                fechaFinalizacion.Enabled = true;
                btnGuardarCantidadPasajeros.Enabled = true;
                spinnerCantidadPasajerosAdultos.Enabled = true;
                spinnerCantidadPasajerosNiños.Enabled = true;
                btnGuardarReservacion.Enabled = true;
                btnCofirmarReservacion.Enabled = true;
                dtgVistaPreliminarVHA.Enabled = true;
                optMenosEscalas.Visible = false;
                //optPrecioMenorHotel.Checked = true;
                //metodos.LlenarDtVistaPreliminarVuelosASC(dtgVistaPreliminarVHA,comboBoxPaisOrigen.SelectedItem.ToString(),comboBoxPaisDestino.SelectedItem.ToString());
                int idVueloDirecto = metodos.RetornarIDVueloDirecto(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
                if (idVueloDirecto != 0)
                {
                    dtgVistaPreliminarVHA.Rows.Clear();
                    //double precio = metodos.RetornarPrecioTotalVueloDirecto(idVueloDirecto); 
                    ArrayList datos = metodos.LlenarDtVistaPreliminarVuelosASCString(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
                    for (int i = 0; i < datos.Count; i++)
                    {
                        string[] info = datos[i].ToString().Split(';');
                        dtgVistaPreliminarVHA.Rows.Add(info[0], info[1], info[2], info[3], "Vuelo Directo");
                    }
                    //dtgVistaPreliminarVHA.Rows.Add(comboBoxPaisOrigen.SelectedItem.ToString(),comboBoxPaisDestino.SelectedItem.ToString(),metodos.RetornarDuracionTotalVueloDirecto(idVueloDirecto),precio, "Vuelo Directo");
                    //dtgVistaPreliminarVHA.Rows.Add(datos[0], datos[1], datos[2], datos[3], "Vuelo Directo");

                }
            }
            else if (metodos.BanderaRutaConEscalas(comboBoxPaisDestino.SelectedItem.ToString()))
            {
                optPrecioMayorHotel.Visible = false;
                optPrecioMenorHotel.Visible = false;
                optTiempoCorto.Visible = false;
                optMenosEscalas.Visible = false;
                MessageBox.Show("NO existe este Vuelo DIRECTO, Existen pero SI con Escalas.");
                reservacionVuelo.vuelo_escala= metodos.RetornarPaisEscala(comboBoxPaisDestino.SelectedItem.ToString());
                optMenosEscalas.Visible = true;
                metodos.LlenarHotelesPaisDestino(comboBoxHotelesPaisDestino, comboBoxPaisDestino.SelectedItem.ToString());
                optPrecioMayorHotel.Enabled = true;
                optPrecioMenorHotel.Enabled = true;
                optTiempoCorto.Enabled = true;
                optTodosServicios.Enabled = true;
                optAutomovil.Enabled = true;
                optHotel.Enabled = true;
                fechaInicio.Enabled = true;
                fechaFinalizacion.Enabled = true;
                btnGuardarCantidadPasajeros.Enabled = true;
                spinnerCantidadPasajerosAdultos.Enabled = true;
                spinnerCantidadPasajerosNiños.Enabled = true;
                btnGuardarReservacion.Enabled = true;
                btnCofirmarReservacion.Enabled = true;
                dtgVistaPreliminarVHA.Enabled = true;
                int duracioVD = metodos.RetornarDuracionTotalVueloDirecto(comboBoxPaisOrigen.SelectedItem.ToString());
                int duracionVE = metodos.RetornarDuracionTotalVueloEscala(metodos.RetornarPaisEscala(comboBoxPaisDestino.SelectedItem.ToString()), comboBoxPaisDestino.SelectedItem.ToString());
                int duracionTotal = duracioVD + duracionVE;

                double precio1 = metodos.RetornarPrecioTotalVueloDirectoOrigenEscala(comboBoxPaisOrigen.SelectedItem.ToString());
                double precio2 = metodos.RetornarPrecioTotalVueloDirectoOrigenDestinoVueloEscala(metodos.RetornarPaisEscala(comboBoxPaisDestino.SelectedItem.ToString()), comboBoxPaisDestino.SelectedItem.ToString());
                double precioTotal = precio1 + precio2;
                dtgVistaPreliminarVHA.Rows.Add(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString(), duracionTotal, precioTotal, metodos.RetornarPaisEscala(comboBoxPaisDestino.SelectedItem.ToString()));
            }
            else {

                dtgVistaPreliminarVHA.Rows.Clear();
                optPrecioMayorHotel.Enabled = false;
                optPrecioMenorHotel.Enabled = false;
                optTiempoCorto.Enabled = false;
                optTodosServicios.Enabled = false;
                optAutomovil.Enabled = false;
                optHotel.Enabled = false;
                fechaInicio.Enabled = false;
                fechaFinalizacion.Enabled = false;
                btnGuardarCantidadPasajeros.Enabled = false;
                spinnerCantidadPasajerosAdultos.Enabled = false;
                spinnerCantidadPasajerosNiños.Enabled = false;
                btnGuardarReservacion.Enabled = false;
                btnCofirmarReservacion.Enabled = false;
                dtgVistaPreliminarVHA.Enabled = false;
                panelAgregarAutomovil.Visible = false;
                panelAgregarHotel.Visible = false;
                MessageBox.Show("NO EXISTE TAL VUELO");
            }
        }

        private void spinnerCantidadPasajerosAdultos_ValueChanged(object sender, EventArgs e)
        {
            btnGuardarCantidadPasajeros.Visible = true;
        }

        private void optPrecioMenorHotel_CheckedChanged(object sender, EventArgs e)
        {
            int idVueloDirecto = metodos.RetornarIDVueloDirecto(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
            if (idVueloDirecto != 0)
            {
                //double precio = metodos.RetornarPrecioTotalVueloDirecto(idVueloDirecto); 
                dtgVistaPreliminarVHA.Rows.Clear();
                ArrayList datos = metodos.LlenarDtVistaPreliminarVuelosASCString(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
                for (int i = 0; i < datos.Count; i++)
                {
                    string[] info = datos[i].ToString().Split(';');
                    dtgVistaPreliminarVHA.Rows.Add(info[0], info[1], info[2], info[3], "Vuelo Directo");
                }
                //dtgVistaPreliminarVHA.Rows.Add(comboBoxPaisOrigen.SelectedItem.ToString(),comboBoxPaisDestino.SelectedItem.ToString(),metodos.RetornarDuracionTotalVueloDirecto(idVueloDirecto),precio, "Vuelo Directo");
                //dtgVistaPreliminarVHA.Rows.Add(datos[0], datos[1], datos[2], datos[3], "Vuelo Directo");

            }
        }

        private void optPrecioMayorHotel_CheckedChanged(object sender, EventArgs e)
        {
            //metodos.LlenarDtVistaPreliminarVuelosDESC(dtgVistaPreliminarVHA, comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
            //metodos.LlenarDtVistaPreliminarVuelosASC(dtgVistaPreliminarVHA, comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString
            int idVueloDirecto = metodos.RetornarIDVueloDirecto(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
            if (idVueloDirecto != 0)
            {
                //double precio = metodos.RetornarPrecioTotalVueloDirecto(idVueloDirecto);
                dtgVistaPreliminarVHA.Rows.Clear();
                ArrayList datos = metodos.LlenarDtVistaPreliminarVuelosDESCString(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
                for (int i = 0; i < datos.Count; i++)
                {
                    string[] info = datos[i].ToString().Split(';');
                    dtgVistaPreliminarVHA.Rows.Add(info[0], info[1], info[2], info[3], "Vuelo Directo");
                }
                //dtgVistaPreliminarVHA.Rows.Add(comboBoxPaisOrigen.SelectedItem.ToString(),comboBoxPaisDestino.SelectedItem.ToString(),metodos.RetornarDuracionTotalVueloDirecto(idVueloDirecto),precio, "Vuelo Directo");
                //dtgVistaPreliminarVHA.Rows.Add(datos[0], datos[1], datos[2], datos[3], "Vuelo Directo");

            }
        }

        private void comboBoxHotelesPasDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodos.RetornarPrecioHabitacionesHotel(comboBoxHotelesPaisDestino, txtPrecioHabitacion);
        }

        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void optTiempoCorto_CheckedChanged(object sender, EventArgs e)
        {
            int idVueloDirecto = metodos.RetornarIDVueloDirecto(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
            if (idVueloDirecto != 0)
            {
                //double precio = metodos.RetornarPrecioTotalVueloDirecto(idVueloDirecto);
                dtgVistaPreliminarVHA.Rows.Clear();
                ArrayList datos = metodos.LlenarDtVistaPreliminarVuelosDuracionASCtring(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
                for (int i = 0; i < datos.Count; i++)
                {
                    string[] info = datos[i].ToString().Split(';');
                    dtgVistaPreliminarVHA.Rows.Add(info[0], info[1], info[2], info[3], "Vuelo Directo");
                }
                //dtgVistaPreliminarVHA.Rows.Add(comboBoxPaisOrigen.SelectedItem.ToString(),comboBoxPaisDestino.SelectedItem.ToString(),metodos.RetornarDuracionTotalVueloDirecto(idVueloDirecto),precio, "Vuelo Directo");
                //dtgVistaPreliminarVHA.Rows.Add(datos[0], datos[1], datos[2], datos[3], "Vuelo Directo");

            }
        }

        private void btnGuardarSeleccionHotel_Click(object sender, EventArgs e)
        {
          //  reservacionVuelo.id_hotel = metodos.ConsultarIDHotel(comboBoxHotelesPaisDestino.SelectedItem.ToString());
            MessageBox.Show("Hotel Agregado Correctamente.");
            precioHotel = Convert.ToDouble(txtPrecioHabitacion.Text); 
            panelAgregarHotel.Enabled = false;
            optHotel.Enabled = false;        
            labelNotificacionH.Visible = true;
            MessageBox.Show(metodos.ConsultarIDHotel(comboBoxHotelesPaisDestino.SelectedItem.ToString()).ToString());
            idHotel = metodos.ConsultarIDHotel(comboBoxHotelesPaisDestino.SelectedItem.ToString());
            reservacionVuelo.id_hotel = idHotel;
            MessageBox.Show(reservacionVuelo.id_hotel.ToString());
        }

        private void btnGuardarSeleccionAutomovil_Click(object sender, EventArgs e)
        {   
            MessageBox.Show("Vehiculo agregado Correctamente.");
            precioVehiculo = Convert.ToDouble(txtPrecioVehiculo.Text);
            panelAgregarAutomovil.Enabled = false;
            optAutomovil.Enabled = false;
            labelNotificacionV.Visible = true;
            placaVehiculo = Convert.ToInt16(comboBoxVehiculos.SelectedItem.ToString());
            reservacionVuelo.placa_vehiculo = placaVehiculo;
            MessageBox.Show(reservacionVuelo.placa_vehiculo.ToString());
        }

        private void panelAgregarHotel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardarReservacionPais_Click(object sender, EventArgs e)
        {
            if (metodos.DiferenciaDiasFechas(fechaInicio.Text, fechaFinalizacion.Text) > 0)
            {

                int cantidadDias = metodos.DiferenciaDiasFechas(fechaInicio.Text, fechaFinalizacion.Text);
                int idVueloDirecto = metodos.RetornarIDVueloDirecto(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
                reservacionVuelo.id_vuelo = idVueloDirecto;
                posicionDTGVuelos = dtgVistaPreliminarVHA.CurrentRow.Index;
                string paisOrigen = dtgVistaPreliminarVHA[0, posicionDTGVuelos].Value.ToString();
                string paisDestino = dtgVistaPreliminarVHA[1, posicionDTGVuelos].Value.ToString();
                double precioTotalHotel = (precioHotel * cantidadDias);
                double precioTotalVehiculo = (precioVehiculo * cantidadDias);
                int duracionTotal = Convert.ToInt16(dtgVistaPreliminarVHA[2, posicionDTGVuelos].Value);
                double precioTotal = Convert.ToDouble(dtgVistaPreliminarVHA[3, posicionDTGVuelos].Value);
                string vuelo_Escala = dtgVistaPreliminarVHA[4, posicionDTGVuelos].Value.ToString();
                reservacionVuelo.pasajeros_adultos = Convert.ToInt16(spinnerCantidadPasajerosAdultos.Value);
                reservacionVuelo.pasajeros_niños = Convert.ToInt16(spinnerCantidadPasajerosNiños.Value);
                reservacionVuelo.habitaciones_hotel = Convert.ToInt16(spinnerCantidadHabitacionesHotel.Value);
                reservacionVuelo.pais_origen = paisOrigen;
                reservacionVuelo.pais_destino = paisDestino;
                reservacionVuelo.duracion_total = duracionTotal;
                reservacionVuelo.precio_total = (precioTotal + precioTotalHotel + precioTotalVehiculo);
                reservacionVuelo.vuelo_escala = vuelo_Escala;
                reservacionVuelo.fecha_inicio = fechaInicio.Text;
                reservacionVuelo.fecha_fin = fechaFinalizacion.Text;
                reservacionVuelo.id_cliente = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);

                if (optHotel.Checked == true)
                {
                    MessageBox.Show("Se ha confirmado tu Pre Reservacion de Vuelo con Hotel " + Login.nombreUsuario);
                   
                    //int cantidadActualHabitaciones = metodos.ConsultarCantidadHabitacionesHotel(metodos.ConsultarIDHotel(comboBoxHotelesPaisDestino.SelectedItem.ToString()));
                    //int cantidadRestar = Convert.ToInt16(spinnerCantidadHabitacionesHotel.Value);
                    //int resultadoResta = (cantidadActualHabitaciones - cantidadRestar);
                    //metodos.ActualizarCantidadHabitacionesHotel(resultadoResta, metodos.ConsultarIDHotel(comboBoxHotelesPaisDestino.SelectedItem.ToString()));
                }
                else if (optAutomovil.Checked == true)
                {
                    MessageBox.Show("Se ha confirmado tu Pre Reservacion de Vuelo con Automovil " + Login.nombreUsuario);
                   

                }
                else if (optTodosServicios.Checked == true)
                {
                    MessageBox.Show("Se ha confirmado tu Pre Reservacion de Vuelo con Automovil y  Hotel " + Login.nombreUsuario);
                }
                else
                {
                    MessageBox.Show("Se ha confirmado tu Pre Reservacion solo con el Vuelo Pasajeros " + spinnerCantidadPasajerosAdultos.Value.ToString() + " Psajeros Niños " + spinnerCantidadPasajerosNiños.Value.ToString());
                }
                metodos.InsertarDatosPreReservacionesVuelos(reservacionVuelo);


                dtgVistaPreliminarVHA.Rows.Clear();
                optPrecioMayorHotel.Enabled = false;
                optPrecioMenorHotel.Enabled = false;
                optTiempoCorto.Enabled = false;
                optTodosServicios.Enabled = false;
                optAutomovil.Enabled = false;
                optHotel.Enabled = false;
                fechaInicio.Enabled = false;
                fechaFinalizacion.Enabled = false;
                btnGuardarCantidadPasajeros.Enabled = false;
                spinnerCantidadPasajerosAdultos.Enabled = false;
                spinnerCantidadPasajerosNiños.Enabled = false;
                btnGuardarReservacion.Enabled = false;
                btnCofirmarReservacion.Enabled = false;
                dtgVistaPreliminarVHA.Enabled = false;
                panelAgregarAutomovil.Visible = false;
                panelAgregarHotel.Visible = false;
                labelNotificacionH.Visible = false;
                labelNotificacionV.Visible = false;
            }
            else
            {
                MessageBox.Show("Debe de Seleccionar Fechas Correctas");
            }
        }
    
        private void btnCofirmarReservacion1_Click(object sender, EventArgs e)
        {
            if (metodos.DiferenciaDiasFechas(fechaInicio.Text, fechaFinalizacion.Text) > 0) { 

                int cantidadDias =metodos.DiferenciaDiasFechas(fechaInicio.Text,fechaFinalizacion.Text);
                int idVueloDirecto = metodos.RetornarIDVueloDirecto(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
                reservacionVuelo.id_vuelo =idVueloDirecto;
                posicionDTGVuelos = dtgVistaPreliminarVHA.CurrentRow.Index;
                string paisOrigen = dtgVistaPreliminarVHA[0, posicionDTGVuelos].Value.ToString();
                string paisDestino = dtgVistaPreliminarVHA[1, posicionDTGVuelos].Value.ToString();
                double precioTotalHotel =(precioHotel*cantidadDias);
                double precioTotalVehiculo = (precioVehiculo * cantidadDias);
                int duracionTotal = Convert.ToInt16(dtgVistaPreliminarVHA[2, posicionDTGVuelos].Value);
                double precioTotal = Convert.ToDouble(dtgVistaPreliminarVHA[3, posicionDTGVuelos].Value) ;
                string vuelo_Escala = dtgVistaPreliminarVHA[4, posicionDTGVuelos].Value.ToString();             
                reservacionVuelo.pasajeros_adultos = Convert.ToInt16(spinnerCantidadPasajerosAdultos.Value);
                reservacionVuelo.pasajeros_niños = Convert.ToInt16(spinnerCantidadPasajerosNiños.Value);
                reservacionVuelo.habitaciones_hotel = Convert.ToInt16(spinnerCantidadHabitacionesHotel.Value);
                reservacionVuelo.pais_origen = paisOrigen;
                reservacionVuelo.pais_destino = paisDestino;
                reservacionVuelo.duracion_total = duracionTotal;
                reservacionVuelo.precio_total = (precioTotal + precioTotalHotel + precioTotalVehiculo);
                reservacionVuelo.vuelo_escala = vuelo_Escala;
                reservacionVuelo.fecha_inicio = fechaInicio.Text;
                reservacionVuelo.fecha_fin = fechaFinalizacion.Text;
                reservacionVuelo.id_cliente=conexion.ConsultarCedulaUsuario(Login.nombreUsuario);              

                if (optHotel.Checked == true)
                {
                    MessageBox.Show("Se ha confirmado tu Reservacion de Vuelo con Hotel " + Login.nombreUsuario);                   
              
                    int cantidadActualHabitaciones = metodos.ConsultarCantidadHabitacionesHotel(metodos.ConsultarIDHotel(comboBoxHotelesPaisDestino.SelectedItem.ToString()));
                    int cantidadRestar = Convert.ToInt16(spinnerCantidadHabitacionesHotel.Value);
                    int resultadoResta = (cantidadActualHabitaciones - cantidadRestar);
                    metodos.ActualizarCantidadHabitacionesHotel(resultadoResta, metodos.ConsultarIDHotel(comboBoxHotelesPaisDestino.SelectedItem.ToString()));
                }
                else if (optAutomovil.Checked == true)
                {
                    MessageBox.Show("Se ha confirmado tu Reservacion de Vuelo con Automovil " + Login.nombreUsuario);
                    

                }
                else if (optTodosServicios.Checked == true)
                {
                    MessageBox.Show("Se ha confirmado tu Reservacion de Vuelo con Automovil y  Hotel " + Login.nombreUsuario);
                }
                else
                {
                    MessageBox.Show("Se ha confirmado tu Reservacion solo con el Vuelo Pasajeros " + spinnerCantidadPasajerosAdultos.Value.ToString() + " Psajeros Niños " + spinnerCantidadPasajerosNiños.Value.ToString());
                }
                metodos.InsertarDatosReservacionesVuelos(reservacionVuelo);
              

                dtgVistaPreliminarVHA.Rows.Clear();
                optPrecioMayorHotel.Enabled = false;
                optPrecioMenorHotel.Enabled = false;
                optTiempoCorto.Enabled = false;
                optTodosServicios.Enabled = false;
                optAutomovil.Enabled = false;
                optHotel.Enabled = false;
                fechaInicio.Enabled = false;
                fechaFinalizacion.Enabled = false;
                btnGuardarCantidadPasajeros.Enabled = false;
                spinnerCantidadPasajerosAdultos.Enabled = false;
                spinnerCantidadPasajerosNiños.Enabled = false;
                btnGuardarReservacion.Enabled = false;
                btnCofirmarReservacion.Enabled = false;
                dtgVistaPreliminarVHA.Enabled = false;
                panelAgregarAutomovil.Visible = false;
                panelAgregarHotel.Visible = false;
                labelNotificacionH.Visible = false;
                labelNotificacionV.Visible = false;
            }
            else
            {
                MessageBox.Show("Debe de Seleccionar Fechas Correctas");
            }
        }

    }
}
