using System;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        Validaciones validaciones = new Validaciones();
        Conexiones_Base_Datos conexiones = new Conexiones_Base_Datos();

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCedulaLogin.Text.Length==0 || txtCntraseñaLogin.Text.Length==0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else {

                String usuario = conexiones.TipoDeUsuario(txtCedulaLogin.Text);
                String contraseña = conexiones.ValidarContraseña(txtCedulaLogin.Text);

                if (usuario.Equals("Administrador") && contraseña.Equals(txtCntraseñaLogin.Text))
                {
                    this.Hide();
                    Menu_Principal_Administrador v = new Menu_Principal_Administrador();
                    v.Show();
                }
                else if (usuario.Equals("Cliente") && contraseña.Equals(txtCntraseñaLogin.Text))
                {

                    this.Hide();
                    Menu_Principal_Usuarios v = new Menu_Principal_Usuarios();
                    v.Show();
                }
                else
                {
                    MessageBox.Show("Usuario No Registrado en el Sistema");
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
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
            validaciones.validarSoloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarSoloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "" || txtNombre.Text == "" || txtContraseña.Text == ""){


                MessageBox.Show("Debe de llenar todos los campos.");
            }
            else {

                int cedula = int.Parse(txtCedula.Text);
                string nombre = txtNombre.Text;
                string contraseña = txtContraseña.Text;
        

                conexiones.InsertarDatosUsuarios(cedula, nombre,Seguridad.EncriptarContraseña(contraseña),"Cliente");
                MessageBox.Show("Usuario registrado");

                txtCedula.Text = "";
                txtNombre.Text = "";
                txtContraseña.Text = "";

            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
