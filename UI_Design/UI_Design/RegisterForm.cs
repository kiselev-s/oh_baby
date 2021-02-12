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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
                MessageBox.Show("Введите имя!");
            else if (txtLastName.Text == string.Empty)
                MessageBox.Show("Введите фамилию!");
            else if (txtEmail.Text == string.Empty)
                MessageBox.Show("Введите email!");
            else if (txtPass.Text == string.Empty)
                MessageBox.Show("Введите пароль!");
            else if (txtPassCheck.Text == string.Empty)
                MessageBox.Show("Введите проверочный пароль!");
            else if (txtPassCheck.Text != txtPass.Text)
                MessageBox.Show("Введенные пароли не совпадают!!");
            else//сюда логику проверки на уникальность Email из базы. Если ок, то функция добавления в базу пользователя
            {
                MessageBox.Show("Поздравляем! Вы зарегистрировались! Но регистрация пока бесполезна =))))))");
            }
        }
    }
}
