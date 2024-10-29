using DiemDanhSV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Controller
{
    internal class StudentController
    {
        private StudentRepository studentRepository = new StudentRepository();

        public string getMajor(string id)
        {
            string major = studentRepository.getMajorById(id);
            if (major == null)
            {
                throw new Exception("Wrong usersID");
            } else
            {
                return major;
            }
        }
    }
}
