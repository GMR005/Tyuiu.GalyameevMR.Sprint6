
using System;

namespace Tyuiu.GalyameevMR.Sprint6.Task0.V22
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
            this.textBoxVarX_GMR = new System.Windows.Forms.TextBox();
            this.buttonHelp_GMR = new System.Windows.Forms.TextBox();
            this.pictureImage_GMR = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxValue_GMR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage_GMR)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVarX_GMR
            // 
            this.textBoxVarX_GMR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxVarX_GMR.Location = new System.Drawing.Point(12, 203);
            this.textBoxVarX_GMR.Name = "textBoxVarX_GMR";
            this.textBoxVarX_GMR.Size = new System.Drawing.Size(91, 20);
            this.textBoxVarX_GMR.TabIndex = 1;
            this.textBoxVarX_GMR.TextChanged += new System.EventHandler(this.buttonRes_GMR_Click);
            this.textBoxVarX_GMR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_GMR_KeyPress);
            // 
            // buttonHelp_GMR
            // 
            this.buttonHelp_GMR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp_GMR.Location = new System.Drawing.Point(266, 239);
            this.buttonHelp_GMR.Name = "buttonHelp_GMR";
            this.buttonHelp_GMR.ReadOnly = true;
            this.buttonHelp_GMR.Size = new System.Drawing.Size(24, 20);
            this.buttonHelp_GMR.TabIndex = 2;
            this.buttonHelp_GMR.Text = "?"; 
            this.buttonHelp_GMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonHelp_GMR.TextChanged += new System.EventHandler(this.buttonRes_GMR_Click);
            this.buttonHelp_GMR.DoubleClick += new System.EventHandler(this.buttonHelp_GMR_Click);
            // 
            // pictureImage_GMR
            // 
            this.pictureImage_GMR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureImage_GMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureImage_GMR.Image = ((System.Drawing.Image)(resources.GetObject("pictureImage_GMR.Image")));
            this.pictureImage_GMR.Location = new System.Drawing.Point(29, 78);
            this.pictureImage_GMR.Name = "pictureImage_GMR";
            this.pictureImage_GMR.Size = new System.Drawing.Size(136, 51);
            this.pictureImage_GMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImage_GMR.TabIndex = 3;
            this.pictureImage_GMR.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 153);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Условие:\r\n\r\nВычислить выражение по формуле:";
            this.textBox1.TextChanged += new System.EventHandler(this.buttonRes_GMR_Click);
            // 
            // textBoxValue_GMR
            // 
            this.textBoxValue_GMR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxValue_GMR.Location = new System.Drawing.Point(158, 203);
            this.textBoxValue_GMR.Name = "textBoxValue_GMR";
            this.textBoxValue_GMR.ReadOnly = true;
            this.textBoxValue_GMR.Size = new System.Drawing.Size(96, 20);
            this.textBoxValue_GMR.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ввод данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вывод данных";
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(293, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValue_GMR);
            this.Controls.Add(this.pictureImage_GMR);
            this.Controls.Add(this.buttonHelp_GMR);
            this.Controls.Add(this.textBoxVarX_GMR);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 22 | Галямеев Михаил Русланович ПКтб-23-1 ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage_GMR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox textBoxVarX_GMR;
        private System.Windows.Forms.TextBox buttonHelp_GMR;
        private System.Windows.Forms.PictureBox pictureImage_GMR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxValue_GMR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

