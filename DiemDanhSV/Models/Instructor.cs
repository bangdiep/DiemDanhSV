using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Models
{
    public class Instructor : Users
    {
        private string degree;

        public string Degree { get => degree; set => degree = value; }
        public Instructor(string id, string fullname, string username, string pwd, string email, string gender, string deGree)
            : base (id, fullname, username, pwd, email, gender, 1)
        {
            this.degree = deGree;
        }

        public Instructor() : base()
        {
            base.Role = 1;
            this.degree = "";
        }

        public Instructor FromDataReader(MySqlDataReader reader)
        {
            Users u = Users.FromDataReader(reader);
            Instructor inst = u.ToInstructor();
            //s.SetMajor(reader.GetString("major"));
            inst.degree = reader.GetString("degree");
            return inst;
        }
    }
}
