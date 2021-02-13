using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    [Table(Name = "parents")]
    class Parent
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int")]
        public int Id { get; set; }

        [Column(Name = "FirstName", CanBeNull = true)]
        public string FirstName { get; set; }

        [Column(Name = "LastName", CanBeNull = true)]
        public string LastName { get; set; }

        [Column(Name = "Email", DbType = "NVarChar")]// Как сделать уникальный ключ?
        //[System.ComponentModel.DataAnnotations.Schema.Index(IsUnique = true)]
        public string Email { get; set; }

        [Column(Name = "password")]
        public string Password { get; set; }

        public virtual ICollection<Child> childs { get; set; }

        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }

        //public virtual ICollection<Child> childs { get; set; }

        //public Parent (int _id, string _firstName, string _lastName, string _email, string _password)// это вообще можно было здесь создавать?
        //{
        //    Id = _id;
        //    FirstName = _firstName;
        //    LastName = _lastName;
        //    Email = _email;
        //    Password = _password;
        //}
    }
}
