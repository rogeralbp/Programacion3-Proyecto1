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
    public partial class Principal_Compra_Reserva : Form
    {
        public Principal_Compra_Reserva()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Usuarios v = new Menu_Principal_Usuarios();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Seccion_Compra_Reserva_Hoteles v = new Seccion_Compra_Reserva_Hoteles();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compra_Reserva_Vuelos v = new Compra_Reserva_Vuelos();
            v.Show();
        }
    }
}
