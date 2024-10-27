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

namespace DiemDanhSV.PAL.Forms
{
    public partial class FormLogin : Form
    {
        private UsersController usersController;
        public FormLogin()
        {
            InitializeComponent();
            usersController = new UsersController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username" || txt_error.Visible == true)
            {
                txtUsername.Clear();
                txt_error.Visible = false;
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usName = txtUsername.Text;
                string usPassword = txtPassword.Text;

                Users user = usersController.getUsersByUsername(usName);

                if (user.GetPassword() != usPassword)
                {
                    txt_error.Text = "Username or password is incorrect!";
                    txt_error.Visible = true;

                }
                else
                {

                    if (user.GetRole() == 1)
                    {
                        MessageBox.Show("Instructor");
                    }
                    else if (user.GetRole() == 2)
                    {
                        FormDashboardStudent student = new FormDashboardStudent();
                        student.Show();
                        this.Hide();

                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg);
                txt_error.Text = msg;
                txt_error.Visible = true;
            }

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Clear();

            }
        }
    }
}
