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
    internal class InstructorRepository
    {
        public string getDegreeById(string id)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT degree FROM Instructor WHERE inID = @inID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public bool addInstructor(Instructor inst)
        {
            using(MySqlConnection  connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Instructor (inID, degree) " +
                    "VALUES (@inID, @degree);";

                using (MySqlCommand cmd = new MySqlCommand (query, connection))
                {
                    cmd.Parameters.AddWithValue("@inID", inst.UserID);
                    cmd.Parameters.AddWithValue("@degree", inst.Degree);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<Instructor> findAll()
        {
            List<Instructor> instructors = new List<Instructor>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT u.*, i.degree FROM Users u INNER JOIN Instructor i ON u.userID = i.inID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Instructor inst = Instructor.FromDataReader(reader);
                            instructors.Add(inst);
                        }
                    }
                }
            }
            return instructors;
        }
    }
}
