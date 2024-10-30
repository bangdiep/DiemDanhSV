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

namespace DiemDanhSV.PAL.Forms
{
    public partial class FormDashboardStudent : Form
    {
        private Users student;
        private UsersController usersController;
        private ClassesController classesController;
        public FormDashboardStudent(Users std)
        {
            InitializeComponent();
            student = std;
            usersController = new UsersController();
            classesController = new ClassesController();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashboardStudent_Load(object sender, EventArgs e)
        {
            username.Text = student.FullName;
            role.Text = student.UserID;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure to log out?", // Thông điệp hiển thị
                "Log out Confirmation", // Tiêu đề của MessageBox
                MessageBoxButtons.YesNo, // Các nút có sẵn
                MessageBoxIcon.Question // Biểu tượng hiển thị
            );

            // Kiểm tra kết quả từ MessageBox
            if (result == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        public void LoadData()
        {
            List<StudentClassInfo> std_class = classesController.getStudentClassInfoByID(student.UserID);


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