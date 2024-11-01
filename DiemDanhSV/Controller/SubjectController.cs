using DiemDanhSV.Models;
using DiemDanhSV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Controller
{
    internal class SubjectController
    {
        private readonly SubjectRepository subjectRepository = new SubjectRepository();

        public List<Subject> getAllSubject()
        {
            return subjectRepository.findAll();
        }

        public bool addSubject(Subject subject)
        {
            if (subject.SubjectId == "")
            {
                throw new Exception("Subject ID cannot be null!");
            } else if (subject.SubjectName == "")
            {
                throw new Exception("Subject Name cannot be null");
            }
            return subjectRepository.AddSubject(subject);
        }
    }
}
