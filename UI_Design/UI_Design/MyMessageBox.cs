using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        public static void MyShow(string text)
        {
            MyMessageBox mb = new MyMessageBox();

            mb.Width = 12 + (text.Length * 10);
            mb.labelHide.Width = text.Length * 10;
            mb.labelHide.Text = text;

            mb.btnOK.Location = new Point((mb.Width - mb.btnOK.Width) / 2, mb.btnOK.Location.Y);
            mb.labelHide.Location = new Point((mb.Width - mb.labelHide.Width) / 2, mb.labelHide.Location.Y);

            mb.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
