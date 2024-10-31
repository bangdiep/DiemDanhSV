using DiemDanhSV.Database;
using DiemDanhModels = DiemDanhSV.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Repository
{
    internal class UsersRepository
    {
        public List<DiemDanhModels.Users> findAll()
        {
            List<DiemDanhModels.Users> users = new List<DiemDanhModels.Users>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Users";
                
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DiemDanhModels.Users user = DiemDanhModels.Users.FromDataReader(reader);
                            users.Add(user);
                        }
                    }
                }

                return users;
            }
        }

        public DiemDanhModels.Users findByUsername(string username)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE userName=@usname";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@usname", username);
                    

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //reader.Read();
                            DiemDanhModels.Users u = DiemDanhModels.Users.FromDataReader(reader);
                            return u;
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy người dùng với username: " + username);
                            return null;
                        }
                        
                    }
                }
            }
        }

        public bool adddUser(DiemDanhModels.Users user)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Users (userID, fullName, userName, passwords, email, gender, roles) " +
                         "VALUES (@userID, @fullName, @userName, @passwords, @email, @gender, @roles)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userID", user.UserID);
                    cmd.Parameters.AddWithValue("@fullName", user.FullName);
                    cmd.Parameters.AddWithValue("@userName", user.UserName);
                    cmd.Parameters.AddWithValue("@passwords", user.Password);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@roles", user.Role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public void addUserFromExcel(List<DiemDanhModels.Users> users)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                foreach (var user in users)
                {
                    string query = "INSERT INTO Users (userID, fullName, userName, passwords, email, gender, roles) " +
                                     "VALUES (@userID, @fullName, @userName, @passwords, @email, @gender, @roles)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userID", user.UserID);
                    cmd.Parameters.AddWithValue("@fullName", user.FullName);
                    cmd.Parameters.AddWithValue("@userName", user.UserName);
                    cmd.Parameters.AddWithValue("@passwords", user.Password);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@roles", user.Role);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
    }
}
