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

        int i = 1;

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

        public void LimpiarDatos()
        {
            txtCodigoAeropuertos.Clear();
            txtIdentificador.Clear();
            txtNombre.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int identificador = int.Parse(txtIdentificador.Text);
            string nombre = txtNombre.Text;
            int codigo = int.Parse(txtCodigoAeropuertos.Text);
            string lugar = ComboLugares.Selected.ToString();



            tblAerpuertos.Rows.Add(i + "", identificador, nombre,  lugar,  codigo);
            i = i + 1;
            conectar.InsertarDatosAeropuerto(identificador, nombre, lugar, codigo);
            MessageBox.Show("Agregado con Exito");

            LimpiarDatos();

            

            


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblAerpuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Aeropuerto_Load(object sender, EventArgs e)
        {
            //Este metodo llena el comobo que esta dentro del DatagridView
            metodo.LlenarComboDatagridviewAeropuertos(ComboLugares);
        }
    }
}
