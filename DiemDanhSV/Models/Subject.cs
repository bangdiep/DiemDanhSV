using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Models
{
    internal class Subject
    {
        private string subjectId;
        private string subjectName;

        public string SubjectId
        {
            get { return subjectId; }
            set { subjectId = value; }
        }

        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        public Subject(string id, string name)
        {
            subjectId = id;
            subjectName = name;
        }
    }
}
