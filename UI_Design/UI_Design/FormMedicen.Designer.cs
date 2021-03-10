
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
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateMeeting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNextMeeting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageHealth = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddHealth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Proff,
            this.DateMeeting,
            this.DateNextMeeting,
            this.ImageHealth});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1277, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.HeaderText = "Имя Фамилия";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 180;
            // 
            // Proff
            // 
            this.Proff.HeaderText = "Специалист";
            this.Proff.MinimumWidth = 6;
            this.Proff.Name = "Proff";
            this.Proff.Width = 180;
            // 
            // DateMeeting
            // 
            this.DateMeeting.HeaderText = "Дата приема";
            this.DateMeeting.MinimumWidth = 6;
            this.DateMeeting.Name = "DateMeeting";
            this.DateMeeting.Width = 140;
            // 
            // DateNextMeeting
            // 
            this.DateNextMeeting.HeaderText = "Дата следующего приема";
            this.DateNextMeeting.MinimumWidth = 6;
            this.DateNextMeeting.Name = "DateNextMeeting";
            this.DateNextMeeting.Width = 140;
            // 
            // ImageHealth
            // 
            this.ImageHealth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageHealth.HeaderText = "Фото";
            this.ImageHealth.MinimumWidth = 6;
            this.ImageHealth.Name = "ImageHealth";
            this.ImageHealth.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageHealth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.btnAddHealth.Location = new System.Drawing.Point(1003, 538);
            this.btnAddHealth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddHealth.Name = "btnAddHealth";
            this.btnAddHealth.Size = new System.Drawing.Size(291, 80);
            this.btnAddHealth.TabIndex = 6;
            this.btnAddHealth.Text = "Добавить";
            this.btnAddHealth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddHealth.UseVisualStyleBackColor = true;
            this.btnAddHealth.Click += new System.EventHandler(this.btnAddHealth_Click);
            // 
            // FormMedicen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1309, 630);
            this.Controls.Add(this.btnAddHealth);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMedicen";
            this.Text = "FormMedicen";
            this.Load += new System.EventHandler(this.FormDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proff;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateMeeting;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNextMeeting;
        private System.Windows.Forms.DataGridViewImageColumn ImageHealth;
        private System.Windows.Forms.Button btnAddHealth;
    }
}