namespace DiemDanhSV.PAL.Forms.InstructorView
{
    partial class FormAddAttendanceData
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            student_list_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            columnStudentID = new DataGridViewTextBoxColumn();
            columnClassID = new DataGridViewTextBoxColumn();
            columnTime = new DataGridViewTextBoxColumn();
            btnSelect = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)student_list_gridView).BeginInit();
            SuspendLayout();
            // 
            // student_list_gridView
            // 
            student_list_gridView.AllowUserToAddRows = false;
            student_list_gridView.AllowUserToDeleteRows = false;
            student_list_gridView.AllowUserToResizeColumns = false;
            student_list_gridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            student_list_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            student_list_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            student_list_gridView.ColumnHeadersHeight = 25;
            student_list_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            student_list_gridView.Columns.AddRange(new DataGridViewColumn[] { columnStudentID, columnClassID, columnTime });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            student_list_gridView.DefaultCellStyle = dataGridViewCellStyle3;
            student_list_gridView.Dock = DockStyle.Bottom;
            student_list_gridView.GridColor = Color.FromArgb(231, 229, 255);
            student_list_gridView.Location = new Point(0, 73);
            student_list_gridView.Margin = new Padding(3, 4, 3, 4);
            student_list_gridView.Name = "student_list_gridView";
            student_list_gridView.ReadOnly = true;
            student_list_gridView.RowHeadersVisible = false;
            student_list_gridView.RowHeadersWidth = 51;
            student_list_gridView.RowTemplate.Height = 25;
            student_list_gridView.RowTemplate.Resizable = DataGridViewTriState.True;
            student_list_gridView.Size = new Size(800, 377);
            student_list_gridView.TabIndex = 9;
            student_list_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            student_list_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            student_list_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            student_list_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            student_list_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            student_list_gridView.ThemeStyle.BackColor = Color.White;
            student_list_gridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            student_list_gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            student_list_gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            student_list_gridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            student_list_gridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            student_list_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            student_list_gridView.ThemeStyle.HeaderStyle.Height = 25;
            student_list_gridView.ThemeStyle.ReadOnly = true;
            student_list_gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            student_list_gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            student_list_gridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            student_list_gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            student_list_gridView.ThemeStyle.RowsStyle.Height = 25;
            student_list_gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            student_list_gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // columnStudentID
            // 
            columnStudentID.DataPropertyName = "stdID";
            columnStudentID.HeaderText = "Student ID";
            columnStudentID.MinimumWidth = 6;
            columnStudentID.Name = "columnStudentID";
            columnStudentID.ReadOnly = true;
            // 
            // columnClassID
            // 
            columnClassID.HeaderText = "Class ID";
            columnClassID.MinimumWidth = 6;
            columnClassID.Name = "columnClassID";
            columnClassID.ReadOnly = true;
            // 
            // columnTime
            // 
            columnTime.HeaderText = "Time";
            columnTime.MinimumWidth = 6;
            columnTime.Name = "columnTime";
            columnTime.ReadOnly = true;
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
            btnSelect.Location = new Point(649, 13);
            btnSelect.Margin = new Padding(3, 4, 3, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSelect.Size = new Size(139, 40);
            btnSelect.TabIndex = 11;
            btnSelect.Text = "Select file Excel";
            btnSelect.Click += btnSelect_Click;
            // 
            // FormAddAttendanceData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelect);
            Controls.Add(student_list_gridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddAttendanceData";
            Text = "FormAddAttendanceData";
            Load += FormAddAttendanceData_Load;
            ((System.ComponentModel.ISupportInitialize)student_list_gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView student_list_gridView;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private DataGridViewTextBoxColumn columnStudentID;
        private DataGridViewTextBoxColumn columnClassID;
        private DataGridViewTextBoxColumn columnTime;
    }
}