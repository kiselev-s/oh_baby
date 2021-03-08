using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class HealthRepos
    {
        public static void AddData(string firstName, string lastName, string proff, DateTime dateMeeting, DateTime dateNextMeeting)
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Health health = new Health
                    {
                        FullName = firstName + " " + lastName,
                        Proff = proff,
                        DateMeeting = dateMeeting,
                        DateNextMeeting = dateNextMeeting,
                    };
                    //health.ImageHealths.Add();
                    Child child = db.Childs.FirstOrDefault(c => c.FirstName == firstName);
                    child.Healths.Add(health);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Ошибка работы с базой Health...");
                throw;
            }
        }

        public static Health FindByChildId(int childId)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Healths.FirstOrDefault(Health => Health.Child_Id == childId);
            }
        }

        public static List<Health> FindByChild(Child child)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Healths.Where(health => health.Child_Id == child.Id).ToList();
            }
        }
    }
}
