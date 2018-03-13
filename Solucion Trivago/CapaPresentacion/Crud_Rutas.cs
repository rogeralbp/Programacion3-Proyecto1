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
    public partial class Crud_Rutas : Form
    {
        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Metodos metodo = new Metodos();

        public Crud_Rutas()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Metodos que llenan los combobox de la TAB de agregar agregar rutas
            metodo.ComboNombresPaises(comboPaisOrigen);
            metodo.ComboNombresPaises(comboPaisDestino);

            metodo.ComboNombresPaises(comboBoxNuevoPaisOrigen);
            metodo.ComboNombresPaises(comboBoxNuevoPaisDestino);

            //Metodo que llena el combobox del TAB de eliminar rutas
            metodo.ComboIDRuta(comboIDRutas);

            //Metodo que llena el combobox del TAD de modificar de rutas
            metodo.ComboIDRuta(comboboxIDModificar);
        }

        private void tabPage1_Click(object sender, EventArgs e)
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

        public void limpiarCampos()
        {
            txtIdentificador.Clear();
            txtDuracion.Clear();
           
            
        }

        public void Actualizar_Rutas()
        {
            //Llenamos el datagridview de rutas ingresadas
            metodo.LlenarDtRutas(TablaRutas);

        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (txtIdentificador.Text.Length == 0 || txtDuracion.Text.Length == 0 || comboPaisOrigen.Text.Length == 0 || comboPaisDestino.Text.Length == 0 || txtDuracion.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                int indentificadorRuta = int.Parse(txtIdentificador.Text);
                string origen = comboPaisOrigen.SelectedItem.ToString();
                string destino = comboPaisDestino.SelectedItem.ToString();
                int cantidad = int.Parse(txtDuracion.Text);

                conectar.InsertarDatosRutas(indentificadorRuta, origen, destino, cantidad);
                MessageBox.Show("Ruta ingresada con Exito");
                limpiarCampos();
                Actualizar_Rutas();

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void Crud_Rutas_Load(object sender, EventArgs e)
        {
            //Llenamos el datagridview de rutas ingresadas
            metodo.LlenarDtRutas(TablaRutas);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            //Metodo que muestra la informacion de la ruta
            metodo.MostrarInformacionRutas(comboboxIDModificar , textOrigen , textDestino , textDuracion);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarRuta.Enabled = true;

            //Metodo que muestra la informacion de la ruta 
            metodo.MostrarInformacionRutas(comboIDRutas, txtOrigenActual, txtDestinoActual, txtDuracionActual);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        public void limpiarCamposEliminar()
        {
            txtOrigenActual.Clear();
            txtDestinoActual.Clear();
            txtDuracionActual.Clear();
        }
        private void btnEliminarRuta_Click(object sender, EventArgs e)
        {


            int identificador = int.Parse(comboIDRutas.SelectedItem.ToString() );
            conectar.EliminarDatosRuta(identificador);
            MessageBox.Show("Ruta Eliminada con Exito");
            limpiarCamposEliminar();
            Actualizar_Rutas();

        }

        public void LimpiarCamposModificar()
        {
            txtOrigenActual.Clear();
            txtDestinoActual.Clear();
            txtDuracionActual.Clear();

            comboBoxNuevoPaisOrigen.Items.Clear();
            comboBoxNuevoPaisDestino.Items.Clear();
            textNuevoDuracion.Clear();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string origen_nuevo = comboBoxNuevoPaisOrigen.SelectedItem.ToString();
            string destino_nuevo = comboBoxNuevoPaisDestino.SelectedItem.ToString();
            int duracion_nuevo = int.Parse(textNuevoDuracion.Text);
            int identificador_modificar = int.Parse(comboboxIDModificar.SelectedItem.ToString());

            conectar.ModificarDatosRuta(identificador_modificar, origen_nuevo, destino_nuevo, duracion_nuevo);
            MessageBox.Show("Ruta modificada con exito");

            LimpiarCamposModificar();
            Actualizar_Rutas();


        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
