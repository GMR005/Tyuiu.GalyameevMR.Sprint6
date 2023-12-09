using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GalyameevMR.Sprint6.Task5.V24.Lib;

namespace Tyuiu.GalyameevMR.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService DataService = new DataService();
        string path = @"C:\visual studio\Sprint6Task5\InPutFileTask5V24.txt";
        private void buttonRes_GMR_Click(object sender, EventArgs e)
        {
            dataGridViewRes_GMR.ColumnCount = 2;
            dataGridViewRes_GMR.Columns[0].Width = 25;
            dataGridViewRes_GMR.Columns[1].Width = 35;
            dataGridViewRes_GMR.RowHeadersVisible = false;
            dataGridViewRes_GMR.Columns[0].HeaderText = "X";
            dataGridViewRes_GMR.Columns[1].HeaderText = "F(X)";
            this.chartFunc_GMR.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunc_GMR.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartFunc_GMR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;

            chartFunc_GMR.Series[0].Points.Clear();
            int len = DataService.LoadFromDataFile(path).Length;
            double[] numsMass = new double[len];
            numsMass = DataService.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes_GMR.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunc_GMR.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
            private void buttonHelp_GMR_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-1 Галямеев Михаил Русланович", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


    }
}
