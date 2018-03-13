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
using CapaDatos;
using System.Collections;

namespace CapaPresentacion
{
    public partial class Seccion_Alojamiento : Form
    {
        Validaciones validaciones = new Validaciones();

        Metodos_Usuarios metodos = new Metodos_Usuarios();

        Conexiones_Base_Datos conexion = new Conexiones_Base_Datos();

        int cantidadDiasHotelPais;
        int cantidadDiasHotelCiudad;
        int posicionDTGHotelPais;
        int cantidadDiasHotel;
        int posicionDTGHotelCiudad;
        int posicionDTGHotel;

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
            if (metodos.DiferenciaDiasFechas(fechaLlegadaPais.Text, fechaPartidaPais.Text) > 0)
            {
                labelCantidadDias2.Text = "Cantidad de dias " + metodos.DiferenciaDiasFechas(fechaLlegadaPais.Text, fechaPartidaPais.Text).ToString();
            }
            else {

                MessageBox.Show("Debe de Seleccionnar Fechas Validas");

            }
        }


        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            if (metodos.DiferenciaDiasFechas(fechaLlegadaCiudad.Text, FechaPartidaCiudad.Text) > 0)
            {
                labelCntidadDias3.Text = "Cantidad de dias " + metodos.DiferenciaDiasFechas(fechaLlegadaCiudad.Text, FechaPartidaCiudad.Text).ToString();
            }
            else
            {
                MessageBox.Show("Debe de Seleccionnar Fechas Validas");
            }
        }

        private void btnBuscarHotel_Click(object sender, EventArgs e)
        {
            ///se consulta los hoteles que esten en el pais en el que se
            ///desea hospedar el cliente
            ///

            if (metodos.BanderaHotel(txtNombreHotelBuscar.Text))
            {

                labelFechaLlegadaHotel.Visible = true;
                labelFechaSalidaHotel.Visible = true;
                fechaLlegadaHotel.Enabled = true;
                fechaPartidaHotel.Enabled = true;
                btnPersonasHotel.Visible = true;
                btnHabitacionesHotel.Visible = true;
                metodos.LlenarDtVistaPreliminarBusquedaHotel(dtgResultadosBusquedad, txtNombreHotelBuscar.Text);
                btnConfirmarReservacionHotel.Enabled = true;
                btnGuardarReservacionHotel.Enabled = true;
            }
            else {
                dtgResultadosBusquedad.DataSource = null;
                MessageBox.Show("No existen Hoteles con ese nombre.");
                labelFechaLlegadaHotel.Visible =false;
                labelFechaSalidaHotel.Visible = false;
                fechaLlegadaHotel.Enabled = false;
                fechaPartidaHotel.Enabled = false;
                btnPersonasHotel.Visible = false;
                btnHabitacionesHotel.Visible = false;
                btnConfirmarReservacionHotel.Enabled = false;
            }
        }

        private void fechaSalidaHotel_ValueChanged(object sender, EventArgs e)
        {
            if (metodos.DiferenciaDiasFechas(fechaLlegadaHotel.Text, fechaPartidaHotel.Text) > 0)
            {
                labelCantidadDias4.Text = "Cantidad de dias " + metodos.DiferenciaDiasFechas(fechaLlegadaHotel.Text, fechaPartidaHotel.Text).ToString();
            }
            else
            {
                MessageBox.Show("Debe de Seleccionnar Fechas Validas");
            }
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            labelHabitaciones.Visible = true;
            spinnerHabitacionesPais.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panelAdultosNiñosPais.Visible = true;
            btnGuardarCantidadPersonasPais.Visible = true;
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
            posicionDTGHotelPais = dtgHotelesPaises.CurrentRow.Index;
            int idHotelPais=Convert.ToInt16(dtgHotelesPaises[0, posicionDTGHotelPais].Value.ToString());
            string nombreHotelPais = dtgHotelesPaises[1, posicionDTGHotelPais].Value.ToString();
            int cedulaUsuario = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);

            double precioTotalHospedajeHotelPais = ((Convert.ToDouble(dtgHotelesPaises[4, posicionDTGHotelPais].Value.ToString()))*cantidadDiasHotelPais);
            if (metodos.DiferenciaDiasFechas(fechaLlegadaPais.Text, fechaPartidaPais.Text) > 0)
            {
                metodos.InsertarDatosReservacionHotel(idHotelPais, fechaLlegadaPais.Text, fechaPartidaPais.Text, Convert.ToInt16(spinnerHabitacionesPais.Value), Convert.ToInt16(spinnerPersonasAdultasPais.Value + spinnerPersonasMenoresPais.Value), cedulaUsuario, Convert.ToInt16(spinnerPersonasAdultasPais.Value), Convert.ToInt16(spinnerPersonasMenoresPais.Value), precioTotalHospedajeHotelPais);
     
                //SECCION DE CALIFICACION DEL HOTEL
                DialogResult opcion;
                opcion= MessageBox.Show("La Reservacion se Logro con Exito.\nDesea Calificar el Hotel?","Confirmacion de Reservacion",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int calificacionHotelPais = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Digite la Calificacion para el Hotel : "+nombreHotelPais+", en escala de 1 a 10.","Calificacion Hoteles","1",100,100));
                    metodos.InsertarDatosCalifacionHoteles(idHotelPais,calificacionHotelPais);
                }
                int cantidadActualHabitaciones = Convert.ToInt16(dtgHotelesPaises[3, posicionDTGHotelPais].Value.ToString());
                int cantidadRestar = Convert.ToInt16(spinnerHabitacionesPais.Value);
                int resultadoResta =(cantidadActualHabitaciones-cantidadRestar);
                metodos.ActualizarCantidadHabitacionesHotel(resultadoResta,idHotelPais);
                dtgHotelesPaises.DataSource = null;
                btnVerListaPreeliminarHotelesPais.Enabled = false;
                fechaLlegadaPais.Enabled = false;
                fechaPartidaPais.Enabled = false;
                btnPersonasPais.Enabled = false;
                btnHabitacionesPais.Visible = false;
                optPrecioMayorPais.Visible = false;
                optPrecioMenorPais.Visible = false;
                panelAdultosNiñosPais.Visible = false;
                labelHabitaciones.Visible = false;
                spinnerHabitacionesPais.Visible = false;
                btnGuardarCantidadPersonasPais.Visible = false;
                comboPaises.Items.Clear();
                
            }
            else
            {
                MessageBox.Show("Debe de Seleccionar Fechas Correctas.");
            }

            /// ------------------------------------------------
            ///Falta realizar la calificacion que el cliente le da al Hotel 
            ///
            
        }

        private void btnConfirmarReservacionCiudad_Click(object sender, EventArgs e)
        {
            ///Hago la reservacion en la tabla 
            ///reservaciones hoteles y luego pido la calificacion del cliente
            posicionDTGHotelCiudad = dtgHotelesCiudades.CurrentRow.Index;
            int idHotelCiudad = Convert.ToInt16(dtgHotelesCiudades[0, posicionDTGHotelCiudad].Value.ToString());
            string nombreHotelCiudad = dtgHotelesCiudades[1, posicionDTGHotelCiudad].Value.ToString();
            int cedulaUsuario = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);
            double precioTotalHospedajeHotelCiudad = ((Convert.ToDouble(dtgHotelesCiudades[3, posicionDTGHotelCiudad].Value.ToString())) * cantidadDiasHotelCiudad);
            //metodos.InsertarDatosReservacionHotel(idHotelPais, fechaLlegadaPais.Text, fechaPartidaPais.Text, Convert.ToInt16(spinnerHabitacionesPais.Value), Convert.ToInt16(spinnerPersonasAdultasPais.Value + spinnerPersonasMenoresPais.Value), cedulaUsuario, Convert.ToInt16(spinnerPersonasAdultasPais.Value), Convert.ToInt16(spinnerPersonasMenoresPais.Value), precioTotalHospedajeHotelPais);

            if (metodos.DiferenciaDiasFechas(fechaLlegadaCiudad.Text, FechaPartidaCiudad.Text) > 0)
            {
                metodos.InsertarDatosReservacionHotel(idHotelCiudad, fechaLlegadaCiudad.Text, FechaPartidaCiudad.Text, Convert.ToInt16(spinnerHabitacionesCiudad.Value), Convert.ToInt16(spinnerPersonasAdultosCiudad.Value + spinnerPersonasMenoresCiudad.Value), cedulaUsuario, Convert.ToInt16(spinnerPersonasAdultosCiudad.Value), Convert.ToInt16(spinnerPersonasMenoresCiudad.Value), precioTotalHospedajeHotelCiudad);
                //SECCION DE CALIFICACION DEL HOTEL
                DialogResult opcion;
                opcion = MessageBox.Show("La Reservacion se Logro con Exito.\nDesea Calificar el Hotel?", "Confirmacion de Reservacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int calificacionHotelCiudad = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Digite la Calificacion para el Hotel : " + nombreHotelCiudad + ", en escala de 1 a 10.", "Calificacion Hoteles", "1", 100, 100));
                    metodos.InsertarDatosCalifacionHoteles(idHotelCiudad, calificacionHotelCiudad);
                }
                int cantidadActualHabitaciones = Convert.ToInt16(dtgHotelesCiudades[2, posicionDTGHotelCiudad].Value.ToString());
                int cantidadRestar = Convert.ToInt16(spinnerHabitacionesCiudad.Value);
                int resultadoResta = (cantidadActualHabitaciones - cantidadRestar);
                metodos.ActualizarCantidadHabitacionesHotel(resultadoResta, idHotelCiudad);
                dtgHotelesCiudades.DataSource = null;
                btnHabitacionesCiudad.Enabled = false;
                btnPersonasCiudad.Enabled = false;
                fechaLlegadaCiudad.Enabled = false;
                FechaPartidaCiudad.Enabled = false;
                panelAdultosNiñosPais.Visible = false;
                labelHabitaciones.Visible = false;
                spinnerHabitacionesPais.Visible = false;
                btnGuardarCantidadPersonasPais.Visible = false;
                comboCiudades.Items.Clear();
            }
            else {
                MessageBox.Show("Debe de Ingresar fechas correctas");
            }
            
            /// ------------------------------------------------
            ///Falta realizar la calificacion que el cliente le da al Hotel 
            ///


        }

        private void btnConfirmarReservacionHotel_Click(object sender, EventArgs e)
        {
            ///Hago la reservacion en la tabla 
            ///reservaciones hoteles y luego pido la calificacion del cliente

            posicionDTGHotel = dtgResultadosBusquedad.CurrentRow.Index;
            int idHotel = Convert.ToInt16(dtgResultadosBusquedad[0, posicionDTGHotel].Value.ToString());
            string nombreHotel= dtgResultadosBusquedad[1, posicionDTGHotel].Value.ToString();
            int cedulaUsuario = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);
            double precioTotalHospedajeHotel = ((Convert.ToDouble(dtgResultadosBusquedad[5, posicionDTGHotel].Value.ToString())) * cantidadDiasHotel);
            if (metodos.DiferenciaDiasFechas(fechaLlegadaHotel.Text, fechaPartidaHotel.Text) > 0)
            {
                metodos.InsertarDatosReservacionHotel(idHotel, fechaLlegadaHotel.Text, fechaPartidaHotel.Text, Convert.ToInt16(spinnerHabitacionesHotel.Value), Convert.ToInt16(spinnerPersonasAdultosHotel.Value + spinnerPersonasMenoresHotel.Value), cedulaUsuario, Convert.ToInt16(spinnerPersonasAdultosHotel.Value), Convert.ToInt16(spinnerPersonasMenoresHotel.Value), precioTotalHospedajeHotel);
                DialogResult opcion;
                opcion = MessageBox.Show("La Reservacion se Logro con Exito.\nDesea Calificar el Hotel?", "Confirmacion de Reservacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int calificacionHotel = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Digite la Calificacion para el Hotel : " + nombreHotel + ", en escala de 1 a 10.", "Calificacion Hoteles", "1", 100, 100));
                    metodos.InsertarDatosCalifacionHoteles(idHotel, calificacionHotel);
                }
                int cantidadActualHabitaciones = Convert.ToInt16(dtgResultadosBusquedad[4, posicionDTGHotel].Value.ToString());
                int cantidadRestar = Convert.ToInt16(spinnerHabitacionesHotel.Value);
                int resultadoResta = (cantidadActualHabitaciones - cantidadRestar);
                metodos.ActualizarCantidadHabitacionesHotel(resultadoResta, idHotel);
                dtgResultadosBusquedad.DataSource = null;
                labelFechaLlegadaHotel.Visible = false;
                labelFechaSalidaHotel.Visible = false;
                fechaLlegadaHotel.Enabled = false;
                fechaPartidaHotel.Enabled = false;
                btnPersonasHotel.Visible = false;
                btnHabitacionesHotel.Visible = false;
                btnConfirmarReservacionHotel.Enabled = false;
                btnGuardarReservacionHotel.Enabled = false;
            }
            else {

                MessageBox.Show("Debe de Ingresar Fechas Correctas");
            }
            /// ------------------------------------------------
            ///Falta realizar la calificacion que el cliente le da al Hotel 
            ///
        }

        private void labelHabitaciones_Click(object sender, EventArgs e)
        {

        }

        private void comboCiudadesCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVerListaPreeliminarHotelesCiudad.Enabled = true;
            btnHabitacionesCiudad.Enabled = true;
            btnPersonasCiudad.Enabled = true;
            fechaLlegadaCiudad.Enabled = true;
            FechaPartidaCiudad.Enabled = true;
            optPrecioMayorCiudad.Enabled = true;
            optPrecioMenorCiudad.Enabled = true;
            btnGuardarReservacionCiudad.Enabled = true;
            btnConfirmarReservacionCiudad.Enabled = true;
        }

        private void btnGuardarReservacionPais_Click(object sender, EventArgs e)
        {
            //Se debe mostrar nombre, foto, pais, lugar, cantidad de habitaciones en base
            //al pais en el que se desea alojar SELECT * FROM hoteles JOIN pais ON  hoteles.pais = pais.identificador
            posicionDTGHotelPais = dtgHotelesPaises.CurrentRow.Index;
            int idHotel = Convert.ToInt16(dtgHotelesPaises[0, posicionDTGHotelPais].Value.ToString());
            string nombreH = dtgHotelesPaises[1, posicionDTGHotelPais].Value.ToString();
            int cedulaUsuario = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);

            double precioTotalHospedajeHotelPais = ((Convert.ToDouble(dtgHotelesPaises[4, posicionDTGHotelPais].Value.ToString())) * cantidadDiasHotelPais);
            if (metodos.DiferenciaDiasFechas(fechaLlegadaPais.Text, fechaPartidaPais.Text) > 0)
            {
                metodos.InsertarDatosPreReservacionHotel(idHotel, fechaLlegadaPais.Text, fechaPartidaPais.Text, Convert.ToInt16(spinnerHabitacionesPais.Value), Convert.ToInt16(spinnerPersonasAdultasPais.Value + spinnerPersonasMenoresPais.Value), cedulaUsuario, Convert.ToInt16(spinnerPersonasAdultasPais.Value), Convert.ToInt16(spinnerPersonasMenoresPais.Value), precioTotalHospedajeHotelPais);
                MessageBox.Show("La Pre Reservacion se Logro con Exito.");
                dtgHotelesPaises.DataSource = null;
                btnVerListaPreeliminarHotelesPais.Enabled = false;
                fechaLlegadaPais.Enabled = false;
                fechaPartidaPais.Enabled = false;
                btnPersonasPais.Enabled = false;
                btnHabitacionesPais.Visible = false;
                optPrecioMayorPais.Visible = false;
                optPrecioMenorPais.Visible = false;
                panelAdultosNiñosPais.Visible = false;
                labelHabitaciones.Visible = false;
                spinnerHabitacionesPais.Visible = false;
                btnGuardarCantidadPersonasPais.Visible = false;
                comboPaises.Items.Clear();

            }
            else
            {

                MessageBox.Show("Debe de Seleccionar Fechas Correctas.");
            }
        }

            private void btnVerListaPreeliminarHotelesPais_Click(object sender, EventArgs e)
        {
            ///se consulta los hoteles que esten en el pais en el que se
            ///desea hospedar el cliente
            optPrecioMayorPais.Enabled = true;
            optPrecioMenorPais.Enabled = true;
            optPrecioMenorPais.Checked = true;
            dtgHotelesPaises.DataSource = null;
            metodos.LlenarDtVistaPreliminarHotelsPaisASC(dtgHotelesPaises, comboPaises.SelectedItem.ToString());

            //ArrayList lista = new ArrayList();
            //lista = metodos.CargarFotosHotelesPaisASC(comboPaises.SelectedItem.ToString());
            //Image fotoHP;
            //for (int i = 0; i < dtgHotelesPaises.RowCount; i++)
            //{
            //    fotoHP = Image.FromFile(lista[i].ToString());
            //    dtgHotelesPaises.Rows[i].Cells["Foto_Hotel"].Value = fotoHP;
            //}
        }

        private void btnVerListaPreeliminarHotelesCiudad_Click(object sender, EventArgs e)
        {
            ///se consulta los hoteles que esten en el pais en el que se
            ///desea hospedar el cliente
            optPrecioMenorCiudad.Checked = true;
            metodos.LlenarDtVistaPreliminarHotelsCiudadASC(dtgHotelesCiudades, comboCiudades.SelectedItem.ToString());
    
        }


        private void spinnerPersonasAdultosCiudad_ValueChanged(object sender, EventArgs e)
        {
            btnGuardarCantidadPersonsCiudad.Visible = true;
        }

        private void Seccion_Alojamiento_Load(object sender, EventArgs e)
        {
            metodos.LlenarNombresPaises(comboPaises);
            metodos.LlenarNombresLugares(comboCiudades);
        }

        private void comboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVerListaPreeliminarHotelesPais.Enabled = true;
            fechaLlegadaPais.Enabled = true;
            fechaPartidaPais.Enabled = true;
            btnPersonasPais.Enabled = true;
            btnHabitacionesPais.Enabled = true;
            optPrecioMenorPais.Enabled = true;
            optPrecioMayorPais.Enabled = true;
            optPrecioMayorPais.Visible = true;
            optPrecioMenorPais.Visible = true;
            btnConfirmarReservacionPais.Enabled = true;
            btnGuardarReservacionPais.Enabled = true;
        }

        private void optPrecioMayorPais_Click(object sender, EventArgs e)
        {
            metodos.LlenarDtVistaPreliminarHotelsPaisDESC(dtgHotelesPaises, comboPaises.SelectedItem.ToString());

        }

        private void optPrecioMenorPais_Click(object sender, EventArgs e)
        {
            metodos.LlenarDtVistaPreliminarHotelsPaisASC(dtgHotelesPaises, comboPaises.SelectedItem.ToString());

        }

        private void btnGuardarCantidadPersonasPais_Click(object sender, EventArgs e)
        {
            int cantidadTotalPersonasPais = Convert.ToInt16(spinnerPersonasAdultasPais.Value + spinnerPersonasMenoresPais.Value);
            
            if (cantidadTotalPersonasPais <= 4)
            {

                MessageBox.Show("Una habitacion");
                spinnerHabitacionesPais.Value = 1;
            }
            if ((cantidadTotalPersonasPais > 4) && (cantidadTotalPersonasPais <= 8))
            {
                MessageBox.Show("Dos habitaciones");
                spinnerHabitacionesPais.Value = 2;
            }
            if ((cantidadTotalPersonasPais > 8) && (cantidadTotalPersonasPais <= 12))
            {
                MessageBox.Show("Tres habitaciones");
                spinnerHabitacionesPais.Value = 3;
            }
            if ((cantidadTotalPersonasPais > 12) && (cantidadTotalPersonasPais <= 16))
            {
                MessageBox.Show("Cuatro habitaciones");
                spinnerHabitacionesPais.Value = 4;
            }
            if ((cantidadTotalPersonasPais > 16) && (cantidadTotalPersonasPais <= 20))
            {

                MessageBox.Show("Cinco habitaciones");
                spinnerHabitacionesPais.Value = 5;
            }
            if ((cantidadTotalPersonasPais > 20) && (cantidadTotalPersonasPais <= 24))
            {

                MessageBox.Show("Seis habitaciones");
                spinnerHabitacionesPais.Value = 6;
            }
            if ((cantidadTotalPersonasPais > 24) && (cantidadTotalPersonasPais <= 28))
            {

                MessageBox.Show("Siete habitaciones");
                spinnerHabitacionesPais.Value = 7;
            }
            if ((cantidadTotalPersonasPais > 28) && (cantidadTotalPersonasPais <= 32))
            {

                MessageBox.Show("Ocho habitaciones");
                spinnerHabitacionesPais.Value = 8;
            }
            if ((cantidadTotalPersonasPais > 32) && (cantidadTotalPersonasPais <= 36))
            {

                MessageBox.Show("Nueve habitaciones");
                spinnerHabitacionesPais.Value = 9;
            }
            if ((cantidadTotalPersonasPais > 36) && (cantidadTotalPersonasPais <= 40))
            {

                MessageBox.Show("Diez habitaciones");
                spinnerHabitacionesPais.Value = 10;
            }
            if (cantidadTotalPersonasPais > 40)
            {
                MessageBox.Show("Cantidad de Personas Inexsistente");
            }
            //if (spinnerHabitacionesPais.Value == 1) {

            //    spinnerPersonasAdultasPais.Value=2;
            //    spinnerPersonasMenoresPais.Value=2;
            //}
            //if (spinnerHabitacionesPais.Value == 2)
            //{

            //    spinnerPersonasAdultasPais.Value = 4;
            //    spinnerPersonasMenoresPais.Value = 4;
            //}
            //if (spinnerHabitacionesPais.Value == 3)
            //{

            //    spinnerPersonasAdultasPais.Value = 6;
            //    spinnerPersonasMenoresPais.Value = 6;
            //}
            //if (spinnerHabitacionesPais.Value == 4)
            //{

            //    spinnerPersonasAdultasPais.Value = 8;
            //    spinnerPersonasMenoresPais.Value = 8;
            //}
            //if (spinnerHabitacionesPais.Value == 5)
            //{

            //    spinnerPersonasAdultasPais.Value = 10;
            //    spinnerPersonasMenoresPais.Value = 10;
            //}
            //if (spinnerHabitacionesPais.Value == 6)
            //{

            //    spinnerPersonasAdultasPais.Value = 12;
            //    spinnerPersonasMenoresPais.Value = 12;
            //}
            //if (spinnerHabitacionesPais.Value == 7)
            //{

            //    spinnerPersonasAdultasPais.Value = 14;
            //    spinnerPersonasMenoresPais.Value = 14;
            //}
        }

        private void btnGuardarCantidadPersonsCiudad_Click(object sender, EventArgs e)
        {
            int cantidadTotalPersonasCiudad = Convert.ToInt16(spinnerPersonasAdultosCiudad.Value + spinnerPersonasMenoresCiudad.Value);


            if (cantidadTotalPersonasCiudad <= 4)
            {

                MessageBox.Show("Una habitacion");
                spinnerHabitacionesCiudad.Value = 1;
            }
            if ((cantidadTotalPersonasCiudad > 4) && (cantidadTotalPersonasCiudad <= 8))
            {
                MessageBox.Show("Dos habitaciones");
                spinnerHabitacionesCiudad.Value = 2;
            }
            if ((cantidadTotalPersonasCiudad > 8) && (cantidadTotalPersonasCiudad <= 12))
            {
                MessageBox.Show("Tres habitaciones");
                spinnerHabitacionesCiudad.Value = 3;
            }
            if ((cantidadTotalPersonasCiudad > 12) && (cantidadTotalPersonasCiudad <= 16))
            {
                MessageBox.Show("Cuatro habitaciones");
                spinnerHabitacionesCiudad.Value = 4;
            }
            if ((cantidadTotalPersonasCiudad > 16) && (cantidadTotalPersonasCiudad <= 20))
            {

                MessageBox.Show("Cinco habitaciones");
                spinnerHabitacionesCiudad.Value = 5;
            }
            if ((cantidadTotalPersonasCiudad > 20) && (cantidadTotalPersonasCiudad <= 24))
            {

                MessageBox.Show("Seis habitaciones");
                spinnerHabitacionesCiudad.Value = 6;
            }
            if ((cantidadTotalPersonasCiudad > 24) && (cantidadTotalPersonasCiudad <= 28))
            {

                MessageBox.Show("Siete habitaciones");
                spinnerHabitacionesCiudad.Value = 7;
            }
            if ((cantidadTotalPersonasCiudad > 28) && (cantidadTotalPersonasCiudad <= 32))
            {

                MessageBox.Show("Ocho habitaciones");
                spinnerHabitacionesCiudad.Value = 8;
            }
            if ((cantidadTotalPersonasCiudad > 32) && (cantidadTotalPersonasCiudad <= 36))
            {

                MessageBox.Show("Nueve habitaciones");
                spinnerHabitacionesCiudad.Value = 9;
            }
            if ((cantidadTotalPersonasCiudad > 36) && (cantidadTotalPersonasCiudad <= 40))
            {

                MessageBox.Show("Diez habitaciones");
                spinnerHabitacionesCiudad.Value = 10;
            }
            if (cantidadTotalPersonasCiudad > 40)
            {
                MessageBox.Show("Cantidad de Personas Inexsistente");
            }
        }

        private void optPrecioMayorCiudad_CheckedChanged(object sender, EventArgs e)
        {
            metodos.LlenarDtVistaPreliminarHotelsCiudadDESC(dtgHotelesCiudades, comboCiudades.SelectedItem.ToString());
        }

        private void optPrecioMenorCiudad_CheckedChanged(object sender, EventArgs e)
        {
            metodos.LlenarDtVistaPreliminarHotelsCiudadASC(dtgHotelesCiudades, comboCiudades.SelectedItem.ToString());
        }

        private void btnGuardarCantidadPersonasHotel_Click(object sender, EventArgs e)
        {
            int cantidadTotalPersonasHotel = Convert.ToInt16(spinnerPersonasAdultosHotel.Value + spinnerPersonasMenoresHotel.Value);


            if (cantidadTotalPersonasHotel <= 4)
            {

                MessageBox.Show("Una habitacion");
                spinnerHabitacionesHotel.Value = 1;
            }
            if ((cantidadTotalPersonasHotel > 4) && (cantidadTotalPersonasHotel <= 8))
            {
                MessageBox.Show("Dos habitaciones");
                spinnerHabitacionesHotel.Value = 2;
            }
            if ((cantidadTotalPersonasHotel > 8) && (cantidadTotalPersonasHotel <= 12))
            {
                MessageBox.Show("Tres habitaciones");
                spinnerHabitacionesHotel.Value = 3;
            }
            if ((cantidadTotalPersonasHotel > 12) && (cantidadTotalPersonasHotel <= 16))
            {
                MessageBox.Show("Cuatro habitaciones");
                spinnerHabitacionesHotel.Value = 4;
            }
            if ((cantidadTotalPersonasHotel > 16) && (cantidadTotalPersonasHotel <= 20))
            {

                MessageBox.Show("Cinco habitaciones");
                spinnerHabitacionesHotel.Value = 5;
            }
            if ((cantidadTotalPersonasHotel > 20) && (cantidadTotalPersonasHotel <= 24))
            {

                MessageBox.Show("Seis habitaciones");
                spinnerHabitacionesHotel.Value = 6;
            }
            if ((cantidadTotalPersonasHotel > 24) && (cantidadTotalPersonasHotel <= 28))
            {

                MessageBox.Show("Siete habitaciones");
                spinnerHabitacionesHotel.Value = 7;
            }
            if ((cantidadTotalPersonasHotel > 28) && (cantidadTotalPersonasHotel <= 32))
            {

                MessageBox.Show("Ocho habitaciones");
                spinnerHabitacionesHotel.Value = 8;
            }
            if ((cantidadTotalPersonasHotel > 32) && (cantidadTotalPersonasHotel <= 36))
            {

                MessageBox.Show("Nueve habitaciones");
                spinnerHabitacionesHotel.Value = 9;
            }
            if ((cantidadTotalPersonasHotel > 36) && (cantidadTotalPersonasHotel <= 40))
            {

                MessageBox.Show("Diez habitaciones");
                spinnerHabitacionesHotel.Value = 10;
            }
            if (cantidadTotalPersonasHotel > 40)
            {
                MessageBox.Show("Cantidad de Personas Inexsistente");
            }
        }

        private void spinnerPersonasAdultosHotel_ValueChanged(object sender, EventArgs e)
        {
            btnGuardarCantidadPersonasHotel.Visible = true;
        }

        private void btnGuardarReservacionCiudad_Click(object sender, EventArgs e)
        {
            ///Hago la reservacion en la tabla 
            ///reservaciones hoteles y luego pido la calificacion del cliente
            posicionDTGHotelCiudad = dtgHotelesCiudades.CurrentRow.Index;
            int idHotelCiudad = Convert.ToInt16(dtgHotelesCiudades[0, posicionDTGHotelCiudad].Value.ToString());
            string nombreHotelCiudad = dtgHotelesCiudades[1, posicionDTGHotelCiudad].Value.ToString();
            int cedulaUsuario = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);
            double precioTotalHospedajeHotel = ((Convert.ToDouble(dtgResultadosBusquedad[5, posicionDTGHotel].Value.ToString())) * cantidadDiasHotel);
            if (metodos.DiferenciaDiasFechas(fechaLlegadaCiudad.Text, FechaPartidaCiudad.Text) > 0)
            {
                metodos.InsertarDatosPreReservacionHotel(idHotelCiudad, fechaLlegadaCiudad.Text, FechaPartidaCiudad.Text, Convert.ToInt16(spinnerHabitacionesCiudad.Value), Convert.ToInt16(spinnerPersonasAdultosCiudad.Value + spinnerPersonasMenoresCiudad.Value), cedulaUsuario, Convert.ToInt16(spinnerPersonasAdultosCiudad.Value), Convert.ToInt16(spinnerPersonasMenoresCiudad.Value), precioTotalHospedajeHotel);
                MessageBox.Show("La Pre Reservacion se Realizo con Exito.");
                dtgHotelesCiudades.DataSource = null;
                btnHabitacionesCiudad.Enabled = false;
                btnPersonasCiudad.Enabled = false;
                fechaLlegadaCiudad.Enabled = false;
                FechaPartidaCiudad.Enabled = false;
                panelAdultosNiñosPais.Visible = false;
                labelHabitaciones.Visible = false;
                spinnerHabitacionesPais.Visible = false;
                btnGuardarCantidadPersonasPais.Visible = false;
                comboCiudades.Items.Clear();
            }
            else
            {
                MessageBox.Show("Debe de Ingresar fechas correctas");
            }
        }

        private void btnGuardarReservacionHotel_Click(object sender, EventArgs e)
        {
            posicionDTGHotel = dtgResultadosBusquedad.CurrentRow.Index;
            int idHotel = Convert.ToInt16(dtgResultadosBusquedad[0, posicionDTGHotel].Value.ToString());
            string nombreHotel = dtgResultadosBusquedad[1, posicionDTGHotel].Value.ToString();
            int cedulaUsuario = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);
            double precioTotalHospedajeHotel = ((Convert.ToDouble(dtgResultadosBusquedad[5, posicionDTGHotel].Value.ToString())) * cantidadDiasHotel);
            if (metodos.DiferenciaDiasFechas(fechaLlegadaCiudad.Text, FechaPartidaCiudad.Text) > 0)
            {
                metodos.InsertarDatosPreReservacionHotel(idHotel, fechaLlegadaCiudad.Text, FechaPartidaCiudad.Text, Convert.ToInt16(spinnerHabitacionesCiudad.Value), Convert.ToInt16(spinnerPersonasAdultosCiudad.Value + spinnerPersonasMenoresCiudad.Value), cedulaUsuario, Convert.ToInt16(spinnerPersonasAdultosCiudad.Value), Convert.ToInt16(spinnerPersonasMenoresCiudad.Value), precioTotalHospedajeHotel);
                MessageBox.Show("La Pre Reservacion se Realizo con Exito.");
                dtgHotelesCiudades.DataSource = null;
                btnHabitacionesCiudad.Enabled = false;
                btnPersonasCiudad.Enabled = false;
                fechaLlegadaCiudad.Enabled = false;
                FechaPartidaCiudad.Enabled = false;
                panelAdultosNiñosPais.Visible = false;
                labelHabitaciones.Visible = false;
                spinnerHabitacionesPais.Visible = false;
                btnGuardarCantidadPersonasPais.Visible = false;
                comboCiudades.Items.Clear();
            }
            else
            {
                MessageBox.Show("Debe de Ingresar fechas correctas");
            }
        }

        private void optPrecioMenorPais_CheckedChanged(object sender, EventArgs e)
        {
            //dtgHotelesPaises.DataSource = null;
            metodos.LlenarDtVistaPreliminarHotelsPaisASC(dtgHotelesPaises, comboPaises.SelectedItem.ToString());
            //ArrayList lista = new ArrayList();
            //lista = metodos.CargarFotosHotelesPaisASC(comboPaises.SelectedItem.ToString());
            //Image fotoHP;
            //for (int i = 0; i < dtgHotelesPaises.RowCount; i++)
            //{
            //    fotoHP = Image.FromFile(lista[i].ToString());
            //    dtgHotelesPaises.Rows[i].Cells["Foto_Hotel"].Value = fotoHP;
            //}
        }

        private void optPrecioMayorPais_CheckedChanged(object sender, EventArgs e)
        {
            //dtgHotelesPaises.Columns.Clear();
            //dtgHotelesPaises.DataSource=null;
            metodos.LlenarDtVistaPreliminarHotelsPaisDESC(dtgHotelesPaises, comboPaises.SelectedItem.ToString());

            //ArrayList lista = new ArrayList();
            //lista = metodos.CargarFotosHotelesPaisDESC(comboPaises.SelectedItem.ToString());
            //Image fotoHP;
            //for (int i = 0; i < dtgHotelesPaises.RowCount; i++)
            //{
            //    fotoHP = Image.FromFile(lista[i].ToString());
            //    dtgHotelesPaises.Rows[i].Cells["Foto_Hotel"].Value = fotoHP;
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fotoHotel.Visible = true;
            posicionDTGHotelPais = dtgHotelesPaises.CurrentRow.Index;
            string ruta = dtgHotelesPaises[5, posicionDTGHotelPais].Value.ToString();
            fotoHotelPais.Image = Image.FromFile(ruta);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fotoHotel.Visible = true;
            posicionDTGHotelCiudad = dtgHotelesCiudades.CurrentRow.Index;
            string ruta = dtgHotelesCiudades[4, posicionDTGHotelCiudad].Value.ToString();
            fotoHotelCiudad.Image = Image.FromFile(ruta);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fotoHotel.Visible = true;
            posicionDTGHotel = dtgResultadosBusquedad.CurrentRow.Index;
            string ruta = dtgResultadosBusquedad[6, posicionDTGHotel].Value.ToString();
            fotoHotel.Image = Image.FromFile(ruta);
        }

    }
}
