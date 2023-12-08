
namespace Tyuiu.GalyameevMR.Sprint6.Task3.V18
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
            this.buttonRes_GMR = new System.Windows.Forms.Button();
            this.DataGridViewRes_GMR = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHelp_GMR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRes_GMR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRes_GMR
            // 
            this.buttonRes_GMR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRes_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRes_GMR.Location = new System.Drawing.Point(23, 312);
            this.buttonRes_GMR.Name = "buttonRes_GMR";
            this.buttonRes_GMR.Size = new System.Drawing.Size(157, 85);
            this.buttonRes_GMR.TabIndex = 1;
            this.buttonRes_GMR.Text = "Заменить";
            this.buttonRes_GMR.UseVisualStyleBackColor = false;
            this.buttonRes_GMR.Click += new System.EventHandler(this.buttonRes_GMR_Click);
            // 
            // DataGridViewRes_GMR
            // 
            this.DataGridViewRes_GMR.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridViewRes_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewRes_GMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRes_GMR.Location = new System.Drawing.Point(372, 102);
            this.DataGridViewRes_GMR.Name = "DataGridViewRes_GMR";
            this.DataGridViewRes_GMR.RowHeadersVisible = false;
            this.DataGridViewRes_GMR.Size = new System.Drawing.Size(335, 295);
            this.DataGridViewRes_GMR.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(23, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 223);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "В матрице\r\n{-19, -19, 1, 18, 7}\r\n{ 5, 3, -4, -6, -12}\r\n{ -15, 6, 2, 2, -14}\r\n{ -9" +
    ", -10, 15, -5, -6}\r\n{ -13, -15, -9, 7, 1}\r\nзаменить четные элементы 4 строки на " +
    "0\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(403, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат:";
            // 
            // buttonHelp_GMR
            // 
            this.buttonHelp_GMR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonHelp_GMR.Location = new System.Drawing.Point(211, 312);
            this.buttonHelp_GMR.Name = "buttonHelp_GMR";
            this.buttonHelp_GMR.Size = new System.Drawing.Size(81, 85);
            this.buttonHelp_GMR.TabIndex = 5;
            this.buttonHelp_GMR.Text = "?";
            this.buttonHelp_GMR.UseVisualStyleBackColor = false;
            this.buttonHelp_GMR.Click += new System.EventHandler(this.buttonHelp_GMR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_GMR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGridViewRes_GMR);
            this.Controls.Add(this.buttonRes_GMR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | V18 | Галямеев М.Р.";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRes_GMR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRes_GMR;
        private System.Windows.Forms.DataGridView DataGridViewRes_GMR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHelp_GMR;
    }
}

