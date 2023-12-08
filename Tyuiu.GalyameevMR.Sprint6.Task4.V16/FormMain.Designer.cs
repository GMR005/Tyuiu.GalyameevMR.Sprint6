
namespace Tyuiu.GalyameevMR.Sprint6.Task4.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxStart_GMR = new System.Windows.Forms.TextBox();
            this.textBoxStop_GMR = new System.Windows.Forms.TextBox();
            this.chartFunc_GMR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRes_GMR = new System.Windows.Forms.TextBox();
            this.buttonDone_GMR = new System.Windows.Forms.Button();
            this.buttonFile_GMR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFirst_GMR = new System.Windows.Forms.Label();
            this.labelStop_GMR = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRes_GMR = new System.Windows.Forms.Label();
            this.labelStart_GMR = new System.Windows.Forms.Label();
            this.panelFunc_GMR = new System.Windows.Forms.Panel();
            this.buttonFil_GMR = new System.Windows.Forms.Button();
            this.buttonHelp_GMR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFinal_GMR = new System.Windows.Forms.Label();
            this.labelFx_GMR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_GMR)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFunc_GMR.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStart_GMR
            // 
            this.textBoxStart_GMR.Location = new System.Drawing.Point(132, 107);
            this.textBoxStart_GMR.Name = "textBoxStart_GMR";
            this.textBoxStart_GMR.Size = new System.Drawing.Size(107, 20);
            this.textBoxStart_GMR.TabIndex = 0;
            // 
            // textBoxStop_GMR
            // 
            this.textBoxStop_GMR.Location = new System.Drawing.Point(245, 107);
            this.textBoxStop_GMR.Name = "textBoxStop_GMR";
            this.textBoxStop_GMR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_GMR.TabIndex = 1;
            // 
            // chartFunc_GMR
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunc_GMR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunc_GMR.Legends.Add(legend2);
            this.chartFunc_GMR.Location = new System.Drawing.Point(45, 51);
            this.chartFunc_GMR.Name = "chartFunc_GMR";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "F(X)";
            this.chartFunc_GMR.Series.Add(series2);
            this.chartFunc_GMR.Size = new System.Drawing.Size(392, 242);
            this.chartFunc_GMR.TabIndex = 2;
            this.chartFunc_GMR.Text = "chart1";
            // 
            // textBoxRes_GMR
            // 
            this.textBoxRes_GMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxRes_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRes_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_GMR.Location = new System.Drawing.Point(441, 135);
            this.textBoxRes_GMR.Multiline = true;
            this.textBoxRes_GMR.Name = "textBoxRes_GMR";
            this.textBoxRes_GMR.ReadOnly = true;
            this.textBoxRes_GMR.Size = new System.Drawing.Size(133, 281);
            this.textBoxRes_GMR.TabIndex = 3;
            this.textBoxRes_GMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDone_GMR
            // 
            this.buttonDone_GMR.BackColor = System.Drawing.Color.Yellow;
            this.buttonDone_GMR.Location = new System.Drawing.Point(30, 159);
            this.buttonDone_GMR.Name = "buttonDone_GMR";
            this.buttonDone_GMR.Size = new System.Drawing.Size(162, 71);
            this.buttonDone_GMR.TabIndex = 4;
            this.buttonDone_GMR.UseVisualStyleBackColor = false;
            this.buttonDone_GMR.Click += new System.EventHandler(this.buttonDone_GMR_Click);
            // 
            // buttonFile_GMR
            // 
            this.buttonFile_GMR.Location = new System.Drawing.Point(753, 278);
            this.buttonFile_GMR.Name = "buttonFile_GMR";
            this.buttonFile_GMR.Size = new System.Drawing.Size(162, 70);
            this.buttonFile_GMR.TabIndex = 5;
            this.buttonFile_GMR.UseVisualStyleBackColor = true;
            this.buttonFile_GMR.Click += new System.EventHandler(this.buttonFile_GMR_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.labelFirst_GMR);
            this.panel1.Controls.Add(this.labelStop_GMR);
            this.panel1.Controls.Add(this.textBoxStart_GMR);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelRes_GMR);
            this.panel1.Controls.Add(this.textBoxStop_GMR);
            this.panel1.Controls.Add(this.labelStart_GMR);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 129);
            this.panel1.TabIndex = 6;
            // 
            // labelFirst_GMR
            // 
            this.labelFirst_GMR.AutoSize = true;
            this.labelFirst_GMR.Location = new System.Drawing.Point(132, 91);
            this.labelFirst_GMR.Name = "labelFirst_GMR";
            this.labelFirst_GMR.Size = new System.Drawing.Size(20, 13);
            this.labelFirst_GMR.TabIndex = 10;
            this.labelFirst_GMR.Text = "От";
            // 
            // labelStop_GMR
            // 
            this.labelStop_GMR.AutoSize = true;
            this.labelStop_GMR.Location = new System.Drawing.Point(242, 91);
            this.labelStop_GMR.Name = "labelStop_GMR";
            this.labelStop_GMR.Size = new System.Drawing.Size(25, 13);
            this.labelStop_GMR.TabIndex = 7;
            this.labelStop_GMR.Text = "До:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 42);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelRes_GMR
            // 
            this.labelRes_GMR.AutoSize = true;
            this.labelRes_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes_GMR.Location = new System.Drawing.Point(31, 11);
            this.labelRes_GMR.Name = "labelRes_GMR";
            this.labelRes_GMR.Size = new System.Drawing.Size(190, 112);
            this.labelRes_GMR.TabIndex = 9;
            this.labelRes_GMR.Text = "Протабулировать функцию\r\n\r\n\r\n\r\n\r\n\r\n на отрезке";
            // 
            // labelStart_GMR
            // 
            this.labelStart_GMR.AutoSize = true;
            this.labelStart_GMR.Location = new System.Drawing.Point(129, 91);
            this.labelStart_GMR.Name = "labelStart_GMR";
            this.labelStart_GMR.Size = new System.Drawing.Size(23, 13);
            this.labelStart_GMR.TabIndex = 6;
            this.labelStart_GMR.Text = "От:";
            // 
            // panelFunc_GMR
            // 
            this.panelFunc_GMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelFunc_GMR.Controls.Add(this.chartFunc_GMR);
            this.panelFunc_GMR.Location = new System.Drawing.Point(555, 65);
            this.panelFunc_GMR.Name = "panelFunc_GMR";
            this.panelFunc_GMR.Size = new System.Drawing.Size(440, 373);
            this.panelFunc_GMR.TabIndex = 7;
            // 
            // buttonFil_GMR
            // 
            this.buttonFil_GMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFil_GMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFil_GMR.Location = new System.Drawing.Point(245, 159);
            this.buttonFil_GMR.Name = "buttonFil_GMR";
            this.buttonFil_GMR.Size = new System.Drawing.Size(162, 70);
            this.buttonFil_GMR.TabIndex = 8;
            this.buttonFil_GMR.UseVisualStyleBackColor = false;
            this.buttonFil_GMR.Click += new System.EventHandler(this.buttonFile_GMR_Click);
            // 
            // buttonHelp_GMR
            // 
            this.buttonHelp_GMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonHelp_GMR.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_GMR.Location = new System.Drawing.Point(164, 291);
            this.buttonHelp_GMR.Name = "buttonHelp_GMR";
            this.buttonHelp_GMR.Size = new System.Drawing.Size(114, 95);
            this.buttonHelp_GMR.TabIndex = 9;
            this.buttonHelp_GMR.UseVisualStyleBackColor = false;
            this.buttonHelp_GMR.Click += new System.EventHandler(this.buttonHelp_GMR_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(21, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 301);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // labelFinal_GMR
            // 
            this.labelFinal_GMR.AutoSize = true;
            this.labelFinal_GMR.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinal_GMR.Location = new System.Drawing.Point(488, 9);
            this.labelFinal_GMR.Name = "labelFinal_GMR";
            this.labelFinal_GMR.Size = new System.Drawing.Size(191, 42);
            this.labelFinal_GMR.TabIndex = 11;
            this.labelFinal_GMR.Text = "Результат:";
            // 
            // labelFx_GMR
            // 
            this.labelFx_GMR.AutoSize = true;
            this.labelFx_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFx_GMR.Location = new System.Drawing.Point(492, 116);
            this.labelFx_GMR.Name = "labelFx_GMR";
            this.labelFx_GMR.Size = new System.Drawing.Size(36, 16);
            this.labelFx_GMR.TabIndex = 12;
            this.labelFx_GMR.Text = "F(X)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.labelFx_GMR);
            this.Controls.Add(this.textBoxRes_GMR);
            this.Controls.Add(this.labelFinal_GMR);
            this.Controls.Add(this.buttonHelp_GMR);
            this.Controls.Add(this.panelFunc_GMR);
            this.Controls.Add(this.buttonFil_GMR);
            this.Controls.Add(this.buttonFile_GMR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDone_GMR);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_GMR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFunc_GMR.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStart_GMR;
        private System.Windows.Forms.TextBox textBoxStop_GMR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_GMR;
        private System.Windows.Forms.TextBox textBoxRes_GMR;
        private System.Windows.Forms.Button buttonDone_GMR;
        private System.Windows.Forms.Button buttonFile_GMR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStop_GMR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRes_GMR;
        private System.Windows.Forms.Label labelStart_GMR;
        private System.Windows.Forms.Panel panelFunc_GMR;
        private System.Windows.Forms.Label labelFirst_GMR;
        private System.Windows.Forms.Button buttonFil_GMR;
        private System.Windows.Forms.Button buttonHelp_GMR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFinal_GMR;
        private System.Windows.Forms.Label labelFx_GMR;
    }
}

