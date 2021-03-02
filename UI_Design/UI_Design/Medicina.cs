using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class Medicina
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string FullName { get; set; }

        [Required, MaxLength(60)]
        public string Proff { get; set; }

        public DateTime DatePriyom { get; set; }

        public DateTime DateNextPriyom { get; set; }

        public virtual ICollection<Imagge> Images { get; set; }
    }
}
