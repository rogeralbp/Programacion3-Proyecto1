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

namespace CapaPresentacion
{

    public partial class Crud_Aerolineas : Form
    {
        Conexiones_Base_Datos conexion = new Conexiones_Base_Datos();

        public Crud_Aerolineas()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtIDNuevo.Text.Length == 0 || txtNNuevo.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los Espacios.");
            }
            else
            {
                conexion.InsertarDatosAerolineas(txtIDNuevo.Text, txtNNuevo.Text);
                MessageBox.Show("Se Registro correctamente la Aerolinea");
                txtIDNuevo.Text = "";
                txtNNuevo.Text = "";
            }
            //Validacion
            //if (txtIDNuevo.Text.Length == 0 || txtNNuevo.Text.Length == 0)
            //{
            //    MessageBox.Show("Debe de llenar todos los Espacios.");
            //}
            //else
            //{ }
            }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = true;
            txtNuevoNombreModificar.Enabled = true;
            conexion.MostrarInformacionAerolineas(comboBoxIDSA, txtIDActual, txtNombreActual);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarAerolinea.Enabled = true;
            conexion.MostrarInformacionAerolineas(comboIDSElmiminar, txtIDEliminar, txtNombreEliminar);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            comboBoxIDSA.Items.Clear();
            conexion.LlenarComboIdentificadorAerolineas(comboBoxIDSA);
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (txtNuevoNombreModificar.Text.Length == 0)
            {
                MessageBox.Show("Debe llenar los campos");
            }
            else
            {
                conexion.ModificarDatosAerolineas(txtIDActual.Text, txtNuevoNombreModificar.Text);
                MessageBox.Show("Se ha Modificado la Aerolinea con Exito.");
                txtNuevoNombreModificar.Text = "";
            }
            comboIDSElmiminar.Items.Clear();
            conexion.LlenarComboIdentificadorAerolineas(comboIDSElmiminar);
            comboBoxIDSA.Items.Clear();
            conexion.LlenarComboIdentificadorAerolineas(comboBoxIDSA);
        }

        private void btnEliminarAerolinea_Click(object sender, EventArgs e)
        {
            conexion.EliminarDatosAerolineas(txtIDEliminar.Text);
            MessageBox.Show("Se ha eliminado con Exito la Aerolinea");
            txtIDEliminar.Text = "";
            txtNombreEliminar.Text = "";
        
            comboIDSElmiminar.Items.Clear();
            conexion.LlenarComboIdentificadorAerolineas(comboIDSElmiminar);
            comboBoxIDSA.Items.Clear();
            conexion.LlenarComboIdentificadorAerolineas(comboBoxIDSA);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            comboIDSElmiminar.Items.Clear();
            conexion.LlenarComboIdentificadorAerolineas(comboIDSElmiminar);
        }

        private void Crud_Aerolineas_Load(object sender, EventArgs e)
        {
            conexion.LlenarComboIdentificadorAerolineas(comboIDSElmiminar);
            conexion.LlenarComboIdentificadorAerolineas(comboBoxIDSA);
        }
    }
}
