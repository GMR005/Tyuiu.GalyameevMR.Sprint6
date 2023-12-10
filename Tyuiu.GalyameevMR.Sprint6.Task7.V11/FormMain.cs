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
using Tyuiu.GalyameevMR.Sprint6.Task7.V11.Lib;

namespace Tyuiu.GalyameevMR.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogMtrx_GMR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMtrx_GMR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonSave_GMR_Click(object sender, EventArgs e)
        {
            saveFileDialogMtrx_GMR.FileName = "OutPutFileTask7.csv";
            saveFileDialogMtrx_GMR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMtrx_GMR.ShowDialog();

            string path = saveFileDialogMtrx_GMR.FileName;
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutPut_GMR.RowCount;
            int columns = dataGridViewOutPut_GMR.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_GMR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_GMR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonFile_GMR_Click(object sender, EventArgs e)
        {
            openFileDialogMtrx_GMR.ShowDialog();
            openFilePath = openFileDialogMtrx_GMR.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInp_GMR.ColumnCount = columns;
            dataGridViewInp_GMR.RowCount = rows;
            dataGridViewOutPut_GMR.ColumnCount = columns;
            dataGridViewOutPut_GMR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInp_GMR.Columns[i].Width = 25;
                dataGridViewOutPut_GMR.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInp_GMR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonSave_GMR.Enabled = true;
        }

        private void buttonRes_GMR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_GMR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_GMR.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInp_GMR.ColumnCount = 50;
            dataGridViewOutPut_GMR.ColumnCount = 50;

            dataGridViewInp_GMR.RowCount = 50;
            dataGridViewOutPut_GMR.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInp_GMR.Columns[i].Width = 25;
                dataGridViewOutPut_GMR.Columns[i].Width = 25;
            }
        }



        private void buttonHelp_GMR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

     
    }
}