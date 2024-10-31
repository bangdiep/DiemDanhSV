using DiemDanhSV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DiemDanhSV.Models;
using Microsoft.VisualBasic.ApplicationServices;
using DiemDanhModels = DiemDanhSV.Models;


namespace DiemDanhSV.Controller
{
    internal class AdminController
    {
        private UsersRepository usersRepository = new UsersRepository();

        public List<Users> ReadUsersFromExcel(string filePath)
        {
            var users = new List<Users>();
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                foreach (var row in worksheet.RangeUsed().RowsUsed().Skip(1))
                {
                    var userId = row.Cell(1).GetString();
                    var fullName = row.Cell(2).GetString();
                    var username = row.Cell(3).GetString();
                    var password = row.Cell(4).GetString();
                    var email = row.Cell(5).GetString();
                    var gender = row.Cell(6).GetString();
                    var roles = row.Cell(7).GetValue<int>();
                    users.Add(new Users
                    {
                        UserID = userId,
                        FullName = fullName,
                        UserName = username,
                        Password = password,
                        Email = email,
                        Gender = gender,
                        Role = roles
                    });
                }
            }
            return users;
        }

        public void SaveUsersToDatabase(List<DiemDanhModels.Users> users)
        {
            usersRepository.addUserFromExcel(users);
        }
    }
}
