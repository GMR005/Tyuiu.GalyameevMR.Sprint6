using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GalyameevMR.Sprint6.Task3.V18.LIb;

namespace Tyuiu.GalyameevMR.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService DataService = new DataService();
        int[,] mtrx = { { -19, -19, 1, 18, 7 }, { 5, 3, -4, -6, -12 }, { -15, 6, 2, 2, -14 }, { -9, -10, 15, -5, -6 }, { -13, -15, -9, 7, 1 } };
        private void buttonRes_GMR_Click(object sender, EventArgs e)
        {

            int[,] restmtrx = DataService.Calculate(mtrx);

            DataGridViewRes_GMR.ColumnCount = 5;
            DataGridViewRes_GMR.RowCount = 5;

            for (int i = 0; i < 5; i++)
            {
                DataGridViewRes_GMR.Columns[i].Width = 60;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    DataGridViewRes_GMR.Rows[i].Cells[j].Value = Convert.ToString(restmtrx[i, j]);
                }
            }
        }

        private void buttonHelp_GMR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-3 ГАлямеев Михаил Русланович", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }
