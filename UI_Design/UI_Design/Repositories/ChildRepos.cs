using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class ChildRepos
    {
        public static Child findById(int Id)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Childs.FirstOrDefault(c => c.Id == Id);
            }
        }
    }
}
