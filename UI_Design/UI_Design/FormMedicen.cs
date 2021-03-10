using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Entity;
using System.IO;

namespace UI_Design
{
    public partial class FormMedicen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        private static Child child = null;
        private static List<Health> healths = null;

        public FormMedicen(Child ch)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            child = ch;
        }

        private void FormDocuments_Load(object sender, EventArgs e)
        {
            FillMedTableChild();
        }

        private void BtnAddHealth_Click(object sender, EventArgs e)
        {

            FormAddHealth formAddHealth = new FormAddHealth(child);

            if (formAddHealth.ShowDialog() == DialogResult.OK)
            {
                FillMedTableChild();
            }
            else{}
        }

        private void FillMedTableChild()
        {
            try
            {
                healths = HealthRepos.FindByChild(child);

                if (dataGridView1.Rows.Count > 0)
                    dataGridView1.Rows.Clear();

                for (int i = 0; i < healths.Count; i++)
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[i].Cells[0].Value = healths[i].LastName;
                    dataGridView1.Rows[i].Cells[1].Value = healths[i].FirstName;
                    dataGridView1.Rows[i].Cells[2].Value = healths[i].FatherName;
                    dataGridView1.Rows[i].Cells[3].Value = healths[i].Proff;
                    dataGridView1.Rows[i].Cells[4].Value = healths[i].DateMeeting.ToShortDateString();
                    dataGridView1.Rows[i].Cells[5].Value = healths[i].DateNextMeeting.ToShortDateString();
                    dataGridView1.Rows[i].Cells[6].Value = healths[i].ImageView;
                }
                dataGridView1.SelectedCells[0].Selected = false;
            }
            catch (Exception)
            {
                FormMessage.Show("Таблица пока не содержит записей...");
            }
        }

        private void FillMedTableChild2()////// не работает, удаилть!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            try
            {
                healths = HealthRepos.FindByChild(child);

                var bindingList = new BindingList<Health>(healths);

                var source = new BindingSource(bindingList, null);

                dataGridView1.DataSource = source;

            }
            catch (Exception)
            {
                FormMessage.Show("Таблица пока не содержит записей...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                //FormMessage.Show($"Клик: строка{e.RowIndex}");
                try
                {
                    if (healths[e.RowIndex].ImageView.Length > 0)
                        FormMessage.Show("Изображение уже добавлено...");
                }
                catch (Exception)
                {
                    AddImage(e);
                    FillMedTableChild();
                }
            }
        }

        private void AddImage(DataGridViewCellEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            dialog.Filter = "Image Files(*.bmp;*.png;*.jpg;*.jpeg;)|*.bmp;*.png;*.jpg;*.jpeg;";
            byte[] byteImg;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                byteImg = File.ReadAllBytes(dialog.FileName);
                HealthRepos.UpdateImage(healths[e.RowIndex].Id, byteImg);
            }
        }

        private void BtnDelHealth_Click(object sender, EventArgs e)
        {
            try
            {
                HealthRepos.Remove(healths[dataGridView1.SelectedCells[0].RowIndex].Id);
                FillMedTableChild();
            }
            catch (Exception)
            {
                FormMessage.Show("Выберите запись для удаления!");
            }
        }
    }
}
