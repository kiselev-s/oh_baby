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

        public static string GetHash(string pass)//шифруем пароль в MD5
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));

            return Convert.ToBase64String(hash);
        }
    }
}
