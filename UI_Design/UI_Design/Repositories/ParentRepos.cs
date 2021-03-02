using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class ParentRepos
    {
        public static Parent FindByEmail(string email)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Parents.FirstOrDefault(p => p.Email == email);
            }
        }

        public static Parent FindById(int Id)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Parents.First(p => p.Id == Id);
            }
        }

        public static void Add(string firstName, string lastName, string email, string password)//добавление родителя в базу
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Parent parent = new Parent()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Password = AuthService.GetHash(password)
                    };

                    db.Parents.Add(parent);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Пользователь с таким email существует!");
            }
        }
    }
}
