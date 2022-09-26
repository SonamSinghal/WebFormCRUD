using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebFormCRUD.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [Column("Gender")]
        public string GenderString
        {
            get { return Gender.ToString(); }
            private set { Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), value, true); }
        }

        [NotMapped]
        public GenderEnum Gender { get; set; }
    }
}