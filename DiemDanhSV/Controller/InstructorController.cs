using DiemDanhSV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Controller
{
    internal class InstructorController
    {
        private InstructorRepository instructorRepository = new InstructorRepository();

        public string getDegree(string id)
        {
            string degree = instructorRepository.getDegreeById(id);
            if (degree == null)
            {
                throw new Exception("Wrong usersID");
            }
            else
            {
                return degree;
            }
        }
    }
}
