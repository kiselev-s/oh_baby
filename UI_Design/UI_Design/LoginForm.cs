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
    public partial class LoginForm : Form
    {
        private static int parentId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            Hide();
            txtEmail.Text = null;
            txtPass.Text = null;
            if (regForm.ShowDialog() == DialogResult.OK)
                Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//ВРЕМЕННО!!! ПОТОМ УДАЛИТЬ!
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            parentId = 0;
            if(txtEmail.Text == string.Empty)
            {
                MyMessageBox.MyShow("Enter email!");
            }
            else if(txtPass.Text == string.Empty)
            {
                MyMessageBox.MyShow("Enter password!");
            }
            else
            {
                parentId = GetDataDB.verifyLogin(txtEmail.Text, GetDataDB.GetHash(txtPass.Text));
                if(parentId == -1)
                {
                    MyMessageBox.MyShow("Login or password is incorrect");
                }
                else//залогинились успешно
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        public int getParentId()//функция возвращает Id пользователя, который вошел в приложение
        {
            return parentId;
        }

        private void btnVisiblePassTrue_Click(object sender, EventArgs e)//показать пароль
        {
            txtPass.PasswordChar = '\0';
            btnVisiblePass.Click -= new EventHandler(btnVisiblePassTrue_Click);
            btnVisiblePass.Click += new EventHandler(btnVisiblePassFalse_Click);
        }
        private void btnVisiblePassFalse_Click(object sender, EventArgs e)//скрыть пароль
        {
            txtPass.PasswordChar = '*';
            btnVisiblePass.Click -= new EventHandler(btnVisiblePassFalse_Click);
            btnVisiblePass.Click += new EventHandler(btnVisiblePassTrue_Click);
        }
    }
}
