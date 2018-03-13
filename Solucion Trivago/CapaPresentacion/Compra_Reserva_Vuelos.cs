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

namespace CapaPresentacion
{
    public partial class Compra_Reserva_Vuelos : Form
    {
        Metodos_Usuarios metodos = new Metodos_Usuarios();
        Conexiones_Base_Datos conexion = new Conexiones_Base_Datos();
        int posicionDTGPREREERVACIONES;
        public Compra_Reserva_Vuelos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Compra_Reserva v = new Principal_Compra_Reserva();
            v.Show();
        }

        private void Compra_Reserva_Vuelos_Load(object sender, EventArgs e)
        {
            metodos.LlenarDtVistaPreReservacionesVuelos(dtgPreReservacionesVuelos, conexion.ConsultarCedulaUsuario(Login.nombreUsuario));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            posicionDTGPREREERVACIONES = dtgPreReservacionesVuelos.CurrentRow.Index;
            String pasajerosAdultos = dtgPreReservacionesVuelos[3,posicionDTGPREREERVACIONES].Value.ToString();
            String pasajerosNiños = dtgPreReservacionesVuelos[4, posicionDTGPREREERVACIONES].Value.ToString();
            String paisOrigen = dtgPreReservacionesVuelos[8, posicionDTGPREREERVACIONES].Value.ToString();
            String paisDestino = dtgPreReservacionesVuelos[9, posicionDTGPREREERVACIONES].Value.ToString();
            String idCliente = dtgPreReservacionesVuelos[13, posicionDTGPREREERVACIONES].Value.ToString();
            metodos.EliminarPreReservacionesVuelos(pasajerosAdultos,pasajerosNiños,paisOrigen,paisDestino,idCliente);
            MessageBox.Show("Se elimino correctamente esta Reservacion.");
            dtgPreReservacionesVuelos.DataSource = null;
            //dtgPreReservacionesVuelos.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            posicionDTGPREREERVACIONES = dtgPreReservacionesVuelos.CurrentRow.Index;
            int id_Vuelo= Convert.ToInt16(dtgPreReservacionesVuelos[0, posicionDTGPREREERVACIONES].Value.ToString());
            int id_Hotel = Convert.ToInt16(dtgPreReservacionesVuelos[1, posicionDTGPREREERVACIONES].Value.ToString());
            int placa_Vehiculo = Convert.ToInt16(dtgPreReservacionesVuelos[2, posicionDTGPREREERVACIONES].Value.ToString());
            int pasajeros_Adultos = Convert.ToInt16(dtgPreReservacionesVuelos[3, posicionDTGPREREERVACIONES].Value.ToString());
            int pasajeros_Niños = Convert.ToInt16(dtgPreReservacionesVuelos[4, posicionDTGPREREERVACIONES].Value.ToString());
            int habitacionesHotel= Convert.ToInt16(dtgPreReservacionesVuelos[5, posicionDTGPREREERVACIONES].Value.ToString());
            DateTime fechaInicio = Convert.ToDateTime(dtgPreReservacionesVuelos[6, posicionDTGPREREERVACIONES].Value.ToString());
            DateTime fechaFin= Convert.ToDateTime(dtgPreReservacionesVuelos[7, posicionDTGPREREERVACIONES].Value.ToString());
            string paisOrigen = dtgPreReservacionesVuelos[8, posicionDTGPREREERVACIONES].Value.ToString();
            string paisDestino = dtgPreReservacionesVuelos[9, posicionDTGPREREERVACIONES].Value.ToString();
            int duracionTotal = Convert.ToInt16(dtgPreReservacionesVuelos[10, posicionDTGPREREERVACIONES].Value.ToString());
            double precioTotal = Convert.ToDouble(dtgPreReservacionesVuelos[11, posicionDTGPREREERVACIONES].Value.ToString());
            string vueloOescala = dtgPreReservacionesVuelos[12, posicionDTGPREREERVACIONES].Value.ToString();
            int cedulaUsuario = Convert.ToInt16(dtgPreReservacionesVuelos[13, posicionDTGPREREERVACIONES].Value.ToString());
            Reservaciones_Vuelos reservacion = new Reservaciones_Vuelos(id_Vuelo,id_Hotel,placa_Vehiculo,pasajeros_Adultos,pasajeros_Niños,habitacionesHotel,fechaInicio.ToShortDateString(),fechaFin.ToShortDateString(),paisOrigen,paisDestino,duracionTotal,precioTotal,vueloOescala,cedulaUsuario); 
            metodos.InsertarDatosReservacionesVuelos(reservacion);
            MessageBox.Show("Se ha ejercido la Reserva con exito");
            metodos.EliminarPreReservacionesVuelos(pasajeros_Adultos.ToString(), pasajeros_Niños.ToString(), paisOrigen, paisDestino, cedulaUsuario.ToString());
            dtgPreReservacionesVuelos.DataSource = null;
            int cantidadActualHabitaciones = metodos.ConsultarCantidadHabitacionesHotel(id_Hotel);
            int cantidadRestar = Convert.ToInt16(habitacionesHotel);
            int resultadoResta = (cantidadActualHabitaciones - cantidadRestar);
            metodos.ActualizarCantidadHabitacionesHotel(resultadoResta,id_Hotel);
            //dtgPreReservacionesVuelos.Rows.Clear();

        }
    }
}
