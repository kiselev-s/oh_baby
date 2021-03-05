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

        private void btnAddHealth_Click(object sender, EventArgs e)
        {

            FormAddHealth formAddHealth = new FormAddHealth(child);

            if (formAddHealth.ShowDialog() == DialogResult.OK)
            {
                //Opacity = 1.0;

                FillMedTableChild();
            }
            else
            {
                //Opacity = 1.0;
            }
        }

        private void FillMedTableChild()
        {
            try
            {
                List<Health> healths = HealthRepos.FindByChild(child);

                for (int i = 0; i < healths.Count; i++)
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[i].Cells[0].Value = healths[i].FullName;
                    dataGridView1.Rows[i].Cells[1].Value = healths[i].Proff;
                    dataGridView1.Rows[i].Cells[2].Value = healths[i].DateMeeting.ToShortDateString();
                    dataGridView1.Rows[i].Cells[3].Value = healths[i].DateNextMeeting.ToShortDateString();
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Что-то не так с таблицей... Надо дебажить...");
            }
        }
    }
}
