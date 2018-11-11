using System;
using StudentWebApp.BLL;
using StudentWebApp.DAL.Model;

namespace StudentWebApp.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        private StudentManager studentManager = new StudentManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Department = departmentTextBox.Text;

            string message = studentManager.Save(aStudent);
            outputLabel.Text = message;

        }
    }
}