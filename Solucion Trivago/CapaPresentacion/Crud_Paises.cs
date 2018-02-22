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

    
    public partial class Crud_Paises : Form
    {
        string dir;
        string dir3;

        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Metodos metodos = new Metodos();

        public Crud_Paises()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int identificador = int.Parse(txtIDPaisNuevo.Text);
            string nombre = txtNombrePaisNuevo.Text;

            conectar.InsertarDatosPaises(identificador, nombre, dir);
            MessageBox.Show("Se registro el Pais con exito");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnActualizarPais.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarPais.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos de Imagenes(*.jpg)(*,jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            op.InitialDirectory = "C://";

            if (op.ShowDialog() == DialogResult.OK)
            {
                dir = op.FileName;
                Bitmap foto = new Bitmap(dir);

                pictureBox1.Image = (Image)foto;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos de Imagenes(*.jpg)(*,jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            op.InitialDirectory = "C://";

            if (op.ShowDialog() == DialogResult.OK)
            {
                dir3 = op.FileName;
                Bitmap foto = new Bitmap(dir3);
                pictureBox1.Image = (Image)foto;
            }
        }

    }
}
