
namespace Tyuiu.GalyameevMR.Sprint6.Task1.V7
{
    partial class FormMain_GMR
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
            this.textBox_GMR = new System.Windows.Forms.TextBox();
            this.textBoxStart_GMR = new System.Windows.Forms.TextBox();
            this.textBoxStop_GMR = new System.Windows.Forms.TextBox();
            this.buttonRes_GMR = new System.Windows.Forms.Button();
            this.buttonHelp_GMR = new System.Windows.Forms.Button();
            this.textBoxResult_GMR = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_GMR
            // 
            this.textBox_GMR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_GMR.Location = new System.Drawing.Point(54, 64);
            this.textBox_GMR.Multiline = true;
            this.textBox_GMR.Name = "textBox_GMR";
            this.textBox_GMR.ReadOnly = true;
            this.textBox_GMR.Size = new System.Drawing.Size(365, 213);
            this.textBox_GMR.TabIndex = 1;
            this.textBox_GMR.Text = "Протабулировать функцию\r\n\r\n\r\n\r\nна отрезке [-5; 5]";
            this.textBox_GMR.TextChanged += new System.EventHandler(this.textBox_GMR_TextChanged);
            // 
            // textBoxStart_GMR
            // 
            this.textBoxStart_GMR.Location = new System.Drawing.Point(34, 283);
            this.textBoxStart_GMR.Name = "textBoxStart_GMR";
            this.textBoxStart_GMR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_GMR.TabIndex = 2;
            this.textBoxStart_GMR.TextChanged += new System.EventHandler(this.textBoxStart_GMR_TextChanged);
            // 
            // textBoxStop_GMR
            // 
            this.textBoxStop_GMR.Location = new System.Drawing.Point(173, 283);
            this.textBoxStop_GMR.Name = "textBoxStop_GMR";
            this.textBoxStop_GMR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_GMR.TabIndex = 3;
            this.textBoxStop_GMR.TextChanged += new System.EventHandler(this.textBoxStop_GMR_TextChanged);
            // 
            // buttonRes_GMR
            // 
            this.buttonRes_GMR.BackColor = System.Drawing.Color.Aqua;
            this.buttonRes_GMR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRes_GMR.Location = new System.Drawing.Point(34, 345);
            this.buttonRes_GMR.Name = "buttonRes_GMR";
            this.buttonRes_GMR.Size = new System.Drawing.Size(100, 62);
            this.buttonRes_GMR.TabIndex = 4;
            this.buttonRes_GMR.Text = "Выполнить";
            this.buttonRes_GMR.UseVisualStyleBackColor = false;
            this.buttonRes_GMR.Click += new System.EventHandler(this.buttonRes_GMR_Click);
            // 
            // buttonHelp_GMR
            // 
            this.buttonHelp_GMR.BackColor = System.Drawing.Color.Green;
            this.buttonHelp_GMR.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp_GMR.Location = new System.Drawing.Point(173, 345);
            this.buttonHelp_GMR.Name = "buttonHelp_GMR";
            this.buttonHelp_GMR.Size = new System.Drawing.Size(100, 62);
            this.buttonHelp_GMR.TabIndex = 6;
            this.buttonHelp_GMR.Text = "?";
            this.buttonHelp_GMR.UseVisualStyleBackColor = false;
            this.buttonHelp_GMR.Click += new System.EventHandler(this.buttonHelp_GMR_Click);
            // 
            // textBoxResult_GMR
            // 
            this.textBoxResult_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_GMR.Location = new System.Drawing.Point(446, 125);
            this.textBoxResult_GMR.Multiline = true;
            this.textBoxResult_GMR.Name = "textBoxResult_GMR";
            this.textBoxResult_GMR.Size = new System.Drawing.Size(280, 259);
            this.textBoxResult_GMR.TabIndex = 7;
            this.textBoxResult_GMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResult_GMR.TextChanged += new System.EventHandler(this.textBoxResult_GMR_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(54, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 62);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "                2x - 3      \r\nF(x) = ----------------- + 5\r\n             cos(x) +" +
    " x";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(483, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 24);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Результат:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FormMain_GMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxResult_GMR);
            this.Controls.Add(this.buttonHelp_GMR);
            this.Controls.Add(this.buttonRes_GMR);
            this.Controls.Add(this.textBoxStop_GMR);
            this.Controls.Add(this.textBoxStart_GMR);
            this.Controls.Add(this.textBox_GMR);
            this.Name = "FormMain_GMR";
            this.Text = "Спринт 6 | Таск 1 | Вариант 7 | Галямеев Михаил Русланович";
            this.Load += new System.EventHandler(this.FormMain_GMR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_GMR;
        private System.Windows.Forms.TextBox textBoxStart_GMR;
        private System.Windows.Forms.TextBox textBoxStop_GMR;
        private System.Windows.Forms.Button buttonRes_GMR;
        private System.Windows.Forms.Button buttonHelp_GMR;
        private System.Windows.Forms.TextBox textBoxResult_GMR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

