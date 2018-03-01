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
        Metodos_Usuarios metodos = new Metodos_Usuarios();

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
            labelCantidadDias2.Text+=cantidadDias.ToString();
        }


        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime f1 = DateTime.Parse(fechaLlegadaCiudad.Text);
            DateTime f2 = DateTime.Parse(FechaPartidaCiudad.Text);
            TimeSpan ts = f2 - f1;
            int cantidadDias = ts.Days;
             labelCntidadDias3.Text+=cantidadDias.ToString();
        }
   
        private void btnBuscarHotel_Click(object sender, EventArgs e)
        {
            ///se consulta los hoteles que esten en el pais en el que se
            ///desea hospedar el cliente
            ///
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
            labelCantidadDias4.Text += cantidadDias.ToString();
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

        private void labelHabitaciones_Click(object sender, EventArgs e)
        {

        }

        private void comboCiudadesCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarReservacionPais_Click(object sender, EventArgs e)
        {
            //Se debe mostrar nombre, foto, pais, lugar, cantidad de habitaciones en base
            //al pais en el que se desea alojar SELECT * FROM hoteles JOIN pais ON  hoteles.pais = pais.identificador
            MessageBox.Show("Se ha guardado este reservacion para " + Login.nombreUsuario);
        }

        private void btnVerListaPreeliminarHotelesPais_Click(object sender, EventArgs e)
        {
            ///se consulta los hoteles que esten en el pais en el que se
            ///desea hospedar el cliente
        }

        private void btnVerListaPreeliminarHotelesCiudad_Click(object sender, EventArgs e)
        {
            ///se consulta los hoteles que esten en el pais en el que se
            ///desea hospedar el cliente
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if ((spinnerPersonasMenoresPais.Value+spinnerPersonasAdultasPais.Value)>4) {

                MessageBox.Show("Una habitacion");
                spinnerHabitacionesPais.Value =1;
            }
        }

        private void spinnerPersonasAdultas_ValueChanged(object sender, EventArgs e)
        {
            if ((spinnerPersonasAdultasPais.Value + spinnerPersonasMenoresPais.Value) > 4)
            {

                MessageBox.Show("Una habitacion");
                spinnerHabitacionesPais.Value = 1;
            }
        }

        private void spinnerPersonasMenores_ValueChanged(object sender, EventArgs e)
        {
            if ((spinnerPersonasMenoresCiudad.Value + spinnerPersonasAdultosCiudad.Value) > 4)
            {

                MessageBox.Show("Una habitacion");
                spinnerHabitacionesCiudad.Value = 1;
            }
        }

        private void spinnerPersonasAdultosCiudad_ValueChanged(object sender, EventArgs e)
        {
            if ((spinnerPersonasAdultosCiudad.Value + spinnerPersonasMenoresCiudad.Value) > 4)
            {

                MessageBox.Show("Una habitacion");
                spinnerHabitacionesCiudad.Value = 1;
            }
        }

        private void Seccion_Alojamiento_Load(object sender, EventArgs e)
        {
            metodos.LlenarNombresPaises(comboPaises);
            metodos.LlenarNombresLugares(comboCiudades);
        }
    }
}
