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
    public partial class Seccion_Compra_Reserva : Form
    {
        public Seccion_Compra_Reserva()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Seccion_Compra_Reserva_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Usuarios v = new Menu_Principal_Usuarios();
            v.Show();
        }
    }
}
