﻿namespace DiemDanhSV.PAL.Forms.AdminView
{
    partial class FormAddClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            // Thêm mã để thực hiện khi người dùng click vào label
            // Ví dụ:
            MessageBox.Show("Bạn đã click vào label!");
        }
        private void list_student_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thêm mã để thực hiện khi người dùng click vào một cell trong gridview
            // Ví dụ:
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = list_class_gridView.Rows[e.RowIndex];
                string studentID = row.Cells["columnStdId"].Value.ToString();
                // Làm gì đó với studentID, ví dụ: hiển thị thông tin sinh viên
                MessageBox.Show("Bạn đã chọn sinh viên có ID: " + studentID);
            }
        }
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            list_class_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            btnSelect = new Guna.UI2.WinForms.Guna2Button();
            columnStdId = new DataGridViewTextBoxColumn();
            columnPwd = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnUsername = new DataGridViewTextBoxColumn();
            Shift = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)list_class_gridView).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(7, 2);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(111, 30);
            guna2HtmlLabel1.TabIndex = 12;
            guna2HtmlLabel1.Text = "ADD CLASS";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // list_class_gridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            list_class_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            list_class_gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            list_class_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            list_class_gridView.ColumnHeadersHeight = 17;
            list_class_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_class_gridView.Columns.AddRange(new DataGridViewColumn[] { columnStdId, columnPwd, columnEmail, Column1, columnName, columnUsername, Shift });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            list_class_gridView.DefaultCellStyle = dataGridViewCellStyle3;
            list_class_gridView.GridColor = Color.FromArgb(231, 229, 255);
            list_class_gridView.Location = new Point(7, 53);
            list_class_gridView.Margin = new Padding(3, 4, 3, 4);
            list_class_gridView.Name = "list_class_gridView";
            list_class_gridView.RowHeadersVisible = false;
            list_class_gridView.RowHeadersWidth = 51;
            list_class_gridView.RowTemplate.Height = 25;
            list_class_gridView.Size = new Size(731, 476);
            list_class_gridView.TabIndex = 11;
            list_class_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            list_class_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            list_class_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            list_class_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            list_class_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            list_class_gridView.ThemeStyle.BackColor = Color.White;
            list_class_gridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            list_class_gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            list_class_gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            list_class_gridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            list_class_gridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            list_class_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_class_gridView.ThemeStyle.HeaderStyle.Height = 17;
            list_class_gridView.ThemeStyle.ReadOnly = false;
            list_class_gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            list_class_gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            list_class_gridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            list_class_gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            list_class_gridView.ThemeStyle.RowsStyle.Height = 25;
            list_class_gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            list_class_gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            list_class_gridView.CellContentClick += list_student_gridView_CellContentClick;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.BorderRadius = 10;
            btnSelect.CustomizableEdges = customizableEdges1;
            btnSelect.DisabledState.BorderColor = Color.DarkGray;
            btnSelect.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSelect.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSelect.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSelect.FillColor = Color.LightCoral;
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.Black;
            btnSelect.Location = new Point(599, 3);
            btnSelect.Margin = new Padding(3, 4, 3, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSelect.Size = new Size(139, 40);
            btnSelect.TabIndex = 10;
            btnSelect.Text = "Select file Excel";
            btnSelect.Click += btnSelect_Click;
            // 
            // columnStdId
            // 
            columnStdId.HeaderText = "Class ID";
            columnStdId.MinimumWidth = 6;
            columnStdId.Name = "columnStdId";
            // 
            // columnPwd
            // 
            columnPwd.HeaderText = "Type";
            columnPwd.MinimumWidth = 6;
            columnPwd.Name = "columnPwd";
            // 
            // columnEmail
            // 
            columnEmail.HeaderText = "Room";
            columnEmail.MinimumWidth = 6;
            columnEmail.Name = "columnEmail";
            // 
            // Column1
            // 
            Column1.HeaderText = "Term";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // columnName
            // 
            columnName.HeaderText = "Instructor";
            columnName.MinimumWidth = 6;
            columnName.Name = "columnName";
            // 
            // columnUsername
            // 
            columnUsername.HeaderText = "Subject";
            columnUsername.MinimumWidth = 6;
            columnUsername.Name = "columnUsername";
            // 
            // Shift
            // 
            Shift.HeaderText = "Shift";
            Shift.MinimumWidth = 6;
            Shift.Name = "Shift";
            // 
            // FormAddClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 530);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(list_class_gridView);
            Controls.Add(btnSelect);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddClass";
            Text = "FormAddClass";
            Load += FormAddClass_Load;
            ((System.ComponentModel.ISupportInitialize)list_class_gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView list_class_gridView;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private DataGridViewTextBoxColumn columnStdId;
        private DataGridViewTextBoxColumn columnPwd;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn Shift;
    }
}