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
    public partial class FormAddList : Form
    {
        private readonly ListsController listsController;
        private readonly SubjectController subjectController;
        public FormAddList()
        {
            InitializeComponent();
            listsController = new ListsController();
            subjectController = new SubjectController();
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
                    var lst = listsController.ReadListsFromExcel(filePath);

                    // Lưu thông tin class vào database
                    listsController.addListsFromList(lst);

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
            List<Classes> classes = listsController.getAllClassExist();

            this.Invoke((MethodInvoker)delegate
            {
                // Xóa các hàng hiện có (nếu cần)
                list_data_gridView.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (Classes cls in classes)
                {
                    Subject sj = subjectController.getSubjectByID(cls.Subject);
                    int total = listsController.getToTalStudentInClass(cls.ClassID);
                    list_data_gridView.Rows.Add(sj.SubjectName, cls.ClassID, cls.Room, cls.Term, total);
                }

                this.Cursor = Cursors.Default;
            });
        }
    }
}
