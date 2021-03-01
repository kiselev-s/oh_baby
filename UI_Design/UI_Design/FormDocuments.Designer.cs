namespace UI_Design
{
    partial class FormDocuments
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddImd = new System.Windows.Forms.Button();
            this.pctrBoxDoc = new System.Windows.Forms.PictureBox();
            this.btnShowImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.comboBox1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 34);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(115, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "название документа";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.button2.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_3;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.Location = new System.Drawing.Point(958, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 70);
            this.button2.TabIndex = 6;
            this.button2.Text = " удалить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.button1.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_3;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.Location = new System.Drawing.Point(630, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = " печать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddImd
            // 
            this.AddImd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AddImd.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_3;
            this.AddImd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddImd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImd.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddImd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AddImd.Location = new System.Drawing.Point(32, 290);
            this.AddImd.Name = "AddImd";
            this.AddImd.Size = new System.Drawing.Size(260, 70);
            this.AddImd.TabIndex = 4;
            this.AddImd.Text = "  хочу добавить    новый документ";
            this.AddImd.UseVisualStyleBackColor = false;
            this.AddImd.Click += new System.EventHandler(this.AddImd_Click);
            // 
            // pctrBoxDoc
            // 
           
            this.pctrBoxDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctrBoxDoc.Location = new System.Drawing.Point(630, 36);
            this.pctrBoxDoc.Name = "pctrBoxDoc";
            this.pctrBoxDoc.Size = new System.Drawing.Size(588, 447);
            this.pctrBoxDoc.TabIndex = 2;
            this.pctrBoxDoc.TabStop = false;
            // 
            // btnShowImg
            // 
            this.btnShowImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowImg.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_3;
            this.btnShowImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowImg.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowImg.Location = new System.Drawing.Point(329, 290);
            this.btnShowImg.Name = "btnShowImg";
            this.btnShowImg.Size = new System.Drawing.Size(260, 70);
            this.btnShowImg.TabIndex = 8;
            this.btnShowImg.Text = "  хочу посмотреть документ";
            this.btnShowImg.UseVisualStyleBackColor = false;
            this.btnShowImg.Click += new System.EventHandler(this.btnShowImg_Click);
            // 
            // FormDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1310, 650);
            this.Controls.Add(this.btnShowImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddImd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pctrBoxDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDocuments";
            this.Text = "FormDocuments";
            this.Load += new System.EventHandler(this.FormDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctrBoxDoc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddImd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowImg;
    }
}