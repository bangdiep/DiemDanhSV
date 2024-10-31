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
    internal class SubjectRepository
    {
        public bool AddSubject(Subject subject)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Subjects (subID, subjectName) VALUES (@subID, @subjectName)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@subID", subject.SubjectId);
                    cmd.Parameters.AddWithValue("@subjectName", subject.SubjectName);
                    int result = cmd.ExecuteNonQuery();

                    return result > 0; // Trả về true nếu thêm thành công
                }
            }
        }

        public List<Subject> findAll()
        {
            List<Subject> users = new List<Subject>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Users";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Subject user = Subject.FromDataReader(reader);
                            users.Add(user);
                        }
                    }
                }

                return users;
            }
        }
    }
}
