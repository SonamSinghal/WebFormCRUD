using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormCRUD.Model;
using WebFormCRUD.Repository;

namespace WebFormCRUD.Controller
{
    public class ApplicationController
    {
        private readonly ApplicationRepository _repository;

        public ApplicationController(ApplicationRepository repository)
        {
            _repository = repository;
        }

        public List<Student> GetAllStudents()
        {
            return _repository.GetAllStudents();
        }

        public void CreateStudent(Student model)
        {
            _repository.AddStudent(model);
        }

        public void EditStudent(Student model)
        {
            _repository.EditStudent(model);
        }

        public void DeleteStudent(int studentId)
        {
            _repository.DeleteStudent(studentId);
        }

        public Student GetStudentById(int studentId)
        {
            return _repository.GetStudentById(studentId);
        }
    }
}