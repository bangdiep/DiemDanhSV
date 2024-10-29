using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Models
{
    internal class Classes
    {
        private string classID;
        private string type;
        private string room;
        private string term;
        private string teacher;
        private string subject;
        private string shift;

        public string ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        public string Type
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

        public Classes(string id, string type, string room, string term, string teacher, string subject, string shift)
        {
            this.classID = id;
            this.type = type;
            this.room = room;
            this.term = term;
            this.teacher = teacher;
            this.subject = subject;
            this.shift = shift;
        }
    }
}
