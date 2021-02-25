using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class ParentRepos
    {
        public static Parent findByEmail(string email)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Parents.FirstOrDefault(p => p.Email == email);
            }
        }

        public static Parent findById(int Id)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Parents.First(p => p.Id == Id);
            }
        }
    }
}
