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
        private SubjectRepository subjectRepository = new SubjectRepository();

        public FormAddSubject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string subjectId = txtBoxId.Text;
            string subjectName = txtBoxName.Text;

            // Tạo đối tượng Subject
            Subject subject = new Subject(subjectId, subjectName);

            // Thêm vào database
            bool isAdded = subjectRepository.AddSubject(subject);
            if (isAdded)
            {
                MessageBox.Show("Môn học đã được thêm thành công!");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm môn học.");
            }
        }
    }
}
