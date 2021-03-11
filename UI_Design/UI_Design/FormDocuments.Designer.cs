
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocuments));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.butPrint = new System.Windows.Forms.Button();
            this.butShare = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnElse = new System.Windows.Forms.Button();
            this.butStrah = new System.Windows.Forms.Button();
            this.butSport = new System.Windows.Forms.Button();
            this.butUch = new System.Windows.Forms.Button();
            this.butInn = new System.Windows.Forms.Button();
            this.butZagPas = new System.Windows.Forms.Button();
            this.butUaPas = new System.Windows.Forms.Button();
            this.butSv = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnNext.Image = global::UI_Design.Properties.Resources.double_right_50px1;
            this.btnNext.Location = new System.Drawing.Point(832, 375);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 51);
            this.btnNext.TabIndex = 14;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnPrev.Image = global::UI_Design.Properties.Resources.double_left_50px22;
            this.btnPrev.Location = new System.Drawing.Point(471, 375);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(71, 51);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // butPrint
            // 
            this.butPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butPrint.BackgroundImage")));
            this.butPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butPrint.Image = global::UI_Design.Properties.Resources.print_50px;
            this.butPrint.Location = new System.Drawing.Point(610, 429);
            this.butPrint.Margin = new System.Windows.Forms.Padding(2);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(71, 51);
            this.butPrint.TabIndex = 12;
            this.butPrint.UseVisualStyleBackColor = true;
            this.butPrint.Click += new System.EventHandler(this.ButPrint_Click);
            // 
            // butShare
            // 
            this.butShare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butShare.BackgroundImage")));
            this.butShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butShare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butShare.Image = global::UI_Design.Properties.Resources.share_50px1;
            this.butShare.Location = new System.Drawing.Point(700, 429);
            this.butShare.Margin = new System.Windows.Forms.Padding(2);
            this.butShare.Name = "butShare";
            this.butShare.Size = new System.Drawing.Size(71, 51);
            this.butShare.TabIndex = 11;
            this.butShare.UseVisualStyleBackColor = true;
            // 
            // butDel
            // 
            this.butDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butDel.BackgroundImage")));
            this.butDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butDel.Image = global::UI_Design.Properties.Resources.delete_receipt_50px2;
            this.butDel.Location = new System.Drawing.Point(832, 10);
            this.butDel.Margin = new System.Windows.Forms.Padding(2);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(71, 51);
            this.butDel.TabIndex = 10;
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butAdd.BackgroundImage")));
            this.butAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butAdd.Image = global::UI_Design.Properties.Resources.add_receipt_50px2;
            this.butAdd.Location = new System.Drawing.Point(471, 9);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(71, 51);
            this.butAdd.TabIndex = 9;
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(471, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 301);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnElse
            // 
            this.btnElse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnElse.BackgroundImage")));
            this.btnElse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnElse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnElse.Location = new System.Drawing.Point(68, 386);
            this.btnElse.Margin = new System.Windows.Forms.Padding(2);
            this.btnElse.Name = "btnElse";
            this.btnElse.Size = new System.Drawing.Size(262, 41);
            this.btnElse.TabIndex = 7;
            this.btnElse.Text = "Другие";
            this.btnElse.UseVisualStyleBackColor = true;
            this.btnElse.Click += new System.EventHandler(this.btnElse_Click);
            // 
            // butStrah
            // 
            this.butStrah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butStrah.BackgroundImage")));
            this.butStrah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butStrah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butStrah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStrah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butStrah.Location = new System.Drawing.Point(68, 225);
            this.butStrah.Margin = new System.Windows.Forms.Padding(2);
            this.butStrah.Name = "butStrah";
            this.butStrah.Size = new System.Drawing.Size(262, 41);
            this.butStrah.TabIndex = 6;
            this.butStrah.Text = "Страховка";
            this.butStrah.UseVisualStyleBackColor = true;
            this.butStrah.Click += new System.EventHandler(this.butStrah_Click);
            // 
            // butSport
            // 
            this.butSport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSport.BackgroundImage")));
            this.butSport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butSport.Location = new System.Drawing.Point(68, 332);
            this.butSport.Margin = new System.Windows.Forms.Padding(2);
            this.butSport.Name = "butSport";
            this.butSport.Size = new System.Drawing.Size(262, 41);
            this.butSport.TabIndex = 5;
            this.butSport.Text = "Спортивные достижения";
            this.butSport.UseVisualStyleBackColor = true;
            this.butSport.Click += new System.EventHandler(this.butSport_Click);
            // 
            // butUch
            // 
            this.butUch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butUch.BackgroundImage")));
            this.butUch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butUch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butUch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butUch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butUch.Location = new System.Drawing.Point(68, 278);
            this.butUch.Margin = new System.Windows.Forms.Padding(2);
            this.butUch.Name = "butUch";
            this.butUch.Size = new System.Drawing.Size(262, 41);
            this.butUch.TabIndex = 4;
            this.butUch.Text = "Учебные достижения";
            this.butUch.UseVisualStyleBackColor = true;
            this.butUch.Click += new System.EventHandler(this.butUch_Click);
            // 
            // butInn
            // 
            this.butInn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butInn.BackgroundImage")));
            this.butInn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butInn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butInn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butInn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butInn.Location = new System.Drawing.Point(68, 171);
            this.butInn.Margin = new System.Windows.Forms.Padding(2);
            this.butInn.Name = "butInn";
            this.butInn.Size = new System.Drawing.Size(262, 41);
            this.butInn.TabIndex = 3;
            this.butInn.Text = "ИНН";
            this.butInn.UseVisualStyleBackColor = true;
            this.butInn.Click += new System.EventHandler(this.butInn_Click);
            // 
            // butZagPas
            // 
            this.butZagPas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butZagPas.BackgroundImage")));
            this.butZagPas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butZagPas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butZagPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butZagPas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butZagPas.Location = new System.Drawing.Point(68, 119);
            this.butZagPas.Margin = new System.Windows.Forms.Padding(2);
            this.butZagPas.Name = "butZagPas";
            this.butZagPas.Size = new System.Drawing.Size(262, 41);
            this.butZagPas.TabIndex = 2;
            this.butZagPas.Text = "Загранпаспорт";
            this.butZagPas.UseVisualStyleBackColor = true;
            this.butZagPas.Click += new System.EventHandler(this.butZagPas_Click);
            // 
            // butUaPas
            // 
            this.butUaPas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butUaPas.BackgroundImage")));
            this.butUaPas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butUaPas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butUaPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butUaPas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butUaPas.Location = new System.Drawing.Point(68, 65);
            this.butUaPas.Margin = new System.Windows.Forms.Padding(2);
            this.butUaPas.Name = "butUaPas";
            this.butUaPas.Size = new System.Drawing.Size(262, 41);
            this.butUaPas.TabIndex = 1;
            this.butUaPas.Text = "Украинский паспорт";
            this.butUaPas.UseVisualStyleBackColor = true;
            this.butUaPas.Click += new System.EventHandler(this.butUaPas_Click);
            // 
            // butSv
            // 
            this.butSv.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_52;
            this.butSv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.butSv.Location = new System.Drawing.Point(68, 10);
            this.butSv.Margin = new System.Windows.Forms.Padding(2);
            this.butSv.Name = "butSv";
            this.butSv.Size = new System.Drawing.Size(262, 41);
            this.butSv.TabIndex = 0;
            this.butSv.Text = "Свидетельство о рождении";
            this.butSv.UseVisualStyleBackColor = true;
            this.butSv.Click += new System.EventHandler(this.butSv_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // FormDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(982, 512);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.butPrint);
            this.Controls.Add(this.butShare);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnElse);
            this.Controls.Add(this.butStrah);
            this.Controls.Add(this.butSport);
            this.Controls.Add(this.butUch);
            this.Controls.Add(this.butInn);
            this.Controls.Add(this.butZagPas);
            this.Controls.Add(this.butUaPas);
            this.Controls.Add(this.butSv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDocuments";
            this.Text = "FormDocuments";
            this.Load += new System.EventHandler(this.FormDocuments_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butSv;
        private System.Windows.Forms.Button butUaPas;
        private System.Windows.Forms.Button butZagPas;
        private System.Windows.Forms.Button butInn;
        private System.Windows.Forms.Button butUch;
        private System.Windows.Forms.Button butStrah;
        private System.Windows.Forms.Button butSport;
        private System.Windows.Forms.Button btnElse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butShare;
        private System.Windows.Forms.Button butPrint;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}