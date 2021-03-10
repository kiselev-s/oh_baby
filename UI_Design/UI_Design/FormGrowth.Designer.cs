
namespace UI_Design
{
    partial class FormGrowth
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
            this.panelG = new System.Windows.Forms.Panel();
            this.crtsnChrtDiagramm = new LiveCharts.WinForms.CartesianChart();
            this.cmbBoxYear = new System.Windows.Forms.ComboBox();
            this.txtBoxGr = new System.Windows.Forms.TextBox();
            this.txtBoxWght = new System.Windows.Forms.TextBox();
            this.btnBild = new System.Windows.Forms.Button();
            this.rdBtnMnth = new System.Windows.Forms.RadioButton();
            this.rdBtnYr = new System.Windows.Forms.RadioButton();
            this.cmbBoxMonth = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGr = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panelG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelG
            // 
            this.panelG.Controls.Add(this.crtsnChrtDiagramm);
            this.panelG.Location = new System.Drawing.Point(102, 173);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(1000, 400);
            this.panelG.TabIndex = 0;
            // 
            // crtsnChrtDiagramm
            // 
            this.crtsnChrtDiagramm.Location = new System.Drawing.Point(273, 121);
            this.crtsnChrtDiagramm.Name = "crtsnChrtDiagramm";
            this.crtsnChrtDiagramm.Size = new System.Drawing.Size(460, 208);
            this.crtsnChrtDiagramm.TabIndex = 0;
            this.crtsnChrtDiagramm.Text = "cartesianChart1";
            // 
            // cmbBoxYear
            // 
            this.cmbBoxYear.FormattingEnabled = true;
            this.cmbBoxYear.Location = new System.Drawing.Point(283, 36);
            this.cmbBoxYear.Name = "cmbBoxYear";
            this.cmbBoxYear.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxYear.TabIndex = 2;
            this.cmbBoxYear.Text = "лет";
            // 
            // txtBoxGr
            // 
            this.txtBoxGr.Location = new System.Drawing.Point(692, 35);
            this.txtBoxGr.Name = "txtBoxGr";
            this.txtBoxGr.Size = new System.Drawing.Size(100, 22);
            this.txtBoxGr.TabIndex = 4;
            // 
            // txtBoxWght
            // 
            this.txtBoxWght.Location = new System.Drawing.Point(999, 38);
            this.txtBoxWght.Name = "txtBoxWght";
            this.txtBoxWght.Size = new System.Drawing.Size(100, 22);
            this.txtBoxWght.TabIndex = 6;
            // 
            // btnBild
            // 
            this.btnBild.Location = new System.Drawing.Point(520, 121);
            this.btnBild.Name = "btnBild";
            this.btnBild.Size = new System.Drawing.Size(176, 46);
            this.btnBild.TabIndex = 7;
            this.btnBild.Text = "Построить диаграмму";
            this.btnBild.UseVisualStyleBackColor = true;
            this.btnBild.Click += new System.EventHandler(this.btnBild_Click);
            // 
            // rdBtnMnth
            // 
            this.rdBtnMnth.AutoSize = true;
            this.rdBtnMnth.Location = new System.Drawing.Point(408, 134);
            this.rdBtnMnth.Name = "rdBtnMnth";
            this.rdBtnMnth.Size = new System.Drawing.Size(81, 21);
            this.rdBtnMnth.TabIndex = 8;
            this.rdBtnMnth.TabStop = true;
            this.rdBtnMnth.Text = "До года";
            this.rdBtnMnth.UseVisualStyleBackColor = true;
            // 
            // rdBtnYr
            // 
            this.rdBtnYr.AutoSize = true;
            this.rdBtnYr.Location = new System.Drawing.Point(732, 134);
            this.rdBtnYr.Name = "rdBtnYr";
            this.rdBtnYr.Size = new System.Drawing.Size(103, 21);
            this.rdBtnYr.TabIndex = 9;
            this.rdBtnYr.TabStop = true;
            this.rdBtnYr.Text = "После года";
            this.rdBtnYr.UseVisualStyleBackColor = true;
            // 
            // cmbBoxMonth
            // 
            this.cmbBoxMonth.FormattingEnabled = true;
            this.cmbBoxMonth.Location = new System.Drawing.Point(422, 35);
            this.cmbBoxMonth.Name = "cmbBoxMonth";
            this.cmbBoxMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxMonth.TabIndex = 11;
            this.cmbBoxMonth.Text = "месяцев";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(201, 39);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(62, 17);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Возраст";
            // 
            // lblGr
            // 
            this.lblGr.AutoSize = true;
            this.lblGr.Location = new System.Drawing.Point(634, 38);
            this.lblGr.Name = "lblGr";
            this.lblGr.Size = new System.Drawing.Size(39, 17);
            this.lblGr.TabIndex = 13;
            this.lblGr.Text = "Рост";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(927, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(32, 17);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Вес";
            // 
            // FormGrowth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1309, 630);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblGr);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.cmbBoxMonth);
            this.Controls.Add(this.rdBtnYr);
            this.Controls.Add(this.rdBtnMnth);
            this.Controls.Add(this.btnBild);
            this.Controls.Add(this.txtBoxWght);
            this.Controls.Add(this.txtBoxGr);
            this.Controls.Add(this.cmbBoxYear);
            this.Controls.Add(this.panelG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGrowth";
            this.Text = "FormGrowht";
            this.Load += new System.EventHandler(this.FormGrowth_Load);
            this.panelG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelG;
        private LiveCharts.WinForms.CartesianChart crtsnChrtDiagramm;
        private System.Windows.Forms.ComboBox cmbBoxYear;
        private System.Windows.Forms.TextBox txtBoxGr;
        private System.Windows.Forms.TextBox txtBoxWght;
        private System.Windows.Forms.Button btnBild;
        private System.Windows.Forms.RadioButton rdBtnMnth;
        private System.Windows.Forms.RadioButton rdBtnYr;
        private System.Windows.Forms.ComboBox cmbBoxMonth;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGr;
        private System.Windows.Forms.Label lbl;
    }
}