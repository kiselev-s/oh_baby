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
        private static Child tempChild;
        public static Child FindById(int Id)
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    return db.Childs.FirstOrDefault(c => c.Id == Id);
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Данных о ребенке не существует в базе...");
                return new Child();// ??????????????????????????????????????????????????
            }
        }

        public static Child FindByFirstName(string firstName)
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    return db.Childs.FirstOrDefault(c => c.FirstName == firstName);
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Ребенок с таким именем не найден в базе данных...");
                return new Child();// ??????????????????????????????????????????????????
            }
        }

        public static void AddChild(string firstName, string lastName, DateTime birthday, Parent inputParent)//добавление ребенка в базу
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    tempChild = null;

                    Child newChild = new Child()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Birthday = birthday
                    };

                    Parent par = db.Parents.FirstOrDefault(p => p.Id == inputParent.Id);
                    par.Children.Add(newChild);
                    db.SaveChanges();

                    tempChild = newChild;
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Ошибка работы с базой при добавлении ребенка...");
            }
        }

        public static Child GetNewAddChild() => tempChild;

        public static void FindAllChild(Parent parent, ComboBox cbx, bool addChild)
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
