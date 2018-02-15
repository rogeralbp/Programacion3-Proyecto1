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
    public partial class Seccion_Vuelos : Form
    {
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
        }
    }
}
