using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    class AuthService
    {
        public static bool Login(string email, string pass)
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Parent par = db.Parents.FirstOrDefault(p => p.Email == email);

                    if (par.Password == GetHash(pass))
                        return true;
                    else
                    {
                        FormMessage.Show("Еmail или пароль не корректны! Попробуй ещё.");
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Введенного email не существует!");
                return false;
            }
        }

        public static string GetHash(string input)//шифруем пароль в MD5
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        public static bool CheckLogin(Form mainForm, FormLogin loginForm)
        {
            mainForm.Opacity = 0.85;
            mainForm.Show();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                mainForm.Opacity = 1.0;
                Parent parent = loginForm.GetParent();
                FormMessage.Show($@"Добро пожаловать, {parent.FirstName} {parent.LastName}");
                return true;
            }
            else
            {
                mainForm.Opacity = 1.0;
                return false;
            }
        }

        public static bool AddChildTrue(Form mainForm, FormAddChild formAddChild)
        {
            mainForm.Opacity = 0.85;

            if (formAddChild.ShowDialog() == DialogResult.OK)
            {
                mainForm.Opacity = 1.0;
                Child child = formAddChild.GetChild();
                FormMessage.Show($"Добавлен ребенок: {child.FirstName} {child.LastName}, дата рождения: {child.Birthday.ToShortDateString()}");
                return true;
            }
            else//сюда попали если в FormAddChild нажали "отмена"
            {
                mainForm.Opacity = 1.0;
                return false;
            }
        }
    }
}
