using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    class ChildRepos
    {

        public static Child FindByFirstName(string firstName)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
               return db.Childs.FirstOrDefault(c => c.FirstName == firstName);
            }
        }

        public static Child Create(string firstName, string lastName, DateTime birthday, Parent inputParent, int gender)//добавление ребенка в базу
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Child newChild = new Child()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Birthday = birthday,
                        Gender = gender
                    };

                    Parent par = db.Parents.FirstOrDefault(p => p.Id == inputParent.Id);
                    par.Children.Add(newChild);
                    db.SaveChanges();

                    return newChild;
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Ошибка работы с базой при добавлении ребенка...");
                throw;
            }
        }

        public static List<Child> FindByParent(Parent parent)//найти всех детей родителя
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Childs.Where(child => child.Parent_Id == parent.Id).ToList();
            }
        }
    }
}
