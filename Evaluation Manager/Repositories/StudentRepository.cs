using DBLayer;
using Evaluation_Manager.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Repositories {
    public class StudentRepository 
        {
        public static Student GetStudent(int id)
            {
            Student student = null;
            string sql = $"SELECT * FROM Students WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return student; 

        }

        public static List<Student> GetStudents() {
            List<Student> students = new List<Student>();
            string sql = "SELECT * FROM Students";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) 
                {
                Student student = CreateObject(reader);
                students.Add(student);



            }
            reader.Close();
            DB.CloseConnection();
            return students;



        }
        private static Student CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string FirstName = reader["FirstName"].ToString();
            string LastName = reader["LastName"].ToString();
            int.TryParse(reader["Grade"].ToString(), out int grade);

            var student = new Student {

                Id = id;
            firstName = firstName;
            lastName = LastName;
            grade = Grade;

        };
        ReturnMessage student;






                }
                
    }
}
