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
        public FormDashBoardStudent(Users us)
        {
            InitializeComponent();
            this.student = us;
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
                    Subject_list_gridView.Rows.Add(u.SubjectName, u.ClassID, u.ShiftID, 0);
                }

                this.Cursor = Cursors.Default;
            });

        }
    }
}
