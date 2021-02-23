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
        public static int verifyLogin(string email, string pass)//проверка наличия в базе пользователя с данным Email и Password
        {
            string connString = ConfigurationManager
               .ConnectionStrings["defaultConnection"]
               .ConnectionString;
            DataContext db = new DataContext(connString);

            var result = db.GetTable<Parent>()
                .Where(p => p.Email == email).Where(u => u.Password == pass);
            if (result.Count() > 0)
            {
                Parent parent = result.FirstOrDefault();
                return parent.Id;
            }
            else
            {
                return -1;
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
            Parent parent = result.FirstOrDefault();
            return parent;
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

        public static void addChild(string firstName, string lastName, DateTime birthday)//джобавление ребенка в базу
        {
            string connString = ConfigurationManager
                .ConnectionStrings["defaultConnection"]
                .ConnectionString;
            DataContext db = new DataContext(connString);

            Table<Child> childs = db.GetTable<Child>();

            Child newChild = new Child()
            {
                FirstName = firstName,
                LastName = lastName,
                Birthday = birthday
            };

            childs.InsertOnSubmit(newChild);
            db.SubmitChanges();
        }
    }
}
