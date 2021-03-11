
namespace UI_Design
{
    partial class FormMedicen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateMeeting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNextMeeting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageHealth = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelHealth = new System.Windows.Forms.Button();
            this.btnAddHealth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.FatherName,
            this.Proff,
            this.DateMeeting,
            this.DateNextMeeting,
            this.ImageHealth});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(958, 420);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LastName.Width = 140;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FirstName.Width = 140;
            // 
            // FatherName
            // 
            this.FatherName.HeaderText = "Отчество";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            this.FatherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FatherName.Width = 140;
            // 
            // Proff
            // 
            this.Proff.HeaderText = "Специалист";
            this.Proff.MinimumWidth = 6;
            this.Proff.Name = "Proff";
            this.Proff.ReadOnly = true;
            this.Proff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Proff.Width = 180;
            // 
            // DateMeeting
            // 
            this.DateMeeting.HeaderText = "Дата приема";
            this.DateMeeting.MinimumWidth = 6;
            this.DateMeeting.Name = "DateMeeting";
            this.DateMeeting.ReadOnly = true;
            this.DateMeeting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateMeeting.Width = 140;
            // 
            // DateNextMeeting
            // 
            this.DateNextMeeting.HeaderText = "Дата следующего приема";
            this.DateNextMeeting.MinimumWidth = 6;
            this.DateNextMeeting.Name = "DateNextMeeting";
            this.DateNextMeeting.ReadOnly = true;
            this.DateNextMeeting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateNextMeeting.Width = 140;
            // 
            // ImageHealth
            // 
            this.ImageHealth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageHealth.HeaderText = "Фото";
            this.ImageHealth.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageHealth.MinimumWidth = 6;
            this.ImageHealth.Name = "ImageHealth";
            this.ImageHealth.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageHealth.ToolTipText = "Нажмите для добавления диагноза";
            // 
            // btnDelHealth
            // 
            this.btnDelHealth.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnDelHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelHealth.FlatAppearance.BorderSize = 0;
            this.btnDelHealth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnDelHealth.Image = global::UI_Design.Properties.Resources.minus;
            this.btnDelHealth.Location = new System.Drawing.Point(452, 436);
            this.btnDelHealth.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelHealth.Name = "btnDelHealth";
            this.btnDelHealth.Size = new System.Drawing.Size(218, 65);
            this.btnDelHealth.TabIndex = 8;
            this.btnDelHealth.Text = "Удалить";
            this.btnDelHealth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelHealth.UseVisualStyleBackColor = true;
            this.btnDelHealth.Click += new System.EventHandler(this.BtnDelHealth_Click);
            // 
            // btnAddHealth
            // 
            this.btnAddHealth.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnAddHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddHealth.FlatAppearance.BorderSize = 0;
            this.btnAddHealth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnAddHealth.Image = global::UI_Design.Properties.Resources.add_50px21;
            this.btnAddHealth.Location = new System.Drawing.Point(752, 437);
            this.btnAddHealth.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddHealth.Name = "btnAddHealth";
            this.btnAddHealth.Size = new System.Drawing.Size(218, 65);
            this.btnAddHealth.TabIndex = 6;
            this.btnAddHealth.Text = "Добавить";
            this.btnAddHealth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddHealth.UseVisualStyleBackColor = true;
            this.btnAddHealth.Click += new System.EventHandler(this.BtnAddHealth_Click);
            // 
            // FormMedicen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(982, 512);
            this.Controls.Add(this.btnDelHealth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddHealth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMedicen";
            this.Text = "FormMedicen";
            this.Load += new System.EventHandler(this.FormDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddHealth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proff;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateMeeting;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNextMeeting;
        private System.Windows.Forms.DataGridViewImageColumn ImageHealth;
        private System.Windows.Forms.Button btnDelHealth;
    }
}