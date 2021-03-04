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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HealthRepos.AddData(child.FirstName, child.LastName, "Хирург", DateTime.Now, DateTime.Now);//временно, тестим базу
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = 1;//временно
            dataGridView1.Rows[0].Cells[1].Value = 2;
            dataGridView1.Rows[0].Cells[2].Value = 3;
            dataGridView1.Rows[0].Cells[3].Value = 4;
        }
    }
}
