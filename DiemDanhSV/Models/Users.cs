using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Models
{
    internal class Users
    {
        private string userID;
        private string fullName;
        private string userName;
        private string password;
        private string email;
        private string gender;
        private int role;

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

        public string GetUserID()
        {
            return userID;
        }

        public void SetUserID(string id)
        {
            userID = id;
        }

        public string GetFullName()
        {
            return fullName;
        }

        public void SetFullName(string name)
        {
            fullName = name;
        }

        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string name)
        {
            userName = name;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string pwd)
        {
            password = pwd;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string mail)
        {
            email = mail;
        }

        public string GetGender()
        {
            return gender;
        }

        public void SetGender(string genders)
        {
            gender = genders;
        }

        public int GetRole()
        {
            return role;
        }

        public void SetRole(int role)
        {
            this.role = role;
        }

        public static Users FromDataReader(MySqlDataReader reader)
        {
            return new Users(
                reader["userID"].ToString(),
                reader["fullName"].ToString(),
                reader["userName"].ToString(),
                reader["passwords"].ToString(),
                reader["email"].ToString(),
                reader["gender"].ToString(),
                Convert.ToInt32(reader["roles"])
            );
        }

    }
}
