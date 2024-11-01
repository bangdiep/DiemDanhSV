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
    public partial class FormAddInstructor : Form
    {
        private readonly InstructorController instructorController;
        public FormAddInstructor()
        {
            InitializeComponent();
            instructorController = new InstructorController();
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
                    var instructors = instructorController.ReadInstructorFromExcel(filePath);

                    // Lưu thông tin user vào database
                    instructorController.addInstructorFromList(instructors);

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
            List<Instructor> instructors = instructorController.getAllInstructor();

            this.Invoke((MethodInvoker)delegate
            {
                // Xóa các hàng hiện có (nếu cần)
                list_instructor_gridView.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (Instructor ins in instructors)
                {
                    list_instructor_gridView.Rows.Add(ins.UserID, ins.FullName, ins.UserName, ins.Password, ins.Degree);
                }

                this.Cursor = Cursors.Default;
            });
        }
    }
}
