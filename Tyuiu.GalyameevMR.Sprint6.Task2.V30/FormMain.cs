using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint6.Task2.V30.Lib;
using System.Windows.Forms;

namespace Tyuiu.GalyameevMR.Sprint6.Task2.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxCond_GMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRes_GMR_Click(object sender, EventArgs e)
        {
            try
            {
                DataService DataService = new DataService();
                int startStep = Convert.ToInt32(textBoxStart_GMR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_GMR.Text);
                double[] array = DataService.GetMassFunction(startStep, stopStep);
                this.chartFunc_GMR.Titles.Add("(5 * x + 2.5) / (Sin(x) + 3)) + 2 * x + Cos(x)");

                this.chartFunc_GMR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_GMR.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    this.DataGridView_GMR.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));
                    this.chartFunc_GMR.Series[0].Points.AddXY(startStep, array[i]);
                    
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_GMR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-1 Галямеев Михаил Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
