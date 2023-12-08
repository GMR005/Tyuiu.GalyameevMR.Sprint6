
namespace Tyuiu.GalyameevMR.Sprint6.Task2.V30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DataGridView_GMR = new System.Windows.Forms.DataGridView();
            this.textBoxCond_GMR = new System.Windows.Forms.TextBox();
            this.pictureBox_GMR = new System.Windows.Forms.PictureBox();
            this.buttonRes_GMR = new System.Windows.Forms.Button();
            this.textBoxStart_GMR = new System.Windows.Forms.TextBox();
            this.textBoxStop_GMR = new System.Windows.Forms.TextBox();
            this.labelStart_GMR = new System.Windows.Forms.Label();
            this.labelStop_GMR = new System.Windows.Forms.Label();
            this.chartFunc_GMR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_GMR = new System.Windows.Forms.Button();
            this.Column_GMR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTwo_GMR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_GMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_GMR)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_GMR
            // 
            this.DataGridView_GMR.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView_GMR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView_GMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_GMR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_GMR,
            this.ColumnTwo_GMR});
            this.DataGridView_GMR.Location = new System.Drawing.Point(411, 12);
            this.DataGridView_GMR.Name = "DataGridView_GMR";
            this.DataGridView_GMR.ReadOnly = true;
            this.DataGridView_GMR.Size = new System.Drawing.Size(142, 271);
            this.DataGridView_GMR.TabIndex = 0;
            this.DataGridView_GMR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // textBoxCond_GMR
            // 
            this.textBoxCond_GMR.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCond_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCond_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCond_GMR.Location = new System.Drawing.Point(25, 64);
            this.textBoxCond_GMR.Multiline = true;
            this.textBoxCond_GMR.Name = "textBoxCond_GMR";
            this.textBoxCond_GMR.Size = new System.Drawing.Size(367, 107);
            this.textBoxCond_GMR.TabIndex = 1;
            this.textBoxCond_GMR.Text = "Протабулировать функцию\r\n\r\n\r\n          на отрезке\r\n";
            this.textBoxCond_GMR.TextChanged += new System.EventHandler(this.textBoxCond_GMR_TextChanged);
            // 
            // pictureBox_GMR
            // 
            this.pictureBox_GMR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_GMR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_GMR.Image")));
            this.pictureBox_GMR.Location = new System.Drawing.Point(25, 93);
            this.pictureBox_GMR.Name = "pictureBox_GMR";
            this.pictureBox_GMR.Size = new System.Drawing.Size(292, 39);
            this.pictureBox_GMR.TabIndex = 3;
            this.pictureBox_GMR.TabStop = false;
            // 
            // buttonRes_GMR
            // 
            this.buttonRes_GMR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRes_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRes_GMR.Location = new System.Drawing.Point(25, 230);
            this.buttonRes_GMR.Name = "buttonRes_GMR";
            this.buttonRes_GMR.Size = new System.Drawing.Size(189, 53);
            this.buttonRes_GMR.TabIndex = 4;
            this.buttonRes_GMR.Text = "Выполнить";
            this.buttonRes_GMR.UseVisualStyleBackColor = false;
            this.buttonRes_GMR.Click += new System.EventHandler(this.buttonRes_GMR_Click);
            // 
            // textBoxStart_GMR
            // 
            this.textBoxStart_GMR.Location = new System.Drawing.Point(25, 177);
            this.textBoxStart_GMR.Name = "textBoxStart_GMR";
            this.textBoxStart_GMR.Size = new System.Drawing.Size(86, 20);
            this.textBoxStart_GMR.TabIndex = 5;
            // 
            // textBoxStop_GMR
            // 
            this.textBoxStop_GMR.Location = new System.Drawing.Point(232, 177);
            this.textBoxStop_GMR.Name = "textBoxStop_GMR";
            this.textBoxStop_GMR.Size = new System.Drawing.Size(85, 20);
            this.textBoxStop_GMR.TabIndex = 6;
            // 
            // labelStart_GMR
            // 
            this.labelStart_GMR.AutoSize = true;
            this.labelStart_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart_GMR.Location = new System.Drawing.Point(21, 154);
            this.labelStart_GMR.Name = "labelStart_GMR";
            this.labelStart_GMR.Size = new System.Drawing.Size(30, 20);
            this.labelStart_GMR.TabIndex = 7;
            this.labelStart_GMR.Text = "От";
            // 
            // labelStop_GMR
            // 
            this.labelStop_GMR.AutoSize = true;
            this.labelStop_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStop_GMR.Location = new System.Drawing.Point(228, 151);
            this.labelStop_GMR.Name = "labelStop_GMR";
            this.labelStop_GMR.Size = new System.Drawing.Size(30, 20);
            this.labelStop_GMR.TabIndex = 8;
            this.labelStop_GMR.Text = "До";
            // 
            // chartFunc_GMR
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunc_GMR.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunc_GMR.Legends.Add(legend4);
            this.chartFunc_GMR.Location = new System.Drawing.Point(591, 12);
            this.chartFunc_GMR.Name = "chartFunc_GMR";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "F(X)";
            this.chartFunc_GMR.Series.Add(series4);
            this.chartFunc_GMR.Size = new System.Drawing.Size(444, 285);
            this.chartFunc_GMR.TabIndex = 9;
            this.chartFunc_GMR.Text = "chart1";
            // 
            // buttonHelp_GMR
            // 
            this.buttonHelp_GMR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp_GMR.Location = new System.Drawing.Point(265, 230);
            this.buttonHelp_GMR.Name = "buttonHelp_GMR";
            this.buttonHelp_GMR.Size = new System.Drawing.Size(52, 53);
            this.buttonHelp_GMR.TabIndex = 10;
            this.buttonHelp_GMR.Text = "?";
            this.buttonHelp_GMR.UseVisualStyleBackColor = false;
            this.buttonHelp_GMR.Click += new System.EventHandler(this.buttonHelp_GMR_Click);
            // 
            // Column_GMR
            // 
            this.Column_GMR.HeaderText = "X";
            this.Column_GMR.Name = "Column_GMR";
            this.Column_GMR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column_GMR.ToolTipText = "5";
            this.Column_GMR.Width = 50;
            // 
            // ColumnTwo_GMR
            // 
            this.ColumnTwo_GMR.HeaderText = "F(X)";
            this.ColumnTwo_GMR.Name = "ColumnTwo_GMR";
            this.ColumnTwo_GMR.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 381);
            this.Controls.Add(this.buttonHelp_GMR);
            this.Controls.Add(this.chartFunc_GMR);
            this.Controls.Add(this.labelStop_GMR);
            this.Controls.Add(this.labelStart_GMR);
            this.Controls.Add(this.textBoxStop_GMR);
            this.Controls.Add(this.textBoxStart_GMR);
            this.Controls.Add(this.buttonRes_GMR);
            this.Controls.Add(this.pictureBox_GMR);
            this.Controls.Add(this.textBoxCond_GMR);
            this.Controls.Add(this.DataGridView_GMR);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_GMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_GMR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_GMR;
        private System.Windows.Forms.TextBox textBoxCond_GMR;
        private System.Windows.Forms.PictureBox pictureBox_GMR;
        private System.Windows.Forms.Button buttonRes_GMR;
        private System.Windows.Forms.TextBox textBoxStart_GMR;
        private System.Windows.Forms.TextBox textBoxStop_GMR;
        private System.Windows.Forms.Label labelStart_GMR;
        private System.Windows.Forms.Label labelStop_GMR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_GMR;
        private System.Windows.Forms.Button buttonHelp_GMR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GMR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTwo_GMR;
    }
}

