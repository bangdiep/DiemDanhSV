﻿namespace DiemDanhSV.PAL.Forms.AdminView
{
    partial class FormAddStudent
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
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            list_student_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            columnStdId = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnUsername = new DataGridViewTextBoxColumn();
            columnPwd = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            btnSelect = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)list_student_gridView).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(7, 5);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(144, 30);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "ADD STUDENT";
            // 
            // list_student_gridView
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            list_student_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            list_student_gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            list_student_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            list_student_gridView.ColumnHeadersHeight = 17;
            list_student_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_student_gridView.Columns.AddRange(new DataGridViewColumn[] { columnStdId, columnName, columnUsername, columnPwd, columnEmail });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            list_student_gridView.DefaultCellStyle = dataGridViewCellStyle6;
            list_student_gridView.GridColor = Color.FromArgb(231, 229, 255);
            list_student_gridView.Location = new Point(7, 56);
            list_student_gridView.Margin = new Padding(3, 4, 3, 4);
            list_student_gridView.Name = "list_student_gridView";
            list_student_gridView.RowHeadersVisible = false;
            list_student_gridView.RowHeadersWidth = 51;
            list_student_gridView.RowTemplate.Height = 25;
            list_student_gridView.Size = new Size(786, 396);
            list_student_gridView.TabIndex = 8;
            list_student_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            list_student_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            list_student_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            list_student_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            list_student_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            list_student_gridView.ThemeStyle.BackColor = Color.White;
            list_student_gridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            list_student_gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            list_student_gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            list_student_gridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            list_student_gridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            list_student_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_student_gridView.ThemeStyle.HeaderStyle.Height = 17;
            list_student_gridView.ThemeStyle.ReadOnly = false;
            list_student_gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            list_student_gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            list_student_gridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            list_student_gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            list_student_gridView.ThemeStyle.RowsStyle.Height = 25;
            list_student_gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            list_student_gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // columnStdId
            // 
            columnStdId.HeaderText = "Student's ID";
            columnStdId.MinimumWidth = 6;
            columnStdId.Name = "columnStdId";
            // 
            // columnName
            // 
            columnName.HeaderText = "Full Name";
            columnName.MinimumWidth = 6;
            columnName.Name = "columnName";
            // 
            // columnUsername
            // 
            columnUsername.HeaderText = "User name";
            columnUsername.MinimumWidth = 6;
            columnUsername.Name = "columnUsername";
            // 
            // columnPwd
            // 
            columnPwd.HeaderText = "Password";
            columnPwd.MinimumWidth = 6;
            columnPwd.Name = "columnPwd";
            // 
            // columnEmail
            // 
            columnEmail.HeaderText = "Email";
            columnEmail.MinimumWidth = 6;
            columnEmail.Name = "columnEmail";
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.BorderRadius = 10;
            btnSelect.CustomizableEdges = customizableEdges3;
            btnSelect.DisabledState.BorderColor = Color.DarkGray;
            btnSelect.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSelect.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSelect.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSelect.FillColor = Color.LightCoral;
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.Black;
            btnSelect.Location = new Point(654, 6);
            btnSelect.Margin = new Padding(3, 4, 3, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSelect.Size = new Size(139, 40);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "Select file Excel";
            btnSelect.Click += btnSelect_Click;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(list_student_gridView);
            Controls.Add(btnSelect);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddStudent";
            Text = "FormAddStudent";
            Load += FormAddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)list_student_gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView list_student_gridView;
        private DataGridViewTextBoxColumn columnStdId;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn columnPwd;
        private DataGridViewTextBoxColumn columnEmail;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
    }
}