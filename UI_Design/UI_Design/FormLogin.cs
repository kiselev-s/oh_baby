using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class FormLogin : Form
    {
        private static Parent returnParent;
        private Point MouseHook;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister regForm = new FormRegister();
            Hide();
            //txtEmail.Text = null;
            //txtPass.Text = null;
            if (regForm.ShowDialog() == DialogResult.OK)
                Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(Validation.VerifyLogin(txtEmail.Text, txtPass.Text))
            {
                if (AuthService.Login(txtEmail.Text, txtPass.Text))
                {
                    returnParent = ParentRepos.FindByEmail(txtEmail.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        public Parent GetParent() => returnParent;

        private void BtnVisiblePassTrue_Click(object sender, EventArgs e)//показать пароль
        {
            StylesService.ViewEyePassTrue(sender, txtPass, BtnVisiblePassTrue_Click, BtnVisiblePassFalse_Click);
        }
        private void BtnVisiblePassFalse_Click(object sender, EventArgs e)//скрыть пароль
        {
            StylesService.ViewEyePassFalse(sender, txtPass, BtnVisiblePassTrue_Click, BtnVisiblePassFalse_Click);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
    }
}
