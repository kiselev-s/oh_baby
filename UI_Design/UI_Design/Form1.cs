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

        BabyDbContext db;
        SqlConnection connection;
        //DataSet set = null;
        //SqlDataAdapter adapter = null;
        public Form1()
        {
            //db = new BabyDbContext();
            
            //string connString = ConfigurationManager
            //   .ConnectionStrings["defaultConnection"]
            //   .ConnectionString;
            //db.Parents.Load();
            //db.Childs.Load();
            //db.Growth_Weights.Load();
            //connection = new SqlConnection(connString);

            //set = new DataSet();

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //pnlNav.Height = btnHome.Height;
            //pnlNav.Top = btnHome.Top;
            //pnlNav.Left = btnHome.Left;
            //btnHome.BackColor = Color.FromArgb(46, 51, 73);
            viewClickButtun(sender);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            //pnlNav.Height = btnDocuments.Height;
            //pnlNav.Top = btnDocuments.Top;
            //pnlNav.Left = btnDocuments.Left;
            //btnDocuments.BackColor = Color.FromArgb(46, 51, 73);
            viewClickButtun(sender);
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            //pnlNav.Height = btnMed.Height;
            //pnlNav.Top = btnMed.Top;
            //pnlNav.Left = btnMed.Left;
            //btnMed.BackColor = Color.FromArgb(46, 51, 73);
            viewClickButtun(sender);
        }

        private void btnGrowth_Click(object sender, EventArgs e)
        {
            //pnlNav.Height = btnGrowth.Height;
            //pnlNav.Top = btnGrowth.Top;
            //pnlNav.Left = btnGrowth.Left;
            //btnGrowth.BackColor = Color.FromArgb(46, 51, 73);
            viewClickButtun(sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //pnlNav.Height = btnSettings.Height;
            //pnlNav.Top = btnSettings.Top;
            //pnlNav.Left = btnSettings.Left;
            //btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            viewClickButtun(sender);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            //btnHome.BackColor = Color.FromArgb(24, 30, 54);
            viewBakcColorButton(sender);
        }

        private void btnDocuments_Leave(object sender, EventArgs e)
        {
            //btnDocuments.BackColor = Color.FromArgb(24, 30, 54);
            viewBakcColorButton(sender);
        }

        private void btnMed_Leave(object sender, EventArgs e)
        {
            //btnMed.BackColor = Color.FromArgb(24, 30, 54);
            viewBakcColorButton(sender);
        }

        private void btnGrowth_Leave(object sender, EventArgs e)
        {
            //btnGrowth.BackColor = Color.FromArgb(24, 30, 54);
            viewBakcColorButton(sender);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            //btnSettings.BackColor = Color.FromArgb(24, 30, 54);
            viewBakcColorButton(sender);
        }

        private void viewClickButtun(object sender)
        {
            Button senderBtn = sender as Button;
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            senderBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void viewBakcColorButton(object sender)
        {
            Button senderBtn = sender as Button;
            senderBtn.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
