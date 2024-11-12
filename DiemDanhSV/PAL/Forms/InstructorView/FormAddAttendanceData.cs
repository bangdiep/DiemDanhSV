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

namespace DiemDanhSV.PAL.Forms.InstructorView
{
    public partial class FormAddAttendanceData : Form
    {
        private AttendanceController attendanceController;
        private StudentController studentController;
        public FormAddAttendanceData()
        {
            InitializeComponent();
            attendanceController = new AttendanceController();
            studentController = new StudentController();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Chọn file Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    // Đọc thông tin class từ file Excel
                    var attend = attendanceController.ReadAttendanceFromExcel(filePath);

                    // Lưu thông tin class vào database
                    attendanceController.addAttendanceFromList(attend);

                    Task.Run(() =>
                    {
                        this.LoadData();
                    });
                    this.Cursor = Cursors.Default;

                    MessageBox.Show("Tải dữ liệu lên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    this.Cursor = Cursors.Default;
                }
            }
        }


        public void LoadData()
        {
            List<Attendance> classes = attendanceController.getAll();

            this.Invoke((MethodInvoker)delegate
            {
                // Xóa các hàng hiện có (nếu cần)
                student_list_gridView.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (Attendance cls in classes)
                {
                    student_list_gridView.Rows.Add(cls.StdID, cls.CID, cls.TimeAttend);
                }

                this.Cursor = Cursors.Default;
            });
        }

        private void FormAddAttendanceData_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
