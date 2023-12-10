using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GalyameevMR.Sprint6.Task6.V28.Lib;

namespace Tyuiu.GalyameevMR.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath = @"C:\visual studio\Sprint6Task6\InPutFileTask6V28.txt";
        DataService DataService = new DataService();
        private void buttonHelp_GMR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFile_GMR_Click(object sender, EventArgs e)
        {
            openFileDialogRes_GMR.ShowDialog();
            openFilePath = openFileDialogRes_GMR.FileName;
            textBoxFileInput_GMR.Text = File.ReadAllText(openFilePath);
            groupBoxRes_GMR.Text = groupBoxRes_GMR.Text + " " + openFileDialogRes_GMR.FileName;
            buttonFile_GMR.Enabled = true;
        }

        private void buttonDone_GMR_Click(object sender, EventArgs e)
        {
            string str = " ";
            textBoxOutput_GMR.Text = DataService.CollectTextFromFile(str, openFilePath);
        }
    }
}
