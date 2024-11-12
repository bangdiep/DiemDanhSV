using DiemDanhSV.Database;
using DiemDanhSV.Models;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.VariantTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemDanhSV.Repository
{
    internal class ListsRepository
    {
        public bool AddList(Lists list)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Lists (stdID, cID, term) VALUES (@StdID, @CID, @Term)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StdID", list.StdID);
                    cmd.Parameters.AddWithValue("@CID", list.CID);
                    cmd.Parameters.AddWithValue("@Term", list.Term);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<Classes> findAllClassExist()
        {
            List<Classes> classes = new List<Classes>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT distinct c.* " +
                    "FROM Class c JOIN Lists l " +
                    "ON c.classID = l.cID; ";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Classes cls = Classes.FromDataReader(reader);
                            classes.Add(cls);
                        }
                    }
                }
            }
            return classes;
        }

        public int CountByCID(string cID)
        {
            int count = 0;
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Lists WHERE cID = @CID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CID", cID);

                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
        }

        public DataTable getAllStudentInClass(string classID)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT s.stdID, u.fullname FROM Lists l JOIN Student s ON l.stdID = s.stdID JOIN Users u ON s.stdID = u.userID WHERE l.cID = @classID";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@classID", classID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable); // Đổ dữ liệu vào DataTable
                }
            }
            return dataTable;
        }
    }
}
