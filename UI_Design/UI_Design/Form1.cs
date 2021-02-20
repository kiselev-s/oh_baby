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

        //SqlConnection connection;//вроде бы не используется, нужно?
        //DataSet set = null;//вроде бы не используется, нужно?
        //SqlDataAdapter adapter = null;//вроде бы не используется, нужно?

        public Form1()
        {
            db = new BabyDbContext();

            db.Parents.Load();
            db.Childs.Load();
            db.Growth_Weights.Load();

            //string connString = ConfigurationManager //вроде бы не используется, нужно?
            //   .ConnectionStrings["defaultConnection"] //вроде бы не используется, нужно?
            //   .ConnectionString; //вроде бы не используется, нужно?

            //connection = new SqlConnection(connString);//вроде бы не используется, нужно?

            //set = new DataSet();//вроде бы не используется, нужно?

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0.85;
            Show();

            LoginForm logForm = new LoginForm();
            if(logForm.ShowDialog()==DialogResult.OK)
            {
                Opacity = 1.0;
                try
                {
                    //MyMessageBox.MyShow($"Залогинился пользователь Id = {logForm.getParentId()}");// сюда вернулся Id пользователя, берем его отсюда и длаем с ним все что угодно
                    int test = logForm.getParentId();
                    //Например посмотрим кто же там. Временно естественно
                    MyMessageBox.MyShow($@"{GetDataDB.findParentById(test).FirstName} {GetDataDB.findParentById(test).LastName} {GetDataDB.findParentById(test).Email} {GetDataDB.findParentById(test).Password}");
                }
                catch (Exception)
                {
                    MyMessageBox.MyShow("Ай яй яй! Надо было залогиниться...");
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnGrowth_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetStyleElemens.viewClickButton(sender, pnlNav);
        }

        private void btnAll_Leave(object sender, EventArgs e)//курсор покинул пределы любой кнопки
        {
            SetStyleElemens.viewBackColorButton(sender);
        }
    }
}
