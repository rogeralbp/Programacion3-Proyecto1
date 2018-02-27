using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Crud_Aeropuertos : Form
    {

        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Metodos metodo = new Metodos();
        Validaciones validar = new Validaciones();

        public Crud_Aeropuertos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
