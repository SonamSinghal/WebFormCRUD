using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebFormCRUD.Model
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid UniversityId { get; set; }
    }
}