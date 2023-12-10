
namespace Tyuiu.GalyameevMR.Sprint6.Task6.V28
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxInfo_GMR = new System.Windows.Forms.TextBox();
            this.pictureBox_GMR = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GMR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxInfo_GMR);
            this.panel1.Location = new System.Drawing.Point(107, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 88);
            this.panel1.TabIndex = 0;
            // 
            // textBoxInfo_GMR
            // 
            this.textBoxInfo_GMR.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxInfo_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_GMR.Location = new System.Drawing.Point(3, 15);
            this.textBoxInfo_GMR.Multiline = true;
            this.textBoxInfo_GMR.Name = "textBoxInfo_GMR";
            this.textBoxInfo_GMR.ReadOnly = true;
            this.textBoxInfo_GMR.Size = new System.Drawing.Size(292, 70);
            this.textBoxInfo_GMR.TabIndex = 0;
            this.textBoxInfo_GMR.Text = "Выполнил: \r\nГалямеев Михаил Русланович ПКТб-23-1\r\nСпринт 6 Таск 6 V28 ";
            // 
            // pictureBox_GMR
            // 
            this.pictureBox_GMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_GMR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_GMR.Image")));
            this.pictureBox_GMR.Location = new System.Drawing.Point(12, 37);
            this.pictureBox_GMR.Name = "pictureBox_GMR";
            this.pictureBox_GMR.Size = new System.Drawing.Size(89, 88);
            this.pictureBox_GMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_GMR.TabIndex = 1;
            this.pictureBox_GMR.TabStop = false;
            this.pictureBox_GMR.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(431, 202);
            this.Controls.Add(this.pictureBox_GMR);
            this.Controls.Add(this.panel1);
            this.Name = "FormAbout";
            this.Text = "Подсказка";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GMR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxInfo_GMR;
        private System.Windows.Forms.PictureBox pictureBox_GMR;
    }
}