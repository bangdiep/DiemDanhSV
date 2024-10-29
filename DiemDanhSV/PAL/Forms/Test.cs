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
    public partial class Test : Form
    {
        private UsersController usersController;
        public Test()
        {
            InitializeComponent();
            usersController = new UsersController();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            List<Users> users = usersController.getAllUsers();

            //DataTable dt = new DataTable();
            dataGridView1.DataSource = users;
        }
    }
}
