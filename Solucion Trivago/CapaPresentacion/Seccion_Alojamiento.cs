using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Seccion_Alojamiento : Form
    {
        public Seccion_Alojamiento()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Seccion_Alojamiento_Load(object sender, EventArgs e)
        {

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

        private void optPrecioMayor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime f1 = DateTime.Parse(fechaLlegadaCiudad.Text);
            DateTime f2 = DateTime.Parse(FechaPartidaCiudad.Text);
            TimeSpan ts = f2 - f1;
            int cantidadDias = ts.Days;
            labelCantidadDiasLugar.Text = "Cantidad de dias " + cantidadDias.ToString();
        }
    

        private void tabPage1_Click(object sender, EventArgs e)
        {

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
            labelCantidadDiasLugar.Text = "Cantidad de dias " + cantidadDias.ToString();
        }

        private void btnBuscarHotel_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Pasaste el Mouse sobre mi");
        }

        private void btnBuscarHotel_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Dejaste  de pasar el Mouse sobre mi");
        }
    }
}
