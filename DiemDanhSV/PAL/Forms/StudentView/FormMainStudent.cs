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
using DiemDanhSV.PAL.Forms;
using DiemDanhSV.PAL.Forms.StudentView;

namespace DiemDanhSV.PAL.Forms
{
    public partial class FormMainStudent : Form
    {
        private Users student;
        private UsersController usersController;
        private ClassesController classesController;
        private Form currentChildForm;
        public FormMainStudent(Users std)
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

            FormDashBoardStudent stdDashBoard = new FormDashBoardStudent(this.student);
            openChildFrom((Form) stdDashBoard);
            Task.Run(() =>
            {
                stdDashBoard.LoadData();
            });

        }

        private void openChildFrom(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            std_panel.Controls.Add(childForm);
            std_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {

        }
    }
}