using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentWebApp.DAL.Gateway;
using StudentWebApp.DAL.Model;

namespace StudentWebApp.BLL
{
    public class StudentManager
    {
        private StudentGateway studentGateway = new StudentGateway();
        public string Save(Student student)
        {

            if (studentGateway.IsRegNoExists(student.RegNo))
            {
                return "Registration No Already Exists";
            }
            else
            {
                int rowAffect = studentGateway.Save(student);
                if (rowAffect > 0)
                {
                    return "Save Successful";
                }
                else
                {
                    return "Save Failed";

                }
            }           
        }
    }
}