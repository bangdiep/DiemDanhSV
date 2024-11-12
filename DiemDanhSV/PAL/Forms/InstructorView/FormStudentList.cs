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

namespace DiemDanhSV.PAL.Forms.InstructorView
{
    public partial class FormStudentList : Form
    {
        ListsRepository ListsRepository;
        Classes classes;
        public FormStudentList(Classes classes)
        {
            InitializeComponent();
            this.classes = classes;
            ListsRepository = new ListsRepository();
            LoadFormStudentList();
        }

        public void LoadFormStudentList()
        {
            student_list_gridView.DataSource = ListsRepository.getAllStudentInClass(classes.ClassID);
        }
    }
}
