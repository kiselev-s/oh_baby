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
        private readonly FormMain formMain;

        public FormMedicen(Child ch, FormMain _formMain)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            child = ch;

            formMain = _formMain;
        }

        private void FormDocuments_Load(object sender, EventArgs e)
        {
            FillMedTableChild();
        }

        private void BtnAddHealth_Click(object sender, EventArgs e)
        {
            formMain.Opacity = 0.5;

            FormAddHealth formAddHealth = new FormAddHealth(child);

            if (formAddHealth.ShowDialog() == DialogResult.OK)
            {
                FillMedTableChild();
            }
            else{}

            formMain.Opacity = 1.0;
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
                //FormMessage.Show("Таблица пока не содержит записей...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                try
                {
                    if (healths[e.RowIndex].ImageView.Length > 0)
                    {
                        FormViewImage formView = new FormViewImage(healths[e.RowIndex].ImageView, formMain);
                        formView.ShowDialog();
                    }
                    else
                    {
                        AddImage(e);
                        FillMedTableChild();
                    }
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
