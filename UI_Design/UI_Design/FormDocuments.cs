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
    public partial class FormDocuments : Form
        
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
        static public Parent parent = null;

       
        public FormDocuments(Parent _parent)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            parent = _parent;
        }
        static string title=null;

        private void FormDocuments_Load(object sender, EventArgs e)
        {

        }

        private void AddImd_Click(object sender, EventArgs e)
        {
            //Image img =null;
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.CheckFileExists = true;
            //dialog.Multiselect = false;
            //dialog.Filter = "Image Files(*.bmp;*.png;*.jpg;*.jpeg)|*.bmp;*.png;*.jpg;*.jpeg";
            //byte[] byteImg = null;
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{

            //     byteImg = File.ReadAllBytes(dialog.FileName); 
            //}
            //using (MemoryStream ms = new MemoryStream(byteImg, 0, byteImg.Length))
            //{
            //    ms.Write(byteImg, 0, byteImg.Length);
            //    pictureBox1.Image = Image.FromStream(ms);
            //}
            FormTitleImg form = new FormTitleImg(parent);
            form.ShowDialog();
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {

        }
    }
}
