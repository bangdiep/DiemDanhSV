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
    public partial class FormAddClass : Form
    {
        private ClassesController classesController;
        public FormAddClass()
        {
            InitializeComponent();
            classesController = new ClassesController();
        }

        private void FormAddClass_Load(object sender, EventArgs e)
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
                    this.Cursor = Cursors.WaitCursor;
                    // Đọc thông tin user từ file Excel
                    var classes = 

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

        public void LoadData()
        {
            List<Classes> classes = classesController.getAllClass();

            this.Invoke((MethodInvoker)delegate
            {
                // Xóa các hàng hiện có (nếu cần)
                list_class_gridView.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (Classes cls in classes)
                {
                    list_class_gridView.Rows.Add(cls.ClassID, cls.Type, cls.Room, cls.Term, cls.Teacher, cls.Subject, cls.Shift);
                }

                this.Cursor = Cursors.Default;
            });
        }
    }
}
