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
    public partial class Crud_Hoteles : Form
    {
        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        Metodos metodos = new Metodos();
        Validaciones validar = new Validaciones();
        string bandera;
        string banderas;
        string direccion = "";
        public Crud_Hoteles()
        {
            InitializeComponent();
            this.CenterToScreen();


            ActualizarTablaHoteles();

            //Llenando los combobox de paise y lugares
            metodos.ComboNombresPaises(comboBoxPaises);
            metodos.ComboLugares(comboBoxLugares);

            //Llenando los combobox de modificar lugar y pais
            metodos.ComboNombresPaises(comboNuevoPais);
            metodos.ComboLugares(comboNuevoLugar);
                

            //Metodo que llena los combobox de ID de hoteles
            metodos.ComboIDHoteles(comboBoxEliminarIdentificador);

            //Metodo que llena el combobox de ID de hoteles
            metodos.ComboIDHoteles(comboBoxModifcarIdentificador);


            metodos.ComboPreciosTarifaHoteles(comboBoxPrecioTarifa);
            metodos.ComboPreciosTarifaHoteles(comboBoxTarifaNueva);

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




            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();

        }


        public void LimpiarCampos()
        {
            txtIdentificador.Clear();
            txtNombre.Clear();
            txtHabitaciones.Clear();
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdentificador.Text.Length == 0 || txtNombre.Text.Length == 0 || comboBoxPaises.Text.Length == 0 || comboBoxLugares.Text.Length == 0 || txtHabitaciones.Text.Length == 0 
              )
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                int identificador = int.Parse(txtIdentificador.Text);
                string nombre = txtNombre.Text;
                string pais = comboBoxPaises.SelectedItem.ToString();
                string lugar = comboBoxLugares.SelectedItem.ToString();
                int habitaciones = int.Parse(txtHabitaciones.Text);
                double precio_tarifa = double.Parse(this.comboBoxPrecioTarifa.SelectedItem.ToString()); 
                conectar.InsertarHotel(identificador, nombre, direccion, pais, lugar, habitaciones , precio_tarifa);

                MessageBox.Show("Hotel Agregado con Exito");
                LimpiarCampos();
                ActualizarTablaHoteles();


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador v = new Menu_Principal_Administrador();
            v.Show();
        }

        public void LimpiarCamposModificar()
        {
            txtNombreActual.Clear();
            txtPaisActual.Clear();
            txtLugarActual.Clear();
            txtHabitacionesActuales.Clear();
            txtNuevoNombre.Clear();
            txtNuevasHabitaciones.Clear();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = true;
            //Metodo que muestra la informacion del hotel
            metodos.MostrarInformacionHoteles(comboBoxModifcarIdentificador, txtNombreActual, txtPaisActual, txtLugarActual, txtHabitacionesActuales , txtTarifaAc);
        }
        public void LimpiarCamposEliminar()
        {
            textNombreActual.Clear();
            textPaisActual.Clear();
            textLugarActual.Clear();
            textHabitacionesActuales.Clear();
            

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarHotel.Enabled = true;
            //Metodo que muestra la informacion del hotel
            metodos.MostrarInformacionHoteles(comboBoxEliminarIdentificador, textNombreActual, textPaisActual, textLugarActual, textHabitacionesActuales , txtTarifaActual);
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

        private void btnEliminarHotel_Click(object sender, EventArgs e)
        {
            int identificador = int.Parse(this.comboBoxEliminarIdentificador.SelectedItem.ToString());
            conectar.EliminarHotel(identificador);
            MessageBox.Show("Hotel eliminado con exito");
            LimpiarCamposEliminar();
            ActualizarTablaHoteles();
        }
        
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            int identificador = int.Parse(this.comboBoxModifcarIdentificador.SelectedItem.ToString());
            string nuevo_nombre = txtNuevoNombre.Text;
            string nuevo_pais = comboNuevoPais.SelectedItem.ToString();
            string nuevo_lugar = comboNuevoLugar.SelectedItem.ToString();
            int habitaciones = int.Parse(txtNuevasHabitaciones.Text);

            double tarifa_nueva = int.Parse(this.comboBoxTarifaNueva.SelectedItem.ToString());

            conectar.ModificarHotel(identificador, nuevo_nombre, nuevo_pais, nuevo_lugar, habitaciones , tarifa_nueva );
            MessageBox.Show("Hotel Modificado con Exito");

            LimpiarCamposModificar();
            ActualizarTablaHoteles();
        }



        public void ActualizarTablaHoteles()
        {

            metodos.LlenarDtHoteles(Tabla_Hoteles);

        }

        private void Crud_Hoteles_Load(object sender, EventArgs e)
        {
            ActualizarTablaHoteles();
        }

        private void txtIdentificador_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtHabitaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void txtNombreActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtNuevoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtNuevasHabitaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumeros(e);
        }

        private void textNombreActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }
    }
}


    


