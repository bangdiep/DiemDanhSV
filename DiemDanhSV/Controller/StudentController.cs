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
    internal class StudentController
    {
        private readonly StudentRepository studentRepository = new StudentRepository();
        private readonly UsersRepository usersRepository = new UsersRepository();

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

        public List<Student> getAllStudent()
        {
            return studentRepository.findAll();
        }

        public List<Student> ReadStudentFromExcel(string filePath)
        {
            var users = new List<Student>();
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                foreach (var row in worksheet.RangeUsed().RowsUsed().Skip(1)) // skip first row
                {
                    var userId = row.Cell(1).GetString();
                    var fullName = row.Cell(2).GetString();
                    var username = userId;
                    var password = "tdtu@123";
                    var email = row.Cell(3).GetString();
                    var gender = row.Cell(4).GetString();
                    var roles = 2;
                    var major = row.Cell(5).GetString();
                    users.Add(new Student
                    {
                        UserID = userId,
                        FullName = fullName,
                        UserName = username,
                        Password = password,
                        Email = email,
                        Gender = gender,
                        Role = roles,
                        Major = major
                    });
                }
            }
            return users;
        }

        public bool addStudent(Student student)
        {
            // add user 
            bool addUser = usersRepository.adddUser((Users) student);

            if (addUser)
            {
                // add student 
                bool addStudent = studentRepository.addStudent(student);

                return addStudent;
            } else
            {
                return false;
            }
        }

        public bool addStudentFromList(List<Student> students)
        {
            foreach (Student std in students)
            {
                bool result = this.addStudent(std);
                if (result == false)
                {
                    throw new Exception($"Cannot add student with ID: {std.UserID}");
                }
            }
            return true;
        }
    }
}
