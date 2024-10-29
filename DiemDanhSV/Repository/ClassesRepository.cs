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
    internal class ClassesRepository
    {
        public List<StudentClassInfo> getAllStudetClassId(string id)
        {
            List<StudentClassInfo> info = new List<StudentClassInfo>();
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT s.subjectName, c1.classID, c1.shID " +
                    "FROM subjects s JOIN class c1 ON c1.sjID = s.subID " +
                    "WHERE s.subID IN (" +
                    "SELECT DISTINCT sjID FROM Class c WHERE c.classID IN (" +
                    "SELECT cID FROM lists l WHERE l.stdID = @studentID))";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@studentID", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentClassInfo sc = new StudentClassInfo
                            {
                                SubjectName = reader.GetString("subjectName"),
                                ClassID = reader.GetString("classID"),
                                ShiftID = reader.GetString("shID")
                            };
                            info.Add(sc);
                        }
                    }
                }
            }
            return info;
        }

        
    }
}
