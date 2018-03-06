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
    public partial class Compra_Reserva_Vuelos : Form
    {
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
    }
}
