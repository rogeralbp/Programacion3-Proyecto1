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
    public partial class Crud_Tarifas_Vuelo : Form
    {
        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Metodos metodo = new Metodos();

        public Crud_Tarifas_Vuelo()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Este metodo llena el combo de rutas del TAB de agregar
            // metodo.ComboNombreRuta(comboBoxRuta);
            // metodo.ComboNombreRuta(comboNueaRuta);

            metodo.ComboIDRutas(comboBoxRuta);
            metodo.ComboIDRutas(comboNueaRuta);

            //Este metodo llena el combo de ID de vuelos del TAB de modificar

            metodo.ComboIDVuelos(comboIDVuelos);

            //Este metodo llena el combo de ID vuelos del TAB de eliminar
            metodo.ComboIDVuelos(comboboxIndenticadorEliminar);


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        public void LimpiarCampos()
        {
            txtIdentificador.Clear();
            txtPrecio.Clear();
            txtPrecioNuevo.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtIdentificador.Text.Length == 0 || txtPrecio.Text.Length == 0 || comboBoxRuta.Text.Length == 0 )
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                int identificador = int.Parse(txtIdentificador.Text);
                int ruta = int.Parse(comboBoxRuta.SelectedItem.ToString()) ;
                double precio = double.Parse(txtPrecio.Text);

                conectar.InsertarDatosVuelos(identificador, ruta, precio);
                MessageBox.Show("Tarifa de vuelo ingresada");
                LimpiarCampos();
                //Actulizamos la tabla de vuelos
                metodo.LlenarDtTarifaVuelo(TablaVuelos);


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
            //Metodo que me muestra la informacion
            metodo.MostrarInformacionVuelos(comboIDVuelos, txtModificarRuta, txtModificarPrecio);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarTarifa.Enabled = true;
            metodo.MostrarInformacionVuelos(comboboxIndenticadorEliminar, txtRutaEliminar, txtPrecioEliminar);


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Cargar_Load(object sender, EventArgs e)
        {
            //Actulizamos la tabla de vuelos
            metodo.LlenarDtTarifaVuelo(TablaVuelos);
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            int ruta = int.Parse(comboNueaRuta.SelectedItem.ToString());
            double precio = double.Parse(txtPrecioNuevo.Text);
            int identificador_ruta = int.Parse(comboIDVuelos.SelectedItem.ToString());
           conectar.ModificarTarifaVuelo(identificador_ruta, ruta, precio);

            MessageBox.Show("Tarifa vuelo modificada con exito");

            LimpiarCampos();
            //Actulizamos la tabla de vuelos
            metodo.LlenarDtTarifaVuelo(TablaVuelos);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCamposEliminar()
        {
            txtPrecioEliminar.Clear();
            txtRutaEliminar.Clear();
        }

        private void btnEliminarTarifa_Click(object sender, EventArgs e)
        {
            int indentificador_eliminar = int.Parse(comboboxIndenticadorEliminar.SelectedItem.ToString());
            conectar.EliminarDatosTarifaVuelos(indentificador_eliminar);
            MessageBox.Show("Tarifa Eliminada con exito");

            LimpiarCamposEliminar();
            //Actulizamos la tabla de vuelos
            metodo.LlenarDtTarifaVuelo(TablaVuelos);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
