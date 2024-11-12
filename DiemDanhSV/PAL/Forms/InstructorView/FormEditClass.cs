using DiemDanhSV.Controller;
using DiemDanhSV.Models;


namespace DiemDanhSV.PAL.Forms.InstructorView
{
    public partial class FormEditClass : Form
    {
        private Classes classes;
        ClassesController classesController;
        public FormEditClass(Classes classes)
        {
            InitializeComponent();
            this.classes = classes;
            LoadFormEditClass();
        }

        public void LoadFormEditClass()
        {
            SubjectController controller = new SubjectController();
            text_subjectName.Text = controller.getSubjectByID(classes.Subject).SubjectName;
            text_classCode.Text = classes.ClassID;
            text_term.Text = classes.Term;
            text_linkGGForm.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string linkGGForm = text_linkGGForm.Text;
            classesController = new ClassesController();
            classesController.updateLinkForm(classes.ClassID, linkGGForm);
        }

        private void text_linkGGForm_DataContextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu giá trị hiện tại khác với giá trị ban đầu
            classesController = new ClassesController();
            if (text_linkGGForm.Text != classesController.getClassByID(classes.ClassID).FromLink)
            {
                btn_showQR.Visible = false;
                btn_save.Visible = true; // Hiển thị nút Save
                btn_cancel.Visible = true;
            }
        }

        private void text_linkGGForm_MouseLeave(object sender, EventArgs e)
        {
            if (text_linkGGForm.Text == null)
            {
                btn_showQR.Visible = true;
                btn_save.Visible = false; // Hiển thị nút Save
                btn_cancel.Visible = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            classesController = new ClassesController();
            text_linkGGForm.Text = classesController.getClassByID(classes.ClassID).FromLink;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btn_showQR.Visible = true;
        }
    }
}
