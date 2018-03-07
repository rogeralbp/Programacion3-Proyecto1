using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Seccion_Vuelos : Form
    {
        Validaciones validar = new Validaciones();

        Metodos_Usuarios metodos = new Metodos_Usuarios();

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

        private void btnCofirmarReservacion1_Click(object sender, EventArgs e)
        {
            if (optHotel.Checked == true)
            {
                MessageBox.Show("Se ha confirmado tu Reservacion de Vuelo con Hotel " + Login.nombreUsuario);
            }
            else if (optAutomovil.Checked == true)
            {

                MessageBox.Show("Se ha confirmado tu Reservacion de Vuelo con Automovil " + Login.nombreUsuario);
            }
            else if (optTodosServicios.Checked==true)
            {

                MessageBox.Show("Se ha confirmado tu Reservacion de Vuelo con Automovil y  Hotel " + Login.nombreUsuario);
            }
            else {

                MessageBox.Show("Se ha confirmado tu Reservacion solo con el Vuelo Pasajeros "+spinnerCantidadPasajerosAdultos.Value.ToString()+" Psajeros Niños "+spinnerCantidadPasajerosNiños.Value.ToString());
            }
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
            metodos.LlenarHotelesPaisDestino(comboBoxHotelesPaisDestino, comboBoxPaisDestino.SelectedItem.ToString());
        }

        private void comboBoxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodos.MostrarInformacionVehiculos(comboBoxVehiculos, textBoxMarcaVehiculo, textBoxModeloVehiculo, textBoxTipoVehiculo, textBoxPrecioVehiculo);
        }

        private void btnVerListaPreeliminarHotelesVuelos_Click(object sender, EventArgs e)
        {
            if (metodos.BanderaRutaSinEscala(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString()))
            {
                MessageBox.Show("SI existe en Vuelo DIRECTO");
                optPrecioMenorHotel.Checked = true;
                 metodos.LlenarDtVistaPreliminarVuelosASC(dtgVistaPreliminarVHA,comboBoxPaisOrigen.SelectedItem.ToString(),comboBoxPaisDestino.SelectedItem.ToString());
                //int idVueloDirecto = metodos.RetornarIDVueloDirecto(comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
                //if (idVueloDirecto != 0)
                //{
                //    int duracion = metodos.RetornarDuracionTotalVueloDirecto(idVueloDirecto);
                //    double precio = metodos.RetornarPrecioTotalVueloDirecto(idVueloDirecto);
                //    dtgVistaPreliminarVHA.Rows.Add("Vuelo Directo");
                //}

            }
            else {
                MessageBox.Show("NO existe este Vuelo DIRECTO, Existen pero con Escalas.");

            }
        }

        private void spinnerCantidadPasajerosAdultos_ValueChanged(object sender, EventArgs e)
        {
            btnGuardarCantidadPasajeros.Visible = true;
        }

        private void optPrecioMenorHotel_CheckedChanged(object sender, EventArgs e)
        {
            metodos.LlenarDtVistaPreliminarVuelosASC(dtgVistaPreliminarVHA, comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
        }

        private void optPrecioMayorHotel_CheckedChanged(object sender, EventArgs e)
        {
            metodos.LlenarDtVistaPreliminarVuelosDESC(dtgVistaPreliminarVHA, comboBoxPaisOrigen.SelectedItem.ToString(), comboBoxPaisDestino.SelectedItem.ToString());
        }

        private void comboBoxHotelesPasDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodos.RetornarPrecioHabitacionesHotel(comboBoxHotelesPaisDestino, txtPrecioHabitacion);
        }
    }
}
