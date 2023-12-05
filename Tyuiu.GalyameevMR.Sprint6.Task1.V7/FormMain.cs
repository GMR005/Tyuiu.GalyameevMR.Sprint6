using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GalyameevMR.Sprint6.Task1.V7.Lib;

namespace Tyuiu.GalyameevMR.Sprint6.Task1.V7
{
    public partial class FormMain_GMR : Form
    {
        public FormMain_GMR()
        {
            InitializeComponent();
        }
        DataService DataService = new DataService();
        private void FormMain_GMR_Load(object sender, EventArgs e) { }

        private void textBox_GMR_TextChanged(object sender, EventArgs e) { }

        private void pictureBoxGMR_Click(object sender, EventArgs e) { }

        private void textBoxStart_GMR_TextChanged(object sender, EventArgs e) { }

        private void textBoxStop_GMR_TextChanged(object sender, EventArgs e) { }

        private void buttonHelp_GMR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТБ-23-1 Галямеев Михаил Русланович", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonRes_GMR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_GMR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_GMR.Text);

                string strLine;

                int len = DataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = DataService.GetMassFunction(startStep, stopStep);
                textBoxResult_GMR.Text = "";
                textBoxResult_GMR.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_GMR.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_GMR.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}     |   {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_GMR.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_GMR.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxResult_GMR_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}