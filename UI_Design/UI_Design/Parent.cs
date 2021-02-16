using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ColumnAttribute = System.Data.Linq.Mapping.ColumnAttribute;
using TableAttribute = System.Data.Linq.Mapping.TableAttribute;
using System.ComponentModel.DataAnnotations;

namespace UI_Design
{
    [Table(Name = "parents")]
    class Parent
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "FirstName"), MaxLength(60)]
        public string FirstName { get; set; }

        [Column(Name = "LastName"), MaxLength(60)]
        public string LastName { get; set; }

        [Column(Name = "Email"), Required, Index(IsUnique = true), MaxLength(100)]
        public string Email { get; set;}

        [Column(Name = "password"), Required, MaxLength(130)]
        public string Password { get; set; }

        public virtual ICollection<Child> childs { get; set; }

        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }

        //public virtual ICollection<Child> childs { get; set; }
    }
}
