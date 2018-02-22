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
    public partial class Crud_Vehiculos : Form
    {


        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Metodos metodo = new Metodos();
        Validaciones validar = new Validaciones();


        public Crud_Vehiculos()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Llena el combo con las placas de los vehiculos
            metodo.LlenarCombo1IdentificadorVehiculos(comboVehiculosModificar);

            //Llena el combo del TAB de eliminar Vehiculos 
            metodo.LlenarCombo1IdentificadorVehiculos(ComboPlacasEliminar);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = true;
            metodo.Combo2Vehiculos(comboVehiculosModificar, txtMarca, txtModelo, txtTipo, txtPre, txtCantida);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarVehiculo.Enabled = true;
            metodo.Combo2Vehiculos(ComboPlacasEliminar, textBoxMarcaActual, textBoxModeloActual, textBoxTipoActual, textBoxPrecioActual, textBoxCantidadActual);

        }

        public void LImpiarCampos()
        {
            txtIdentificador.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            //Validando entrada de datos
            if (txtIdentificador.Text.Length == 0 || comboMarca.Text.Length == 0 || comboModelo.Text.Length == 0 || comboTipo.Text.Length == 0 || txtPrecio.Text.Length == 0 || txtCantidad.Text.Length == 0
                )
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {

                int placa = int.Parse(txtIdentificador.Text);
                string marca = comboMarca.Text;
                string modelo = comboModelo.Text;
                string tipo = comboTipo.Text;
                double precio = double.Parse(txtPrecio.Text);
                int cantidadP = int.Parse(txtCantidad.Text);

                conectar.InsertarDatosVehiculos(placa, marca, modelo, tipo, precio, cantidadP);
                MessageBox.Show("Vehiculo Insertado con Exito");

                LImpiarCampos();
                //Metodo para llenar el DataGridView con informacion de la tabla de vehiculos
                metodo.LlenarDtVehiculos(TablaVehiculos);


            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            double castear = Convert.ToDouble(this.txtNuevoPrecio.Text);
            int castear2 = Convert.ToInt16(this.txtNuevaCantidad.Text);
            int placa = int.Parse(this.comboVehiculosModificar.SelectedItem.ToString());

            
            conectar.ModificarDatosVehiculo(placa ,ComboMarcaNueva.Text, comboModeloNuevo.Text, comboTipoNuevo.Text, castear , castear2 );
            MessageBox.Show("Vehiculo Modificado");
            //Metodo para llenar el DataGridView con informacion de la tabla de vehiculos
            metodo.LlenarDtVehiculos(TablaVehiculos);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


        public void Limpiar()
        {
            textBoxMarcaActual.Clear();
            textBoxModeloActual.Clear();
            textBoxTipoActual.Clear();
            textBoxPrecioActual.Clear();
            textBoxCantidadActual.Clear();
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            //Boton y Metodo  Eliminar Vehiculo
            int placas_eliminar = int.Parse(this.ComboPlacasEliminar.SelectedItem.ToString());
            conectar.EliminarDatosVehiculos(placas_eliminar);
            MessageBox.Show("Vehiculo Eliminado");
            Limpiar();
            //Metodo para llenar el DataGridView con informacion de la tabla de vehiculos
            metodo.LlenarDtVehiculos(TablaVehiculos);
        }

        private void Crud_Vehiculos_Load(object sender, EventArgs e)
        {

            //Metodo para llenar el DataGridView con informacion de la tabla de vehiculos
            metodo.LlenarDtVehiculos(TablaVehiculos);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
