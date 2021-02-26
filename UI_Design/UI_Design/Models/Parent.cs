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
    public class Parent
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string FirstName { get; set; }

        [Required, MaxLength(60)]
        public string LastName { get; set; }

        [Required, Index(IsUnique = true), MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(130)]
        public string Password { get; set; }

        public virtual ICollection<Child> Children { get; set; }

        public Parent()
        {
            Children = new List<Child>();
        }
    }
}
