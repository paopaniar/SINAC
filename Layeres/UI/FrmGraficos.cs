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

namespace SINAC.Layeres.UI
{
    public partial class FrmGraficos : Form
    {
        public FrmGraficos()
        {
            InitializeComponent();
        }

        private void FrmGraficos_Load(object sender, EventArgs e)
        {
            string[] series = { "Parque Nacional", "Monumento Nacional", "Reservas Biologicas" };
            int[] puntos = {30, 2, 0 };

            //cambiar colores
            chart1.Palette = ChartColorPalette.SeaGreen;


            chart1.Titles.Add("Mas vendidos");

            for (int i = 0; i < series.Length; i++)
            {

                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades

                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //vectores con los datos
          
        }
    }
}
