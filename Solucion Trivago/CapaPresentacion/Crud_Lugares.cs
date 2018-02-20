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
    public partial class Crud_Lugares : Form
    {

        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Validaciones validar = new Validaciones();
        Metodos metodos = new Metodos();

        public Crud_Lugares()
        {
            InitializeComponent();
            this.CenterToScreen();
           //Llenando el combobox
            metodos.LlenarLugares(comboIdentificador);
            metodos.LlenarComboNLugares(comboBoxLugar);

           
        }

        private void Crud_Lugares_Load(object sender, EventArgs e)
        {
            //Lleno la tabla de lugares
            metodos.LlenarDtLugar(dataGridView1);

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void LimpiarCampos()
        {
            txtIDLugarNuevo.Clear();
            txtNombreLugarNuevo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validando entrada de datos
            if (txtIDLugarNuevo.Text.Length == 0 || txtIDLugarNuevo.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                int identificador = int.Parse(txtIDLugarNuevo.Text);
                string nombre = txtNombre.Text;
                conectar.InsertarDatosLugares(identificador, nombre);
                MessageBox.Show("Lugar Registrado con exito");

                //Limpiar campos
                LimpiarCampos();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = true;
        }


        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {

        }

       

        private void comboIdentificador_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodos.LLenarComboLugares(comboIdentificador, txtNombre);

        }

        private void txtIDLugarNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tabla_Lugares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodos.ComboboxModificarLugares(comboBoxLugar , txtNombreLugarActual);
        }
    }
}
