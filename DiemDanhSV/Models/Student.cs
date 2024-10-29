using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Models
{
    public class Student : Users
    {
        private string major;

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public Student(string id, string fullname, string username, string pwd, string email, string gender, string major)
            : base(id, fullname, username, pwd, email, gender, 2)
        {
            this.major = major;
        }

        public Student() : base()
        {
            base.Role = 2;
            this.major = "";
        }

        public Student FromDataReader(MySqlDataReader reader)
        {
            Users u = Users.FromDataReader(reader);
            Student s = u.ToStudent();
            //s.SetMajor(reader.GetString("major"));
            s.Major = reader.GetString("major");
            return s;
        }

        
    }
}
