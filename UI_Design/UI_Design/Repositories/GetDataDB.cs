using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    class GetDataDB
    {
        //public static void verifyLogin(TextBox txtEmail, TextBox txtPass)
        //{
        //    string connString = ConfigurationManager
        //       .ConnectionStrings["defaultConnection"]
        //       .ConnectionString;
        //    SqlConnection connection = new SqlConnection(connString);
        //    string query = "Select * from Parents where email = '" + txtEmail.Text + "' and password = '" + txtPass.Text + "'";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    if(table.Rows.Count == 1)
        //    {
        //        MessageBox.Show("Юхуууууууууууууууууу");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Пичаль.......");
        //    }
        //}
        #region
        public static Parent verifyLogin(string email, string pass)//проверка наличия в базе пользователя с данным Email и Password
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                Parent par = db.Parents.FirstOrDefault(p => p.Email == email);

                return par;
            }
        }

        public static void addParent(string firstName, string lastName, string email, string password)//джобавление нового пользователя в базу
        {
            string connString = ConfigurationManager
                .ConnectionStrings["defaultConnection"]
                .ConnectionString;
            DataContext db = new DataContext(connString);

            Table<Parent> parents = db.GetTable<Parent>();

            Parent newParent = new Parent()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            parents.InsertOnSubmit(newParent);
            db.SubmitChanges();
        }

        public static void deleteParentLinq()//а надо ли?
        {
            //надо реализовать
        }

        public static Parent findParentById(int findId)//поиск в базе пользователя по искомому Id, возвращает обьект класса Parent
        {
            string connString = ConfigurationManager
               .ConnectionStrings["defaultConnection"]
               .ConnectionString;
            DataContext db = new DataContext(connString);

            var result = db.GetTable<Parent>()
                .Where(p => p.Id == findId);
            //if (result.Count() > 0)
            //{
            return result.FirstOrDefault();
            // LoginForm по любому возвращает Id который существует в базе, поэтому мне кажется что никакие if не нужны
            //}
            //else
            //{
            //    return null;
            //}
        }

        public static string GetHash(string input)//шифруем пароль в MD5
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        #endregion
        public static void addChild(string firstName, string lastName, DateTime birthday, int parentId)//добавление ребенка в базу
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                Child newChild = new Child()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Birthday = birthday
                };

                Parent par = db.Parents.FirstOrDefault(p => p.Id == parentId);
                par.Children.Add(newChild);
                db.SaveChanges();
            }
        }
        #region
        public static Child findChildById(int findId)//поиск в базе ребенка по искомому Id, возвращает обьект класса Child
        {
            string connString = ConfigurationManager
               .ConnectionStrings["defaultConnection"]
               .ConnectionString;
            DataContext db = new DataContext(connString);

            var result = db.GetTable<Child>()
                .Where(ch => ch.Id == findId);

            return result.FirstOrDefault();
        }
        #endregion
    }
}
