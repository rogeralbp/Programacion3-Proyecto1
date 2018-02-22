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
        string bandera;
        string banderas;

        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Metodos metodos = new Metodos();

        public Crud_Paises()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Lleno el combo del TAB de eliminar
            metodos.ComboIDPaises(comboPaisesEliminar);

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


       public void LimpiarCamposAgregar()
        {
            txtIDPaisNuevo.Clear();
            txtNombrePaisNuevo.Clear();
            pictureBox1.Image = null;
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (txtIDPaisNuevo.Text.Length == 0 || txtNombrePaisNuevo.Text.Length == 0 || pictureBox1 == null)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                int identificador = int.Parse(txtIDPaisNuevo.Text);
                string nombre = txtNombrePaisNuevo.Text;
                conectar.InsertarDatosPaises(identificador, nombre, bandera);
                MessageBox.Show("Se registro el Pais con exito");


                LimpiarCamposAgregar();
            }
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

        public void LimpiarEliminarCampos()
        {
            txtIdentificadorEliminar.Clear();
            txtNombreEliminar.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarPais.Enabled = true;
            //Metodo para mostrar la informacion del pais , de acuerdo con el ID correspondiente
            metodos.MostrarInformacionPais(comboPaisesEliminar, txtIdentificadorEliminar, txtNombreEliminar);
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos de Imagenes(*.jpg)(*,jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            op.InitialDirectory = "C://";

            if (op.ShowDialog() == DialogResult.OK)
            {
                bandera = op.FileName;
                Bitmap foto = new Bitmap(bandera);

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
                banderas = op.FileName;
                Bitmap foto = new Bitmap(banderas);
                pictureBox1.Image = (Image)foto;
            }
        }

        private void btnEliminarPais_Click(object sender, EventArgs e)
        {

            conectar.EliminarDatosPaises(txtNombreEliminar.Text);
            MessageBox.Show("Pais eliminado con exito");
            LimpiarEliminarCampos();
        }
    }
}
