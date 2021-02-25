using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class AuthService
    {
        public static bool Login(string email, string pass)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                Parent par = db.Parents.FirstOrDefault(p => p.Email == email);

                if (par.Password == GetHash(pass))
                    return true;
                else
                    return false;
            }
        }

        private static string GetHash(string input)//шифруем пароль в MD5
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
