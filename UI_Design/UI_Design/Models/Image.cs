using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class Image
    {
        public int Id { get; set; }
        //public image ImageVew { get; set; }
        public string Title { get; set; }
        public int Child_Id { get; set; }
        [ForeignKey("Child_Id")]
        public virtual Child Child { get; set; }

        //public Child Child { get; set; }
    }
}
