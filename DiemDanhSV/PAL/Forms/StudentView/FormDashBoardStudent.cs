using DiemDanhSV.Controller;
using DiemDanhSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemDanhSV.PAL.Forms.StudentView
{
    public partial class FormDashBoardStudent : Form
    {
        private Users student;
        private ClassesController classesController;
        private AttendanceController attendanceController;
        public FormDashBoardStudent(Users us)
        {
            InitializeComponent();
            this.student = us;
            classesController = new ClassesController();
            attendanceController = new AttendanceController();
        }

        public void LoadData()
        {
            List<StudentClassInfo> std_class = classesController.getStudentClassInfoByID(this.student.UserID);



            // Cập nhật DataGridView trên UI thread
            this.Invoke((MethodInvoker)delegate
            {
                // Xóa các hàng hiện có (nếu cần)
                Subject_list_gridView.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (StudentClassInfo u in std_class)
                {
                    int total = attendanceController.getSuccessfullAttend(student.UserID, u.ClassID);
                    Subject_list_gridView.Rows.Add(u.SubjectName, u.ClassID, u.ShiftID, total);
                }

                this.Cursor = Cursors.Default;
            });

        }
    }
}
