using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCRUD.Controller;
using WebFormCRUD.Model;

namespace WebFormCRUD
{
    public partial class ShowStudents : System.Web.UI.Page
    {
        private readonly ApplicationController _controller;

        public Student Student = new Student(); 

        public ShowStudents(ApplicationController controller)
        {
            _controller = controller;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> students = _controller.GetAllStudents();

            StudentsList.DataSource = students;
            StudentsList.DataBind();
        }

        protected void CreateStudent_Click(object sender, EventArgs e)
        {
            var student = new Student()
            {
                Name = NameTxt.Text,
                Email = EmailTxt.Text,
                Gender = MaleGender.Checked ? GenderEnum.Male : GenderEnum.Female
            };

            _controller.CreateStudent(student);
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;
            var studentId = Convert.ToInt32((item.FindControl("StudentId") as Label).Text);
            _controller.DeleteStudent(studentId);
        }

        protected void GetStudent_Click(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;
            var studentId = Convert.ToInt32((item.FindControl("StudentId") as Label).Text);
            Student = _controller.GetStudentById(studentId);
        }
    }
}