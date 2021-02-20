using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
                MyMessageBox.MyShow("Введите имя!");
            else if (txtLastName.Text == string.Empty)
                MyMessageBox.MyShow("Введите фамилию!");
            else if (txtEmail.Text == string.Empty)
                MyMessageBox.MyShow("Введите email!");
            else if(!isValidEmail(txtEmail.Text))
                MyMessageBox.MyShow("Введите настоящий email!");
            else if (txtPass.Text == string.Empty)
                MyMessageBox.MyShow("Введите пароль!");
            else if (txtPassCheck.Text == string.Empty)
                MyMessageBox.MyShow("Введите проверочный пароль!");
            else if (txtPassCheck.Text != txtPass.Text)
                MyMessageBox.MyShow("Введенные пароли не совпадают!");
            else if (txtPass.Text.Length < 8 || txtPassCheck.TextLength < 8)
                MyMessageBox.MyShow("Минимальная длина пароля - 8 символов");
            else if(txtPass.Text.Length > 16 || txtPassCheck.TextLength > 16)
                MyMessageBox.MyShow("Максимальная длина пароля - 16 символов");
            else
            {
                try
                {
                    GetDataDB.addParent(txtFirstName.Text, txtLastName.Text, txtEmail.Text, GetDataDB.GetHash(txtPass.Text));//добавить в таблицу нового пользователя
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MyMessageBox.MyShow("Пользователь с таким email существует!");
                }
            }
        }

        bool isValidEmail(string email)//проверка валидности Email
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        private void btnVisiblePassTrue_Click(object sender, EventArgs e)//показать пароль
        {
            txtPass.PasswordChar = '\0';
            txtPassCheck.PasswordChar = '\0';
            btnVisiblePass.Click -= new EventHandler(btnVisiblePassTrue_Click);
            btnVisiblePass.Click += new EventHandler(btnVisiblePassFalse_Click);
        }
        private void btnVisiblePassFalse_Click(object sender, EventArgs e)//скрыть пароль
        {
            txtPass.PasswordChar = '*';
            txtPassCheck.PasswordChar = '*';
            btnVisiblePass.Click -= new EventHandler(btnVisiblePassFalse_Click);
            btnVisiblePass.Click += new EventHandler(btnVisiblePassTrue_Click);
        }
    }
}
