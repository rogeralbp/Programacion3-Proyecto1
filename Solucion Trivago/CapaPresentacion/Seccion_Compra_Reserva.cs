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
    public partial class Seccion_Compra_Reserva_Hoteles : Form
    {
        Metodos_Usuarios metodos = new Metodos_Usuarios();
        Conexiones_Base_Datos conexion = new Conexiones_Base_Datos();
        
        public Seccion_Compra_Reserva_Hoteles()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Seccion_Compra_Reserva_Load(object sender, EventArgs e)
        {
            int cedulaUsuario = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);
            metodos.LlenarDtVistaPrereservacionesHotelPais(dtgPreservaciones, cedulaUsuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Compra_Reserva v = new Principal_Compra_Reserva();
            v.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int posicionDTGPrereservaciones = dtgPreservaciones.CurrentRow.Index;
            int idHotel = Convert.ToInt16(dtgPreservaciones[0, posicionDTGPrereservaciones].Value.ToString());
            DateTime fechaLlegada = Convert.ToDateTime(dtgPreservaciones[1, posicionDTGPrereservaciones].Value.ToString());
            DateTime fechaSalida = Convert.ToDateTime(dtgPreservaciones[2, posicionDTGPrereservaciones].Value.ToString());
            int cantidadHabitaciones = Convert.ToInt16(dtgPreservaciones[3, posicionDTGPrereservaciones].Value.ToString());
            int cantidadPersonas = Convert.ToInt16(dtgPreservaciones[4, posicionDTGPrereservaciones].Value.ToString());
            int idCliente = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);
            int cantidadPersonasMenores = Convert.ToInt16(dtgPreservaciones[6, posicionDTGPrereservaciones].Value.ToString());
            int cantidadPersonasAdultas = Convert.ToInt16(dtgPreservaciones[7, posicionDTGPrereservaciones].Value.ToString());
            double precioHospedajeTotal = Convert.ToDouble(dtgPreservaciones[8, posicionDTGPrereservaciones].Value.ToString());
            metodos.InsertarDatosReservacionHotelDesdePrereservacion(idHotel,fechaLlegada,fechaSalida,cantidadHabitaciones,cantidadPersonas,idCliente,cantidadPersonasMenores,cantidadPersonasAdultas,precioHospedajeTotal);
            metodos.EliminarDatosPreReservacionHotel(idHotel, cantidadHabitaciones, cantidadPersonas, idCliente);
            MessageBox.Show("Se ha ejercido la Prereservacion Correctamente.");
            int cantidadActualHabitaciones = metodos.ActualCantidadHabitaciones(idHotel);
            int cantidadRestar = cantidadHabitaciones;
            int resultadoResta = (cantidadActualHabitaciones - cantidadRestar);
            metodos.ActualizarCantidadHabitacionesHotel(resultadoResta, idHotel);
            dtgPreservaciones.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int posicionDTGPrereservaciones = dtgPreservaciones.CurrentRow.Index;
            int idHotel = Convert.ToInt16(dtgPreservaciones[0, posicionDTGPrereservaciones].Value.ToString());
            string fechaLlegada = dtgPreservaciones[1, posicionDTGPrereservaciones].Value.ToString();
            string fechaSalida = dtgPreservaciones[2, posicionDTGPrereservaciones].Value.ToString();
            int cantidadHabitaciones = Convert.ToInt16(dtgPreservaciones[3, posicionDTGPrereservaciones].Value.ToString());
            int cantidadPersonas = Convert.ToInt16(dtgPreservaciones[4, posicionDTGPrereservaciones].Value.ToString());
            int idCliente = conexion.ConsultarCedulaUsuario(Login.nombreUsuario);
            metodos.EliminarDatosPreReservacionHotel(idHotel,  cantidadHabitaciones, cantidadPersonas, idCliente);
            MessageBox.Show("Se ha Eliminado la Prereservacion Correctamente.");
            dtgPreservaciones.DataSource = null;
        }
    }
}
