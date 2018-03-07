using System;
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
        List<string> cantidad = new List<string>();
        List<String> nombres = new List<String>();

        public Reportes()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Reportes_Load(object sender, EventArgs e)
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
    }
}
