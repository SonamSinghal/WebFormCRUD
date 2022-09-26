using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormCRUD.Data;
using WebFormCRUD.Model;

namespace WebFormCRUD.Repository
{
    public class ApplicationRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public void AddStudent(Student model)
        {
            _context.Students.Add(model);
            _context.SaveChanges();
        }

        public void DeleteStudent(int studentId)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == studentId);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

        public void EditStudent(Student model)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == model.Id);
            if (student != null)
            {
                student.Name = model.Name;
                student.Email = model.Email;
                student.Gender = model.Gender;
                _context.SaveChanges();
            }
        }

        public Student GetStudentById(int studentId)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == studentId);
            return student;
        }
    }
}