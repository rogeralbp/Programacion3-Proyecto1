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
    public partial class Menu_Principal_Usuarios : Form
    {
        public Menu_Principal_Usuarios()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login v = new Login();
            v.Show();
            Login.nombreUsuario = String.Empty;
        }

        private void Menu_Principal_Usuarios_Load(object sender, EventArgs e)
        {
            nomUser.Text = Login.nombreUsuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seccion_Alojamiento v = new Seccion_Alojamiento();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Seccion_Vuelos v = new Seccion_Vuelos();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Seccion_Compra_Reserva v = new Seccion_Compra_Reserva();
            v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
    }
}
