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
    public partial class ShowAllStudentList : System.Web.UI.Page
    {
        private readonly StudentController _controller;

        public Student Student = new Student();

        public ShowAllStudentList(StudentController controller)
        {
            _controller = controller;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void CreateStudent_Click(object sender, EventArgs e)
        //{
        //    var student = new Student()
        //    {
        //        Name = NameTxt.Text,
        //        Email = EmailTxt.Text,
        //        Gender = MaleGender.Checked ? GenderEnum.Male : GenderEnum.Female
        //    };

        //    _controller.CreateStudent(student);
        //}
    }
}