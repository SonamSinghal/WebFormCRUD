using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebFormCRUD.Model;
using WebFormCRUD.Model.Views;
using WebFormCRUD.Repository;

namespace WebFormCRUD.Controller
{
    public class StudentController
    {
        private readonly ApplicationRepository _repository = new ApplicationRepository(new Data.ApplicationDbContext());

        //public ApplicationController(ApplicationRepository repository)
        //{
        //    _repository = repository;
        //}

        public List<ShowStudentsView> GetAllStudents()
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

        public void DeleteStudent(Guid studentId)
        {
            _repository.DeleteStudent(studentId);
        }

        public Student GetStudentById(Guid studentId)
        {
            return _repository.GetStudentById(studentId);
        }

        public List<ShowStudentsView> GetFilterData(string uni, string gender)
        {
            return _repository.GetFilteredData(uni, gender);
        }
    }

}