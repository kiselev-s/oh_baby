using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ColumnAttribute = System.Data.Linq.Mapping.ColumnAttribute;
using TableAttribute = System.Data.Linq.Mapping.TableAttribute;
using System.ComponentModel.DataAnnotations;

namespace UI_Design
{
    [Table(Name = "children")]
    class Child
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "FirstName"), MaxLength(60)]
        public string FirstName { get; set; }

        [Column(Name = "LastName"), MaxLength(60)]
        public string LastName { get; set; }

        [Column(Name = "Birthday", DbType = "SmallDateTime")]
        public DateTime Birthday { get; set; }
        public int? Parent_Id { get; set; }

        [ForeignKey("Parent_Id")]
        public virtual Parent Parent { get; set; }
    }

    //class Child //старое
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public DateTime Birthday { get; set; }
    //    //public int Id_Parent { get; set; }

    //    public Parent Parent { get; set; }
    //}
}
