using DiemDanhSV.Controller;
using DiemDanhSV.Models;
using DiemDanhSV.Repository;
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
    public partial class FormAddSubject : Form
    {
        private SubjectController subjectController = new SubjectController();

        public FormAddSubject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string subjectId = txtBoxId.Text;
                string subjectName = txtBoxName.Text;

                // Tạo đối tượng Subject
                Subject subject = new Subject(subjectId, subjectName);

                // Thêm vào database
                bool isAdded = subjectController.addSubject(subject);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadData();

        }

        private void FormAddSubject_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<Subject> subs = subjectController.getAllSubject();

            this.Invoke((MethodInvoker)delegate
            {
                // Xóa các hàng hiện có (nếu cần)
                list_subject_gridView.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (Subject s in subs)
                {
                    list_subject_gridView.Rows.Add(s.SubjectId, s.SubjectName);
                }

                this.Cursor = Cursors.Default;
            });
        }
    }
}
