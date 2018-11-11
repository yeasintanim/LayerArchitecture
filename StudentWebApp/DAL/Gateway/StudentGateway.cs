using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentWebApp.DAL.Model;

namespace StudentWebApp.DAL.Gateway
{
    public class StudentGateway
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;


        public StudentGateway()
        {
            string connectionString =
               @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityDB_20;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public int Save(Student student)
        {                              
            string query = "INSERT INTO Students(RegNo, Name, Email, Address, Department)" +
                           " VALUES(@regNo, @name,@email,@address,@department)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@regNo", student.RegNo);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@email", student.Email);
            command.Parameters.AddWithValue("@address", student.Address);
            command.Parameters.AddWithValue("@department", student.Department);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();

            return rowAffect;
        }


        public bool IsRegNoExists(string regNo)
        {
            string query = "SELECT * FROM Students WHERE RegNo=@regNo";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@regNo", regNo);
            connection.Open();
            reader = command.ExecuteReader();
            bool isExists = reader.HasRows;
            connection.Close();
            return isExists;

            //if (reader.HasRows == true)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

        }
    }
}