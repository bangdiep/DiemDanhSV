using DiemDanhSV.Controller;
using DiemDanhSV.Database;
using DiemDanhSV.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Repository
{
    internal class StudentRepository
    {
        //private UsersRepository usersRepository = new UsersRepository();
        public List<Student> findAll()
        {
            List<Student> students = new List<Student>();
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT u.*, s.major FROM Users u INNER JOIN Student s ON u.userID = s.stdID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student std = Student.FromDataReader(reader);
                            students.Add(std);
                        }
                    }
                }
            }
            return students;
        }
        //public string findMajor(string id)
        //{
        //    using (MySqlConnection connection = DatabaseConnection.GetConnection())
        //    {
        //        string query = "SELECT major FROM Student WHERE stdID=@id";

        //        using (MySqlCommand cmd = new MySqlCommand(query, connection))
        //        {
        //            using (MySqlDataReader reader = cmd.ExecuteReader())
        //            {

        //            }
        //        }
        //    }
        //}
        public string getMajorById(string id)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT major FROM Student WHERE stdID = @sid";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        } else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public bool addStudent(Student std)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Student (stdID, major) VALUES " +
                    "(@sID, @major);"; 
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@sID", std.UserID);
                    cmd.Parameters.AddWithValue("@major", std.Major);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
