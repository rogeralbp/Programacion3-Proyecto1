﻿using System;
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
            if (nombres.Count <= 0)
            {
                MessageBox.Show("No se encuentran Reservaciones en este momento!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < nombres.Count; i++)
                {
                    Series serie = chart2.Series.Add(nombres[i].ToString());
                    serie.Label = cantidad[i].ToString();
                    serie.Points.Add(Convert.ToInt32(cantidad[i]));
                }


            }

        }
            public void Reporte3()
        {

        }

        public void Reporte4()
        {

        }
        public void Reporte5()
        {

        }

        public void Reporte6()
        {

        }
        public void Reporte7()
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            //Funcion del reporte 1
            Reporte1();
            Reporte2();


            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
