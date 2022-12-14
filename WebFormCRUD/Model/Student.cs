using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebFormCRUD.Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        
        public Guid GenderId { get; set; }

        
        public Guid CourseId { get; set; }
        public bool HasCertificate { get; set; }
    }
}