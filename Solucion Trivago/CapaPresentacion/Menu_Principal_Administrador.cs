using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu_Principal_Administrador : Form
    {

        public Menu_Principal_Administrador()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud_Rutas v = new Crud_Rutas();
            v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud_Lugares v = new Crud_Lugares();
            v.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
           Crud_Tarifas_Vuelo v = new Crud_Tarifas_Vuelo();
            v.Show();
        }

        private void Menu_Principal_Administrador_Load(object sender, EventArgs e)
        {
           nombreUsuarioVer.Text = "Bienvenido Administrador,"+Login.nombreUsuario;
            Console.WriteLine("Bienvenido Administrador ," + Login.nombreUsuario);
            
        }

        private void btnCrud_Aeropuerto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud_Aeropuertos v = new Crud_Aeropuertos();
            v.Show();
        }

        private void btnCrud_TarifasH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud_Tarifas_Hotel v = new Crud_Tarifas_Hotel();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login v = new Login();
            v.Show();
            Login.nombreUsuario =String.Empty;
        }

        private void btnCrud_Vehiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud_Vehiculos v = new Crud_Vehiculos();
            v.Show();
        }

        private void btnCrud_Hoteles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud_Hoteles v = new Crud_Hoteles();
            v.Show();
        }

        private void btnCrud_Paises_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud_Paises v = new Crud_Paises();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud_Aerolineas v = new Crud_Aerolineas();
            v.Show();
        }
    }
}
