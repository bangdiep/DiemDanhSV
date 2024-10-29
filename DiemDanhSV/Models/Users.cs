using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DiemDanhSV.Models
{
    public class Users
    {
        private string userID;
        private string fullName;
        private string userName;
        private string password;
        private string email;
        private string gender;
        private int role;

        public string UserID { get => userID; set => userID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Role { get => role; set => role = value; }

        public Users(string id, string fullname, string username, string pwd, string email, string gender, int roles)
        {
            userID = id;
            fullName = fullname;
            userName = username;
            password = pwd;
            this.email = email;
            this.gender = gender;
            role = roles;
        }

        public Users()
        {
            userID = "";
            fullName = "";
            userName = "";
            password = "";
            this.email = "";
            this.gender = "";
            this.role = 0;
        }


        public static Users FromDataReader(MySqlDataReader reader)
        {
            return new Users(
                reader.GetString("userID"),
                reader.GetString("fullName"),
                reader.GetString("userName"),
                reader.GetString("passwords"),
                reader.GetString("email"),
                reader.GetString("gender"),
                reader.GetInt32("roles")
            );
        }

        public Student ToStudent()
        {
            Student s = new Student();

            // Map from Users to Student
            s.UserID = this.UserID;
            s.FullName = this.FullName;
            s.UserName = this.UserName;
            s.Password = this.Password;
            s.Email = this.Email;
            s.Gender = this.Gender;
            return s;
        }

        public Instructor ToInstructor()
        {
            Instructor inst = new Instructor();

            // Map from Users to Student
            inst.UserID = this.UserID;
            inst.FullName = this.FullName;
            inst.UserName = this.UserName;
            inst.Password = this.Password;
            inst.Email = this.Email;
            inst.Gender = this.Gender;
            return inst;
        }

    }
}
