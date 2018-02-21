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
            //Llenando el combobox con ID del lugar
            metodos.Combo1Lugar(comboIdentificador);

            //Llena el combobox de nombres de lugares
            metodos.ComboNombresLugares(comboBoxLugar);


        }

        private void Crud_Lugares_Load(object sender, EventArgs e)
        {
            //Lleno la tabla de lugares en el DataGridview
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
            txtNombres.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validando entrada de datos
            if (txtIDLugarNuevo.Text.Length == 0 || txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                int identificador = int.Parse(txtIDLugarNuevo.Text);
                string nombre = txtNombres.Text;
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

        }


        public void LimpiarDatos()
        {
            textBoxNombre.Clear();
        }


        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {
            conectar.EliminarDatosLugares(textBoxNombre.Text);
            MessageBox.Show("Lugar Eliminado");
            LimpiarCampos();

        }



        private void comboIdentificador_SelectedIndexChanged(object sender, EventArgs e)
        {


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
            metodos.LlenarCombosModificarLugar(comboBoxLugar, txtNombreLugarActual);
        }

        private void comboIdentificador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            metodos.ComboEliminarLugar(comboIdentificador, textBoxNombre);
        
        }
    

        public void LimpiarCamposs()
        {
            txtNombreLugarActualizar.Clear();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {



           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conectar.ModificarDatosLugar( txtNombreLugarActualizar.Text);
            MessageBox.Show("Lugar modificado");
            LimpiarCamposs();
            

        }

        private void txtNombreLugarActualizar_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
