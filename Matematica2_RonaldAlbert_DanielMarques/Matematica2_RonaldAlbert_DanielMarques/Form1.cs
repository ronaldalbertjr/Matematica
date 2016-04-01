using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematica2_RonaldAlbert_DanielMarques
{
    public partial class Form1 : Form
    {
        bool alreadyshown = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!alreadyshown)
            {
                for (double i = 1; i <= 100; i++)
                {
                    chart1.Series["Zumbis"].Points.AddXY(i, Math.Log(Math.Pow(i, 4), (5 * Math.Pow(5, 1 / 3))));
                }
                alreadyshown = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Zumbis");
            chart1.Series["Zumbis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["Zumbis"].BorderWidth = 5;
            alreadyshown = false;
        }
    }
}
