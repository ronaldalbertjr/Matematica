using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematica_RonaldAlbert_DanielMarques
{
    public partial class Form1 : Form
    {
        bool alreadyshown1;
        bool alreadyshown2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!alreadyshown1)
            {
                //naturais logaritmos
                for (int i = 1; i <= 10; i++)
                {
                    chart1.Series["Naturais"].Points.AddXY(i, Math.Log(i, 2));
                }
                //inteiros logaritmos
                for (int i = 1; i <= 10; i++)
                {
                    chart1.Series["Inteiros"].Points.AddXY(i, Math.Log(i, 2));
                }
                //reais logaritmos
                for (double i = 1; i <= 10; i += 0.1)
                {
                    chart1.Series["Reais"].Points.AddXY(i, Math.Log(i, 2));
                }
                alreadyshown1 = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Naturais");
            chart1.Series.Add("Inteiros");
            chart1.Series.Add("Reais");
            chart1.Series["Naturais"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["Inteiros"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["Reais"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["Naturais"].BorderWidth = 5;
            chart1.Series["Inteiros"].BorderWidth = 3;
            chart1.Series["Reais"].BorderWidth = 1;
            alreadyshown1 = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!alreadyshown2)
            {
                //naturais  exponencial
                for (int i = 0; i <= 10; i++)
                {
                    chart2.Series["Naturaisexp"].Points.AddXY(i, Math.Pow(2, i));
                }
                //inteiros exponencial
                for (int i = -10; i <= 10; i++)
                {
                    chart2.Series["Inteirosexp"].Points.AddXY(i, Math.Pow(2, i));
                }
                //reais exponencial
                for (double i = -10; i <= 10; i += 0.1)
                {
                    chart2.Series["Reaisexp"].Points.AddXY(i, Math.Pow(2, i));
                }
                alreadyshown2 = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart2.Series.Add("Naturaisexp");
            chart2.Series.Add("Inteirosexp");
            chart2.Series.Add("Reaisexp");
            chart2.Series["Naturaisexp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart2.Series["Inteirosexp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart2.Series["Reaisexp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart2.Series["Naturaisexp"].BorderWidth = 5;
            chart2.Series["Inteirosexp"].BorderWidth = 3;
            chart2.Series["Reaisexp"].BorderWidth = 1;
            alreadyshown2 = false;
        }
    }
}
