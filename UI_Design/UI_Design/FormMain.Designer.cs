
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
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnGrowth = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.BtnMed = new System.Windows.Forms.Button();
            this.BtnDocuments = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTmp = new System.Windows.Forms.Label();
            this.lblBaby = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbBoxNameChild = new System.Windows.Forms.ComboBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lbltFeastText = new System.Windows.Forms.Label();
            this.lblFeast = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGenderText = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblBirthText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.lblParentName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLastDoc = new System.Windows.Forms.Label();
            this.lblLastDocTxt = new System.Windows.Forms.Label();
            this.lblSoonMed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFormLoader.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 800);
            this.panel1.TabIndex = 0;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnSettings.Image = global::UI_Design.Properties.Resources.automation_48px;
            this.BtnSettings.Location = new System.Drawing.Point(0, 640);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(291, 80);
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
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnExit.Image = global::UI_Design.Properties.Resources.exit_64_1px;
            this.BtnExit.Location = new System.Drawing.Point(0, 720);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(291, 80);
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
            this.BtnGrowth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGrowth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnGrowth.Image = global::UI_Design.Properties.Resources.increase_48px;
            this.BtnGrowth.Location = new System.Drawing.Point(0, 437);
            this.BtnGrowth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGrowth.Name = "BtnGrowth";
            this.BtnGrowth.Size = new System.Drawing.Size(291, 80);
            this.BtnGrowth.TabIndex = 4;
            this.BtnGrowth.Text = "> Развитие   ";
            this.BtnGrowth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnGrowth.UseVisualStyleBackColor = true;
            this.BtnGrowth.Click += new System.EventHandler(this.BtnGrowth_Click);
            this.BtnGrowth.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 197);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 80);
            this.pnlNav.TabIndex = 1;
            // 
            // BtnMed
            // 
            this.BtnMed.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMed.FlatAppearance.BorderSize = 0;
            this.BtnMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnMed.Image = global::UI_Design.Properties.Resources.treatment_64_1px;
            this.BtnMed.Location = new System.Drawing.Point(0, 357);
            this.BtnMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMed.Name = "BtnMed";
            this.BtnMed.Size = new System.Drawing.Size(291, 80);
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
            this.BtnDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnDocuments.Image = global::UI_Design.Properties.Resources.document_64_1px;
            this.BtnDocuments.Location = new System.Drawing.Point(0, 277);
            this.BtnDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDocuments.Name = "BtnDocuments";
            this.BtnDocuments.Size = new System.Drawing.Size(291, 80);
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
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnHome.Image = global::UI_Design.Properties.Resources.home_64_1px;
            this.BtnHome.Location = new System.Drawing.Point(0, 197);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(291, 80);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "> Главная <    ";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.Leave += new System.EventHandler(this.BtnAll_Leave);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 197);
            this.panel2.TabIndex = 0;
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblTmp.Location = new System.Drawing.Point(72, 171);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(143, 29);
            this.lblTmp.TabIndex = 9;
            this.lblTmp.Text = "label_Temp";
            this.lblTmp.Visible = false;
            // 
            // lblBaby
            // 
            this.lblBaby.AutoSize = true;
            this.lblBaby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBaby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblBaby.Location = new System.Drawing.Point(16, 71);
            this.lblBaby.Name = "lblBaby";
            this.lblBaby.Size = new System.Drawing.Size(0, 20);
            this.lblBaby.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Design.Properties.Resources.sleeping_baby_girl_64px;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(81, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbBoxNameChild
            // 
            this.cmbBoxNameChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.cmbBoxNameChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBoxNameChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbBoxNameChild.FormattingEnabled = true;
            this.cmbBoxNameChild.Location = new System.Drawing.Point(71, 132);
            this.cmbBoxNameChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxNameChild.Name = "cmbBoxNameChild";
            this.cmbBoxNameChild.Size = new System.Drawing.Size(144, 37);
            this.cmbBoxNameChild.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.cmbBoxNameChild, "Выберете ребенка для просмотра его данных");
            this.cmbBoxNameChild.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNameChild_SelectedIndexChanged);
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
            this.btnAddChild.Location = new System.Drawing.Point(219, 0);
            this.btnAddChild.Margin = new System.Windows.Forms.Padding(11, 20, 3, 2);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(72, 69);
            this.btnAddChild.TabIndex = 7;
            this.btnAddChild.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTipMain.SetToolTip(this.btnAddChild, "Нажмите для добавления учетной записи ребенка");
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            this.btnAddChild.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Controls.Add(this.label1);
            this.pnlFormLoader.Controls.Add(this.lblSoonMed);
            this.pnlFormLoader.Controls.Add(this.lblLastDocTxt);
            this.pnlFormLoader.Controls.Add(this.lblLastDoc);
            this.pnlFormLoader.Controls.Add(this.lblParentName);
            this.pnlFormLoader.Controls.Add(this.lbltFeastText);
            this.pnlFormLoader.Controls.Add(this.lblFeast);
            this.pnlFormLoader.Controls.Add(this.lblGender);
            this.pnlFormLoader.Controls.Add(this.lblGenderText);
            this.pnlFormLoader.Controls.Add(this.lblBirthday);
            this.pnlFormLoader.Controls.Add(this.lblBirthText);
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(291, 170);
            this.pnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1309, 630);
            this.pnlFormLoader.TabIndex = 2;
            this.pnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormLoader_Paint);
            // 
            // lbltFeastText
            // 
            this.lbltFeastText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltFeastText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lbltFeastText.Location = new System.Drawing.Point(33, 253);
            this.lbltFeastText.Name = "lbltFeastText";
            this.lbltFeastText.Size = new System.Drawing.Size(194, 65);
            this.lbltFeastText.TabIndex = 17;
            this.lbltFeastText.Text = "До праздника осталось:";
            // 
            // lblFeast
            // 
            this.lblFeast.AutoSize = true;
            this.lblFeast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFeast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblFeast.Location = new System.Drawing.Point(295, 278);
            this.lblFeast.Name = "lblFeast";
            this.lblFeast.Size = new System.Drawing.Size(134, 29);
            this.lblFeast.TabIndex = 16;
            this.lblFeast.Text = "date event";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblGender.Location = new System.Drawing.Point(293, 107);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(93, 39);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "child";
            // 
            // lblGenderText
            // 
            this.lblGenderText.AutoSize = true;
            this.lblGenderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenderText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblGenderText.Location = new System.Drawing.Point(24, 53);
            this.lblGenderText.Name = "lblGenderText";
            this.lblGenderText.Size = new System.Drawing.Size(141, 29);
            this.lblGenderText.TabIndex = 14;
            this.lblGenderText.Text = "Родитель:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblBirthday.Location = new System.Drawing.Point(295, 179);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(48, 29);
            this.lblBirthday.TabIndex = 13;
            this.lblBirthday.Text = "HB";
            // 
            // lblBirthText
            // 
            this.lblBirthText.AutoSize = true;
            this.lblBirthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblBirthText.Location = new System.Drawing.Point(33, 179);
            this.lblBirthText.Name = "lblBirthText";
            this.lblBirthText.Size = new System.Drawing.Size(211, 29);
            this.lblBirthText.TabIndex = 12;
            this.lblBirthText.Text = "Дата рождения:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblTitle.Location = new System.Drawing.Point(815, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 38);
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
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblParentName.Location = new System.Drawing.Point(294, 53);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(108, 36);
            this.lblParentName.TabIndex = 11;
            this.lblParentName.Text = "Parent";
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogo.Image = global::UI_Design.Properties.Resources.logo4;
            this.lblLogo.Location = new System.Drawing.Point(291, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(1309, 95);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastDoc
            // 
            this.lblLastDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblLastDoc.Location = new System.Drawing.Point(34, 350);
            this.lblLastDoc.Name = "lblLastDoc";
            this.lblLastDoc.Size = new System.Drawing.Size(194, 99);
            this.lblLastDoc.TabIndex = 18;
            this.lblLastDoc.Text = "Последний добавленный документ:";
            // 
            // lblLastDocTxt
            // 
            this.lblLastDocTxt.AutoSize = true;
            this.lblLastDocTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastDocTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblLastDocTxt.Location = new System.Drawing.Point(296, 408);
            this.lblLastDocTxt.Name = "lblLastDocTxt";
            this.lblLastDocTxt.Size = new System.Drawing.Size(104, 29);
            this.lblLastDocTxt.TabIndex = 19;
            this.lblLastDocTxt.Text = "last doc";
            // 
            // lblSoonMed
            // 
            this.lblSoonMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSoonMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblSoonMed.Location = new System.Drawing.Point(34, 478);
            this.lblSoonMed.Name = "lblSoonMed";
            this.lblSoonMed.Size = new System.Drawing.Size(264, 72);
            this.lblSoonMed.TabIndex = 20;
            this.lblSoonMed.Text = "Ближайшее медобследование:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(304, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "date soon med";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlFormLoader);
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
            this.pnlFormLoader.ResumeLayout(false);
            this.pnlFormLoader.PerformLayout();
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
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.ComboBox cmbBoxNameChild;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Label lblTmp;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblBirthText;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblGenderText;
        private System.Windows.Forms.Label lblFeast;
        private System.Windows.Forms.Label lbltFeastText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoonMed;
        private System.Windows.Forms.Label lblLastDocTxt;
        private System.Windows.Forms.Label lblLastDoc;
    }
}

