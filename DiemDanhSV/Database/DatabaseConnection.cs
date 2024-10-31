using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiemDanhSV.Database
{
    internal class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Database=attendance_system;User ID=root;Password=hao2004;";
        

        // Connect to database
        public static MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open(); // Mở kết nối ngay lập tức
            return connection;
        }

        
    }
}
