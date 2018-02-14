using System;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Validaciones validaciones = new Validaciones();
        Conexiones_Base_Datos conexiones = new Conexiones_Base_Datos();

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
            comboTipoUsuario.Items.Add("Cliente");
            comboTipoUsuario.Items.Add("Administrador");
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

        private void button2_Click(object sender, EventArgs e)
        {
            int cedula = int.Parse(txtCedula.Text);
            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string combo = comboTipoUsuario.Text;

            conexiones.InsertarDatosUsuarios(cedula, nombre, contraseña, combo);
            MessageBox.Show("Usuario registrado");


        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
