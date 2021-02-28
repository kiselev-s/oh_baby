
namespace UI_Design
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBaby = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGrowth = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.labelNameChild = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnGrowth);
            this.panel1.Controls.Add(this.btnMed);
            this.panel1.Controls.Add(this.btnDocuments);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 800);
            this.panel1.TabIndex = 0;
            // 
            // btnAddChild
            // 
            this.btnAddChild.FlatAppearance.BorderSize = 0;
            this.btnAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddChild.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnAddChild.Location = new System.Drawing.Point(1474, 0);
            this.btnAddChild.Margin = new System.Windows.Forms.Padding(10, 20, 3, 2);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(126, 150);
            this.btnAddChild.TabIndex = 7;
            this.btnAddChild.Text = "   +      new  baby";
            this.btnAddChild.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            this.btnAddChild.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelNameChild);
            this.panel2.Controls.Add(this.lblBaby);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 150);
            this.panel2.TabIndex = 0;
            // 
            // lblBaby
            // 
            this.lblBaby.AutoSize = true;
            this.lblBaby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBaby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblBaby.Location = new System.Drawing.Point(21, 89);
            this.lblBaby.Name = "lblBaby";
            this.lblBaby.Size = new System.Drawing.Size(0, 20);
            this.lblBaby.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 150);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 80);
            this.pnlNav.TabIndex = 1;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(290, 150);
            this.pnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1310, 650);
            this.pnlFormLoader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblTitle.Location = new System.Drawing.Point(879, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 40);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "= Главная =";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.button1.Image = global::UI_Design.Properties.Resources.automation_48px;
            this.button1.Location = new System.Drawing.Point(0, 640);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = "> Свойства  ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnExit.Image = global::UI_Design.Properties.Resources.exit_64_1px;
            this.btnExit.Location = new System.Drawing.Point(0, 720);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(290, 80);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "> Выход     ";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnGrowth
            // 
            this.btnGrowth.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnGrowth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGrowth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrowth.FlatAppearance.BorderSize = 0;
            this.btnGrowth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrowth.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGrowth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnGrowth.Image = global::UI_Design.Properties.Resources.increase_48px;
            this.btnGrowth.Location = new System.Drawing.Point(0, 390);
            this.btnGrowth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrowth.Name = "btnGrowth";
            this.btnGrowth.Size = new System.Drawing.Size(290, 80);
            this.btnGrowth.TabIndex = 4;
            this.btnGrowth.Text = "> Развитие   ";
            this.btnGrowth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGrowth.UseVisualStyleBackColor = true;
            this.btnGrowth.Click += new System.EventHandler(this.BtnGrowth_Click);
            this.btnGrowth.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // btnMed
            // 
            this.btnMed.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMed.FlatAppearance.BorderSize = 0;
            this.btnMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMed.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnMed.Image = global::UI_Design.Properties.Resources.treatment_64_1px;
            this.btnMed.Location = new System.Drawing.Point(0, 310);
            this.btnMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(290, 80);
            this.btnMed.TabIndex = 3;
            this.btnMed.Text = "> Медицина  ";
            this.btnMed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.BtnMed_Click);
            this.btnMed.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // btnDocuments
            // 
            this.btnDocuments.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnDocuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocuments.FlatAppearance.BorderSize = 0;
            this.btnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDocuments.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnDocuments.Image = global::UI_Design.Properties.Resources.document_64_1px;
            this.btnDocuments.Location = new System.Drawing.Point(0, 230);
            this.btnDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(290, 80);
            this.btnDocuments.TabIndex = 2;
            this.btnDocuments.Text = "> Документы";
            this.btnDocuments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDocuments.UseVisualStyleBackColor = true;
            this.btnDocuments.Click += new System.EventHandler(this.BtnDocuments_Click);
            this.btnDocuments.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnHome.Image = global::UI_Design.Properties.Resources.home_64_1px;
            this.btnHome.Location = new System.Drawing.Point(0, 150);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(290, 80);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "> Главная     ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // labelNameChild
            // 
            this.labelNameChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelNameChild.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelNameChild.Image = global::UI_Design.Properties.Resources.Untitled_3;
            this.labelNameChild.Location = new System.Drawing.Point(92, 102);
            this.labelNameChild.Name = "labelNameChild";
            this.labelNameChild.Size = new System.Drawing.Size(105, 33);
            this.labelNameChild.TabIndex = 3;
            this.labelNameChild.Text = "имя";
            this.labelNameChild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Design.Properties.Resources.babys_room_64px;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(95, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblBaby;
        private System.Windows.Forms.Button btnGrowth;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNameChild;
    }
}

