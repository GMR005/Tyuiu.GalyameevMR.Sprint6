using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GalyameevMR.Sprint6.Task0.V22.Lib;

namespace Tyuiu.GalyameevMR.Sprint6.Task0.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRes_GMR_Click(object sender, EventArgs e)
        {
            DataService DataService = new DataService();
            try
            {
                textBoxValue_GMR.Text = Convert.ToString(DataService.Calculate(Convert.ToInt32(textBoxVarX_GMR.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_GMR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) 
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_GMR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТБ-23-1 Галямеев Михаил Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
