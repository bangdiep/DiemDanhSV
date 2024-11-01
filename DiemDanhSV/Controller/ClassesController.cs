using ClosedXML.Excel;
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

        public List<Classes> getAllClass()
        {
            return classesRepository.findAll();
        }

        public List<Classes> ReadClassFromExcel(string filePath)
        {
            var classes = new List<Classes>();
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                foreach (var row in worksheet.RangeUsed().RowsUsed().Skip(1)) // skip first row
                {
                    string classID = row.Cell(1).GetString();
                    var type = row.Cell(2);
                    var room = row.Cell(3).GetString();
                    var term = row.Cell(4).GetString();
                    var teacher = row.Cell(5).GetString();
                    var subject = row.Cell(6).GetString();
                    var shift = row.Cell(7).GetString();
                    classes.Add(new Classes
                    (
                        classID,
                        type,
                        room,
                        term,
                        teacher,
                        subject,
                        shift
                    ));
                }
            }
            return classes;
        }

        //public bool? addClass(Classes cls)
        //{
            
        //}

        //public bool addClassFromList(List<Classes> classes)
        //{
        //    foreach (Classes std in classes)
        //    {
        //        bool? result = this.addStudent(std);
        //        if (result == null)
        //        {
        //            throw new Exception($"Cannot add student with ID: {std.UserID}");
        //        }
        //    }
        //    return true;
        //}
    }
}
