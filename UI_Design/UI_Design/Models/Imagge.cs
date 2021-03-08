using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ColumnAttribute = System.Data.Linq.Mapping.ColumnAttribute;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UI_Design
{
   public class Imagge
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }        
        public string Title { get; set; }
        public byte[] ImageView { get; set; }

        [Required]
        public string Categor { get; set; }
        public int Child_Id { get; set; }
        [ForeignKey("Child_Id")]
        public virtual Child Child { get; set; }


        //public Child Child { get; set; }
    }
}
