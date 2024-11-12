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
            string classID;
            string Ctype;
            ClassesController classesController = new ClassesController();
            if (e.ColumnIndex == Subject_list_gridView.Columns["ColumnSubject"].Index && e.RowIndex >= 0)
            {
                // Lấy mã môn học từ ô tương ứng
                classID = Subject_list_gridView.Rows[e.RowIndex].Cells["columnClassCode"].Value.ToString() ?? string.Empty;
                Ctype = Subject_list_gridView.Rows[e.RowIndex].Cells["columnType"].Value.ToString() ?? string.Empty;


                    ClassesRepository classesRepository = new ClassesRepository();
                    LoadFormQRCoder(classesRepository.getLinkByClassID(classID));

            }
            if (e.ColumnIndex == Subject_list_gridView.Columns["ColumnEdit"].Index && e.RowIndex >= 0)
            {
                classID = Subject_list_gridView.Rows[e.RowIndex].Cells["columnClassCode"].Value.ToString() ?? string.Empty;

                LoadFormEditClass(classesController.getClassByID(classID));
            }
            if (e.ColumnIndex == Subject_list_gridView.Columns["columnStudentList"].Index && e.RowIndex >= 0)
            {
                classID = Subject_list_gridView.Rows[e.RowIndex].Cells["columnClassCode"].Value.ToString() ?? string.Empty;

                LoadFormStudentList(classesController.getClassByID(classID));
            }
        }

        private void LoadFormStudentList(Classes classes)
        {
            FormStudentList formStudentList = new FormStudentList(classes);
            formStudentList.Dock = DockStyle.Fill;
            formStudentList.TopLevel = false;
            pn_formDBInst.Controls.Clear();
            pn_formDBInst.Controls.Add(formStudentList);
            formStudentList.Show();
        }

        private void LoadFormEditClass(Classes classes)
        {
            FormEditClass formEditClass = new FormEditClass(classes);
            formEditClass.Dock = DockStyle.Fill;
            formEditClass.TopLevel = false;
            pn_formDBInst.Controls.Clear();
            pn_formDBInst.Controls.Add(formEditClass);
            formEditClass.Show();

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

            LoadIndexOfColumn();
        }

        private void LoadIndexOfColumn()
        {
            Subject_list_gridView.Columns["columnClassCode"].DisplayIndex = 0;
            Subject_list_gridView.Columns["ColumnSubject"].DisplayIndex = 1;
            Subject_list_gridView.Columns["columnType"].DisplayIndex = 2;
            Subject_list_gridView.Columns["columnRoom"].DisplayIndex = 3;
            Subject_list_gridView.Columns["columnTerm"].DisplayIndex = 4;
            Subject_list_gridView.Columns["ColumnEdit"].DisplayIndex = 5;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pn_formDBInst.Controls.Clear();
            pn_formDBInst.Controls.Add(Subject_list_gridView);
            LoadIndexOfColumn();
            Subject_list_gridView.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadFormAddAttendanceData();
        }

        private void LoadFormAddAttendanceData()
        {
            FormAddAttendanceData formAddAttendanceData = new FormAddAttendanceData();
            formAddAttendanceData.Dock = DockStyle.Fill;
            formAddAttendanceData.TopLevel = false;
            pn_formDBInst.Controls.Clear();
            pn_formDBInst.Controls.Add(formAddAttendanceData);
            formAddAttendanceData.Show();
        }
    }
}
