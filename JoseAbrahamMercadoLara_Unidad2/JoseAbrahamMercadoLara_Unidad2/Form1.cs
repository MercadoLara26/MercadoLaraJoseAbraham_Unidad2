using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace JoseAbrahamMercadoLara_Unidad2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Thread Hilo1;
        Thread Hilo2;

        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int numeroRandom = rn.Next(1, 100);
            int x = numeroRandom;
            int y = 100 - numeroRandom;

            if (chart2.InvokeRequired)
            {
                chart2.Invoke(new MethodInvoker(delegate
                {
                    chart2.Series.Clear();
                    chart2.BackColor = Color.Transparent;
                    Series serie1 = new Series
                    {
                        Name = "Grados",
                        IsVisibleInLegend = false,
                        Color = System.Drawing.Color.Green,
                        ChartType = SeriesChartType.Pie
                    };

                    chart2.Series.Add(serie1);
                    serie1.Points.Add(x);
                    serie1.Points.Add(y);
                }));
            }
            else
            {
                chart2.Series.Clear();
                chart2.BackColor = Color.Transparent;
                Series serie1 = new Series
                {
                    Name = "Grados",
                    IsVisibleInLegend = false,
                    Color = System.Drawing.Color.Green,
                    ChartType = SeriesChartType.Pie
                };

                chart2.Series.Add(serie1);
                serie1.Points.Add(x);
                serie1.Points.Add(y);
            }

            if (lblActualizacion2.InvokeRequired)
            {
                lblActualizacion2.Invoke(new MethodInvoker(delegate
                {
                    lblActualizacion2.Text = DateTime.Now.ToString();
                }));
            }
            else
            {
                lblActualizacion2.Text = DateTime.Now.ToString();
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
