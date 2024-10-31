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

namespace DiemDanhSV.PAL.Forms.AdminView
{
    public partial class FormAddStudent : Form
    {
        private StudentController studentController;
        public FormAddStudent()
        {
            InitializeComponent();
            studentController = new StudentController();
        }

        public void LoadData()
        {
            List<Student> students = studentController.getAllStudent();

            this.Invoke((MethodInvoker)delegate
            {
                // Xóa các hàng hiện có (nếu cần)
                list_student_gridView.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (Student st in students)
                {
                    list_student_gridView.Rows.Add(st.UserID, st.FullName, st.UserName, st.Password, st.Email);
                }

                this.Cursor = Cursors.Default;
            });
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            //LoadData();
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
                    // Đọc thông tin user từ file Excel
                    var students = studentController.ReadStudentFromExcel(filePath);

                    // Lưu thông tin user vào database
                    //studentController.SaveUsersToDatabase(users);
                    studentController.addStudentFromList(students);

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
    }
}
