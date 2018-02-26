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
   
        public Seccion_Vuelos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Seccion_Vuelos_Load(object sender, EventArgs e)
        {
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
            DateTime f1 = DateTime.Parse(fechaInicio.Text);
            DateTime f2 = DateTime.Parse(fechaFinalizacion.Text);
            TimeSpan ts = f2 - f1;
            int cantidadDias = ts.Days;
            labelCantidadDias.Text += cantidadDias.ToString();
        }

        private void spinnerCantidadPasajerosNiños_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
