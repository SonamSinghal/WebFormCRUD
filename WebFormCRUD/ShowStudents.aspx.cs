using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCRUD.Controller;
using WebFormCRUD.Model;
using WebFormCRUD.Model.Views;

namespace WebFormCRUD
{
    public partial class ShowStudents : System.Web.UI.Page
    {
        private readonly StudentController _studentController = new StudentController();
        private readonly GenderController _genderController = new GenderController();

        public Student Student = new Student();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<ShowStudentsView> students = _studentController.GetAllStudents();

            StudentsList.DataSource = students;
            StudentsList.DataBind();
        }

        protected void CreateStudent_Click(object sender, EventArgs e)
        {
            var student = new Student()
            {
                Name = NameTxt.Text,
                Email = EmailTxt.Text,
                GenderId = MaleGender.Checked ? _genderController.GetGenderId("Male") : _genderController.GetGenderId("Female")
            };

            _studentController.CreateStudent(student);
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {

        }

        protected void StudentsList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Guid studentId = Guid.Parse(e.CommandArgument.ToString());

            if (e.CommandName == "Update")
            {
                Student = _studentController.GetStudentById(studentId);
            }
            else if (e.CommandName == "Delete")
            {
                _studentController.DeleteStudent(studentId);
                string url = Convert.ToString(HttpContext.Current.Request.Url);
                Response.Redirect(url);
            }
        }

        protected void ApplyFilter_Click(object sender, EventArgs e)
        {
            string uni = UniFilter.Text.ToString();
            string gender = GenderFilter.Text.ToString();
            StudentsList.DataSource = _studentController.GetFilterData(uni, gender);
            StudentsList.DataBind();
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
            {
            
        }
    }
}