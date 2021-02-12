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
            regForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//временно!!!
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Введите email!");
            }
            else if(txtPass.Text == string.Empty)
            {
                MessageBox.Show("Введите password!");
            }
            else// сюда логику проверки логина и пароля из базы
            {
                Close();//временное решение!
            }
        }
    }
}
