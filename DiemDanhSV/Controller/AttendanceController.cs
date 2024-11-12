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
    internal class AttendanceController
    {
        private readonly AttendanceRepository attendanceRepository = new AttendanceRepository();

        public bool addAttendance(Attendance attendance)
        {
            return attendanceRepository.AddAttendance(attendance);
        }

        public bool addAttendanceFromList(List<Attendance> attendances)
        {
            foreach (Attendance att in attendances)
            {
                bool result = this.addAttendance(att);
                if (result == false)
                {
                    throw new Exception($"Cannot add attendance: {att.ToString()}");
                }
            }
            return true;
        }

        public List<Attendance> ReadAttendanceFromExcel(string filePath)
        {
            var attends = new List<Attendance>();
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                foreach (var row in worksheet.RowsUsed().Skip(1)) // Bỏ qua dòng đầu tiên (tiêu đề)
                {
                    var timeAttend = row.Cell(1).GetDateTime();
                    var stdID = row.Cell(2).GetValue<long>().ToString();
                    var classID = row.Cell(3).GetString();

                    // Tạo đối tượng Attendance từ dữ liệu đọc được
                    var attendance = new Attendance
                    {
                        StdID = stdID,
                        CID = classID,
                        TimeAttend = timeAttend
                    };

                    attends.Add(attendance);
                }
            }
            return attends;
        }

        public int getSuccessfullAttend(string stdID, string cID)
        {
            return attendanceRepository.GetSuccessfulAttendanceCount(stdID, cID);
        }

        public List<Attendance> getAll()
        {
            return attendanceRepository.findAll();
        }

    }
}
