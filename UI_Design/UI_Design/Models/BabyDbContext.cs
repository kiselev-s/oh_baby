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
        public DbSet<Imagge> Images { get; set; }
        public DbSet<Health> Healths { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Child>()
                        .Property(e => e.Birthday)
                        .HasColumnType("date");

            modelBuilder.Entity<Health>()
                        .Property(e => e.DateMeeting)
                        .HasColumnType("date");

            modelBuilder.Entity<Health>()
                        .Property(e => e.DateNextMeeting)
                        .HasColumnType("date");
        }
    }
}
