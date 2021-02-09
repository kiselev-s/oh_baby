using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class Growth_Weight
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Growth { get; set; }
        //public int Id_Child { get; set; }

        public Child Child { get; set; }
    }
}
