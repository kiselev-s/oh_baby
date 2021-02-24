using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;


namespace UI_Design
{
    
    public partial class Form1 : Form
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

        readonly BabyDbContext db;

        SqlConnection connection;//вроде бы не используется, нужно?
        DataSet set = null;//вроде бы не используется, нужно?
        SqlDataAdapter adapter = null;//вроде бы не используется, нужно?

        private static int parentId = -1;

        public Form1()
        {
            //db = new BabyDbContext();

            //db.Parents.Load();
            //db.Childs.Load();
            //db.Growth_Weights.Load();

            string connString = ConfigurationManager //вроде бы не используется, нужно?
              .ConnectionStrings["defaultConnection"] //вроде бы не используется, нужно?
              .ConnectionString; //вроде бы не используется, нужно?

            connection = new SqlConnection(connString);//вроде бы не используется, нужно?

            set = new DataSet();//вроде бы не используется, нужно?

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0.85;
            Show();

            LoginForm logForm = new LoginForm();
            if (logForm.ShowDialog() == DialogResult.OK)
            {
                Opacity = 1.0;
                try
                {
                    //MyMessageBox.MyShow($"Залогинился пользователь Id = {logForm.getParentId()}");// сюда вернулся Id пользователя, берем его отсюда и длаем с ним все что угодно
                    parentId = logForm.getParentId();
                    //Например посмотрим кто же там. Временно естественно
                    MyMessageBox.MyShow($@"{GetDataDB.findParentById(parentId).FirstName} {GetDataDB.findParentById(parentId).LastName} {GetDataDB.findParentById(parentId).Email} {GetDataDB.findParentById(parentId).Password}");
                }
                catch (Exception)
                {
                    MyMessageBox.MyShow("Ай яй яй! Надо было залогиниться...");
                }
            }
            else
            {
                Opacity = 1.0;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
            lblTitle.Text = "Home";
            this.pnlFormLoader.Controls.Clear();
            //Form1 formHome = new Form1(); //{ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //formHome.FormBorderStyle = FormBorderStyle.None;
            //this.pnlFormLoader.Controls.Add(formHome);
            //formHome.Show();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);

            FormDocuments fornDoc = new FormDocuments();
            SetStyleElemens.CreateForm(fornDoc, pnlFormLoader, lblTitle, "Documents");           
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);

            FormMedicen formMed = new FormMedicen();
            SetStyleElemens.CreateForm(formMed, pnlFormLoader, lblTitle, "Medicina");       
           
        }

        private void btnGrowth_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);

            Opacity = 0.85;

            FormAddChild formAddChild = new FormAddChild();
            if (formAddChild.ShowDialog() == DialogResult.OK)
            {
                Opacity = 1.0;
                try
                {
                    // сюда какой-то код после добавления ребенка
                }
                catch (Exception)
                {
                    MyMessageBox.MyShow("Нарушение доступа к базе данных???");
                }
            }
            else
            {
                Opacity = 1.0;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnAll_Leave(object sender, EventArgs e)//курсор покинул пределы любой кнопки
        {
            SetStyleElemens.viewBackColorButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
