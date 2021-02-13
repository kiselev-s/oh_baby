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
            Hide();
            if (regForm.ShowDialog() == DialogResult.OK)
                Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//временно!!!
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Enter email!");
            }
            else if(txtPass.Text == string.Empty)
            {
                MessageBox.Show("Enter password!");
            }
            else
            {
                int returnId = GetDataDB.verifyLoginLinq(txtEmail.Text, txtPass.Text);
                if(returnId == -1)
                {
                    MessageBox.Show("Login or password is incorrect");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    //
                    MessageBox.Show("Залогинились успешно. Надо добавить возврат значения в главную форму (Id того кто залогинился)");
                    // добавить возврат значения в главную форму (Id того кто залогинился)
                    //
                    Close();
                }
            }
        }
    }
}
