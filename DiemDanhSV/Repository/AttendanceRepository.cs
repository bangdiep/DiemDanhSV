using DiemDanhSV.Database;
using DiemDanhSV.Models;
using DocumentFormat.OpenXml.Office.Word;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Repository
{
    internal class AttendanceRepository
    {
        public bool AddAttendance(Attendance attendance)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Attendance (stdID, cID, timeAttend) VALUES (@stdID, @cID, @timeAttend)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@stdID", attendance.StdID);
                    command.Parameters.AddWithValue("@cID", attendance.CID);
                    command.Parameters.AddWithValue("@timeAttend", attendance.TimeAttend);
                    int rowEffect = command.ExecuteNonQuery();
                    return rowEffect > 0;
                }
            }
        }

        public int GetSuccessfulAttendanceCount(string studentId, string classId)
        {
            //int successfulCount = 0;

            string query = @"
            SELECT COUNT(*)
                FROM Attendance a
                JOIN Lists l ON a.stdID = l.stdID AND a.cID = l.cID
                JOIN Class c ON l.cID = c.classID
                JOIN Shifts s ON c.shID = s.shiftID
                WHERE l.stdID = @studentId 
                  AND c.classID = @classId
                  AND CAST(a.timeAttend AS TIME) BETWEEN s.timeStart AND s.timeEnd;
            ";

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@classId", classId);
                    //successfulCount = (int)command.ExecuteScalar();
                    int successfulCount = Convert.ToInt32(cmd.ExecuteScalar());

                    return successfulCount;
                }
            }
        }

        public List<Attendance> findAll()
        {
            List<Attendance> subjects = new List<Attendance>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Attendance";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Attendance subject = Attendance.FromDataReader(reader);
                            subjects.Add(subject);
                        }
                    }
                }

                return subjects;
            }
        }

    }
}
