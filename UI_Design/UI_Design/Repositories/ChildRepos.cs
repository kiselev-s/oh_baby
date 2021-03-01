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

        public static Child CreateChild(string firstName, string lastName, DateTime birthday, Parent inputParent)//добавление ребенка в базу
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Child newChild = new Child()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Birthday = birthday
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

        public static void FindByParent(Parent parent, ComboBox cbx, bool addChild)           //ВЕРНУТЬ В ФОРМУ !!!!!!!!!!!!!!!
        {
            if (addChild)
                cbx.Items.Clear();
            using (BabyDbContext db = new BabyDbContext())
            {
                var ch = db.Childs.Where(child => child.Parent_Id == parent.Id).ToList();
                
                foreach (Child item in ch)
                {
                    cbx.Items.Add(item.FirstName);
                    cbx.SelectedIndex = 0;
                }
                if (cbx.Items.Count > 0 && cbx.Enabled == false)
                    cbx.Enabled = true;
            }
        }
    }
}
