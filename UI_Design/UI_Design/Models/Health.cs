using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Linq.Mapping;
using ColumnAttribute = System.Data.Linq.Mapping.ColumnAttribute;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    public class Health
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string FullName { get; set; }

        [Required, MaxLength(60)]
        public string Proff { get; set; }

        public DateTime DateMeeting { get; set; }

        public DateTime DateNextMeeting { get; set; }

        public int Child_Id { get; set; }
        [ForeignKey("Child_Id")]
        public virtual Child Child { get; set; }

        public virtual ICollection<ImageHealth> ImageHealths { get; set; }
    }
}