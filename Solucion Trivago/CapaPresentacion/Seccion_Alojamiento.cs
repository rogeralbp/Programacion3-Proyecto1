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
    public partial class Seccion_Alojamiento : Form
    {
        Validaciones validaciones = new Validaciones();

        public Seccion_Alojamiento()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Usuarios v = new Menu_Principal_Usuarios();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Usuarios v = new Menu_Principal_Usuarios();
            v.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Usuarios v = new Menu_Principal_Usuarios();
            v.Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime f1 = DateTime.Parse(fechaLlegadaPais.Text);
            DateTime f2 = DateTime.Parse(fechaPartidaPais.Text);
            TimeSpan ts = f2 - f1;
            int cantidadDias = ts.Days;
            labelCantidadDias.Text ="Cantidad de dias "+cantidadDias.ToString();
        }


        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime f1 = DateTime.Parse(fechaLlegadaCiudad.Text);
            DateTime f2 = DateTime.Parse(FechaPartidaCiudad.Text);
            TimeSpan ts = f2 - f1;
            int cantidadDias = ts.Days;
            labelCantidadDiasLugar.Text = "Cantidad de dias " + cantidadDias.ToString();
        }
   
        private void btnBuscarHotel_Click(object sender, EventArgs e)
        {
            panelDatosHotel.Visible = true;
            labelFechaLlegadaHotel.Visible = true;
            labelFechaSalidaHotel.Visible = true;
            fechaLlegadaHotel.Visible = true;
            fechaPartidaHotel.Visible = true;
        }

        private void fechaSalidaHotel_ValueChanged(object sender, EventArgs e)
        {
            DateTime f1 = DateTime.Parse(fechaLlegadaHotel.Text);
            DateTime f2 = DateTime.Parse(fechaPartidaHotel.Text);
            TimeSpan ts = f2 - f1;
            int cantidadDias = ts.Days;
            labelCantidadDiasHotel.Text = "  Cantidad de dias " + cantidadDias.ToString();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            labelHabitaciones.Visible = true;
            spinnerHabitacionesPais.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panelAdultosNiñosPais.Visible = true;
        }

        private void btnHabitacionesHotel_Click(object sender, EventArgs e)
        {
            labelHabitacionesH.Visible = true;
            spinnerHabitacionesHotel.Visible = true;
        }

        private void btnPersonasHotel_Click(object sender, EventArgs e)
        {
            panelPersonasHotel.Visible = true;
        }

        private void btnHabitacionesCiudad_Click(object sender, EventArgs e)
        {
            laberlHabitacionesCiudad.Visible = true;
            spinnerHabitacionesCiudad.Visible = true;
        }

        private void btnPersonasCiudad_Click(object sender, EventArgs e)
        {
            panelPersonasCiudad.Visible = true;
        }

        private void spinnerHabitacionesPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);
        }

        private void numericUpDown8_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void fechaLlegadaPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void fechaPartidaPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void fechaLlegadaCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void FechaPartidaCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void spinnerHabitacionesCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void numericUpDown3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void numericUpDown4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void fechaLlegadaHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void fechaPartidaHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void spinnerHabitacionesHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void numericUpDown5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void numericUpDown6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloLetras(e);

        }

        private void btnConfirmarReservacionPais_Click(object sender, EventArgs e)
        {
            ///Hago la reservacion en la tabla 
            ///reservaciones hoteles y luego pido la calificacion del cliente
            /// ------------------------------------------------
            ///Falta realizar la calificacion que el cliente le da al Hotel 
            ///
            MessageBox.Show("Has reservado un hotel "+Login.nombreUsuario+ "con "+spinnerHabitacionesPais.GetType());        }

        private void btnConfirmarReservacionCiudad_Click(object sender, EventArgs e)
        {
            ///Hago la reservacion en la tabla 
            ///reservaciones hoteles y luego pido la calificacion del cliente
            /// ------------------------------------------------
            ///Falta realizar la calificacion que el cliente le da al Hotel 
            ///
        }

        private void btnConfirmarReservacionHotel_Click(object sender, EventArgs e)
        {
            ///Hago la reservacion en la tabla 
            ///reservaciones hoteles y luego pido la calificacion del cliente
            /// ------------------------------------------------
            ///Falta realizar la calificacion que el cliente le da al Hotel 
            ///
        }
    }
}
