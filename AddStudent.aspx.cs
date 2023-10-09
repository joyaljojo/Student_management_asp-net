using Lab_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_7
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            List<FulltimeStudent> fulltime = new List<FulltimeStudent>();
            List<ParttimeStudent> parttime = new List<ParttimeStudent>();
            List<CoopStudent> coop = new List<CoopStudent>();
            string name;
            if (studentname.Text == string.Empty)
            {
                lblErrorMsg.Text = "Please enter name";
            }
            else
            {
                name = studentname.Text;

                if (course.Text == "-1")
                {
                    lblErrorMsg.Text = "Please select a course";
                }
                else if (course.Text == "1")
                {
                    lblErrorMsg.Visible = false;

                    Student newstudent = new Student(name);
                    FulltimeStudent newfull = new FulltimeStudent(name);
                    students.Add(newstudent);
                }
                else if (course.Text == "2")
                {
                    lblErrorMsg.Visible = false;
                    Student newstudent = new Student(name);
                    ParttimeStudent newpart = new ParttimeStudent(name);
                    students.Add(newstudent);
                }
                else if (course.Text == "3")
                {
                    lblErrorMsg.Visible = false;
                    Student newstudent = new Student(name);
                    CoopStudent newcoop = new CoopStudent(name);
                    students.Add(newstudent);
                }
            }
            if(students.Count > 0)
            {
                studentname.Text = string.Empty;
                course.SelectedIndex = -1;
                tabl.InnerText = "";
                if (lblConfirmation.Text == "")
                {
                    lblConfirmation.Text = "<table class=\"table table-bordered\">" + "<tr><th scope='col'>ID</th><th scope='col'>Name</th></tr>";
                }
                else
                {
                    lblConfirmation.Text += "<table class=\"table\">";
                }
                foreach (var j in students)
                {
                    lblConfirmation.Text += "<tr><td scope='row'>" + j.Id + "</td><td scope='row'>" + j.Name + "</td></tr>";
                }
                lblConfirmation.Text += "</table>";

            }
            
        }
    }
}