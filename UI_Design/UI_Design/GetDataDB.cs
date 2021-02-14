using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
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
        public static int verifyLoginLinq(string email, string pass)
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
                return parent.Id;// или может лучше вернуть обьект класса Parent содержащий данные о пользователе
            }
            else
            {
                return -1;
            }
        }

        public static void addParentLinq(string firstName, string lastName, string email, string password)
        {
            string connString = ConfigurationManager
                .ConnectionStrings["defaultConnection"]
                .ConnectionString;
            DataContext db = new DataContext(connString);

            //INSERT
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

        public static void deleteParentLinq()
        {
            //надо реализовать
        }


    }
}
