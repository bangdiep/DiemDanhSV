using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Models
{
    internal class Attendance
    {
        public string StdID { get; set; }  
        public string CID { get; set; }     
        public DateTime TimeAttend { get; set; }

        public static Attendance FromDataReader(MySqlDataReader reader)
        {
            return new Attendance
            {
                StdID = reader.GetString("stdID"),
                CID = reader.GetString("cID"),
                TimeAttend = Convert.ToDateTime(reader["timeAttend"])
            };
        }
    }
}
