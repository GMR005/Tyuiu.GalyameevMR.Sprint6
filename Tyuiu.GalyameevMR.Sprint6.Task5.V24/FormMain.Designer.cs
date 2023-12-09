
namespace Tyuiu.GalyameevMR.Sprint6.Task5.V24
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewRes_GMR = new System.Windows.Forms.DataGridView();
            this.buttonRes_GMR = new System.Windows.Forms.Button();
            this.chartFunc_GMR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_GMR = new System.Windows.Forms.Button();
            this.textBoxList_GMR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRes_GMR = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_GMR)).BeginInit();
            this.panelRes_GMR.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRes_GMR
            // 
            this.dataGridViewRes_GMR.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridViewRes_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRes_GMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_GMR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewRes_GMR.Location = new System.Drawing.Point(625, 172);
            this.dataGridViewRes_GMR.Name = "dataGridViewRes_GMR";
            this.dataGridViewRes_GMR.Size = new System.Drawing.Size(142, 150);
            this.dataGridViewRes_GMR.TabIndex = 0;
            // 
            // buttonRes_GMR
            // 
            this.buttonRes_GMR.BackColor = System.Drawing.Color.White;
            this.buttonRes_GMR.Location = new System.Drawing.Point(299, 12);
            this.buttonRes_GMR.Name = "buttonRes_GMR";
            this.buttonRes_GMR.Size = new System.Drawing.Size(232, 80);
            this.buttonRes_GMR.TabIndex = 1;
            this.buttonRes_GMR.Text = "Выполнить";
            this.buttonRes_GMR.UseVisualStyleBackColor = false;
            this.buttonRes_GMR.Click += new System.EventHandler(this.buttonRes_GMR_Click);
            // 
            // chartFunc_GMR
            // 
            this.chartFunc_GMR.BorderlineColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.chartFunc_GMR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunc_GMR.Legends.Add(legend2);
            this.chartFunc_GMR.Location = new System.Drawing.Point(299, 172);
            this.chartFunc_GMR.Name = "chartFunc_GMR";
            this.chartFunc_GMR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "F(X)";
            this.chartFunc_GMR.Series.Add(series2);
            this.chartFunc_GMR.Size = new System.Drawing.Size(320, 254);
            this.chartFunc_GMR.TabIndex = 2;
            this.chartFunc_GMR.Text = "chart1";
            // 
            // buttonHelp_GMR
            // 
            this.buttonHelp_GMR.BackColor = System.Drawing.Color.White;
            this.buttonHelp_GMR.Location = new System.Drawing.Point(582, 12);
            this.buttonHelp_GMR.Name = "buttonHelp_GMR";
            this.buttonHelp_GMR.Size = new System.Drawing.Size(75, 80);
            this.buttonHelp_GMR.TabIndex = 3;
            this.buttonHelp_GMR.Text = "?";
            this.buttonHelp_GMR.UseVisualStyleBackColor = false;
            this.buttonHelp_GMR.Click += new System.EventHandler(this.buttonHelp_GMR_Click);
            // 
            // textBoxList_GMR
            // 
            this.textBoxList_GMR.BackColor = System.Drawing.Color.Lime;
            this.textBoxList_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxList_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxList_GMR.Location = new System.Drawing.Point(23, 2);
            this.textBoxList_GMR.Multiline = true;
            this.textBoxList_GMR.Name = "textBoxList_GMR";
            this.textBoxList_GMR.Size = new System.Drawing.Size(144, 534);
            this.textBoxList_GMR.TabIndex = 4;
            this.textBoxList_GMR.Text = "Дан список чисел \r\n-17\r\n0\r\n12\r\n-14,32\r\n5\r\n-7,84\r\n12,89\r\n-1,57\r\n-3,64\r\n-13,26\r\n-8," +
    "91\r\n-17,77\r\n35\r\n-9\r\n13,83\r\n12,76\r\n8,86\r\n0\r\n-1,49\r\n-7\r\nВывести те, которые равны " +
    "нулю";
            this.textBoxList_GMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Результат:";
            // 
            // panelRes_GMR
            // 
            this.panelRes_GMR.BackColor = System.Drawing.Color.PaleGreen;
            this.panelRes_GMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRes_GMR.Controls.Add(this.label1);
            this.panelRes_GMR.Location = new System.Drawing.Point(225, 98);
            this.panelRes_GMR.Name = "panelRes_GMR";
            this.panelRes_GMR.Size = new System.Drawing.Size(579, 360);
            this.panelRes_GMR.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-34, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 460);
            this.panel1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRes_GMR);
            this.Controls.Add(this.textBoxList_GMR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewRes_GMR);
            this.Controls.Add(this.chartFunc_GMR);
            this.Controls.Add(this.panelRes_GMR);
            this.Controls.Add(this.buttonHelp_GMR);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_GMR)).EndInit();
            this.panelRes_GMR.ResumeLayout(false);
            this.panelRes_GMR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRes_GMR;
        private System.Windows.Forms.Button buttonRes_GMR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_GMR;
        private System.Windows.Forms.Button buttonHelp_GMR;
        private System.Windows.Forms.TextBox textBoxList_GMR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRes_GMR;
        private System.Windows.Forms.Panel panel1;
    }
}

