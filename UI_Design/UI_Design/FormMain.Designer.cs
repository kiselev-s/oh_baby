
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTmp = new System.Windows.Forms.Label();
            this.lblBaby = new System.Windows.Forms.Label();
            this.cmbBoxNameChild = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnGrowth = new System.Windows.Forms.Button();
            this.BtnMed = new System.Windows.Forms.Button();
            this.BtnDocuments = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnGrowth);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.BtnMed);
            this.panel1.Controls.Add(this.BtnDocuments);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 650);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 160);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 65);
            this.pnlNav.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTmp);
            this.panel2.Controls.Add(this.lblBaby);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.cmbBoxNameChild);
            this.panel2.Controls.Add(this.btnAddChild);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 160);
            this.panel2.TabIndex = 0;
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblTmp.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTmp.Location = new System.Drawing.Point(54, 139);
            this.lblTmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(117, 21);
            this.lblTmp.TabIndex = 9;
            this.lblTmp.Text = "label_Temp";
            this.lblTmp.Visible = false;
            // 
            // lblBaby
            // 
            this.lblBaby.AutoSize = true;
            this.lblBaby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBaby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblBaby.Location = new System.Drawing.Point(12, 58);
            this.lblBaby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaby.Name = "lblBaby";
            this.lblBaby.Size = new System.Drawing.Size(0, 17);
            this.lblBaby.TabIndex = 1;
            // 
            // cmbBoxNameChild
            // 
            this.cmbBoxNameChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.cmbBoxNameChild.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBoxNameChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbBoxNameChild.FormattingEnabled = true;
            this.cmbBoxNameChild.Location = new System.Drawing.Point(53, 107);
            this.cmbBoxNameChild.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxNameChild.Name = "cmbBoxNameChild";
            this.cmbBoxNameChild.Size = new System.Drawing.Size(109, 28);
            this.cmbBoxNameChild.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.cmbBoxNameChild, "Выберете ребенка для просмотра его данных");
            this.cmbBoxNameChild.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNameChild_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblTitle.Location = new System.Drawing.Point(611, 81);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "> Главная <";
            // 
            // toolTipMain
            // 
            this.toolTipMain.AutomaticDelay = 100;
            this.toolTipMain.AutoPopDelay = 5000;
            this.toolTipMain.InitialDelay = 100;
            this.toolTipMain.ReshowDelay = 20;
            this.toolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(218, 137);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(982, 512);
            this.pnlFormLoader.TabIndex = 11;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogo.Image = global::UI_Design.Properties.Resources.logo4;
            this.lblLogo.Location = new System.Drawing.Point(218, 0);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(982, 77);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSettings.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnSettings.Image = global::UI_Design.Properties.Resources.automation_48px;
            this.BtnSettings.Location = new System.Drawing.Point(0, 520);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(218, 65);
            this.BtnSettings.TabIndex = 8;
            this.BtnSettings.Text = "> Свойства  ";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click_1);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnExit.Image = global::UI_Design.Properties.Resources.exit_64_1px;
            this.BtnExit.Location = new System.Drawing.Point(0, 585);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(218, 65);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "> Выход     ";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnGrowth
            // 
            this.BtnGrowth.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnGrowth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGrowth.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGrowth.FlatAppearance.BorderSize = 0;
            this.BtnGrowth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGrowth.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGrowth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnGrowth.Image = global::UI_Design.Properties.Resources.increase_48px;
            this.BtnGrowth.Location = new System.Drawing.Point(0, 355);
            this.BtnGrowth.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGrowth.Name = "BtnGrowth";
            this.BtnGrowth.Size = new System.Drawing.Size(218, 65);
            this.BtnGrowth.TabIndex = 4;
            this.BtnGrowth.Text = "> Развитие   ";
            this.BtnGrowth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnGrowth.UseVisualStyleBackColor = true;
            this.BtnGrowth.Click += new System.EventHandler(this.BtnGrowth_Click);
            this.BtnGrowth.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // BtnMed
            // 
            this.BtnMed.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMed.FlatAppearance.BorderSize = 0;
            this.BtnMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMed.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnMed.Image = global::UI_Design.Properties.Resources.treatment_64_1px;
            this.BtnMed.Location = new System.Drawing.Point(0, 290);
            this.BtnMed.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMed.Name = "BtnMed";
            this.BtnMed.Size = new System.Drawing.Size(218, 65);
            this.BtnMed.TabIndex = 3;
            this.BtnMed.Text = "> Медицина  ";
            this.BtnMed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnMed.UseVisualStyleBackColor = true;
            this.BtnMed.Click += new System.EventHandler(this.BtnMed_Click);
            this.BtnMed.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // BtnDocuments
            // 
            this.BtnDocuments.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnDocuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDocuments.FlatAppearance.BorderSize = 0;
            this.BtnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDocuments.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnDocuments.Image = global::UI_Design.Properties.Resources.document_64_1px;
            this.BtnDocuments.Location = new System.Drawing.Point(0, 225);
            this.BtnDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDocuments.Name = "BtnDocuments";
            this.BtnDocuments.Size = new System.Drawing.Size(218, 65);
            this.BtnDocuments.TabIndex = 2;
            this.BtnDocuments.Text = "> Документы";
            this.BtnDocuments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDocuments.UseVisualStyleBackColor = true;
            this.BtnDocuments.Click += new System.EventHandler(this.BtnDocuments_Click);
            this.BtnDocuments.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // BtnHome
            // 
            this.BtnHome.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHome.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnHome.Image = global::UI_Design.Properties.Resources.home_64_1px;
            this.BtnHome.Location = new System.Drawing.Point(0, 160);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(218, 65);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "> Главная <    ";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Design.Properties.Resources.sleeping_baby_girl_64px;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(61, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddChild
            // 
            this.btnAddChild.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_9;
            this.btnAddChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddChild.FlatAppearance.BorderSize = 0;
            this.btnAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnAddChild.Image = global::UI_Design.Properties.Resources.add_50px2;
            this.btnAddChild.Location = new System.Drawing.Point(164, 0);
            this.btnAddChild.Margin = new System.Windows.Forms.Padding(8, 16, 2, 2);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(54, 56);
            this.btnAddChild.TabIndex = 7;
            this.btnAddChild.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTipMain.SetToolTip(this.btnAddChild, "Нажмите для добавления учетной записи ребенка");
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            this.btnAddChild.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Label lblBaby;
        private System.Windows.Forms.Button BtnGrowth;
        private System.Windows.Forms.Button BtnMed;
        private System.Windows.Forms.Button BtnDocuments;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.ComboBox cmbBoxNameChild;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Label lblTmp;
        private System.Windows.Forms.Panel pnlFormLoader;
    }
}

