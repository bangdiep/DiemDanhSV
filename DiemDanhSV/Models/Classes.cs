using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Models
{
    public class Classes
    {
        private string classID;
        private int type;
        private string room;
        private string term;
        private string teacher;
        private string subject;
        private string shift;
        private string formLink;

        public string ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Room
        {
            get { return room; }
            set {  room = value; }
        }
        public string Term
        {
            get { return term; }
            set {  term = value; }
        }
        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        public string FromLink
        {
            get { return formLink; }
            set { formLink = value; }
        }

        public Classes(string id, int type, string room, string term, string teacher, string subject, string shift)
        {
            this.classID = id;
            this.type = type;
            this.room = room;
            this.term = term;
            this.teacher = teacher;
            this.subject = subject;
            this.shift = shift;
            this.formLink = "";
        }

        public static Classes FromDataReader(MySqlDataReader reader)
        {
            return new Classes(
                reader.GetString("classID"),
                reader.GetInt32("Ctype"),
                reader.GetString("room"),
                reader.GetString("term"),
                reader.GetString("tcID"),
                reader.GetString("sjID"),
                reader.GetString("shID")
            );

        }
    }
}
