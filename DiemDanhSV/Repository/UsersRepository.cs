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

        
    }
}
