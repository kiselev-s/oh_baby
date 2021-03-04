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
    }
}
