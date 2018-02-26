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
        string direccion = "";
      

        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Metodos metodos = new Metodos();
        Validaciones validar = new Validaciones();

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
                conectar.InsertarDatosPaises(identificador, nombre, direccion);
                MessageBox.Show("Se registro el Pais con exito");


                LimpiarCamposAgregar();
                ActualizarTabla();
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
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                    direccion = imagen;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminarPais_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(this.comboPaisesEliminar.SelectedItem.ToString());
            conectar.EliminarDatosPaises(codigo);
            MessageBox.Show("Pais eliminado con exito");
            LimpiarEliminarCampos();
            ActualizarTabla();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarPais_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox2.Image = Image.FromFile(imagen);
                    direccion = imagen;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex);
            }
        }

        public void ActualizarTabla()
        {
            metodos.LlenarDtPaises(Tabla_Paises);
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            ActualizarTabla();

        }

        private void txtNombreEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtIdentificadorEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void txtNombreModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtIdentificadorModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void txtIDPaisNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void txtNombrePaisNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);

        }
    }
}
