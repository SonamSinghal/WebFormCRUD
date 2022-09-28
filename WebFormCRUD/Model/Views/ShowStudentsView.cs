using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebFormCRUD.Model.Views
{
    [Table("View StudentData")]
    public class ShowStudentsView
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string GenderTitle { get; set; }
        public string CourseTitle { get; set; }
        public string UniversityTitle { get; set; }
        public bool HasCertificate { get; set; }
    }
}