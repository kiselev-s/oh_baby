
namespace UI_Design
{
    partial class FormMessage
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
            this.panelBackgroundMessage = new System.Windows.Forms.Panel();
            this.labelHide = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelBackgroundButton = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelBackgroundMessage.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panelBackgroundButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackgroundMessage
            // 
            this.panelBackgroundMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelBackgroundMessage.Controls.Add(this.labelHide);
            this.panelBackgroundMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackgroundMessage.Location = new System.Drawing.Point(0, 0);
            this.panelBackgroundMessage.Name = "panelBackgroundMessage";
            this.panelBackgroundMessage.Size = new System.Drawing.Size(126, 41);
            this.panelBackgroundMessage.TabIndex = 11;
            // 
            // labelHide
            // 
            this.labelHide.BackColor = System.Drawing.Color.Transparent;
            this.labelHide.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.labelHide.Location = new System.Drawing.Point(8, 8);
            this.labelHide.Margin = new System.Windows.Forms.Padding(0);
            this.labelHide.Name = "labelHide";
            this.labelHide.Size = new System.Drawing.Size(110, 24);
            this.labelHide.TabIndex = 12;
            this.labelHide.Text = "label1";
            this.labelHide.Click += new System.EventHandler(this.labelHide_Click);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBack.Controls.Add(this.panelBackgroundButton);
            this.panelBack.Controls.Add(this.panelBackgroundMessage);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(128, 82);
            this.panelBack.TabIndex = 12;
            // 
            // panelBackgroundButton
            // 
            this.panelBackgroundButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelBackgroundButton.Controls.Add(this.btnOK);
            this.panelBackgroundButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBackgroundButton.Location = new System.Drawing.Point(0, 39);
            this.panelBackgroundButton.Name = "panelBackgroundButton";
            this.panelBackgroundButton.Size = new System.Drawing.Size(126, 41);
            this.panelBackgroundButton.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnOK.Location = new System.Drawing.Point(27, 8);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 26);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(128, 82);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMessageBox";
            this.panelBackgroundMessage.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.panelBackgroundButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panelBackgroundMessage;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelBackgroundButton;
        private System.Windows.Forms.Label labelHide;
    }
}