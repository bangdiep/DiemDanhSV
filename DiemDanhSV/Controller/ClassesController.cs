using DiemDanhSV.Models;
using DiemDanhSV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Controller
{
    internal class ClassesController
    {
        private ClassesRepository classesRepository = new ClassesRepository();

        public List<StudentClassInfo> getStudentClassInfoByID(string id)
        {
            List<StudentClassInfo> info = classesRepository.getAllStudetClassId(id);
            return info;
        }
    }
}
