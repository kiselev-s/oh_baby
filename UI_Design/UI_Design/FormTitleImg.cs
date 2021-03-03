using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class FormTitleImg : Form
    {
        public static string titl;
        static public Parent parent = null;
        static public Child child = null;
        public FormTitleImg(Parent _parent, Child _child)
        {
            parent = _parent;
            child = _child;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Image img = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            dialog.Filter = "Image Files(*.bmp;*.png;*.jpg;*.jpeg)|*.bmp;*.png;*.jpg;*.jpeg";
            byte[] byteImg = null;
            bool b = true;
            //while(b)
            //{
            //if (textBox1.Text != "")
            //{
            //{
            if (textBox1.Text == "")   
            {
                // MessageBox.Show("введите какое - то название");
                FormMessage.Show("введите какое - то название");
            }

                if (textBox1.Text !="")
            {
                       if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        byteImg = File.ReadAllBytes(dialog.FileName);
                        ImagesRepos.AddImg(textBox1.Text, byteImg, child);
                    FormMessage.Show($"добавлен новый документ {textBox1.Text}"); ;
                    Close();
                        //b = false;
                    }
            }
                   
                }
                //else
                //{
                //    textBox1.Text = "doc";
                //    MessageBox.Show("Введи название документа");
               
                    
                //}
                             
            //}
            //Close();
            

        
    }
}
