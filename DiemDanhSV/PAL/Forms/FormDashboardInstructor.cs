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
    public partial class FormDashboardInstructor : Form
    {
        private Instructor instructor1;
        private UsersController usersController;
        private ClassesController classesController;
        public FormDashboardInstructor(Instructor inst)
        {
            InitializeComponent();
            instructor1 = inst;

            usersController = new UsersController();
            classesController = new ClassesController();
        }

        private void FormDashboardInstructor_Load(object sender, EventArgs e)
        {
            username.Text = instructor1.FullName;
            role.Text = instructor1.UserID;
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
    }
}
