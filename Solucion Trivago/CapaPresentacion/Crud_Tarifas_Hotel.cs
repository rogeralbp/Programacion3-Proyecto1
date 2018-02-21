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
            //Llenamos el combobox en el TAB de eliminar
            metodos.ComboIDTarifasHoteles(ComboIndentificadorTarifas);
            //Llenamos el combobox en el TAB de modificar
            metodos.ComboIDTarifasHoteles(ComboIDTarifas);

                
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

        public void LimpiarC()
        {
            txtPrecioNuevo.Clear();
            txtTarifaAc.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Double precio = Convert.ToDouble(this.txtPrecioNuevo.Text);
            conectar.ModificarTarifaHotel(precio);
            MessageBox.Show("Precio de tarifa Hotel modificado con Exito");
            LimpiarC();
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
            metodos.MostrarInformacionTarifaHoteles(ComboIDTarifas, txtTarifaAc);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarTarifa.Enabled = true;
            
            metodos.MostrarInformacionTarifaHoteles(ComboIndentificadorTarifas, txtTarifaActual);

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Mostar_Load(object sender, EventArgs e)
        {
            metodos.LlenarDtarifaHotel(TablaTarifasHoteles);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        public void limpiar()
        {
            txtTarifaActual.Clear();
        }
        private void btnEliminarTarifa_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(this.txtTarifaActual.Text);
            conectar.EliminarDatosTarifa(precio);
            MessageBox.Show("Tarifa Hotel eliminado con Exito");
            limpiar();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
