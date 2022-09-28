using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebFormCRUD.Data;
using WebFormCRUD.Model;
using WebFormCRUD.Model.Views;

namespace WebFormCRUD.Repository
{
    public class ApplicationRepository
    {
        private readonly ApplicationDbContext _context;

        ConnectionStringSettings connectionString = ConfigurationManager.ConnectionStrings["DbConnection"];

        public ApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ShowStudentsView> GetAllStudents()
        {
            return _context.StudentListView.ToList();
        }

        public void AddStudent(Student model)
        {
            _context.Students.Add(model);
            _context.SaveChanges();
        }

        public void DeleteStudent(Guid studentId)
        {
            var student = _context.Students.Where(x => x.Id == studentId).FirstOrDefault();
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
                student.GenderId = model.GenderId;
                _context.SaveChanges();
            }
        }

        public Student GetStudentById(Guid studentId)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == studentId);
            return student;
        }

        //---------------------------GENDER--------------------------------
        public List<Gender> GetAllGenders()
        {
            return _context.Gender.ToList();
        }

        public Guid ReturnGenderId(string gender)
        {
            return _context.Gender.Where(x => x.Title == gender).Select(x => x.Id).FirstOrDefault();
        }

        //-----------------------GET FILTERED DATA---------------------
        public List<ShowStudentsView> GetFilteredData(string uni, string gender)
        {
            List<ShowStudentsView> students = new List<ShowStudentsView>();
            using (SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
            {
                conn.Open();
                using (SqlCommand sql = new SqlCommand("ReturnStudentData", conn))
                {
                    sql.CommandType = System.Data.CommandType.StoredProcedure;

                    sql.Parameters.Add(new SqlParameter("@Uni", uni));
                    sql.Parameters.Add(new SqlParameter("@Gen", gender));

                    var reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        var Student = new ShowStudentsView();
                        Student.Id = (Guid)reader["Id"];
                        Student.Name = (string)reader["Name"];
                        Student.Email = (string)reader["Email"];
                        Student.GenderTitle = (string)reader["GenderTitle"];
                        Student.CourseTitle = (string)reader["CourseTitle"];
                        Student.UniversityTitle = (string)reader["UniversityTitle"];
                        Student.HasCertificate = (bool)reader["HasCertificate"];

                        students.Add(Student);
                    }
                    
                }
            }
            return students;
        } 
    }
}