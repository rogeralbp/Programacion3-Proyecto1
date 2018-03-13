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
using System.Windows.Forms.DataVisualization.Charting;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Reportes : Form
    {

        Conexiones_Base_Datos conectar = new Conexiones_Base_Datos();
        List<String> cantidad = new List<String>();
        List<String> nombres = new List<String>();
        List<int> cantidad1 = new List<int>();

        ArrayList cantidad_vehiculos = new ArrayList();

        public Reportes()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void Reporte1()
        {
            cantidad = conectar.Cantidad_Hoteles();
            nombres = conectar.Metodo_Nombres();
            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("CANTIDAD DE HOTELES RESERVADOS");

            for (int i = 0; i < nombres.Count; i++)
            {
                Series serie = chart1.Series.Add(nombres[i].ToString());
                serie.Label = cantidad[i].ToString();
                serie.Points.Add(Convert.ToDouble(cantidad[i]));
            }

        }
        public void Reporte2()
        {

            cantidad1 = conectar.Cantidad_Persona();
            nombres = conectar.Hoteles();
            chart2.Palette = ChartColorPalette.Pastel;
            chart2.Titles.Add("CANTIDAD DE PERSONAS POR HOTEL");

            for (int i = 0; i < nombres.Count; i++)
            {
                Series serie = chart2.Series.Add(nombres[i].ToString());
                serie.Label = cantidad[i].ToString();
                serie.Points.Add(Convert.ToInt32(cantidad[i]));
            }


        }


        public void Reporte3()
        {

            cantidad = conectar.Cantidad_Porcentaje();
            nombres = conectar.Metodo_Porcentaje();
            chart3.Palette = ChartColorPalette.Pastel;
            chart3.Titles.Add("PORCENTAJE DE VISITA POR PAIS");

            for (int i = 0; i < nombres.Count; i++)
            {
                Series serie = chart3.Series.Add(nombres[i].ToString());
                serie.Label = cantidad[i].ToString();
                serie.Points.Add(Convert.ToDouble(cantidad[i]));
            }

        }

        public void Reporte4()
        {
            try
            {

                cantidad = conectar.Cantidad_Adultos(Inicio.Value.ToShortDateString(), Fin.Value.ToShortDateString());
                if (cantidad.Count == 0)
                {
                    MessageBox.Show("No se hay resultados");
                }
                else
                {
                    chart4.Palette = ChartColorPalette.Pastel;
                    chart4.Titles.Add("Adultos que han viajado entre " + Inicio.Value.ToShortDateString() + " Y " + Fin.Value.ToShortDateString());

                    for (int i = 0; i < cantidad.Count; i++)
                    {
                        Series serie = chart4.Series.Add("Adultos");

                        serie.Label = cantidad[i].ToString();

                        serie.Points.Add(Convert.ToDouble(cantidad[i]));
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("No se ha encontran Resultados");
            }

        }
        public void Reporte5()
        {
            try
            {

                cantidad = conectar.Cantidad_Niños(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                if (cantidad.Count == 0)
                {
                    MessageBox.Show("No se hay resultados");
                }
                else
                {
                    chart5.Palette = ChartColorPalette.Pastel;
                    chart5.Titles.Add("Niños que han viajado entre " + dateTimePicker1.Value.ToShortDateString() + " Y " + dateTimePicker2.Value.ToShortDateString());

                    for (int i = 0; i < cantidad.Count; i++)
                    {
                        Series serie = chart5.Series.Add("Niños");

                        serie.Label = cantidad[i].ToString();

                        serie.Points.Add(Convert.ToDouble(cantidad[i]));
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("No se ha encontran Resultados");
            }
        }
    



        public void Reporte6()
        {

            cantidad_vehiculos = conectar.Cantidad_Vehiculos();
            nombres = conectar.Metodo_Vehiculos();
            chart6.Palette = ChartColorPalette.Pastel;
            chart6.Titles.Add("CANTIDAD DE VEHICULOS MAS RENTADOS");

            for (int i = 0; i < nombres.Count; i++)
            {
                Series serie = chart6.Series.Add(nombres[i].ToString());
                serie.Label = cantidad_vehiculos[i].ToString();
                serie.Points.Add(Convert.ToInt32(cantidad_vehiculos[i]));
            }


        }
        public void Reporte7()
        {

            cantidad = conectar.Cantidad_Escala();
            nombres = conectar.Metodo_Escala();
            chart7.Palette = ChartColorPalette.Pastel;
            chart7.Titles.Add("NOMBRES DE PAISES QUE HAN HECHO ESCALA");

            for (int i = 0; i < nombres.Count; i++)
            {
                Series serie = chart7.Series.Add(nombres[i].ToString());
                serie.Label = cantidad[i].ToString();
                serie.Points.Add(Convert.ToDouble(cantidad[i]));
            }


        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            //Funcion del reporte 1
            Reporte1();
            //Funcion del reporte 2
            Reporte2();
            //Funcion del reporte 3
            Reporte3();
            //Funcion del reporte 6
            Reporte6();
            //Funcion del reporte 7
            Reporte7();


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador a = new Menu_Principal_Administrador();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador a = new Menu_Principal_Administrador();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador a = new Menu_Principal_Administrador();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador a = new Menu_Principal_Administrador();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador a = new Menu_Principal_Administrador();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador a = new Menu_Principal_Administrador();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal_Administrador a = new Menu_Principal_Administrador();
            a.Show();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ESTE BOTON ES EL DE BUSCAR FECHA EN ADULTOS QUE HAN VIAJADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            Reporte4();
        }


        /// <summary>
        /// ESTE BOTON ES EL DE BUSCAR FECHA EN NIÑOS QUE HAN VIAJADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Reporte5();
        }

    }
}
    

