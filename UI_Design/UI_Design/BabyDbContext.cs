using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI_Design
{
    class BabyDbContext: DbContext
    {
        public BabyDbContext():base ("defaultConnection")
        {

        }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Childs { get; set; }
        public DbSet<Growth_Weight> Growth_Weights { get; set; }
    }
}
