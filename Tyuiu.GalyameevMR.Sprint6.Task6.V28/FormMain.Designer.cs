
namespace Tyuiu.GalyameevMR.Sprint6.Task6.V28
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_GMR = new System.Windows.Forms.Button();
            this.openFileDialogRes_GMR = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxRes_GMR = new System.Windows.Forms.GroupBox();
            this.buttonFile_GMR = new System.Windows.Forms.Button();
            this.textBoxFileInput_GMR = new System.Windows.Forms.TextBox();
            this.buttonDone_GMR = new System.Windows.Forms.Button();
            this.textBoxOutput_GMR = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_GMR = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipHelp_GMR = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxRes_GMR.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTask_GMR.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_GMR
            // 
            this.buttonHelp_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_GMR.Location = new System.Drawing.Point(642, 3);
            this.buttonHelp_GMR.Name = "buttonHelp_GMR";
            this.buttonHelp_GMR.Size = new System.Drawing.Size(133, 60);
            this.buttonHelp_GMR.TabIndex = 0;
            this.buttonHelp_GMR.Text = "?";
            this.buttonHelp_GMR.UseVisualStyleBackColor = true;
            this.buttonHelp_GMR.Click += new System.EventHandler(this.buttonHelp_GMR_Click);
            // 
            // openFileDialogRes_GMR
            // 
            this.openFileDialogRes_GMR.FileName = "openFileDialog1";
            // 
            // groupBoxRes_GMR
            // 
            this.groupBoxRes_GMR.Controls.Add(this.textBoxFileInput_GMR);
            this.groupBoxRes_GMR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxRes_GMR.Location = new System.Drawing.Point(12, 130);
            this.groupBoxRes_GMR.Name = "groupBoxRes_GMR";
            this.groupBoxRes_GMR.Size = new System.Drawing.Size(371, 293);
            this.groupBoxRes_GMR.TabIndex = 1;
            this.groupBoxRes_GMR.TabStop = false;
            this.groupBoxRes_GMR.Text = "Имя файла: ";
            // 
            // buttonFile_GMR
            // 
            this.buttonFile_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFile_GMR.Location = new System.Drawing.Point(12, 3);
            this.buttonFile_GMR.Name = "buttonFile_GMR";
            this.buttonFile_GMR.Size = new System.Drawing.Size(174, 60);
            this.buttonFile_GMR.TabIndex = 2;
            this.buttonFile_GMR.Text = "Открыть файл";
            this.toolTipHelp_GMR.SetToolTip(this.buttonFile_GMR, "Выберите необходимый файл\r\n");
            this.buttonFile_GMR.UseVisualStyleBackColor = true;
            this.buttonFile_GMR.Click += new System.EventHandler(this.buttonFile_GMR_Click);
            // 
            // textBoxFileInput_GMR
            // 
            this.textBoxFileInput_GMR.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFileInput_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFileInput_GMR.Location = new System.Drawing.Point(9, 19);
            this.textBoxFileInput_GMR.Multiline = true;
            this.textBoxFileInput_GMR.Name = "textBoxFileInput_GMR";
            this.textBoxFileInput_GMR.Size = new System.Drawing.Size(350, 252);
            this.textBoxFileInput_GMR.TabIndex = 3;
            // 
            // buttonDone_GMR
            // 
            this.buttonDone_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_GMR.Location = new System.Drawing.Point(220, 3);
            this.buttonDone_GMR.Name = "buttonDone_GMR";
            this.buttonDone_GMR.Size = new System.Drawing.Size(163, 60);
            this.buttonDone_GMR.TabIndex = 4;
            this.buttonDone_GMR.Text = "Вывести";
            this.buttonDone_GMR.UseVisualStyleBackColor = true;
            this.buttonDone_GMR.Click += new System.EventHandler(this.buttonDone_GMR_Click);
            // 
            // textBoxOutput_GMR
            // 
            this.textBoxOutput_GMR.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOutput_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput_GMR.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutput_GMR.Multiline = true;
            this.textBoxOutput_GMR.Name = "textBoxOutput_GMR";
            this.textBoxOutput_GMR.Size = new System.Drawing.Size(357, 268);
            this.textBoxOutput_GMR.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOutput_GMR);
            this.groupBox1.Location = new System.Drawing.Point(406, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 293);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат:";
            // 
            // groupBoxTask_GMR
            // 
            this.groupBoxTask_GMR.Controls.Add(this.label1);
            this.groupBoxTask_GMR.Location = new System.Drawing.Point(12, 69);
            this.groupBoxTask_GMR.Name = "groupBoxTask_GMR";
            this.groupBoxTask_GMR.Size = new System.Drawing.Size(763, 55);
            this.groupBoxTask_GMR.TabIndex = 7;
            this.groupBoxTask_GMR.TabStop = false;
            this.groupBoxTask_GMR.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTask_GMR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDone_GMR);
            this.Controls.Add(this.buttonFile_GMR);
            this.Controls.Add(this.groupBoxRes_GMR);
            this.Controls.Add(this.buttonHelp_GMR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | V28 | Галямеев М.P.";
            this.groupBoxRes_GMR.ResumeLayout(false);
            this.groupBoxRes_GMR.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTask_GMR.ResumeLayout(false);
            this.groupBoxTask_GMR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_GMR;
        private System.Windows.Forms.OpenFileDialog openFileDialogRes_GMR;
        private System.Windows.Forms.GroupBox groupBoxRes_GMR;
        private System.Windows.Forms.Button buttonFile_GMR;
        private System.Windows.Forms.TextBox textBoxFileInput_GMR;
        private System.Windows.Forms.Button buttonDone_GMR;
        private System.Windows.Forms.TextBox textBoxOutput_GMR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTipHelp_GMR;
        private System.Windows.Forms.GroupBox groupBoxTask_GMR;
        private System.Windows.Forms.Label label1;
    }
}

