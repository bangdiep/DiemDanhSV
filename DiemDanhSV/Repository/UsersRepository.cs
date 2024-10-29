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
    internal class UsersRepository
    {
        public List<Users> findAll()
        {
            List<Users> users = new List<Users>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Users";
                
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        { 
                            Users user = Users.FromDataReader(reader);
                            users.Add(user);
                        }
                    }
                }

                return users;
            }
        }

        public Users findByUsername(string username)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE userName=@usname";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@usname", username);
                    

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //connection.Open();
                        if (reader.Read())
                        {
                            //reader.Read();
                            Users u = Users.FromDataReader(reader);
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

        public bool adddUser(Users user)
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

        
    }
}
