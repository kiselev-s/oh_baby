using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ColumnAttribute = System.Data.Linq.Mapping.ColumnAttribute;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UI_Design
{
    public class ImageHealth
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Required, MaxLength(60)]
        public string Title { get; set; }
        [Required]
        public byte[] ImageView { get; set; }

        public int Health_Id { get; set; }
        [ForeignKey("Health_Id")]
        public virtual Health Healths { get; set; }
    }
}
