﻿namespace DiemDanhSV.PAL.Forms.AdminView
{
    partial class FormAddInstructor
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSelect = new Guna.UI2.WinForms.Guna2Button();
            list_instructor_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            columnStdId = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnUsername = new DataGridViewTextBoxColumn();
            columnPwd = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)list_instructor_gridView).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(12, 4);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(177, 30);
            guna2HtmlLabel1.TabIndex = 15;
            guna2HtmlLabel1.Text = "ADD INSTRUCTOR";
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
            btnSelect.Location = new Point(594, 4);
            btnSelect.Margin = new Padding(3, 4, 3, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSelect.Size = new Size(139, 40);
            btnSelect.TabIndex = 13;
            btnSelect.Text = "Select file Excel";
            btnSelect.Click += btnSelect_Click;
            // 
            // list_instructor_gridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            list_instructor_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            list_instructor_gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            list_instructor_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            list_instructor_gridView.ColumnHeadersHeight = 17;
            list_instructor_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_instructor_gridView.Columns.AddRange(new DataGridViewColumn[] { columnStdId, columnName, columnUsername, columnPwd, columnEmail });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            list_instructor_gridView.DefaultCellStyle = dataGridViewCellStyle3;
            list_instructor_gridView.GridColor = Color.FromArgb(231, 229, 255);
            list_instructor_gridView.Location = new Point(12, 52);
            list_instructor_gridView.Margin = new Padding(3, 4, 3, 4);
            list_instructor_gridView.Name = "list_instructor_gridView";
            list_instructor_gridView.RowHeadersVisible = false;
            list_instructor_gridView.RowHeadersWidth = 51;
            list_instructor_gridView.RowTemplate.Height = 25;
            list_instructor_gridView.Size = new Size(721, 465);
            list_instructor_gridView.TabIndex = 16;
            list_instructor_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            list_instructor_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            list_instructor_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            list_instructor_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            list_instructor_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            list_instructor_gridView.ThemeStyle.BackColor = Color.White;
            list_instructor_gridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            list_instructor_gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            list_instructor_gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            list_instructor_gridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            list_instructor_gridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            list_instructor_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_instructor_gridView.ThemeStyle.HeaderStyle.Height = 17;
            list_instructor_gridView.ThemeStyle.ReadOnly = false;
            list_instructor_gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            list_instructor_gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            list_instructor_gridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            list_instructor_gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            list_instructor_gridView.ThemeStyle.RowsStyle.Height = 25;
            list_instructor_gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            list_instructor_gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // columnStdId
            // 
            columnStdId.HeaderText = "Instructor's ID";
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
            columnEmail.HeaderText = "Degree";
            columnEmail.MinimumWidth = 6;
            columnEmail.Name = "columnEmail";
            // 
            // FormAddInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 530);
            Controls.Add(list_instructor_gridView);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnSelect);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddInstructor";
            Text = "FormAddInstructor";
            ((System.ComponentModel.ISupportInitialize)list_instructor_gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2DataGridView list_instructor_gridView;
        private DataGridViewTextBoxColumn columnStdId;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn columnPwd;
        private DataGridViewTextBoxColumn columnEmail;
    }
}