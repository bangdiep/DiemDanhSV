using ClosedXML.Excel;
using DiemDanhSV.Database;
using DiemDanhSV.Models;
using Microsoft.VisualBasic.ApplicationServices;
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

        public List<Classes> findAll()
        {
            List<Classes> classes = new List<Classes>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Class";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //DiemDanhModels.Users user = DiemDanhModels.Users.FromDataReader(reader);
                            //users.Add(user);
                            Classes cls = Classes.FromDataReader(reader);
                            classes.Add(cls);
                        }
                    }
                }

                return classes;
            }
        }

        public bool addClass(Classes cls)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Class (classID, Ctype, room, term, tcID, sjID, shID, formLink) VALUES " +
                    "(@cID, @type, @room, @term, @instructor, @subject, @shift, @link);";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cID", cls.ClassID);
                    cmd.Parameters.AddWithValue("@type", cls.Type);
                    cmd.Parameters.AddWithValue("@room", cls.Room);
                    cmd.Parameters.AddWithValue("@term", cls.Term);
                    cmd.Parameters.AddWithValue("@instructor", cls.Teacher);
                    cmd.Parameters.AddWithValue("@subject", cls.Subject);
                    cmd.Parameters.AddWithValue("@shift", cls.Shift);
                    cmd.Parameters.AddWithValue("@link", cls.FromLink);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public DataTable getDataClassByInID(string inID)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT Class.classID, Subjects.subjectName, Class.Ctype, Class.term FROM Class JOIN Subjects ON Class.sjID = Subjects.subID WHERE Class.tcID = @inID;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@inID", inID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt); // Đổ dữ liệu vào DataTable
                }
                connection.Close();
            }

            return dt; // Trả về DataTable chứa dữ liệu
        }

        public string getLinkByClassID(string classID)
        {
            string link = string.Empty; // Khởi tạo biến link với giá trị mặc định
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Sửa từ FORM thành FROM
                string query = "SELECT formLink FROM class WHERE classID = @classID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@classID", classID);
                    // Thực thi truy vấn và lấy kết quả
                    object result = cmd.ExecuteScalar();
                    link = result != null ? result.ToString() : string.Empty; // Kiểm tra null trước khi chuyển đổi
                }
            }

            return link;
        }

    }
}
