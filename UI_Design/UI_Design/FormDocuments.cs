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
        static public Child child = null;

        public FormDocuments(Parent _parent, Child _child)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            parent = _parent;
            child = _child;
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
            FormTitleImg form = new FormTitleImg(parent, child);
            form.ShowDialog();
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {
            Imagge img;
            using (BabyDbContext db = new BabyDbContext())
            {
         
                img = db.Images.FirstOrDefault(im => im.Child_Id==child.Id&& im.Title==comboBox1.SelectedItem.ToString());
                
            }
            byte[] byteImg=img.ImageView;
            using(MemoryStream ms=new MemoryStream(byteImg,0,byteImg.Length))
            {
                pcrBoxDoc.BackgroundImage = Image.FromStream(ms);
                //pcrBoxDoc.Image = Image.FromStream(ms);
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                comboBox1.Items.Clear();
               Child childNew= db.Childs.FirstOrDefault(c => c.Id == child.Id);
               var i= childNew.Images;
                foreach(Imagge img in i )
                {
                    comboBox1.Items.Add(img.Title);
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                Imagge imagge = db.Images.FirstOrDefault(i => i.Title == comboBox1.SelectedItem.ToString());
                Child ch2 = db.Childs.FirstOrDefault(c => c.Id == child.Id);
                ch2.Images.Remove(imagge);
               
                db.SaveChanges();
            }
        }
    }
}
