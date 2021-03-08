
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
            this.crtChartG = new LiveCharts.WinForms.CartesianChart();
            this.panelG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelG
            // 
            this.panelG.Controls.Add(this.crtChartG);
            this.panelG.Location = new System.Drawing.Point(132, 288);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(600, 300);
            this.panelG.TabIndex = 0;
            // 
            // crtChartG
            // 
            this.crtChartG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtChartG.Location = new System.Drawing.Point(0, 0);
            this.crtChartG.Name = "crtChartG";
            this.crtChartG.Size = new System.Drawing.Size(600, 300);
            this.crtChartG.TabIndex = 0;
            this.crtChartG.Text = "cartesianChart1";
            // 
            // FormGrowth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1310, 650);
            this.Controls.Add(this.panelG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGrowth";
            this.Text = "FormGrowht";
            this.panelG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelG;
        private LiveCharts.WinForms.CartesianChart crtChartG;
    }
}