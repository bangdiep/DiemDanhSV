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
    internal class InstructorController
    {
        private InstructorRepository instructorRepository = new InstructorRepository();
        private UsersRepository usersRepository = new UsersRepository();

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

        public bool addInstructor(Instructor inst)
        {
            // add user 
            bool addUser = usersRepository.adddUser((Users) inst);

            if (addUser)
            {
                // add student 
                bool addInstructor = instructorRepository.addInstructor(inst);

                return addInstructor;
            }
            else
            {
                return false;
            }
        }

        public bool addInstructorFromList(List<Instructor> instructors)
        {
            foreach (Instructor ins in instructors)
            {
                bool result = this.addInstructor(ins);
                if (result == false)
                {
                    throw new Exception($"Cannot add instructor with ID: {ins.UserID}");
                }
            }
            return true;
        }

        public List<Instructor> ReadInstructorFromExcel(string filePath)
        {
            var users = new List<Instructor>();
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
                    var roles = 1;
                    var degree = row.Cell(5).GetString();
                    users.Add(new Instructor
                    {
                        UserID = userId,
                        FullName = fullName,
                        UserName = username,
                        Password = password,
                        Email = email,
                        Gender = gender,
                        Role = roles,
                        Degree = degree
                    });
                }
            }
            return users;
        }

        public List<Instructor> getAllInstructor()
        {
            return instructorRepository.findAll();
        }
    }
}
