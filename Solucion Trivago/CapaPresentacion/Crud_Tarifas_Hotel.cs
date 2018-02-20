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
    public partial class Crud_Tarifas_Hotel : Form
    {
        Metodos metodos = new Metodos();
        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Validaciones validar = new Validaciones();

        public Crud_Tarifas_Hotel()
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

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCampos()
        {
            txtIdentificador.Clear();
            txtPrecio.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtIdentificador.Text.Length == 0 || txtPrecio.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                int identficador = int.Parse(txtIdentificador.Text);
                double precio = double.Parse(txtPrecio.Text);
                conectar.InsertaTarifaHotel(identficador, precio);
                MessageBox.Show("Tarifa hotel insertado con exito");
                LimpiarCampos();
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
            btnGuardarCambios.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarTarifa.Enabled = true;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Mostar_Load(object sender, EventArgs e)
        {
            metodos.LlenarDtarifaHotel(TablaTarifasHoteles);
        }
    }
}
