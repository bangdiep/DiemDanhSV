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
using DiemDanhSV.PAL.Forms.AdminView;

namespace DiemDanhSV.PAL.Forms
{
    public partial class FormDashboard : Form
    {

        private AdminController adminController;
        private StudentController studentController;
        private Form currentChildForm;
        public FormDashboard()
        {
            InitializeComponent();
            adminController = new AdminController();
            studentController = new StudentController();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

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
                    // Đọc thông tin user từ file Excel
                    var users = adminController.ReadUsersFromExcel(filePath);

                    // Lưu thông tin user vào database
                    adminController.SaveUsersToDatabase(users);

                    MessageBox.Show("Tải dữ liệu lên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
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
            admin_dashboard_pn.Controls.Add(childForm);
            admin_dashboard_pn.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Form addStudentForm = new FormAddStudent();
            FormAddStudent addStudent = new FormAddStudent();
            openChildFrom((Form)addStudent);

            Task.Run(() =>
            {
                addStudent.LoadData();
            });
        }

        private void list_student_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            FormAddSubject addSubject = new FormAddSubject();
            openChildFrom((Form) addSubject);
            Task.Run(() =>
            {
                addSubject.LoadData();
            });

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

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            FormAddClass addClass = new FormAddClass();
            openChildFrom((Form)addClass);

            Task.Run(() =>
            {
                addClass.LoadData();
            });
        }

        private void btn_add_instructor_Click(object sender, EventArgs e)
        {
            FormAddInstructor addInstructor = new FormAddInstructor();
            openChildFrom(addInstructor);

            Task.Run(() =>
            {
                addInstructor.LoadData();
            });
        }
    }
}
