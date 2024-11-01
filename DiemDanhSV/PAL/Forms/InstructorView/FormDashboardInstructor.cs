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
using DiemDanhSV.PAL.Forms.InstructorView;
using DiemDanhSV.Repository;
using System.Web;

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
            LoadDataIntoDataGridView();
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

        private void Subject_list_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Subject_list_gridView.Columns["ColumnSubject"].Index && e.RowIndex >= 0)
            {
                // Lấy mã môn học từ ô tương ứng
                string classID = Subject_list_gridView.Rows[e.RowIndex].Cells["columnClassCode"].Value.ToString() ?? string.Empty;
                string Ctype = Subject_list_gridView.Rows[e.RowIndex].Cells["columnType"].Value.ToString() ?? string.Empty;

                if(int.Parse(Ctype) == 0) //Ly Thuyet
                {
                    ClassesRepository classesRepository = new ClassesRepository();

                    LoadFormQRCoder(classesRepository.getLinkByClassID(classID));
                }

            }
        }

        private void LoadFormQRCoder(string link)
        {
            FormQRCoder formQRCoder = new FormQRCoder(link);
            formQRCoder.Dock = DockStyle.Fill;
            formQRCoder.TopLevel = false;
            pn_formDBInst.Controls.Clear();
            pn_formDBInst.Controls.Add(formQRCoder);
            formQRCoder.Show();
        }

        private void LoadDataIntoDataGridView()
        {
            string inID = role.Text;
            ClassesRepository classesRepository = new ClassesRepository();

            Subject_list_gridView.DataSource = classesRepository.getDataClassByInID(inID);
        }
    }
}
