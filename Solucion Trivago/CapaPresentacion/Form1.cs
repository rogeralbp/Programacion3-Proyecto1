using System;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Validaciones validaciones = new Validaciones();

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cliente");
            comboBox1.Items.Add("Administrador");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloLetras(e);
        }
    }
}
